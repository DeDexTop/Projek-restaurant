namespace WindowsFormsApp7
{
    partial class Form_Admin
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
            this.btnMngEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMngMember = new System.Windows.Forms.Button();
            this.btnMngMenu = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMngEmployee
            // 
            this.btnMngEmployee.Location = new System.Drawing.Point(198, 386);
            this.btnMngEmployee.Name = "btnMngEmployee";
            this.btnMngEmployee.Size = new System.Drawing.Size(180, 36);
            this.btnMngEmployee.TabIndex = 15;
            this.btnMngEmployee.Text = "Manage Employee";
            this.btnMngEmployee.UseVisualStyleBackColor = true;
            this.btnMngEmployee.Click += new System.EventHandler(this.btnMngEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Welcome";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(198, 440);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 36);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMngMember
            // 
            this.btnMngMember.Location = new System.Drawing.Point(198, 332);
            this.btnMngMember.Name = "btnMngMember";
            this.btnMngMember.Size = new System.Drawing.Size(180, 36);
            this.btnMngMember.TabIndex = 12;
            this.btnMngMember.Text = "Manage Member";
            this.btnMngMember.UseVisualStyleBackColor = true;
            this.btnMngMember.Click += new System.EventHandler(this.btnMngMember_Click);
            // 
            // btnMngMenu
            // 
            this.btnMngMenu.Location = new System.Drawing.Point(198, 273);
            this.btnMngMenu.Name = "btnMngMenu";
            this.btnMngMenu.Size = new System.Drawing.Size(180, 36);
            this.btnMngMenu.TabIndex = 11;
            this.btnMngMenu.Text = "Manage Menu";
            this.btnMngMenu.UseVisualStyleBackColor = true;
            this.btnMngMenu.Click += new System.EventHandler(this.btnMngMenu_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(198, 214);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(180, 36);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Admin Navigation";
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 525);
            this.Controls.Add(this.btnMngEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMngMember);
            this.Controls.Add(this.btnMngMenu);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label1);
            this.Name = "Form_Admin";
            this.Text = "Form_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMngEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMngMember;
        private System.Windows.Forms.Button btnMngMenu;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label1;
    }
}