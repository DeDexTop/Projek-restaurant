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
        public Form_Report()
        {
            InitializeComponent();
        }
        public DataRowCollection GetData(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, url);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows;
        }
        public DataTable ResultDataTable(string command)
        {
            try
            {
                if (koneksi.State == ConnectionState.Closed) koneksi.Open();
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
        void fun_read()
        {
            try
            {
                if (koneksi.State == ConnectionState.Closed) koneksi.Open();
                DataRowCollection dataMenu = GetData("SELECT MsMenu.price, OrderDetail.qty, OrderHeader.date FROM OrderHeader JOIN OrderDetail ON OrderDetail.orderid = OrderHeader.id JOIN MsMenu ON MsMenu.id = OrderDetail.menuid WHERE date BETWEEN '" + comboBox1.SelectedValue + "' AND '" + comboBox2.SelectedValue + "';");
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
            Console.WriteLine(displayString);
        }
        void getComboBoxItem()
        {
            var items = new BindingList<KeyValuePair<string, string>>();

            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/01/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Januari"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/02/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Februari"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/03/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Maret"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/04/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "April"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/05/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Mei"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/06/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Juni"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/07/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Juli"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/08/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Agustus"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/09/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "September"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/10/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Oktober"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/11/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "November"));
            items.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/12/01", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "December"));

            var items2 = new BindingList<KeyValuePair<string, string>>();

            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/01/31", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Januari"));
            if (DateTime.IsLeapYear(Convert.ToInt32(DateTime.Now.ToString("yyyy"))))
             {
                items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/02/29", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Februari"));
            }
            else
            {
                items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/02/28", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Februari"));
            }
            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/03/31", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Maret"));
            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/04/30", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "April"));
            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/05/31", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Mei"));
            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/06/30", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Juni"));
            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/07/31", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Juli"));
            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/08/31", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Agustus"));
            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/09/30", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "September"));
            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/10/31", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "Oktober"));
            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/11/30", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "November"));
            items2.Add(new KeyValuePair<string, string>(DateTime.ParseExact("2022/12/31", "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"), "December"));

            comboBox1.DataSource = items;
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Value";
            comboBox2.DataSource = items2;
            comboBox2.ValueMember = "Key";
            comboBox2.DisplayMember = "Value";
        }
        void showData()
        {
            Console.WriteLine(comboBox1.SelectedValue);
            Console.WriteLine(comboBox2.SelectedValue);
            fun_read();
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
            chart1.Series[0].Points.Clear();
            dataGridView1.Rows.Clear();
            for (int i = comboBox1.SelectedIndex +1; i <= comboBox2.SelectedIndex + 1; i++)
            {
                string month = i.ToString("D2");
                DataRowCollection dataMenu = GetData("SELECT MsMenu.price, OrderDetail.qty, OrderHeader.date FROM OrderHeader JOIN OrderDetail ON OrderDetail.orderid = OrderHeader.id JOIN MsMenu ON MsMenu.id = OrderDetail.menuid WHERE date BETWEEN '"+ comboBox1.SelectedValue +"' AND '" + comboBox2.SelectedValue + "';");
                int income = 0;
                for (int x = 0; x < dataMenu.Count; x++)
                {
                    if (DateTime.Parse(dataMenu[x][2].ToString()).ToString("MM") == DateTime.Parse($"2022/{month}/01").ToString("MM"))
                    {
                        Console.WriteLine("kesini");
                        income += Convert.ToInt32(dataMenu[x][1].ToString()) * Convert.ToInt32(dataMenu[x][0].ToString());
                    }
                    Console.WriteLine(dataMenu[0][1]);
                }
                chart1.Series[0].Points.AddXY(DateTime.Parse($"2022/{month}/01").ToString("MMM"), Math.Round(income / 1000000m, 5));
                dataGridView1.Rows.Add(DateTime.Parse($"2022/{month}/01").ToString("MMMM"), Math.Round(income / 1000000m, 5));
            }
            showData();
        }
    }
}
