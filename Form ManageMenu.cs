using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form_ManageMenu : Form
    {
        public static string url = @"Data Source=localhost;Initial Catalog=db_restaurant;Integrated Security=True";
        SqlConnection koneksi = new SqlConnection(url);
        public Form_ManageMenu()
        {
            InitializeComponent();
        }
        public object ShowData(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, url);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object bebas = data.Tables[0];
            return bebas;
        }
        void data()
        {
            dgv_Menu.Columns[0].HeaderText = "MenuId";
            dgv_Menu.Columns[1].HeaderText = "Name";
            dgv_Menu.Columns[2].HeaderText = "Price";
            dgv_Menu.Columns[3].HeaderText = "Photo";
            dgv_Menu.Columns[4].HeaderText = "Image";
            dgv_Menu.Columns[5].HeaderText = "carbo";
            dgv_Menu.Columns[6].HeaderText = "protein";
        }
        void show()
        {
            dgv_Menu.DataSource = ShowData("SELECT * FROM MsMenu1");
            data();

            dgv_Menu.Columns[3].Visible = false;
            dgv_Menu.Columns[4].Visible = false;

            txtMenuId.Enabled = false;
        }
        void clear()
        {
            txtMenuId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtPhoto.Text = "";
            txtCarbo.Text = "";
            txtProtein.Text = "";
            BoxSearch.Text = "";
            label8.Text = "";
            MenuPicture.Image = null;
        }
        public Image ConvertByteToArray(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void Form_ManageMenu_Load(object sender, EventArgs e)
        {
            show();
            label8.Text = "";
        }
        private void DataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMenuId.Text = dgv_Menu.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgv_Menu.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgv_Menu.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhoto.Text = dgv_Menu.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (DBNull.Value.Equals(dgv_Menu.Rows[e.RowIndex].Cells[4].Value))
            {
                MenuPicture.Image = null;
            }
            else
            {
                MenuPicture.Image = ConvertByteToArray((byte[])dgv_Menu.Rows[e.RowIndex].Cells[4].Value);
            }
            txtCarbo.Text = dgv_Menu.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProtein.Text = dgv_Menu.Rows[e.RowIndex].Cells[6].Value.ToString();

            label8.Text = "Jika ingin mengupdate data, pilih ulang gambar";
        }

        private void btnSrchImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string fileName = opf.FileName;
                MenuPicture.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtName.Text == "" || txtPrice.Text == "" || txtPhoto.Text == "" || txtCarbo.Text == "" || txtProtein.Text == "")
                {
                    MessageBox.Show("Kolom data tidak boleh kosong!", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open();

                    SqlCommand com = new SqlCommand("INSERT INTO MsMenu1 ([name], [price], [photo], [carbo], [protein], [image]) VALUES ('" + txtName.Text + "','" + txtPrice.Text + "','" + txtPhoto.Text + "', '" + txtCarbo.Text + "', '" + txtProtein.Text + "', @Pic)", koneksi);
                    MemoryStream stream = new MemoryStream();
                    MenuPicture.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    com.Parameters.AddWithValue("@Pic", pic);
                    com.ExecuteNonQuery();
                    MessageBox.Show("DataBerhasil Ditambahkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();
                    show();
                }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtName.Text == "" || txtPrice.Text == "" || txtPhoto.Text == "" || txtCarbo.Text == "" || txtProtein.Text == "")
                {
                    MessageBox.Show("Kolom data tidak boleh kosong!", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open();

                    SqlCommand com = new SqlCommand("UPDATE MsMenu1 SET name = '" + txtName.Text + "', price = '" + txtPrice.Text + "', photo = '" + txtPhoto.Text + "', carbo = '" + txtCarbo.Text + "', protein = '" + txtProtein.Text + "', image = @Pic WHERE id = '" + txtMenuId.Text + "'", koneksi);
                    MemoryStream stream = new MemoryStream();
                    MenuPicture.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    com.Parameters.AddWithValue("@Pic", pic);
                    com.ExecuteNonQuery();
                    MessageBox.Show("DataBerhasil Diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    show();
                    clear();
                }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                SqlCommand com = new SqlCommand("DELETE FROM MsMenu1 WHERE id = '" + txtMenuId.Text + "'", koneksi);
                com.ExecuteNonQuery();
                MessageBox.Show("DataBerhasil Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                show();
                clear();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                dgv_Menu.DataSource = ShowData("SELECT * FROM MsMenu1 WHERE name LIKE '%" + BoxSearch.Text + "%' OR price LIKE '%" + BoxSearch.Text + "%' OR photo LIKE '%" + BoxSearch.Text + "%' OR carbo LIKE '%" + BoxSearch.Text + "%' OR protein LIKE '%" + BoxSearch.Text + "%'");
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
            show();
        }

        private void BoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    koneksi.Open();
                    dgv_Menu.DataSource = ShowData("SELECT * FROM MsMenu1 WHERE name LIKE '%" + BoxSearch.Text + "%' OR price LIKE '%" + BoxSearch.Text + "%' OR photo LIKE '%" + BoxSearch.Text + "%' OR carbo LIKE '%" + BoxSearch.Text + "%' OR protein LIKE '%" + BoxSearch.Text + "%'");
                    data();

                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_Admin().Show();
            this.Hide();
        }
    }
}
