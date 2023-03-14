
namespace Inventory_System02.Admin
{
    partial class Verify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verify));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_activation_key = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_validate = new System.Windows.Forms.Button();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Unlock = new System.Windows.Forms.Button();
            this.cbo_extend_type = new System.Windows.Forms.ComboBox();
            this.dtp_date_extend = new System.Windows.Forms.DateTimePicker();
            this.lbl_exp_date = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your license is expired!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_activation_key
            // 
            this.lbl_activation_key.AutoSize = true;
            this.lbl_activation_key.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activation_key.Location = new System.Drawing.Point(133, 194);
            this.lbl_activation_key.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_activation_key.Name = "lbl_activation_key";
            this.lbl_activation_key.Size = new System.Drawing.Size(95, 17);
            this.lbl_activation_key.TabIndex = 2;
            this.lbl_activation_key.Text = "Activation Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // btn_validate
            // 
            this.btn_validate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_validate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_validate.Enabled = false;
            this.btn_validate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_validate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validate.ForeColor = System.Drawing.Color.White;
            this.btn_validate.Location = new System.Drawing.Point(148, 219);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(65, 30);
            this.btn_validate.TabIndex = 5;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = false;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(48, 160);
            this.txt_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(262, 29);
            this.txt_1.TabIndex = 0;
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_1.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Admin ID:";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(123, 276);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(158, 25);
            this.txt_Username.TabIndex = 6;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            this.txt_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Username_KeyDown);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(123, 315);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(158, 25);
            this.txt_Password.TabIndex = 7;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // btn_Unlock
            // 
            this.btn_Unlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Unlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Unlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Unlock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Unlock.ForeColor = System.Drawing.Color.White;
            this.btn_Unlock.Location = new System.Drawing.Point(148, 348);
            this.btn_Unlock.Name = "btn_Unlock";
            this.btn_Unlock.Size = new System.Drawing.Size(65, 30);
            this.btn_Unlock.TabIndex = 8;
            this.btn_Unlock.Text = "Unlock";
            this.btn_Unlock.UseVisualStyleBackColor = false;
            this.btn_Unlock.Click += new System.EventHandler(this.btn_Unlock_Click);
            // 
            // cbo_extend_type
            // 
            this.cbo_extend_type.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_extend_type.FormattingEnabled = true;
            this.cbo_extend_type.Items.AddRange(new object[] {
            "Trial",
            "Full"});
            this.cbo_extend_type.Location = new System.Drawing.Point(246, 85);
            this.cbo_extend_type.Name = "cbo_extend_type";
            this.cbo_extend_type.Size = new System.Drawing.Size(64, 25);
            this.cbo_extend_type.TabIndex = 11;
            this.cbo_extend_type.Text = "Trial";
            this.cbo_extend_type.SelectedIndexChanged += new System.EventHandler(this.cbo_extend_type_SelectedIndexChanged);
            // 
            // dtp_date_extend
            // 
            this.dtp_date_extend.CustomFormat = "yyyy-MM-dd";
            this.dtp_date_extend.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_extend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_extend.Location = new System.Drawing.Point(198, 120);
            this.dtp_date_extend.Name = "dtp_date_extend";
            this.dtp_date_extend.Size = new System.Drawing.Size(112, 25);
            this.dtp_date_extend.TabIndex = 12;
            // 
            // lbl_exp_date
            // 
            this.lbl_exp_date.AutoSize = true;
            this.lbl_exp_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exp_date.Location = new System.Drawing.Point(46, 126);
            this.lbl_exp_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_exp_date.Name = "lbl_exp_date";
            this.lbl_exp_date.Size = new System.Drawing.Size(101, 17);
            this.lbl_exp_date.TabIndex = 13;
            this.lbl_exp_date.Text = "Expiration Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "License Type";
            // 
            // Verify
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 434);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_exp_date);
            this.Controls.Add(this.dtp_date_extend);
            this.Controls.Add(this.cbo_extend_type);
            this.Controls.Add(this.btn_Unlock);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_activation_key);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(367, 473);
            this.MinimumSize = new System.Drawing.Size(367, 473);
            this.Name = "Verify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Verify_FormClosed);
            this.Load += new System.EventHandler(this.Verify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_activation_key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Unlock;
        private System.Windows.Forms.ComboBox cbo_extend_type;
        private System.Windows.Forms.DateTimePicker dtp_date_extend;
        private System.Windows.Forms.Label lbl_exp_date;
        private System.Windows.Forms.Label label6;
    }
}