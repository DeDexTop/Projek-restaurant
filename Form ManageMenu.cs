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
            DataTable.Columns[0].HeaderText = "MenuId";
            DataTable.Columns[1].HeaderText = "Name";
            DataTable.Columns[2].HeaderText = "Price";
            DataTable.Columns[3].HeaderText = "Photo";
            DataTable.Columns[4].HeaderText = "Image";
            DataTable.Columns[5].HeaderText = "carbo";
            DataTable.Columns[6].HeaderText = "protein";
        }
        void show()
        {
            DataTable.DataSource = ShowData("SELECT * FROM MsMenu1");
            data();

            DataTable.Columns[3].Visible = false;
            DataTable.Columns[4].Visible = false;

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
        }
        private void DataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMenuId.Text = DataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = DataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhoto.Text = DataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (DBNull.Value.Equals(DataTable.Rows[e.RowIndex].Cells[4].Value))
            {
                MenuPicture.Image = null;
            }
            else
            {
                MenuPicture.Image = ConvertByteToArray((byte[])DataTable.Rows[e.RowIndex].Cells[4].Value);
            }
            txtCarbo.Text = DataTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProtein.Text = DataTable.Rows[e.RowIndex].Cells[6].Value.ToString();
            
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
                DataTable.DataSource = ShowData("SELECT * FROM MsMenu1 WHERE name LIKE '%" + BoxSearch.Text + "%' OR price LIKE '%" + BoxSearch.Text + "%' OR photo LIKE '%" + BoxSearch.Text + "%' OR carbo LIKE '%" + BoxSearch.Text + "%' OR protein LIKE '%" + BoxSearch.Text + "%'");
                data();

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
