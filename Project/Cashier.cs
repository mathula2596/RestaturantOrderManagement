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
    public partial class Cashier : Form
    {
        public Cashier(String username)
        {
            InitializeComponent();
            label5.Text = username;
        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }
    }
}
