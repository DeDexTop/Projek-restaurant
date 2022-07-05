using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            dgv_Menu.Columns[0].HeaderText = "Menu ID";
            dgv_Menu.Columns[1].HeaderText = "Name";
            dgv_Menu.Columns[2].HeaderText = "Price";
            dgv_Menu.Columns[3].HeaderText = "Photo";
            dgv_Menu.Columns[4].HeaderText = "Carbo";
            dgv_Menu.Columns[5].HeaderText = "Protein";
        }
        void show()
        {
            dgv_Menu.DataSource = ShowData("SELECT * FROM MsMenu");
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
            txtCarbo.Text = dgv_Menu.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtProtein.Text = dgv_Menu.Rows[e.RowIndex].Cells[5].Value.ToString();

            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            Image image = Image.FromFile(dir + "\\assets\\" + txtPhoto.Text);
            MenuPicture.Image = image;
            
            label8.Text = "Jika ingin mengupdate data, pilih ulang gambar";
        }

        private void btnSrchImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                
                string newlocation = Path.GetDirectoryName(Application.ExecutablePath) + "\\assets\\" + txtName.Text + ".png";
                string filename = opf.FileName;
                if(File.Exists(newlocation))
                {
                    MenuPicture.Image.Dispose();
                }
                MenuPicture.Image = Image.FromFile(opf.FileName);

                if(File.Exists(newlocation))
                {
                    File.Delete(newlocation);
                    File.Copy(filename, newlocation);
                }
                else
                {
                    File.Copy(filename, newlocation);
                }

                string newName = txtName.Text + ".png";
                txtPhoto.Text = newName;
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

                    SqlCommand com = new SqlCommand("INSERT INTO MsMenu ([name], [price], [photo], [carbo], [protein]) VALUES ('" + txtName.Text + "','" + txtPrice.Text + "','" + txtPhoto.Text + "', '" + txtCarbo.Text + "', '" + txtProtein.Text + "')", koneksi);
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

                    SqlCommand com = new SqlCommand("UPDATE MsMenu SET name = '" + txtName.Text + "', price = '" + txtPrice.Text + "', photo = '" + txtPhoto.Text + "', carbo = '" + txtCarbo.Text + "', protein = '" + txtProtein.Text + "' WHERE id = '" + txtMenuId.Text + "'", koneksi);
                 
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
                SqlCommand com = new SqlCommand("DELETE FROM MsMenu WHERE id = '" + txtMenuId.Text + "'", koneksi);
                com.ExecuteNonQuery();
                string newlocation = Path.GetDirectoryName(Application.ExecutablePath) + "\\assetes\\" + txtName.Text + ".png";
                MenuPicture.Image.Dispose();
                File.Delete(newlocation);
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
                dgv_Menu.DataSource = ShowData("SELECT * FROM MsMenu WHERE id, name, price, photo, carbo, protein LIKE '%" + Convert.ToInt32(BoxSearch.Text) + "%' ");
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
                    dgv_Menu.DataSource = ShowData("SELECT * FROM MsMenu WHERE id, name, price, photo, carbo, protein LIKE '%" + Convert.ToInt32(BoxSearch.Text) + "%' ");
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
