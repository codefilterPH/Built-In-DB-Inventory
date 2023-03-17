namespace Inventory_System02.Outbound
{
    partial class OutEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutEditForm));
            this.dtg_outlist = new System.Windows.Forms.DataGridView();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_paid = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_reference = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_outlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_outlist
            // 
            this.dtg_outlist.AllowUserToAddRows = false;
            this.dtg_outlist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtg_outlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_outlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_outlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_outlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_outlist.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_outlist.Location = new System.Drawing.Point(8, 5);
            this.dtg_outlist.Name = "dtg_outlist";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_outlist.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_outlist.RowTemplate.Height = 20;
            this.dtg_outlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_outlist.Size = new System.Drawing.Size(433, 243);
            this.dtg_outlist.TabIndex = 122;
            // 
            // txt_remarks
            // 
            this.txt_remarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_remarks.Location = new System.Drawing.Point(8, 334);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remarks.Size = new System.Drawing.Size(433, 45);
            this.txt_remarks.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 124;
            this.label1.Text = "Remarks";
            // 
            // chk_paid
            // 
            this.chk_paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_paid.AutoSize = true;
            this.chk_paid.Checked = true;
            this.chk_paid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_paid.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_paid.Location = new System.Drawing.Point(349, 311);
            this.chk_paid.Name = "chk_paid";
            this.chk_paid.Size = new System.Drawing.Size(92, 17);
            this.chk_paid.TabIndex = 125;
            this.chk_paid.Text = "Mark as paid";
            this.chk_paid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_paid.UseVisualStyleBackColor = true;
            this.chk_paid.CheckedChanged += new System.EventHandler(this.chk_paid_CheckedChanged);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_save.Location = new System.Drawing.Point(126, 400);
            this.btn_save.MaximumSize = new System.Drawing.Size(94, 23);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 23);
            this.btn_save.TabIndex = 126;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.Peru;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(226, 400);
            this.btn_cancel.MaximumSize = new System.Drawing.Size(94, 23);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 23);
            this.btn_cancel.TabIndex = 127;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 128;
            this.label2.Text = "REF:";
            // 
            // lbl_reference
            // 
            this.lbl_reference.AutoSize = true;
            this.lbl_reference.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reference.Location = new System.Drawing.Point(49, 251);
            this.lbl_reference.Name = "lbl_reference";
            this.lbl_reference.Size = new System.Drawing.Size(66, 25);
            this.lbl_reference.TabIndex = 129;
            this.lbl_reference.Text = "NONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 130;
            this.label3.Text = "STATUS: ";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(73, 288);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 21);
            this.lbl_status.TabIndex = 131;
            // 
            // OutEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_reference);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.chk_paid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_remarks);
            this.Controls.Add(this.dtg_outlist);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(497, 489);
            this.Name = "OutEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Form";
            this.Load += new System.EventHandler(this.OutEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_outlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_outlist;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_paid;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_reference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_status;
    }
}