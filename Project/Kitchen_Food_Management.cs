using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Project
{
    public partial class Kitchen_Food_Management : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='akshathai';username=root;password=");
        public Kitchen_Food_Management(String id, String name)
        {
            InitializeComponent();
            txtkid.Text = id;
            txtkname.Text = name;
            foodname();
        }
        void foodname()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT name FROM food", con);
            con.Open();
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Load(reader);
            cmbfoodname.DisplayMember = "name";
            cmbfoodname.DataSource = dt;
            con.Close();

          
        }
        string date = DateTime.Now.ToString("d/M/yyyy");
        string quantity;
        string currentquantity;
        int q1, q2;
        private void button7_Click(object sender, EventArgs e)
        {
            //selectfood();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(food_id)  FROM daily_kitchen WHERE food_id='" + txtfoodid.Text + "' and date_time='" + date + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "0")
            {

                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO daily_kitchen (food_id,quantity,kitchen_id,date_time) VALUES ('" + txtfoodid.Text + "','" + txtquantity.Text + "','" + txtkid.Text + "','" + date + "')", con);
                MySqlCommand cmd = new MySqlCommand("INSERT INTO quantity (food_id,quantity,date) VALUES ('" + txtfoodid.Text + "','" + txtquantity.Text + "','" + date + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Added successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtquantity.Clear();

                con.Close();
            }

           
            else
            {
                MySqlCommand cmd3 = new MySqlCommand("SELECT quantity FROM quantity WHERE food_id='" + txtfoodid.Text + "' and date ='"+date+"'", con);
                con.Close();
                con.Open();
                MySqlDataReader sdr3 = cmd3.ExecuteReader();
                while (sdr3.Read())
                {
                    quantity = sdr3[0].ToString();
                }

                con.Close();
                oldquantity = int.Parse(quantity);
                newquantity = oldquantity + int.Parse(txtquantity.Text);
                MySqlCommand cmd1 = new MySqlCommand("UPDATE quantity SET  quantity = '" + newquantity.ToString() + "' WHERE food_id= '" + txtfoodid.Text + "' and date = '" + date + "'", con);

                MySqlCommand cmd4 = new MySqlCommand("SELECT quantity FROM daily_kitchen WHERE food_id='" + txtfoodid.Text + "' and date_time ='" + date + "'", con);
                con.Close();
                con.Open();
                MySqlDataReader sdr4 = cmd4.ExecuteReader();
                while (sdr4.Read())
                {
                    currentquantity = sdr4[0].ToString();
                }

                con.Close();
                if(currentquantity != "0")
                {
                    q2 = int.Parse(currentquantity) + int.Parse(txtquantity.Text);
                }
                else if(currentquantity == "0")
                {
                    q2 =  int.Parse(txtquantity.Text);
                }
                MySqlCommand cmd = new MySqlCommand("UPDATE daily_kitchen SET quantity='" + q2.ToString() + "' WHERE food_id LIKE '" + txtfoodid.Text + "' and date_time LIKE '" + date + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Updated successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtquantity.Clear();
               
                con.Close();
            }
            
        }
        int oldquantity, newquantity;
        private void cmbfoodname_SelectedValueChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("SELECT id FROM food WHERE name='" + cmbfoodname.Text + "' ", con);
            con.Close();
            con.Open();
            MySqlDataReader sdr = cmd1.ExecuteReader();
            while (sdr.Read())
            {
                txtfoodid.Text = sdr[0].ToString();

            }
            con.Close();
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
    }
}
