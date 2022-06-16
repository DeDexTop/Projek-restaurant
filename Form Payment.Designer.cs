namespace WindowsFormsApp7
{
    partial class Form_Payment
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
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_member = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_cash = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_cardNumber = new System.Windows.Forms.TextBox();
            this.cmb_bankName = new System.Windows.Forms.ComboBox();
            this.cmb_typePay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_payment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_orderId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 32);
            this.button2.TabIndex = 63;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(703, 402);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 22);
            this.label8.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 446);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 22);
            this.label9.TabIndex = 79;
            this.label9.Text = "Member";
            // 
            // txb_member
            // 
            this.txb_member.Location = new System.Drawing.Point(351, 438);
            this.txb_member.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_member.Name = "txb_member";
            this.txb_member.Size = new System.Drawing.Size(212, 26);
            this.txb_member.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(165, 526);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 77;
            this.label7.Text = "Uang";
            // 
            // txb_cash
            // 
            this.txb_cash.Location = new System.Drawing.Point(591, 526);
            this.txb_cash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_cash.Name = "txb_cash";
            this.txb_cash.Size = new System.Drawing.Size(212, 26);
            this.txb_cash.TabIndex = 76;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(364, 602);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(181, 51);
            this.btn_insert.TabIndex = 75;
            this.btn_insert.Text = "Simpan / Cetak";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 526);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 74;
            this.label6.Text = "Nama Bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 569);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 73;
            this.label5.Text = "Nomor Kartu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 488);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 22);
            this.label4.TabIndex = 72;
            this.label4.Text = "Tipe Pembayaran";
            // 
            // txb_cardNumber
            // 
            this.txb_cardNumber.Location = new System.Drawing.Point(351, 562);
            this.txb_cardNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_cardNumber.Name = "txb_cardNumber";
            this.txb_cardNumber.Size = new System.Drawing.Size(212, 26);
            this.txb_cardNumber.TabIndex = 71;
            // 
            // cmb_bankName
            // 
            this.cmb_bankName.FormattingEnabled = true;
            this.cmb_bankName.Items.AddRange(new object[] {
            "Bank BRI",
            "Bank BNI",
            "Bank Mandiri",
            "Bank BJB",
            "Bank BCA"});
            this.cmb_bankName.Location = new System.Drawing.Point(351, 518);
            this.cmb_bankName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_bankName.Name = "cmb_bankName";
            this.cmb_bankName.Size = new System.Drawing.Size(212, 28);
            this.cmb_bankName.TabIndex = 70;
            this.cmb_bankName.Text = "Pilih Nama Bank";
            // 
            // cmb_typePay
            // 
            this.cmb_typePay.FormattingEnabled = true;
            this.cmb_typePay.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cmb_typePay.Location = new System.Drawing.Point(351, 478);
            this.cmb_typePay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_typePay.Name = "cmb_typePay";
            this.cmb_typePay.Size = new System.Drawing.Size(212, 28);
            this.cmb_typePay.TabIndex = 69;
            this.cmb_typePay.Text = "Pilih Pembayaran";
            this.cmb_typePay.SelectedIndexChanged += new System.EventHandler(this.cmb_typePay_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 402);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "Total";
            // 
            // dgv_payment
            // 
            this.dgv_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payment.Location = new System.Drawing.Point(13, 162);
            this.dgv_payment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_payment.Name = "dgv_payment";
            this.dgv_payment.RowHeadersWidth = 51;
            this.dgv_payment.Size = new System.Drawing.Size(866, 235);
            this.dgv_payment.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 66;
            this.label2.Text = "Order ID";
            // 
            // cmb_orderId
            // 
            this.cmb_orderId.FormattingEnabled = true;
            this.cmb_orderId.Location = new System.Drawing.Point(364, 119);
            this.cmb_orderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_orderId.Name = "cmb_orderId";
            this.cmb_orderId.Size = new System.Drawing.Size(180, 28);
            this.cmb_orderId.TabIndex = 65;
            this.cmb_orderId.Text = "Pilih Order ID";
            this.cmb_orderId.SelectedValueChanged += new System.EventHandler(this.cmb_orderId_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 40);
            this.label1.TabIndex = 64;
            this.label1.Text = "Pembayaran";
            // 
            // Form_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 669);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_member);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_cash);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_cardNumber);
            this.Controls.Add(this.cmb_bankName);
            this.Controls.Add(this.cmb_typePay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_payment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_orderId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Form_Payment";
            this.Text = "Form_Payment";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_member;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_cash;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_cardNumber;
        private System.Windows.Forms.ComboBox cmb_bankName;
        private System.Windows.Forms.ComboBox cmb_typePay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_payment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_orderId;
        private System.Windows.Forms.Label label1;
    }
}