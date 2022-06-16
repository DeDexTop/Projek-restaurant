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
    public partial class Form_Order : Form
    {
        public static string url = @"Data Source=localhost;Initial Catalog=db_restaurant;Integrated Security=True";
        SqlConnection koneksi = new SqlConnection(url);
        int id = 0;
        public Form_Order()
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
        public void fun_read(string query, DataGridView dgv)
        {
            try
            {
                koneksi.Open();
                SqlCommand command = new SqlCommand(query, koneksi);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
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

        public void fun_query(string query)
        {
            try
            {
                koneksi.Open();
                SqlCommand command = new SqlCommand(query, koneksi);
                command.ExecuteNonQuery();
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

        public void fun_insert(string query)
        {
            try
            {
                koneksi.Open();
                SqlCommand command = new SqlCommand(query, koneksi);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void fun_delete(string query)
        {
            try
            {
                koneksi.Open();
                SqlCommand command = new SqlCommand(query, koneksi);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public Image ConvertByteToArray(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        public void fun_setText(string query, string label, Label lb, string field)
        {
            try
            {
                koneksi.Open();
                SqlCommand command = new SqlCommand(query, koneksi);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lb.Text = $"{label}{reader[field].ToString()}";
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

        string generateId()
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            string hasil = $"{date}{id++.ToString().PadLeft(3, '0')}";
            txb_orderId.Text = hasil;
            return hasil;
        }

        string total()
        {
            int qty = int.Parse(txb_qty.Text);
            int price = int.Parse(txb_price.Text);
            int hasil = price * qty;
            string finaly = hasil.ToString();
            return finaly;
        }

        void checkId()
        {
            koneksi = new SqlConnection(url);
            string query = "SELECT COUNT(*) FROM OrderHeader WHERE id=@id";
            SqlCommand command = new SqlCommand(query, koneksi);
            command.Parameters.AddWithValue("@user", txb_orderId.Text);
            int UserExist = (int)command.ExecuteScalar();

            if (UserExist > 0)
            {
                //Username exist
            }
            else
            {
                generateId();
            }
        }
        void refresh()
        {
            txb_cari.Clear();
            txb_namaMenu.Clear();
            txb_qty.Clear();
            pb_image.Image = null;
            fun_read("SELECT tempOrder1.id, tempOrder1.menuId, MsMenu1.name NamaMenu, tempOrder1.qty Banyak, MsMenu1.carbo Carbo, MsMenu1.protein Protein, MsMenu1.price Harga, tempOrder1.total Total FROM tempOrder1 INNER JOIN MsMenu1 ON tempOrder1.menuId = MsMenu1.id; ", dgv_order);
            dgv_order.Columns[0].Visible = false;
            dgv_order.Columns[1].Visible = false;
            fun_setText("SELECT SUM(carbo) hasil FROM tempOrder1 INNER JOIN MsMenu1 ON tempOrder1.menuId = MsMenu1.id;", "Karbohidrat: ", label4, "hasil");
            fun_setText("SELECT SUM(protein) hasil FROM tempOrder1 INNER JOIN MsMenu1 ON tempOrder1.menuId = MsMenu1.id;", "Protein: ", label5, "hasil");
            fun_setText("SELECT SUM(total) hasil FROM tempOrder1 INNER JOIN MsMenu1 ON tempOrder1.menuId = MsMenu1.id;", "Total: ", label6, "hasil");

        }

        private void Form_Order_Load(object sender, EventArgs e)
        {
            
            fun_read("SELECT id MenuId, name NamaMenu, price Harga, photo Photo, image Image, carbo Karbohidrat, protein Protein FROM MsMenu1", dgv_menu);
            fun_read("SELECT tempOrder1.id orderid, tempOrder1.menuId menuId, MsMenu1.name NamaMenu, tempOrder1.qty Banyak, MsMenu1.carbo Carbo, MsMenu1.protein Protein, MsMenu1.price Harga, tempOrder1.total Total FROM tempOrder1 INNER JOIN MsMenu1 ON tempOrder1.menuId = MsMenu1.id; ", dgv_order);
            txb_menuId.Visible = false;
            dgv_menu.Columns[0].Visible = false;
            dgv_menu.Columns[3].Visible = false;
            dgv_menu.Columns[4].Visible = false;
            dgv_order.Columns[0].Visible = false;
            dgv_order.Columns[1].Visible = false;
            txb_namaMenu.Enabled = false;
        }

        private void dgv_Menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_menuId.Text = dgv_menu.Rows[e.RowIndex].Cells[0].Value.ToString();
            txb_namaMenu.Text = dgv_menu.Rows[e.RowIndex].Cells[1].Value.ToString();
            txb_price.Text = dgv_menu.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (DBNull.Value.Equals(dgv_menu.Rows[e.RowIndex].Cells[4].Value))
            {
                pb_image.Image = null;
            }
            else
            {
                pb_image.Image = ConvertByteToArray((byte[])dgv_menu.Rows[e.RowIndex].Cells[4].Value);
            }
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            if (txb_cari.Text != "")
            {
                fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu1 WHERE name='" + txb_cari.Text + "' ", dgv_menu);
            }
            else
            {
                fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu1", dgv_menu);
            }
        }

        private void txb_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txb_cari.Text != "")
                {
                    fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu1 WHERE name='" + txb_cari.Text + "' ", dgv_menu);
                }
                else
                {
                    fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu1", dgv_menu);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            fun_delete("DELETE FROM tempOrder1 WHERE menuId='" + txb_menuId.Text + "'");
            refresh();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txb_qty.Text != "" && txb_namaMenu.Text != "")
            {
                fun_query("INSERT INTO OrderHeader([id],[employeeId],[memberId],[date]) VALUES('" + txb_orderId.Text + "','1','2',getDate());");
                fun_insert("INSERT INTO tempOrder1([menuId],[qty],[total]) VALUES('" + txb_menuId.Text + "', '" + txb_qty.Text + "', '" + total() + "')");
                total();
                refresh();
            }
        }

        private void btn_insertOrder_Click(object sender, EventArgs e)
        {
            koneksi = new SqlConnection(url);
            try
            {
                foreach (DataGridViewRow row in dgv_order.Rows)
                {
                    koneksi.Open();
                    SqlCommand command = new SqlCommand(@"INSERT INTO OrderDetail1([orderId],[menuId],[qty],[status], [total]) VALUES
                    (@order,@menuName ,@qty, 'unpaid', @total)", koneksi);
                    command.Parameters.AddWithValue("@order", txb_orderId.Text);
                    command.Parameters.AddWithValue("@menuName", row.Cells[1].Value);
                    command.Parameters.AddWithValue("@qty", row.Cells[3].Value);
                    command.Parameters.AddWithValue("@total", row.Cells[7].Value);
                    command.ExecuteNonQuery();
                    refresh();
                    fun_query("DELETE FROM tempOrder1");
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

        private void Form_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            fun_query("DELETE FROM tempOrder1");
        }

        private void btn_hapusOrder_Click(object sender, EventArgs e)
        {
            fun_delete("DELETE FROM tempOrder1");
            txb_orderId.Clear();
            refresh();
        }

        private void dgv_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgv_order.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.

                txb_menuId.Text = row.Cells[1].Value.ToString();
                txb_namaMenu.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //generateId();

            string date = DateTime.Now.ToString("yyyyMMdd");
            id++;
            string hasil = $"{date}{id.ToString().PadLeft(3, '0')}";
            txb_orderId.Text = hasil;
            Console.WriteLine(id);
        }
    }
}
