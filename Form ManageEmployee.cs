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
    public partial class Form_ManageEmployee : Form
    {
        public static string url = @"Data Source=localhost;Initial Catalog=db_restaurant;Integrated Security=True";
        SqlConnection koneksi = new SqlConnection(url);
        public Form_ManageEmployee()
        {
            InitializeComponent();
        }
        public object ShowData(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            object bebas = ds.Tables[0];
            return bebas;
        }
        void data()
        {
            dgv_Employee.Columns[0].HeaderText = "ID";
            dgv_Employee.Columns[1].HeaderText = "Name";
            dgv_Employee.Columns[2].HeaderText = "Email";
            dgv_Employee.Columns[3].HeaderText = "Password";
            dgv_Employee.Columns[4].HeaderText = "Handphone";
            dgv_Employee.Columns[5].HeaderText = "Position";
        }
        void show()
        {
            dgv_Employee.DataSource = ShowData("SELECT * FROM MsEmployee");
            data();
        }
        
        void clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtHandphone.Text = "";
            SearchBox.Text = "";
            cbxPosition.Text = "";

            txtID.Enabled = true;
        }

        private void Form_ManageEmployee_Load(object sender, EventArgs e)
        {
            show();
        }

        private void dgv_Employee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgv_Employee.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgv_Employee.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgv_Employee.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgv_Employee.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtHandphone.Text = dgv_Employee.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxPosition.Text = dgv_Employee.Rows[e.RowIndex].Cells[5].Value.ToString();

            txtID.Enabled = false;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtHandphone.Text == "" || txtPassword.Text == "" || cbxPosition.Text == "")
                {
                    MessageBox.Show("Kolom data tidak boleh kosong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open();
                    SqlCommand com = new SqlCommand("INSERT INTO MsEmployee ([id], [name], [email], [password], [handphone], [position]) VALUES ('" + txtID.Text + "', '" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtPassword.Text + "', '" + txtHandphone.Text + "', '" + cbxPosition.Text + "')", koneksi);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil ditambahkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();

                }
                show();
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtHandphone.Text == "" || txtPassword.Text == "" || cbxPosition.Text == "")
                {
                    MessageBox.Show("Kolom data tidak boleh kosong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open();
                    SqlCommand com = new SqlCommand("UPDATE MsEmployee SET name = '" + txtName.Text + "', email = '" + txtEmail.Text + "', password = '" + txtPassword.Text + "',handphone = '" + txtHandphone.Text + "', position = '" + cbxPosition.Text + "' WHERE id = '" + txtID.Text + "'", koneksi);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();
                }
                show();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                SqlCommand com = new SqlCommand("DELETE FROM MsEmployee WHERE id LIKE '" + txtID.Text + "'", koneksi);
                com.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clear();

                show();
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                dgv_Employee.DataSource = ShowData("SELECT * FROM MsEmployee WHERE id LIKE '%" + SearchBox.Text + "%' OR name LIKE '%" + SearchBox.Text + "%' OR email LIKE '%" + SearchBox.Text + "%' OR password LIKE '%" + SearchBox.Text + "%' OR handphone LIKE '%" + SearchBox.Text + "%' OR position LIKE '%" + SearchBox.Text + "%'");
                data();
                clear();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
    }   
}
