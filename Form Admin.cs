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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
            label2.Text = "Welcome, " + Class.pegawai; 
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new Form_Order().Show();
            this.Hide();
        }

        private void btnMngMenu_Click(object sender, EventArgs e)
        {
            new Form_ManageMenu().Show();
            this.Hide();
        }

        private void btnMngMember_Click(object sender, EventArgs e)
        {
            new Form_ManageMember().Show();
            this.Hide();
        }

        private void btnMngEmployee_Click(object sender, EventArgs e)
        {
            new Form_ManageEmployee().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
