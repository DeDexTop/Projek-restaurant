using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        static string url = @"Data Source=localhost;Initial Catalog=db_restaurant;Integrated Security=True";
        SqlConnection koneksi = new SqlConnection(url);
        public static string ut;
        public Form1()
        {
            InitializeComponent();
        }

        void login()
        {
            try
            {
                koneksi.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT name, email, password, position FROM MsEmployee WHERE email LIKE '" + txtEmail.Text + "' AND password LIKE '" + txtPass.Text + "'", koneksi);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        Class.pegawai = dr["name"].ToString();

                        if(dr["position"].ToString() == "admin")
                        {
                            new Form_Admin().Show();
                            this.Hide();
                        }
                        else if(dr["position"].ToString() == "cashier")
                        {
                            new Form_Cashier().Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Maaf data tidak valid");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Kolom data tida boleh kosong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                login();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Kolom data tida boleh kosong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    login();
                }
            }
        }
    }
}
