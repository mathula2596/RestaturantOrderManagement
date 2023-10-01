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
    public partial class Sales : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='akshathai';username=root;password=");
        public Sales()
        {
            InitializeComponent();
            search();
            column(); 
        }
       
        private void search()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT name FROM food", con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            txtfoodname.AutoCompleteCustomSource = MyCollection;


            con.Close();

        }
        private void searchfoodid()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT id,price FROM food WHERE name='"+txtfoodname.Text+"'", con);
            con.Open();

            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtfoodid.Text = sdr[0].ToString();
                txtunitprice.Text = sdr[1].ToString();

            }
            con.Close();

        }
        int quantity, unitprice, total;
        private void totalprice()
        {
            quantity = int.Parse(txtquantity.Text);
            unitprice = int.Parse(txtunitprice.Text);

            total = quantity * unitprice;

            txttotal.Text = total.ToString();

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtquantity_Leave(object sender, EventArgs e)
        {
            totalprice();
        }
        DataTable table = new DataTable();

        private void column()
        {
            table.Columns.Add("Food Name", typeof(string));// data type int
            table.Columns.Add("Food ID", typeof(string));// datatype string
            table.Columns.Add("Unit Price", typeof(string));// datatype string
            table.Columns.Add("Quantity", typeof(string));// datatype string
            table.Columns.Add("Total", typeof(string));// datatype string
            //table.Columns.Add("Food", typeof(string));// datatype string
            dataGridView2.DataSource = table;

        }
        int amount;
        private void button4_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtfoodname.Text, txtfoodid.Text, txtunitprice.Text,txtquantity.Text,txttotal.Text);
            dataGridView2.DataSource = table;
            txtfoodname.Text = "";
            txtfoodid.Text = "";
            txtunitprice.Text = "";
            txtquantity.Text = "";
            //txttotal.Text = "";

            if (txtamount.Text == "0")
            {
                txtamount.Text = txttotal.Text;
            }
            else
            {
                amount = int.Parse(txtamount.Text);

                txtamount.Text = (amount + total).ToString();
            }
            txttotal.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(rowIndex);


        }
        int totalamount, servicecharge, nettotal;
        int cash, balance;

        private void button7_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtamount.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString(txtservice.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(300, 100));

            e.Graphics.DrawString(txtnettotal.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 100));
            e.Graphics.DrawString(txtcash.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 150));
            e.Graphics.DrawString(txtbalance.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(150, 200));
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cash = int.Parse(txtcash.Text);

            balance = int.Parse(txtnettotal.Text) - cash;

            txtbalance.Text = balance.ToString();
        }

        private void txtservice_Leave(object sender, EventArgs e)
        {
            totalamount = int.Parse(txtamount.Text);
            servicecharge = int.Parse(txtservice.Text);

            nettotal = totalamount + servicecharge;

            txtnettotal.Text = nettotal.ToString();
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void txtfoodname_Leave(object sender, EventArgs e)
        {
            searchfoodid();
        }
    }
}
