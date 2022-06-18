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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_OrderID = new System.Windows.Forms.ComboBox();
            this.cbx_PaymentType = new System.Windows.Forms.ComboBox();
            this.cbx_Bank = new System.Windows.Forms.ComboBox();
            this.txt_CardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Payment = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lableTotal = new System.Windows.Forms.Label();
            this.txt_Cash = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(8, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 21);
            this.button2.TabIndex = 63;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Form Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "OrderID";
            // 
            // cbx_OrderID
            // 
            this.cbx_OrderID.FormattingEnabled = true;
            this.cbx_OrderID.Location = new System.Drawing.Point(229, 86);
            this.cbx_OrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_OrderID.Name = "cbx_OrderID";
            this.cbx_OrderID.Size = new System.Drawing.Size(135, 21);
            this.cbx_OrderID.TabIndex = 66;
            // 
            // cbx_PaymentType
            // 
            this.cbx_PaymentType.FormattingEnabled = true;
            this.cbx_PaymentType.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cbx_PaymentType.Location = new System.Drawing.Point(229, 294);
            this.cbx_PaymentType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_PaymentType.Name = "cbx_PaymentType";
            this.cbx_PaymentType.Size = new System.Drawing.Size(137, 21);
            this.cbx_PaymentType.TabIndex = 67;
            this.cbx_PaymentType.SelectedIndexChanged += new System.EventHandler(this.cbx_PaymentType_SelectedIndexChanged);
            // 
            // cbx_Bank
            // 
            this.cbx_Bank.FormattingEnabled = true;
            this.cbx_Bank.Location = new System.Drawing.Point(229, 363);
            this.cbx_Bank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Bank.Name = "cbx_Bank";
            this.cbx_Bank.Size = new System.Drawing.Size(137, 21);
            this.cbx_Bank.TabIndex = 68;
            // 
            // txt_CardNumber
            // 
            this.txt_CardNumber.Location = new System.Drawing.Point(229, 330);
            this.txt_CardNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_CardNumber.Name = "txt_CardNumber";
            this.txt_CardNumber.Size = new System.Drawing.Size(137, 20);
            this.txt_CardNumber.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Payment Type";
            // 
            // labelNumb
            // 
            this.labelNumb.AutoSize = true;
            this.labelNumb.Location = new System.Drawing.Point(113, 332);
            this.labelNumb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumb.Name = "labelNumb";
            this.labelNumb.Size = new System.Drawing.Size(69, 13);
            this.labelNumb.TabIndex = 71;
            this.labelNumb.Text = "Card Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Bank";
            // 
            // dgv_Payment
            // 
            this.dgv_Payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_Payment.Location = new System.Drawing.Point(8, 149);
            this.dgv_Payment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Payment.Name = "dgv_Payment";
            this.dgv_Payment.RowHeadersWidth = 62;
            this.dgv_Payment.RowTemplate.Height = 28;
            this.dgv_Payment.Size = new System.Drawing.Size(579, 98);
            this.dgv_Payment.TabIndex = 73;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 398);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 29);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lableTotal
            // 
            this.lableTotal.AutoSize = true;
            this.lableTotal.Location = new System.Drawing.Point(427, 255);
            this.lableTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableTotal.Name = "lableTotal";
            this.lableTotal.Size = new System.Drawing.Size(40, 13);
            this.lableTotal.TabIndex = 75;
            this.lableTotal.Text = "Total : ";
            // 
            // txt_Cash
            // 
            this.txt_Cash.Location = new System.Drawing.Point(229, 330);
            this.txt_Cash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Cash.Name = "txt_Cash";
            this.txt_Cash.Size = new System.Drawing.Size(137, 20);
            this.txt_Cash.TabIndex = 76;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Reset.Location = new System.Drawing.Point(521, 398);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(66, 29);
            this.btn_Reset.TabIndex = 77;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // name
            // 
            this.name.HeaderText = "menu";
            this.name.Name = "name";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "qty";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "total";
            this.Column3.Name = "Column3";
            // 
            // Form_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 435);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_CardNumber);
            this.Controls.Add(this.lableTotal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgv_Payment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNumb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Bank);
            this.Controls.Add(this.cbx_PaymentType);
            this.Controls.Add(this.cbx_OrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_Cash);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Payment";
            this.Text = "Form_Payment";
            this.Load += new System.EventHandler(this.Form_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_OrderID;
        private System.Windows.Forms.ComboBox cbx_PaymentType;
        private System.Windows.Forms.ComboBox cbx_Bank;
        private System.Windows.Forms.TextBox txt_CardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Payment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lableTotal;
        private System.Windows.Forms.TextBox txt_Cash;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}