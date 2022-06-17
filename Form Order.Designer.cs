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
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelProtein = new System.Windows.Forms.Label();
            this.labelCarbo = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_qty = new System.Windows.Forms.TextBox();
            this.txb_namaMenu = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.dgv_Menu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPicture = new System.Windows.Forms.PictureBox();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(744, 773);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(65, 20);
            this.labelTotal.TabIndex = 76;
            this.labelTotal.Text = "Total : 0";
            // 
            // labelProtein
            // 
            this.labelProtein.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProtein.AutoSize = true;
            this.labelProtein.Location = new System.Drawing.Point(229, 773);
            this.labelProtein.Name = "labelProtein";
            this.labelProtein.Size = new System.Drawing.Size(80, 20);
            this.labelProtein.TabIndex = 74;
            this.labelProtein.Text = "Protein : 0";
            // 
            // labelCarbo
            // 
            this.labelCarbo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCarbo.AutoSize = true;
            this.labelCarbo.Location = new System.Drawing.Point(38, 773);
            this.labelCarbo.Name = "labelCarbo";
            this.labelCarbo.Size = new System.Drawing.Size(73, 20);
            this.labelCarbo.TabIndex = 72;
            this.labelCarbo.Text = "Carbo : 0";
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrder.Location = new System.Drawing.Point(447, 815);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 36);
            this.btnOrder.TabIndex = 71;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Qty";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Menu Name";
            // 
            // txb_qty
            // 
            this.txb_qty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_qty.Location = new System.Drawing.Point(564, 373);
            this.txb_qty.Name = "txb_qty";
            this.txb_qty.Size = new System.Drawing.Size(215, 26);
            this.txb_qty.TabIndex = 68;
            // 
            // txb_namaMenu
            // 
            this.txb_namaMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_namaMenu.Location = new System.Drawing.Point(564, 327);
            this.txb_namaMenu.Name = "txb_namaMenu";
            this.txb_namaMenu.Size = new System.Drawing.Size(215, 26);
            this.txb_namaMenu.TabIndex = 67;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(671, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(564, 492);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgv_Order
            // 
            this.dgv_Order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5,
            this.column6,
            this.Column7,
            this.Column8});
            this.dgv_Order.Location = new System.Drawing.Point(12, 576);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.RowHeadersWidth = 62;
            this.dgv_Order.RowTemplate.Height = 28;
            this.dgv_Order.Size = new System.Drawing.Size(947, 179);
            this.dgv_Order.TabIndex = 63;
            // 
            // dgv_Menu
            // 
            this.dgv_Menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Menu.Location = new System.Drawing.Point(12, 113);
            this.dgv_Menu.Name = "dgv_Menu";
            this.dgv_Menu.RowHeadersWidth = 62;
            this.dgv_Menu.RowTemplate.Height = 28;
            this.dgv_Menu.Size = new System.Drawing.Size(947, 179);
            this.dgv_Menu.TabIndex = 62;
            this.dgv_Menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Menu_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 61;
            this.label1.Text = "Form Order";
            // 
            // MenuPicture
            // 
            this.MenuPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuPicture.Location = new System.Drawing.Point(99, 348);
            this.MenuPicture.Name = "MenuPicture";
            this.MenuPicture.Size = new System.Drawing.Size(201, 149);
            this.MenuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuPicture.TabIndex = 78;
            this.MenuPicture.TabStop = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Menu ID";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            // 
            // column1
            // 
            this.column1.HeaderText = "Menu";
            this.column1.MinimumWidth = 8;
            this.column1.Name = "column1";
            // 
            // column2
            // 
            this.column2.HeaderText = "Qty";
            this.column2.MinimumWidth = 8;
            this.column2.Name = "column2";
            // 
            // column3
            // 
            this.column3.HeaderText = "Carbo";
            this.column3.MinimumWidth = 8;
            this.column3.Name = "column3";
            // 
            // column4
            // 
            this.column4.HeaderText = "Protein";
            this.column4.MinimumWidth = 8;
            this.column4.Name = "column4";
            // 
            // column5
            // 
            this.column5.HeaderText = "Price";
            this.column5.MinimumWidth = 8;
            this.column5.Name = "column5";
            // 
            // column6
            // 
            this.column6.HeaderText = "Total";
            this.column6.MinimumWidth = 8;
            this.column6.Name = "column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Carbo";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total Protein";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 32);
            this.button1.TabIndex = 79;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 879);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MenuPicture);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelProtein);
            this.Controls.Add(this.labelCarbo);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_qty);
            this.Controls.Add(this.txb_namaMenu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv_Order);
            this.Controls.Add(this.dgv_Menu);
            this.Controls.Add(this.label1);
            this.Name = "Form_Order";
            this.Text = "Form_Order";
            this.Load += new System.EventHandler(this.Form_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelProtein;
        private System.Windows.Forms.Label labelCarbo;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_qty;
        private System.Windows.Forms.TextBox txb_namaMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.DataGridView dgv_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button button1;
    }
}