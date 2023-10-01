using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Admin : Form
    {
        public Admin(String username)
        {
            InitializeComponent();
            label5.Text = username;
        }

        private void Admin_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss");
            label3.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 2000;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food_Management myform = new Food_Management();
            //	Student_Registration myform1 = new Student_Registration();
            myform.FormBorderStyle = FormBorderStyle.None;
            myform.TopLevel = false;
            myform.AutoScroll = true;
            panel5.Controls.Clear();
            panel5.Controls.Add(myform);

            myform.Show();
            //button1.BackColor = Color.DarkSlateBlue;
            btnfood.BackColor = Color.SaddleBrown;
            btnsales.BackColor = Color.SaddleBrown;
            btnreport.BackColor = Color.SaddleBrown;
            btnadmin.BackColor = Color.SaddleBrown;
            btncashier.BackColor = Color.SaddleBrown;
            btnkitchen.BackColor = Color.SaddleBrown;
            btnlogout.BackColor = Color.SaddleBrown;
            btnstock.BackColor = Color.SaddleBrown;

            btnfood.BackColor = Color.SandyBrown;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Sales myform = new Sales();
            //	Student_Registration myform1 = new Student_Registration();
            myform.FormBorderStyle = FormBorderStyle.None;
            myform.TopLevel = false;
            myform.AutoScroll = true;
            panel5.Controls.Clear();
            panel5.Controls.Add(myform);

            myform.Show();
            //button1.BackColor = Color.DarkSlateBlue;
            btnfood.BackColor = Color.SaddleBrown;
            btnsales.BackColor = Color.SaddleBrown;
            btnreport.BackColor = Color.SaddleBrown;
            btnadmin.BackColor = Color.SaddleBrown;
            btncashier.BackColor = Color.SaddleBrown;
            btnkitchen.BackColor = Color.SaddleBrown;
            btnlogout.BackColor = Color.SaddleBrown;
            btnstock.BackColor = Color.SaddleBrown;

            btnsales.BackColor = Color.SandyBrown;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Food_Management myform = new Food_Management();
            //	Student_Registration myform1 = new Student_Registration();
            myform.FormBorderStyle = FormBorderStyle.None;
            myform.TopLevel = false;
            myform.AutoScroll = true;
            panel5.Controls.Clear();
            panel5.Controls.Add(myform);

            myform.Show();
            //button1.BackColor = Color.DarkSlateBlue;
            btnfood.BackColor = Color.SaddleBrown;
            btnsales.BackColor = Color.SaddleBrown;
            btnreport.BackColor = Color.SaddleBrown;
            btnadmin.BackColor = Color.SaddleBrown;
            btncashier.BackColor = Color.SaddleBrown;
            btnkitchen.BackColor = Color.SaddleBrown;
            btnlogout.BackColor = Color.SaddleBrown;
            btnstock.BackColor = Color.SaddleBrown;

            btnreport.BackColor = Color.SandyBrown;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Food_Management myform = new Food_Management();
            //	Student_Registration myform1 = new Student_Registration();
            myform.FormBorderStyle = FormBorderStyle.None;
            myform.TopLevel = false;
            myform.AutoScroll = true;
            panel5.Controls.Clear();
            panel5.Controls.Add(myform);

            myform.Show();
            //button1.BackColor = Color.DarkSlateBlue;
            btnfood.BackColor = Color.SaddleBrown;
            btnsales.BackColor = Color.SaddleBrown;
            btnreport.BackColor = Color.SaddleBrown;
            btnadmin.BackColor = Color.SaddleBrown;
            btncashier.BackColor = Color.SaddleBrown;
            btnkitchen.BackColor = Color.SaddleBrown;
            btnlogout.BackColor = Color.SaddleBrown;
            btnstock.BackColor = Color.SaddleBrown;

            btnstock.BackColor = Color.SandyBrown;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Management myform = new Admin_Management();
            //	Student_Registration myform1 = new Student_Registration();
            myform.FormBorderStyle = FormBorderStyle.None;
            myform.TopLevel = false;
            myform.AutoScroll = true;
            panel5.Controls.Clear();
            panel5.Controls.Add(myform);

            myform.Show();
            //button1.BackColor = Color.DarkSlateBlue;
            btnfood.BackColor = Color.SaddleBrown;
            btnsales.BackColor = Color.SaddleBrown;
            btnreport.BackColor = Color.SaddleBrown;
            btnadmin.BackColor = Color.SaddleBrown;
            btncashier.BackColor = Color.SaddleBrown;
            btnkitchen.BackColor = Color.SaddleBrown;
            btnlogout.BackColor = Color.SaddleBrown;
            btnstock.BackColor = Color.SaddleBrown;

            btnadmin.BackColor = Color.SandyBrown;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cahier_Management myform = new Cahier_Management();
            //	Student_Registration myform1 = new Student_Registration();
            myform.FormBorderStyle = FormBorderStyle.None;
            myform.TopLevel = false;
            myform.AutoScroll = true;
            panel5.Controls.Clear();
            panel5.Controls.Add(myform);

            myform.Show();
            //button1.BackColor = Color.DarkSlateBlue;
            btnfood.BackColor = Color.SaddleBrown;
            btnsales.BackColor = Color.SaddleBrown;
            btnreport.BackColor = Color.SaddleBrown;
            btnadmin.BackColor = Color.SaddleBrown;
            btncashier.BackColor = Color.SaddleBrown;
            btnkitchen.BackColor = Color.SaddleBrown;
            btnlogout.BackColor = Color.SaddleBrown;
            btnstock.BackColor = Color.SaddleBrown;

            btncashier.BackColor = Color.SandyBrown;
        }

        private void btnkitchen_Click(object sender, EventArgs e)
        {
            Kitchen_Management myform = new Kitchen_Management();
            //	Student_Registration myform1 = new Student_Registration();
            myform.FormBorderStyle = FormBorderStyle.None;
            myform.TopLevel = false;
            myform.AutoScroll = true;
            panel5.Controls.Clear();
            panel5.Controls.Add(myform);

            myform.Show();
            //button1.BackColor = Color.DarkSlateBlue;
            btnfood.BackColor = Color.SaddleBrown;
            btnsales.BackColor = Color.SaddleBrown;
            btnreport.BackColor = Color.SaddleBrown;
            btnadmin.BackColor = Color.SaddleBrown;
            btncashier.BackColor = Color.SaddleBrown;
            btnkitchen.BackColor = Color.SaddleBrown;
            btnlogout.BackColor = Color.SaddleBrown;
            btnstock.BackColor = Color.SaddleBrown;

            btnkitchen.BackColor = Color.SandyBrown;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
            //button1.BackColor = Color.DarkSlateBlue;
            btnfood.BackColor = Color.SaddleBrown;
            btnsales.BackColor = Color.SaddleBrown;
            btnreport.BackColor = Color.SaddleBrown;
            btnadmin.BackColor = Color.SaddleBrown;
            btncashier.BackColor = Color.SaddleBrown;
            btnkitchen.BackColor = Color.SaddleBrown;
            btnlogout.BackColor = Color.SaddleBrown;
            btnstock.BackColor = Color.SaddleBrown;

           btnlogout.BackColor = Color.SandyBrown;
        }
    }
}
