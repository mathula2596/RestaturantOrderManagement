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
    public partial class Kitchen_Management : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='akshathai';username=root;password=");
        public Kitchen_Management()
        {
            InitializeComponent();
            autoID();
            viewall();
        }
        private void viewall()
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM kitchen ", con);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);
            con.Close();
            dataGridView2.DataSource = dt;
        }
        public void autoID()
        {
            con.Open();
            // MySqlCommand cmd = new MySqlCommand("SELECT ISNULL(MAX(CAST(SUBSTRING(id,CHARINDEX('F',id)+1,LEN(id))AS INT)),0)+1 FROM food", con);
            MySqlCommand cmd = new MySqlCommand("SELECT id FROM kitchen ORDER BY id DESC limit 1", con);
            String id = cmd.ExecuteScalar().ToString();
            String newid = id.Substring(1, 4);
            int tranID = int.Parse(newid.ToString());
            tranID++;
            string rs = "K" + tranID;
            txtid.Text = rs;
            txtusername.Text = rs;
            con.Close();


        }
        private void button7_Click(object sender, EventArgs e)
        {

            String admin = "Kitchen";
            try
            {
                if (txtid.Text != "" && txtfname.Text != "" && txtlname.Text != "" && txtnic.Text != "" && txtgender.Text != "" && txtpassword.Text != "" && txtphone.Text != "" && txtusername.Text != "" && txtaddress.Text != "")
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO kitchen VALUES ('" + txtid.Text + "','" + txtfname.Text + "','" + txtlname.Text + "','" + txtphone.Text + "','" + txtnic.Text + "','" + txtgender.Text + "','" + txtaddress.Text + "')", con);
                    MySqlCommand cmd1 = new MySqlCommand("INSERT INTO login VALUES ('" + txtusername.Text + "','" + txtpassword.Text + "','" + admin + "')", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Added successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtid.Clear();

                    txtfname.Clear();
                    txtlname.Clear();
                    txtnic.Text = "";
                    txtpassword.Clear();
                    txtphone.Text = "";
                    txtusername.Clear();
                    txtaddress.Text = "";
                    txtgender.Clear();
                    con.Close();
                    autoID();
                    viewall();

                }
                else
                {
                    MessageBox.Show("Please Fill all the fields", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception error ");
            }
            
        }
       
        private void txtnic_TextChanged(object sender, EventArgs e)
        {
            if (txtnic.Text.Length == 9)
            {
                txtnic.Text = txtnic.Text + "V";
            }
        }
       
        String key;
        private void button4_Click(object sender, EventArgs e)
        {
            key = txtnic.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM kitchen WHERE nic='" + txtnic.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() != "1")
            {
                //if (e.KeyCode == Keys.Enter)
                //{

                if (txtnic.Text.Length == 10)
                {
                    String NICNo = txtnic.Text;
                    String Year = "";
                    String Month = "";
                    int Day = 0;
                    bool isValid = false;
                    txtpassword.Text = txtnic.Text;
                    if (NICNo.Length == 10) //Validation 1::Checking The Length Of The NIC Entered
                    {
                        NICNo = NICNo.Substring(0, 9);
                        bool bchk9 = Int32.TryParse(NICNo, out Day);
                        if (bchk9) //Validation 2::Checking The First Nine Digit Of The NIC Entered Are Integers
                        {
                            Year = NICNo.Substring(0, 2); //Getting The Year
                            NICNo = NICNo.Substring(2, 3);
                            Day = int.Parse(NICNo);

                            String Gender;
                            if (Day > 500)
                            {
                                Gender = "Female";

                            }
                            else
                            {
                                Gender = "Male";
                            }
                            txtgender.Text = Gender;


                            if (Day > 500) //Can Be Women's NIC No
                            {
                                Day = Day - 500;
                            }



                        }
                    }




                }

                else
                {
                    MessageBox.Show("Check the NIC No", "NIC Number error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtgender.Focus();
                    txtgender.Text = "";
                }


            }
            else
            {
                MessageBox.Show("NIC is already added", "Kitchen User is already added", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void txtnic_TextChanged_1(object sender, EventArgs e)
        {
            if (txtnic.Text.Length == 9)
            {
                txtnic.Text = txtnic.Text + "V";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM kitchen where id like '%" + txtsearch.Text + "%' or fname like '%" + txtsearch.Text + "%' or lname like '%" + txtsearch.Text + "%' or phone like '%" + txtsearch.Text + "%' or nic like '%" + txtsearch.Text + "%'or gender like '%" + txtsearch.Text + "%' or address like '%" + txtsearch.Text + "%'  ", con);
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

        private void button6_Click(object sender, EventArgs e)
        {
            viewall();
            txtsearch.Text = " ";
        }
        String nic;
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM kitchen WHERE id='" + txtsearchbyid.Text + "' or nic='" + txtsearchbyid.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM kitchen WHERE id='" + txtsearchbyid.Text + "' or nic='" + txtsearchbyid.Text + "'  ", con);
                con.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtsearchbyid.Text = sdr[0].ToString();
                    txtfnameup.Text = sdr[1].ToString();
                    txtlnameup.Text = sdr[2].ToString();
                    txtphoneup.Text = sdr[3].ToString();
                    txtnicup.Text = sdr[4].ToString();
                    txtgenderup.Text = sdr[5].ToString();
                    txtaddressup.Text = sdr[6].ToString();

                }

                con.Close();

                if (txtsearchbyid.Text.Length >= 9)
                {
                    MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM kitchen WHERE nic='" + txtsearchbyid.Text + "'", con);
                    con.Open();
                    MySqlDataReader sdr2 = cmd2.ExecuteReader();
                    while (sdr2.Read())
                    {

                        nic = sdr2[0].ToString();

                    }
                    con.Close();

                    MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM login WHERE username='" + nic + "' ", con);
                    con.Open();
                    MySqlDataReader sdr1 = cmd1.ExecuteReader();
                    while (sdr1.Read())
                    {
                        txtusernameup.Text = sdr1[0].ToString();
                        txtpasswordup.Text = sdr1[1].ToString();

                    }

                    con.Close();



                }
                else
                {

                    MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM login WHERE username='" + txtsearchbyid.Text + "' ", con);
                    con.Close();
                    con.Open();
                    MySqlDataReader sdr3 = cmd3.ExecuteReader();
                    while (sdr3.Read())
                    {
                        txtusernameup.Text = sdr3[0].ToString();
                        txtpasswordup.Text = sdr3[1].ToString();

                    }

                    con.Close();


                }



            }
            else
            {
                MessageBox.Show("Check the ID or NIC", "ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            key = txtnicup.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM kitchen WHERE nic='" + txtnicup.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() != "1")
            {
                //if (e.KeyCode == Keys.Enter)
                //{

                if (txtnic.Text.Length == 10)
                {
                    String NICNo = txtnic.Text;
                    String Year = "";
                    String Month = "";
                    int Day = 0;
                    bool isValid = false;
                    //  txtpassword.Text = txtnic.Text;
                    if (NICNo.Length == 10) //Validation 1::Checking The Length Of The NIC Entered
                    {
                        NICNo = NICNo.Substring(0, 9);
                        bool bchk9 = Int32.TryParse(NICNo, out Day);
                        if (bchk9) //Validation 2::Checking The First Nine Digit Of The NIC Entered Are Integers
                        {
                            Year = NICNo.Substring(0, 2); //Getting The Year
                            NICNo = NICNo.Substring(2, 3);
                            Day = int.Parse(NICNo);

                            String Gender;
                            if (Day > 500)
                            {
                                Gender = "Female";

                            }
                            else
                            {
                                Gender = "Male";
                            }
                            txtgenderup.Text = Gender;


                            if (Day > 500) //Can Be Women's NIC No
                            {
                                Day = Day - 500;
                            }



                        }
                    }

                }

                else
                {
                    MessageBox.Show("Check the NIC No", "NIC Number error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtgenderup.Focus();
                    txtgenderup.Text = "";
                }


            }
            else
            {
                MessageBox.Show("NIC is already added", "Kitchen User is already added", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfnameup.Text != "" && txtlnameup.Text != "" && txtphoneup.Text != "" && txtnicup.Text != "" && txtaddressup.Text != "" && txtgenderup.Text != "" && txtsearchbyid.Text != "")

            {
                MySqlCommand cmd = new MySqlCommand("UPDATE kitchen SET fname='" + txtfnameup.Text + "',lname= '" + txtlnameup.Text + "',address= '" + txtaddressup.Text + "', phone= '" + txtphoneup.Text + "' ,nic='" + txtnicup.Text + "' , gender='" + txtgenderup.Text + "' WHERE id LIKE '" + txtsearchbyid.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfnameup.Clear();
                txtlnameup.Clear();
                txtphoneup.Clear();
                txtaddressup.Clear();
                txtnicup.Text = "";
                txtgenderup.Text = "";
                txtusernameup.Text = "";
                txtpasswordup.Text = "";
                con.Close();
                viewall();

            }

            else
            {
                MessageBox.Show("Please fill all the fields", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtusernameup.Text != "" && txtpasswordup.Text != "")

            {
                MySqlCommand cmd = new MySqlCommand("UPDATE login SET username='" + txtusernameup.Text + "',password= '" + txtpasswordup.Text + "' WHERE username LIKE '" + txtusernameup.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfnameup.Clear();
                txtlnameup.Clear();
                txtphoneup.Clear();
                txtaddressup.Clear();
                txtnicup.Text = "";
                txtgenderup.Text = "";
                txtusernameup.Text = "";
                txtpasswordup.Text = "";
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
