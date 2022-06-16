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
    public partial class Form_Report : Form
    {
        public static string url = @"Data Source=localhost;Initial Catalog=db_restaurant;Integrated Security=True";
        SqlConnection koneksi = new SqlConnection(url);
        SqlCommand command;
        public Form_Report()
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
        void fun_setComboBox(string sql, ComboBox cb, string valueString, string displayString)
        {
            DataTable dtz = new DataTable();
            dtz = ResultDataTable(sql);
            cb.DataSource = dtz;
            cb.DisplayMember = displayString;
            cb.ValueMember = valueString;
        }
        void getComboBoxItem()
        {
            fun_setComboBox("SELECT DISTINCT TOP 100 date FROM OrderHeader;", comboBox1, "date", "date");
            fun_setComboBox("SELECT DISTINCT TOP 100 date FROM OrderHeader;", comboBox2, "date", "date");

        }
        void showData()
        {
            fun_read("SELECT date, total FROM OrderHeader WHERE date BETWEEN '" + comboBox1.SelectedValue + "' AND '" + comboBox2.SelectedValue + "' ORDER BY date ASC ", dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form_Admin().Show();
            this.Hide();
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            getComboBoxItem();
        }

        private void btn_bulan_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
