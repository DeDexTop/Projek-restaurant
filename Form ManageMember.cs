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
    public partial class Form_ManageMember : Form
    {
        public static string url = @"Data Source=localhost;Initial Catalog=db_restaurant;Integrated Security=True";
        SqlConnection koneksi = new SqlConnection(url);
        public Form_ManageMember()
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
            DataTable.Columns[0].HeaderText = "MemberId";
            DataTable.Columns[1].HeaderText = "Name";
            DataTable.Columns[2].HeaderText = "Email";
            DataTable.Columns[3].HeaderText = "Handphone";
            DataTable.Columns[4].HeaderText = "Join Date";
        }
        void show()
        {
            DataTable.DataSource = ShowData("SELECT * FROM MsMember");
            data();

            txtId.Enabled = false;
        }
        void clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtHandphone.Text = "";
        }
        private void Form_ManageMember_Load(object sender, EventArgs e)
        {
            show();
        }

        private void DataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = DataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHandphone.Text = DataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtName.Text == "" || txtEmail.Text == "" || txtHandphone.Text == "")
                {
                    MessageBox.Show("Kolom data tidak boleh kosong!", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open();
                    SqlCommand com = new SqlCommand("INSERT INTO MsMember ([name], [email], [handphone], [join_date]) VALUES ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtHandphone.Text + "', getDate())", koneksi);
                    com.ExecuteNonQuery();
                    MessageBox.Show("DataBerhasil Ditambahkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();
                }
                show();
            }
            catch (Exception ex)
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
                if (txtName.Text == "" || txtEmail.Text == "" || txtHandphone.Text == "")
                {
                    MessageBox.Show("Kolom data tidak boleh kosong!", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open();
                    SqlCommand com = new SqlCommand("UPDATE MsMember SET name = '" + txtName.Text + "',email = '" + txtEmail.Text + "',handphone = '" + txtHandphone.Text + "' WHERE id = '" + txtId.Text + "'", koneksi);
                    com.ExecuteNonQuery();
                    MessageBox.Show("DataBerhasil Diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();
                }
                show();
            }
            catch (Exception ex)
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
                SqlCommand com = new SqlCommand("DELETE FROM MsMember WHERE id = '" + txtId.Text + "'", koneksi);
                com.ExecuteNonQuery();

                clear();

                show();
            }
            catch (Exception ex)
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
                DataTable.DataSource = ShowData("SELECT * FROM MsMember WHERE id LIKE '%" + SearchBox.Text + "%' OR name LIKE '%" + SearchBox.Text + "%' OR email LIKE '%" + SearchBox.Text + "%' OR handphone LIKE '%" + SearchBox.Text + "%' OR join_date LIKE '%" + SearchBox.Text + "%'");
                data();
            }
            catch (Exception ex)
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

