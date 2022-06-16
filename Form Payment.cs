using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form_Payment : Form
    {
        public static string url = @"Data Source=localhost;Initial Catalog=db_restaurant;Integrated Security=True";
        SqlConnection koneksi = new SqlConnection(url);
        SqlCommand command;
        SqlDataReader reader;
        public Form_Payment()
        {
            InitializeComponent();
        }
        public DataTable ResultDataTable(string command)
        {
            try
            {
                koneksi.Open();
                SqlCommand cmd = new SqlCommand(command, koneksi);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message + " : ' " + command + " ' ");
                return null;
            }
            finally
            {
                koneksi.Close();
            }
        }

        void refresh()
        {
            txb_cardNumber.Clear();
            txb_cash.Clear();
            txb_member.Clear();
            fun_read("SELECT MsMenu.name NamaMenu, OrderDetail.qty Banyak, MsMenu.carbo Carbo, MsMenu.protein Protein, MsMenu.price Harga, OrderDetail.total Total FROM OrderDetail INNER JOIN MsMenu ON OrderDetail.menuId = MsMenu.id WHERE orderId='" + cmb_orderId.SelectedValue + "' AND status='unpaid' ", dgv_payment);
            loadComboBox();
            cmb_orderId.Text = "Pilih OrderId";
            cmb_typePay.Text = "Pilih Pembayaran";
            cmb_bankName.Visible = false;
            txb_cardNumber.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            txb_cash.Visible = false;
            label7.Visible = false;
        }
        void fun_setComboBox(string sql, ComboBox cb, string valueString, string displayString)
        {
            DataTable dtz = new DataTable();
            dtz = ResultDataTable(sql);
            cb.DataSource = dtz;
            cb.DisplayMember = displayString;
            cb.ValueMember = valueString;
        }
        void loadComboBox()
        {
            fun_setComboBox(@"SELECT DISTINCT TOP 100 orderId FROM OrderDetail WHERE status='unpaid' ", cmb_orderId, "orderId", "orderId");
        }
        void fun_read(string query, DataGridView dgv)
        {
            try
            {
                koneksi.Open();
                command = new SqlCommand(query, koneksi);
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
        void fun_setText(string query, string label, Label lb, string field)
        {
            try
            {
                koneksi.Open();
                command = new SqlCommand(query, koneksi);
                reader = command.ExecuteReader();
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
        void fun_query(string query)
        {
            try
            {
                koneksi.Open();
                command = new SqlCommand(query, koneksi);
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
        void fun_update(string query)
        {
            try
            {
                koneksi.Open();
                command = new SqlCommand(query, koneksi);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            new Form_Cashier().Show();
            this.Hide();
        }

        private void cmb_orderId_SelectedValueChanged(object sender, EventArgs e)
        {
            fun_read("SELECT MsMenu.name NamaMenu, OrderDetail.qty Banyak, MsMenu.carbo Carbo, MsMenu.protein Protein, MsMenu.price Harga, OrderDetail.total Total FROM OrderDetail INNER JOIN MsMenu ON OrderDetail.menuId = MsMenu.id WHERE orderId='" + cmb_orderId.SelectedValue + "' ", dgv_payment);
            fun_setText("SELECT SUM(total) hasil FROM OrderDetail WHERE orderId='" + cmb_orderId.SelectedValue + "';", "Total: ", label3, "hasil");
            fun_setText("SELECT SUM(total) hasil FROM OrderDetail WHERE orderId='" + cmb_orderId.SelectedValue + "';", "", label8, "hasil");
        }

        private void cmb_typePay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_typePay.SelectedIndex == 1)
            {
                cmb_bankName.Visible = true;
                txb_cardNumber.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                txb_cash.Visible = false;
                label7.Visible = false;
            }
            else if (cmb_typePay.SelectedIndex == 0)
            {
                txb_cash.Visible = true;
                label7.Visible = true;
                cmb_bankName.Visible = false;
                txb_cardNumber.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            else
            {
                cmb_bankName.Visible = false;
                txb_cardNumber.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                txb_cash.Visible = false;
                label7.Visible = false;
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (cmb_typePay.SelectedIndex == 1)
            {
                if (txb_cardNumber.Text != "" && cmb_bankName.Text != "Pilih Nama Bank")
                {
                    fun_update(@"UPDATE OrderHeader SET 
                    paymentType='" + cmb_typePay.Text + "', bank='" + cmb_bankName.Text + "', cardNumber='" + txb_cardNumber.Text + "', total='" + label8.Text + "' WHERE id='" + cmb_orderId.Text + "' ");
                    fun_query(@"UPDATE OrderDetail SET status='Paid' WHERE orderId='" + cmb_orderId.Text + "'");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Harap Isi Semua Kolom!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (cmb_typePay.SelectedIndex == 0)
            {
                if (txb_cash.Text != "")
                {
                    fun_update(@"UPDATE OrderHeader SET 
                    paymentType='" + cmb_typePay.Text + "', bank='" + cmb_bankName.Text + "', cardNumber='" + txb_cardNumber.Text + "', total='" + label8.Text + "' WHERE id='" + cmb_orderId.Text + "' ");
                    fun_query(@"UPDATE OrderDetail SET status='Paid' WHERE orderId='" + cmb_orderId.Text + "'");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Harap Isi Semua Kolom!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Harap Pilih Metode Pembayaran!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
