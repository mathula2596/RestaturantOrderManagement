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
    public partial class Food_Management : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='akshathai';username=root;password=");

        public Food_Management()
        {
            InitializeComponent();
            autoID();
            column();
            viewall();
        }

        public void autoID()
        {
            con.Open();
           // MySqlCommand cmd = new MySqlCommand("SELECT ISNULL(MAX(CAST(SUBSTRING(id,CHARINDEX('F',id)+1,LEN(id))AS INT)),0)+1 FROM food", con);
            MySqlCommand cmd = new MySqlCommand("SELECT id FROM food ORDER BY id DESC limit 1", con);
            String id = cmd.ExecuteScalar().ToString();
            String newid = id.Substring(1,4);
            int tranID = int.Parse(newid.ToString());
            tranID++;
            string rs = "F" + tranID;
            txtfoodid.Text = rs;
            //txtcidbulk.Text = rs;
            con.Close();


        }
        private void viewall()
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM food ", con);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);
            con.Close();
            dataGridView2.DataSource = dt;
        }
        DataTable table = new DataTable();

        private void column()
        {
            table.Columns.Add("Food Id", typeof(string));// data type int
            table.Columns.Add("Food Name", typeof(string));// datatype string
            table.Columns.Add("Food Amount", typeof(string));// datatype string
            //table.Columns.Add("Food", typeof(string));// datatype string
            dataGridView1.DataSource = table;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtfoodid.Text != "" && txtfoodname.Text != "" && txtamount.Text != "")
            {
                table.Rows.Add(txtfoodid.Text, txtfoodname.Text, txtamount.Text);
                dataGridView1.DataSource = table;
                txtfoodname.Text = "";
                txtamount.Text = "";
              
                string tranID = (txtfoodid.Text.Substring(1, 4));

                int x = int.Parse(tranID);
                int y = x + 1;
                string rs = "F" + y;
                txtfoodid.Text = rs;

            }
            else
            {
                MessageBox.Show("Please Fill all the fields", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
     
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO food (id,name,price) VALUES('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            MessageBox.Show("Added successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            search();
            
        }

        void search()
        {
            if (txtsearch.Text != "")
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM food where id like '%" + txtsearch.Text + "%' or name like '%" + txtsearch.Text + "%' or price like '%" + txtsearch.Text + "%' ", con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                con.Close();
                dataGridView2.DataSource = dt;
            }
            else
            {
                viewall();
            }

        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewall();
            txtsearch.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM food WHERE id='" + txtsearchbyid.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM food WHERE id='" + txtsearchbyid.Text + "'", con);
                con.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                 
                    txtfoodnameup.Text = sdr[1].ToString();
                    txtpriceup.Text = sdr[2].ToString();

                }

                con.Close();
                

            }
            else
            {

                MessageBox.Show("Check the ID", "ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtsearchbyid.Text != "" && txtfoodnameup.Text != "" && txtpriceup.Text != "")
            {


                MySqlCommand cmd = new MySqlCommand("UPDATE food SET name= '" + txtfoodnameup.Text + "',price= '" + txtpriceup.Text + "' WHERE id LIKE '" + txtsearchbyid.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsearchbyid.Clear();
                //txtdurationup.Clear();
                txtfoodnameup.Clear();
                txtpriceup.Clear();
                con.Close();
                viewall();

            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
