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
   
        public int qty, price, hasil;
        public string total;

        public Form_Payment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form_Cashier().Show();
            this.Hide();
        }
        string Total()
        {
            qty = Convert.ToInt32(dgv_Payment.Rows[1].Cells[1].Value);
            price = Convert.ToInt32(dgv_Payment.Rows[2].Cells[2].Value);
            hasil = qty * price;
            total = hasil.ToString();
            return total;
        }

        public object ShowData(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, url);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object bebas = data.Tables[0];
            return bebas;
        }

        private void cbx_PaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_PaymentType.Text == "Cash")
            {
                labelNumb.Text = "Amount of Money";
                label5.Visible = false;
                cbx_Bank.Visible = false;
                txt_CardNumber.Visible = false;
                txt_Cash.Visible = true;
            }
            else if(cbx_PaymentType.Text == "Credit")
            {
                labelNumb.Text = "Card Nnumber";
                label5.Visible = true;
                cbx_Bank.Visible = true;
                txt_CardNumber.Visible = true;
                txt_Cash.Visible = false;
            }
            else if( cbx_PaymentType.Text == "")
            {
                labelNumb.Text = "Card Nnumber";
                label5.Visible = true;
                cbx_Bank.Visible = true;
                txt_CardNumber.Visible = true;
                txt_Cash.Visible = false;
            }
        }

        public DataRowCollection GetData(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, url);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows;
        }

        private void Form_Payment_Load(object sender, EventArgs e)
        {
            show();
            cbx_OrderID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Bank.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_PaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void data()
        {
            dgv_Payment.Columns[0].HeaderText = "Name";
            dgv_Payment.Columns[1].HeaderText = "Qty";
            dgv_Payment.Columns[2].HeaderText = "Price";
        }
        void clear()
        {
            dgv_Payment.Rows.Clear();
            labelNumb.Text = "Card Number";
            label5.Visible = true;
            cbx_Bank.Visible = true;
            txt_CardNumber.Visible = true;
            txt_Cash.Visible = false;

            cbx_OrderID.Items.Clear();
            txt_CardNumber.Text = "";
            txt_Cash.Text = "";
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clear();
        }
        
        void show()
        {
            DataRowCollection dataMenu = GetData("SELECT MsMenu.name, OrderDetail.qty, MsMenu.price FROM OrderDetail INNER JOIN MsMenu ON OrderDetail.menuid = MsMenu.id WHERE status = 'unpaid'");
            long total = 0;
            for (int i = 0; i < dataMenu.Count; i++)
            {
                dgv_Payment.Rows.Add(dataMenu[i]["name"],dataMenu[i]["qty"],dataMenu[i]["price"], Convert.ToInt64(dataMenu[i]["qty"]) * Convert.ToInt64(dataMenu[i]["price"]));
                total += Convert.ToInt64(dataMenu[i]["qty"]) * Convert.ToInt64(dataMenu[i]["price"]);
            }
            lableTotal.Text = "Total: " + total;

            DataRowCollection col = GetData("SELECT orderid FROM OrderDetail WHERE status = 'unpaid'");
            foreach (DataRow row in col)
            {
                cbx_OrderID.Items.Add(row["orderid"]);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (koneksi.State == ConnectionState.Closed) koneksi.Open();
                SqlCommand command = new SqlCommand("UPDATE OrderHeader SET paymenttype = '" + cbx_PaymentType.Text + "', cardnumber = '" + txt_CardNumber.Text + "', bank = '" + cbx_Bank.Text + "' WHERE id = '" + cbx_OrderID.Text + "'", koneksi);
                command.ExecuteNonQuery();
                SqlCommand com = new SqlCommand("UPDATE OrderDetail SET status = 'Paid' WHERE orderid = '" + cbx_OrderID.Text + "'", koneksi);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
            clear();
            show();
        }
    }
}
