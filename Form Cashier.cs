using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form_Cashier : Form
    {
        public Form_Cashier()
        {
            InitializeComponent();
            label2.Text = "Welcome, " + Class.pegawai;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new Form_Payment().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form_Login().Show();
            this.Hide();
        }
    }
}
