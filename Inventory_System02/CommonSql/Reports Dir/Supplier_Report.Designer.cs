
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_Report));
            this.chk_Select_All = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Personnel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtg_PreviewPage = new System.Windows.Forms.DataGridView();
            this.cbo_date = new System.Windows.Forms.ComboBox();
            this.grp_filters = new System.Windows.Forms.GroupBox();
            this.chk_entry_date = new System.Windows.Forms.CheckBox();
            this.chk_Phone = new System.Windows.Forms.CheckBox();
            this.chk_Address = new System.Windows.Forms.CheckBox();
            this.chk_Province = new System.Windows.Forms.CheckBox();
            this.chk_City = new System.Windows.Forms.CheckBox();
            this.chk_Street = new System.Windows.Forms.CheckBox();
            this.chk_Email = new System.Windows.Forms.CheckBox();
            this.chk_Supplier_Name = new System.Windows.Forms.CheckBox();
            this.chk_Supplier_ID = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rep_date = new System.Windows.Forms.TextBox();
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
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbl_Personnel);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtg_PreviewPage);
            this.tabPage1.Controls.Add(this.cbo_date);
            this.tabPage1.Controls.Add(this.grp_filters);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_rep_date);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filter Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(523, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Date Within";
            // 
            // lbl_Personnel
            // 
            this.lbl_Personnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Personnel.AutoSize = true;
            this.lbl_Personnel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Personnel.Location = new System.Drawing.Point(133, 198);
            this.lbl_Personnel.Name = "lbl_Personnel";
            this.lbl_Personnel.Size = new System.Drawing.Size(0, 21);
            this.lbl_Personnel.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 198);
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
            this.dtg_PreviewPage.Size = new System.Drawing.Size(733, 149);
            this.dtg_PreviewPage.TabIndex = 22;
            // 
            // cbo_date
            // 
            this.cbo_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbo_date.FormattingEnabled = true;
            this.cbo_date.Items.AddRange(new object[] {
            "All Dates",
            "Today",
            "1 Week",
            "2 Weeks"});
            this.cbo_date.Location = new System.Drawing.Point(607, 6);
            this.cbo_date.Name = "cbo_date";
            this.cbo_date.Size = new System.Drawing.Size(136, 25);
            this.cbo_date.TabIndex = 21;
            this.cbo_date.Text = "All Dates";
            this.cbo_date.SelectedIndexChanged += new System.EventHandler(this.cbo_date_SelectedIndexChanged);
            // 
            // grp_filters
            // 
            this.grp_filters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_filters.Controls.Add(this.chk_entry_date);
            this.grp_filters.Controls.Add(this.chk_Phone);
            this.grp_filters.Controls.Add(this.chk_Address);
            this.grp_filters.Controls.Add(this.chk_Province);
            this.grp_filters.Controls.Add(this.chk_City);
            this.grp_filters.Controls.Add(this.chk_Street);
            this.grp_filters.Controls.Add(this.chk_Email);
            this.grp_filters.Controls.Add(this.chk_Supplier_Name);
            this.grp_filters.Controls.Add(this.chk_Supplier_ID);
            this.grp_filters.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_filters.Location = new System.Drawing.Point(248, 191);
            this.grp_filters.Name = "grp_filters";
            this.grp_filters.Size = new System.Drawing.Size(495, 89);
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
            this.chk_Address.Location = new System.Drawing.Point(412, 51);
            this.chk_Address.Name = "chk_Address";
            this.chk_Address.Size = new System.Drawing.Size(68, 19);
            this.chk_Address.TabIndex = 20;
            this.chk_Address.Text = "Address";
            this.chk_Address.UseVisualStyleBackColor = true;
            // 
            // chk_Province
            // 
            this.chk_Province.AutoSize = true;
            this.chk_Province.Location = new System.Drawing.Point(412, 24);
            this.chk_Province.Name = "chk_Province";
            this.chk_Province.Size = new System.Drawing.Size(72, 19);
            this.chk_Province.TabIndex = 19;
            this.chk_Province.Text = "Province";
            this.chk_Province.UseVisualStyleBackColor = true;
            // 
            // chk_City
            // 
            this.chk_City.AutoSize = true;
            this.chk_City.Location = new System.Drawing.Point(326, 51);
            this.chk_City.Name = "chk_City";
            this.chk_City.Size = new System.Drawing.Size(46, 19);
            this.chk_City.TabIndex = 18;
            this.chk_City.Text = "City";
            this.chk_City.UseVisualStyleBackColor = true;
            // 
            // chk_Street
            // 
            this.chk_Street.AutoSize = true;
            this.chk_Street.Location = new System.Drawing.Point(326, 24);
            this.chk_Street.Name = "chk_Street";
            this.chk_Street.Size = new System.Drawing.Size(57, 19);
            this.chk_Street.TabIndex = 17;
            this.chk_Street.Text = "Street";
            this.chk_Street.UseVisualStyleBackColor = true;
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
            this.chk_Supplier_ID.CheckedChanged += new System.EventHandler(this.chk_Supplier_ID_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Report Date";
            // 
            // txt_rep_date
            // 
            this.txt_rep_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_rep_date.Location = new System.Drawing.Point(94, 6);
            this.txt_rep_date.Name = "txt_rep_date";
            this.txt_rep_date.Size = new System.Drawing.Size(119, 25);
            this.txt_rep_date.TabIndex = 2;
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
            this.btn_Print_Preview.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Print_Preview.Location = new System.Drawing.Point(514, 359);
            this.btn_Print_Preview.Name = "btn_Print_Preview";
            this.btn_Print_Preview.Size = new System.Drawing.Size(116, 23);
            this.btn_Print_Preview.TabIndex = 44;
            this.btn_Print_Preview.Text = "Print Preview";
            this.btn_Print_Preview.UseVisualStyleBackColor = true;
            this.btn_Print_Preview.Click += new System.EventHandler(this.btn_Print_Preview_Click);
            // 
            // btn_Batch
            // 
            this.btn_Batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Batch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Batch.Location = new System.Drawing.Point(636, 359);
            this.btn_Batch.Name = "btn_Batch";
            this.btn_Batch.Size = new System.Drawing.Size(116, 23);
            this.btn_Batch.TabIndex = 43;
            this.btn_Batch.Text = "Batch";
            this.btn_Batch.UseVisualStyleBackColor = true;
            this.btn_Batch.Click += new System.EventHandler(this.btn_Batch_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Print.Location = new System.Drawing.Point(392, 359);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(116, 23);
            this.btn_Print.TabIndex = 55;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ComboBox cbo_date;
        private System.Windows.Forms.GroupBox grp_filters;
        private System.Windows.Forms.CheckBox chk_Phone;
        private System.Windows.Forms.CheckBox chk_City;
        private System.Windows.Forms.CheckBox chk_Street;
        private System.Windows.Forms.CheckBox chk_Email;
        private System.Windows.Forms.CheckBox chk_Supplier_Name;
        private System.Windows.Forms.CheckBox chk_Supplier_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rep_date;
        private System.Windows.Forms.CheckBox chk_Unselect;
        private System.Windows.Forms.Button btn_Print_Preview;
        private System.Windows.Forms.Button btn_Batch;
        public System.Windows.Forms.DataGridView dtg_PreviewPage;
        private System.Windows.Forms.Label lbl_Personnel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_Address;
        private System.Windows.Forms.CheckBox chk_Province;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.CheckBox chk_entry_date;
        private System.Windows.Forms.Label label1;
    }
}