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
    public partial class Kitchen : Form
    {
        string firstname;
        
        public Kitchen(String username, String name)
        {
            InitializeComponent();
            label5.Text = username;
            firstname = name;
        }

        private void Kitchen_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss");
            label3.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void Kitchen_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 2000;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void btnfood_Click(object sender, EventArgs e)
        {
            Kitchen_Food_Management myform = new Kitchen_Food_Management(label5.Text,firstname);
            //	Student_Registration myform1 = new Student_Registration();
            myform.FormBorderStyle = FormBorderStyle.None;
            myform.TopLevel = false;
            myform.AutoScroll = true;
            panel5.Controls.Clear();
            panel5.Controls.Add(myform);

            myform.Show();
            //button1.BackColor = Color.DarkSlateBlue;
            btnfood.BackColor = Color.SaddleBrown;
           
           

            btnfood.BackColor = Color.SandyBrown;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
