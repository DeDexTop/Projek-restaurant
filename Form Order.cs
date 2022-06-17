﻿using System;
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
        public string id, name, qty, carbo, protein, price, total, totalcarbo, totalprotein;
        public int jumlah, harga, hasil, karbo, prote, totalKarbo, totalProte;

        

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
        void data()
        {
            dgv_Menu.Columns[0].HeaderText = "MenuId";
            dgv_Menu.Columns[1].HeaderText = "Name";
            dgv_Menu.Columns[2].HeaderText = "Price";
            dgv_Menu.Columns[3].HeaderText = "Photo";
            dgv_Menu.Columns[4].HeaderText = "carbo";
            dgv_Menu.Columns[5].HeaderText = "protein";
        }
        void show()
        {
            dgv_Menu.DataSource = ShowData("SELECT * FROM MsMenu");
            data();

            dgv_Menu.Columns[0].Visible = false;
            dgv_Menu.Columns[3].Visible = false;

            dgv_Order.Columns[0].Visible = false;
            dgv_Order.Columns[8].Visible = false;
            dgv_Order.Columns[7].Visible = false;
        }
        private void Form_Order_Load(object sender, EventArgs e)
        {
            show();
            txb_namaMenu.Enabled = false;
        }

        private void dgv_Menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_namaMenu.Text = dgv_Menu.Rows[e.RowIndex].Cells[1].Value.ToString();

            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            Image image = Image.FromFile(dir + "\\assets\\" + dgv_Menu.Rows[e.RowIndex].Cells[3].Value.ToString());
            MenuPicture.Image = image;

            id = dgv_Menu.Rows[e.RowIndex].Cells[0].Value.ToString();
            name = dgv_Menu.Rows[e.RowIndex].Cells[1].Value.ToString();
            carbo = dgv_Menu.Rows[e.RowIndex].Cells[4].Value.ToString();
            protein = dgv_Menu.Rows[e.RowIndex].Cells[5].Value.ToString();
            price = dgv_Menu.Rows[e.RowIndex].Cells[2].Value.ToString();

            karbo = int.Parse(dgv_Menu.Rows[e.RowIndex].Cells[4].Value.ToString());
            prote = int.Parse(dgv_Menu.Rows[e.RowIndex].Cells[5].Value.ToString());
            harga = int.Parse(dgv_Menu.Rows[e.RowIndex].Cells[2].Value.ToString());
        }
        string Total()
        {
            jumlah = int.Parse(txb_qty.Text);
            hasil = jumlah * harga;
            total = hasil.ToString();
            string bebas = total;
            return bebas;
        }
        string TotalCarbo()
        {
            jumlah = int.Parse(txb_qty.Text);
            totalKarbo = jumlah * karbo;
            string bebas = totalKarbo.ToString();
            return bebas;
        }
        string TotalProtein()
        {
            jumlah = int.Parse(txb_qty.Text);
            totalProte = jumlah * prote;
            string bebas = totalProte.ToString();
            return bebas;
        }
        void label()
        {
            int car = 0;
            for (int i = 0; i < dgv_Order.Rows.Count; ++i)
            {
                car += Convert.ToInt32(dgv_Order.Rows[i].Cells[7].Value);
                labelCarbo.Text = "Carbo : " + car.ToString();
            }
            int pro = 0;
            for (int i = 0; i < dgv_Order.Rows.Count; ++i)
            {
                pro += Convert.ToInt32(dgv_Order.Rows[i].Cells[8].Value);
                labelProtein.Text = "Protein : " + pro.ToString();
            }
            int total = 0;
            for(int i = 0; i < dgv_Order.Rows.Count; ++i)
            {
                total += Convert.ToInt32(dgv_Order.Rows[i].Cells[6].Value);
                labelTotal.Text = "Total : " + total.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txb_qty.Text == "" || MenuPicture.Image == null || txb_namaMenu.Text == "")
            {
                MessageBox.Show("Semua kolom harap di isi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                bool found = false; 
                if(dgv_Order.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_Order.Rows)
                    {
                        if(Convert.ToString(row.Cells[1].Value) == txb_namaMenu.Text)
                        {   
                            row.Cells[2].Value = Convert.ToString(Convert.ToInt32(txb_qty.Text) + Convert.ToInt32(row.Cells[2].Value));
                            row.Cells[6].Value = Convert.ToString(Convert.ToInt32(row.Cells[6].Value) + Convert.ToInt32(Total()));
                            found = true;
                        }
                    }
                    if(!found)
                    {
                        Total();
                        qty = txb_qty.Text;
                        totalcarbo = TotalCarbo();
                        totalprotein = TotalProtein();
                        dgv_Order.Rows.Add(id, name, qty, carbo, protein, price, total, totalcarbo, totalprotein);
                    }
                }
                else
                {
                    Total();
                    qty = txb_qty.Text;
                    totalcarbo = TotalCarbo();
                    totalprotein = TotalProtein();
                    dgv_Order.Rows.Add(id, name, qty, carbo, protein, price, total, totalcarbo, totalprotein);
                }

                txb_qty.Text = "";
                txb_namaMenu.Text = "";
                MenuPicture.Image = null;
                label();    
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Order.SelectedRows)
            {
                dgv_Order.Rows.RemoveAt(row.Index);

                label();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_Admin().Show();
            this.Hide();
        }
    }
}
