namespace WindowsFormsApp7
{
    partial class Form_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_price = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_hapusOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_orderId = new System.Windows.Forms.TextBox();
            this.btn_insertOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.txb_cari = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.txb_menuId = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_qty = new System.Windows.Forms.TextBox();
            this.txb_namaMenu = new System.Windows.Forms.TextBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_price
            // 
            this.txb_price.Location = new System.Drawing.Point(640, 453);
            this.txb_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(228, 26);
            this.txb_price.TabIndex = 42;
            this.txb_price.Visible = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(291, 25);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(112, 35);
            this.btn_refresh.TabIndex = 32;
            this.btn_refresh.Text = "Refresh ID";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_refresh);
            this.groupBox2.Controls.Add(this.btn_hapusOrder);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txb_orderId);
            this.groupBox2.Controls.Add(this.btn_insertOrder);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgv_order);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(43, 588);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(864, 394);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daftar Order";
            // 
            // btn_hapusOrder
            // 
            this.btn_hapusOrder.AutoSize = true;
            this.btn_hapusOrder.Location = new System.Drawing.Point(668, 25);
            this.btn_hapusOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_hapusOrder.Name = "btn_hapusOrder";
            this.btn_hapusOrder.Size = new System.Drawing.Size(186, 46);
            this.btn_hapusOrder.TabIndex = 31;
            this.btn_hapusOrder.Text = "Bersihkan Daftar Order";
            this.btn_hapusOrder.UseVisualStyleBackColor = true;
            this.btn_hapusOrder.Click += new System.EventHandler(this.btn_hapusOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "Order ID";
            // 
            // txb_orderId
            // 
            this.txb_orderId.Location = new System.Drawing.Point(132, 29);
            this.txb_orderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_orderId.Name = "txb_orderId";
            this.txb_orderId.ReadOnly = true;
            this.txb_orderId.Size = new System.Drawing.Size(148, 26);
            this.txb_orderId.TabIndex = 27;
            // 
            // btn_insertOrder
            // 
            this.btn_insertOrder.Location = new System.Drawing.Point(370, 335);
            this.btn_insertOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_insertOrder.Name = "btn_insertOrder";
            this.btn_insertOrder.Size = new System.Drawing.Size(112, 35);
            this.btn_insertOrder.TabIndex = 18;
            this.btn_insertOrder.Text = "Order";
            this.btn_insertOrder.UseVisualStyleBackColor = true;
            this.btn_insertOrder.Click += new System.EventHandler(this.btn_insertOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(651, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Protein: ";
            // 
            // dgv_order
            // 
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Location = new System.Drawing.Point(9, 78);
            this.dgv_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowHeadersWidth = 62;
            this.dgv_order.Size = new System.Drawing.Size(846, 248);
            this.dgv_order.TabIndex = 17;
            this.dgv_order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Karbohidrat: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_menu);
            this.groupBox1.Controls.Add(this.txb_cari);
            this.groupBox1.Controls.Add(this.btn_cari);
            this.groupBox1.Controls.Add(this.txb_menuId);
            this.groupBox1.Location = new System.Drawing.Point(43, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(864, 283);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Menu";
            // 
            // dgv_menu
            // 
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Location = new System.Drawing.Point(9, 69);
            this.dgv_menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.RowHeadersWidth = 62;
            this.dgv_menu.Size = new System.Drawing.Size(846, 205);
            this.dgv_menu.TabIndex = 9;
            this.dgv_menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Menu_CellClick);
            // 
            // txb_cari
            // 
            this.txb_cari.Location = new System.Drawing.Point(584, 28);
            this.txb_cari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_cari.Name = "txb_cari";
            this.txb_cari.Size = new System.Drawing.Size(148, 26);
            this.txb_cari.TabIndex = 22;
            this.txb_cari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_cari_KeyDown);
            // 
            // btn_cari
            // 
            this.btn_cari.Location = new System.Drawing.Point(742, 25);
            this.btn_cari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(112, 35);
            this.btn_cari.TabIndex = 23;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // txb_menuId
            // 
            this.txb_menuId.Location = new System.Drawing.Point(597, 182);
            this.txb_menuId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_menuId.Name = "txb_menuId";
            this.txb_menuId.Size = new System.Drawing.Size(228, 26);
            this.txb_menuId.TabIndex = 26;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(505, 527);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(112, 35);
            this.btn_insert.TabIndex = 38;
            this.btn_insert.Text = "Tambahkan";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 381);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nama Menu";
            // 
            // txb_qty
            // 
            this.txb_qty.Location = new System.Drawing.Point(640, 413);
            this.txb_qty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_qty.Name = "txb_qty";
            this.txb_qty.Size = new System.Drawing.Size(228, 26);
            this.txb_qty.TabIndex = 35;
            // 
            // txb_namaMenu
            // 
            this.txb_namaMenu.Location = new System.Drawing.Point(640, 373);
            this.txb_namaMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_namaMenu.Name = "txb_namaMenu";
            this.txb_namaMenu.Size = new System.Drawing.Size(228, 26);
            this.txb_namaMenu.TabIndex = 34;
            // 
            // pb_image
            // 
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_image.Location = new System.Drawing.Point(118, 373);
            this.pb_image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(241, 187);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 33;
            this.pb_image.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(627, 527);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 35);
            this.btn_delete.TabIndex = 39;
            this.btn_delete.Text = "Hapus";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 40);
            this.label1.TabIndex = 32;
            this.label1.Text = "Order";
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 994);
            this.Controls.Add(this.txb_price);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_qty);
            this.Controls.Add(this.txb_namaMenu);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.Name = "Form_Order";
            this.Text = "Form_Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Order_FormClosing);
            this.Load += new System.EventHandler(this.Form_Order_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_hapusOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_orderId;
        private System.Windows.Forms.Button btn_insertOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.TextBox txb_cari;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox txb_menuId;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_qty;
        private System.Windows.Forms.TextBox txb_namaMenu;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
    }
}