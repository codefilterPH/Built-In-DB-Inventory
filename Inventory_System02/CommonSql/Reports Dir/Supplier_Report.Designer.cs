
namespace Inventory_System02.Reports_Dir
{
    partial class Supplier_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_Report));
            this.chk_Select_All = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_date_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_date_to = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Personnel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtg_PreviewPage = new System.Windows.Forms.DataGridView();
            this.grp_filters = new System.Windows.Forms.GroupBox();
            this.chk_entry_date = new System.Windows.Forms.CheckBox();
            this.chk_Phone = new System.Windows.Forms.CheckBox();
            this.chk_Address = new System.Windows.Forms.CheckBox();
            this.chk_Email = new System.Windows.Forms.CheckBox();
            this.chk_Supplier_Name = new System.Windows.Forms.CheckBox();
            this.chk_Supplier_ID = new System.Windows.Forms.CheckBox();
            this.chk_Unselect = new System.Windows.Forms.CheckBox();
            this.btn_Print_Preview = new System.Windows.Forms.Button();
            this.btn_Batch = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PreviewPage)).BeginInit();
            this.grp_filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Select_All
            // 
            this.chk_Select_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Select_All.AutoSize = true;
            this.chk_Select_All.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_Select_All.Location = new System.Drawing.Point(16, 361);
            this.chk_Select_All.Name = "chk_Select_All";
            this.chk_Select_All.Size = new System.Drawing.Size(81, 21);
            this.chk_Select_All.TabIndex = 45;
            this.chk_Select_All.Text = "Select All";
            this.chk_Select_All.UseVisualStyleBackColor = true;
            this.chk_Select_All.CheckedChanged += new System.EventHandler(this.chk_Select_All_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(5, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 351);
            this.tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtp_date_from);
            this.tabPage1.Controls.Add(this.dtp_date_to);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbl_Personnel);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtg_PreviewPage);
            this.tabPage1.Controls.Add(this.grp_filters);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filter Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(217, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "to";
            // 
            // dtp_date_from
            // 
            this.dtp_date_from.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_from.CustomFormat = "yyyy-MM-dd";
            this.dtp_date_from.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_from.Location = new System.Drawing.Point(94, 8);
            this.dtp_date_from.Name = "dtp_date_from";
            this.dtp_date_from.Size = new System.Drawing.Size(117, 22);
            this.dtp_date_from.TabIndex = 41;
            this.dtp_date_from.ValueChanged += new System.EventHandler(this.dtp_date_from_ValueChanged);
            // 
            // dtp_date_to
            // 
            this.dtp_date_to.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_to.CustomFormat = "yyyy-MM-dd";
            this.dtp_date_to.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_to.Location = new System.Drawing.Point(240, 8);
            this.dtp_date_to.Name = "dtp_date_to";
            this.dtp_date_to.Size = new System.Drawing.Size(117, 22);
            this.dtp_date_to.TabIndex = 40;
            this.dtp_date_to.ValueChanged += new System.EventHandler(this.dtp_date_to_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Report Date";
            // 
            // lbl_Personnel
            // 
            this.lbl_Personnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Personnel.AutoSize = true;
            this.lbl_Personnel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Personnel.Location = new System.Drawing.Point(133, 206);
            this.lbl_Personnel.Name = "lbl_Personnel";
            this.lbl_Personnel.Size = new System.Drawing.Size(0, 21);
            this.lbl_Personnel.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total Supplier/s:";
            // 
            // dtg_PreviewPage
            // 
            this.dtg_PreviewPage.AllowUserToAddRows = false;
            this.dtg_PreviewPage.AllowUserToDeleteRows = false;
            this.dtg_PreviewPage.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_PreviewPage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_PreviewPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_PreviewPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_PreviewPage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_PreviewPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_PreviewPage.Location = new System.Drawing.Point(10, 37);
            this.dtg_PreviewPage.Name = "dtg_PreviewPage";
            this.dtg_PreviewPage.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_PreviewPage.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_PreviewPage.Size = new System.Drawing.Size(733, 156);
            this.dtg_PreviewPage.TabIndex = 22;
            // 
            // grp_filters
            // 
            this.grp_filters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_filters.Controls.Add(this.chk_entry_date);
            this.grp_filters.Controls.Add(this.chk_Phone);
            this.grp_filters.Controls.Add(this.chk_Address);
            this.grp_filters.Controls.Add(this.chk_Email);
            this.grp_filters.Controls.Add(this.chk_Supplier_Name);
            this.grp_filters.Controls.Add(this.chk_Supplier_ID);
            this.grp_filters.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_filters.Location = new System.Drawing.Point(415, 199);
            this.grp_filters.Name = "grp_filters";
            this.grp_filters.Size = new System.Drawing.Size(328, 89);
            this.grp_filters.TabIndex = 20;
            this.grp_filters.TabStop = false;
            this.grp_filters.Text = "Data Field";
            // 
            // chk_entry_date
            // 
            this.chk_entry_date.AutoSize = true;
            this.chk_entry_date.Location = new System.Drawing.Point(30, 24);
            this.chk_entry_date.Name = "chk_entry_date";
            this.chk_entry_date.Size = new System.Drawing.Size(81, 19);
            this.chk_entry_date.TabIndex = 24;
            this.chk_entry_date.Text = "Entry Date";
            this.chk_entry_date.UseVisualStyleBackColor = true;
            // 
            // chk_Phone
            // 
            this.chk_Phone.AutoSize = true;
            this.chk_Phone.Location = new System.Drawing.Point(241, 51);
            this.chk_Phone.Name = "chk_Phone";
            this.chk_Phone.Size = new System.Drawing.Size(60, 19);
            this.chk_Phone.TabIndex = 23;
            this.chk_Phone.Text = "Phone";
            this.chk_Phone.UseVisualStyleBackColor = true;
            // 
            // chk_Address
            // 
            this.chk_Address.AutoSize = true;
            this.chk_Address.Location = new System.Drawing.Point(30, 51);
            this.chk_Address.Name = "chk_Address";
            this.chk_Address.Size = new System.Drawing.Size(68, 19);
            this.chk_Address.TabIndex = 20;
            this.chk_Address.Text = "Address";
            this.chk_Address.UseVisualStyleBackColor = true;
            // 
            // chk_Email
            // 
            this.chk_Email.AutoSize = true;
            this.chk_Email.Location = new System.Drawing.Point(241, 24);
            this.chk_Email.Name = "chk_Email";
            this.chk_Email.Size = new System.Drawing.Size(55, 19);
            this.chk_Email.TabIndex = 16;
            this.chk_Email.Text = "Email";
            this.chk_Email.UseVisualStyleBackColor = true;
            // 
            // chk_Supplier_Name
            // 
            this.chk_Supplier_Name.AutoSize = true;
            this.chk_Supplier_Name.Location = new System.Drawing.Point(135, 51);
            this.chk_Supplier_Name.Name = "chk_Supplier_Name";
            this.chk_Supplier_Name.Size = new System.Drawing.Size(105, 19);
            this.chk_Supplier_Name.TabIndex = 13;
            this.chk_Supplier_Name.Text = "Supplier Name";
            this.chk_Supplier_Name.UseVisualStyleBackColor = true;
            // 
            // chk_Supplier_ID
            // 
            this.chk_Supplier_ID.AutoSize = true;
            this.chk_Supplier_ID.Location = new System.Drawing.Point(134, 24);
            this.chk_Supplier_ID.Name = "chk_Supplier_ID";
            this.chk_Supplier_ID.Size = new System.Drawing.Size(86, 19);
            this.chk_Supplier_ID.TabIndex = 12;
            this.chk_Supplier_ID.Text = "Supplier ID";
            this.chk_Supplier_ID.UseVisualStyleBackColor = true;
            // 
            // chk_Unselect
            // 
            this.chk_Unselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Unselect.AutoSize = true;
            this.chk_Unselect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_Unselect.Location = new System.Drawing.Point(106, 361);
            this.chk_Unselect.Name = "chk_Unselect";
            this.chk_Unselect.Size = new System.Drawing.Size(97, 21);
            this.chk_Unselect.TabIndex = 47;
            this.chk_Unselect.Text = "Unselect All";
            this.chk_Unselect.UseVisualStyleBackColor = true;
            this.chk_Unselect.CheckedChanged += new System.EventHandler(this.chk_Unselect_CheckedChanged);
            // 
            // btn_Print_Preview
            // 
            this.btn_Print_Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print_Preview.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Print_Preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print_Preview.ForeColor = System.Drawing.Color.White;
            this.btn_Print_Preview.Location = new System.Drawing.Point(514, 359);
            this.btn_Print_Preview.Name = "btn_Print_Preview";
            this.btn_Print_Preview.Size = new System.Drawing.Size(116, 23);
            this.btn_Print_Preview.TabIndex = 44;
            this.btn_Print_Preview.Text = "Print Preview";
            this.btn_Print_Preview.UseVisualStyleBackColor = false;
            this.btn_Print_Preview.Click += new System.EventHandler(this.btn_Print_Preview_Click);
            // 
            // btn_Batch
            // 
            this.btn_Batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Batch.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Batch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Batch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Batch.ForeColor = System.Drawing.Color.White;
            this.btn_Batch.Location = new System.Drawing.Point(636, 359);
            this.btn_Batch.Name = "btn_Batch";
            this.btn_Batch.Size = new System.Drawing.Size(116, 23);
            this.btn_Batch.TabIndex = 43;
            this.btn_Batch.Text = "Batch";
            this.btn_Batch.UseVisualStyleBackColor = false;
            this.btn_Batch.Click += new System.EventHandler(this.btn_Batch_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.BackColor = System.Drawing.Color.Peru;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(392, 359);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(116, 23);
            this.btn_Print.TabIndex = 55;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // Supplier_Report
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 394);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.chk_Select_All);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chk_Unselect);
            this.Controls.Add(this.btn_Print_Preview);
            this.Controls.Add(this.btn_Batch);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Supplier_Report";
            this.Text = "Supplier Report";
            this.Load += new System.EventHandler(this.Supplier_Report_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PreviewPage)).EndInit();
            this.grp_filters.ResumeLayout(false);
            this.grp_filters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Select_All;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grp_filters;
        private System.Windows.Forms.CheckBox chk_Phone;
        private System.Windows.Forms.CheckBox chk_Email;
        private System.Windows.Forms.CheckBox chk_Supplier_Name;
        private System.Windows.Forms.CheckBox chk_Supplier_ID;
        private System.Windows.Forms.CheckBox chk_Unselect;
        private System.Windows.Forms.Button btn_Print_Preview;
        private System.Windows.Forms.Button btn_Batch;
        public System.Windows.Forms.DataGridView dtg_PreviewPage;
        private System.Windows.Forms.Label lbl_Personnel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_Address;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.CheckBox chk_entry_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_date_from;
        private System.Windows.Forms.DateTimePicker dtp_date_to;
        private System.Windows.Forms.Label label2;
    }
}