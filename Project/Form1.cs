using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace Project
{
    public partial class Form1 : Form
    {

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='akshathai';username=root;password=");

       // String username;

        public Form1()
        {
            InitializeComponent();
        }
        string name;
        void login()
		{
			MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + txtuser.Text + "' AND password='" + txtpass.Text + "' and type='" + user + "'", con);

			DataTable dt = new DataTable();
			sda.Fill(dt);
			if (dt.Rows[0][0].ToString() == "1")
			{
                //username = txtuser.Text;
                MySqlCommand cmd = new MySqlCommand("SELECT fname FROM admin WHERE id='" + txtuser.Text + "'", con);
                
                MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                   name = sdr[0].ToString();
                 
                }

                
                Admin frm = new Admin(txtuser.Text);
				frm.Show();
				this.Hide();

			}
			else
				MessageBox.Show("Invalid username or password","Password Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
			txtuser.Text = "";
			txtpass.Text = "";
		}


        void login_cashier()
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + txtuser.Text + "' AND password='" + txtpass.Text + "' and type='" + user + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Cashier frm = new Cashier(txtuser.Text);
                frm.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Invalid username or password", "Password Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtuser.Text = "";
            txtpass.Text = "";
        }



        void login_kitchen()
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + txtuser.Text + "' AND password='" + txtpass.Text + "' and type='" + user + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MySqlCommand cmd = new MySqlCommand("SELECT fname FROM admin WHERE id='" + txtuser.Text + "'", con);
                con.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    name = sdr[0].ToString();

                }
                con.Close();
                Kitchen frm = new Kitchen(txtuser.Text,name);
                frm.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Invalid username or password", "Password Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtuser.Text = "";
            txtpass.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset_Password frm = new Reset_Password();
            frm.Show();
            this.Hide();
        }
        String user;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //username = txtuser.Text;
            if (rdbadmin.Checked == true)
            {
                user = "Admin";
                login();


            }
            else if (rdbcashier.Checked == true)
            {
                user = "Cashier";
                login_cashier();
            }
            else if (rdbkitchen.Checked == true)
            {
                user = "Kitchen";
                login_kitchen();
            }
            else
            {
                MessageBox.Show("Check the user type","Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void txtuser_MouseClick(object sender, MouseEventArgs e)
        {
            txtuser.Text = "";
        }

        private void txtpass_MouseClick(object sender, MouseEventArgs e)
        {
           txtpass.Text = "";
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password Reset", "Reset successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
