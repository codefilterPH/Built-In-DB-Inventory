
namespace Inventory_System02.Reports_Dir
{
    partial class Employee_Report
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Report));
            this.chk_Select_All = new System.Windows.Forms.CheckBox();
            this.chk_Unselect = new System.Windows.Forms.CheckBox();
            this.btn_Print_Preview = new System.Windows.Forms.Button();
            this.btn_Batch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Personnel = new System.Windows.Forms.Label();
            this.dtg_PreviewPage = new System.Windows.Forms.DataGridView();
            this.cbo_date = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grp_filters = new System.Windows.Forms.GroupBox();
            this.chk_HiredDate = new System.Windows.Forms.CheckBox();
            this.chk_JobRole = new System.Windows.Forms.CheckBox();
            this.chk_Address = new System.Windows.Forms.CheckBox();
            this.chk_Phone = new System.Windows.Forms.CheckBox();
            this.chk_Email = new System.Windows.Forms.CheckBox();
            this.chk_LN = new System.Windows.Forms.CheckBox();
            this.chk_FN = new System.Windows.Forms.CheckBox();
            this.chk_Emp_ID = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rep_date = new System.Windows.Forms.TextBox();
            this.jobRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Print = new System.Windows.Forms.Button();
            this.classEmployeeVarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PreviewPage)).BeginInit();
            this.grp_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classEmployeeVarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_Select_All
            // 
            this.chk_Select_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Select_All.AutoSize = true;
            this.chk_Select_All.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_Select_All.Location = new System.Drawing.Point(14, 349);
            this.chk_Select_All.Name = "chk_Select_All";
            this.chk_Select_All.Size = new System.Drawing.Size(81, 21);
            this.chk_Select_All.TabIndex = 51;
            this.chk_Select_All.Text = "Select All";
            this.chk_Select_All.UseVisualStyleBackColor = true;
            this.chk_Select_All.CheckedChanged += new System.EventHandler(this.chk_Select_All_CheckedChanged);
            // 
            // chk_Unselect
            // 
            this.chk_Unselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Unselect.AutoSize = true;
            this.chk_Unselect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_Unselect.Location = new System.Drawing.Point(104, 349);
            this.chk_Unselect.Name = "chk_Unselect";
            this.chk_Unselect.Size = new System.Drawing.Size(97, 21);
            this.chk_Unselect.TabIndex = 52;
            this.chk_Unselect.Text = "Unselect All";
            this.chk_Unselect.UseVisualStyleBackColor = true;
            this.chk_Unselect.CheckedChanged += new System.EventHandler(this.chk_Unselect_CheckedChanged);
            // 
            // btn_Print_Preview
            // 
            this.btn_Print_Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print_Preview.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Print_Preview.Location = new System.Drawing.Point(508, 347);
            this.btn_Print_Preview.Name = "btn_Print_Preview";
            this.btn_Print_Preview.Size = new System.Drawing.Size(116, 23);
            this.btn_Print_Preview.TabIndex = 50;
            this.btn_Print_Preview.Text = "Print Preview";
            this.btn_Print_Preview.UseVisualStyleBackColor = true;
            this.btn_Print_Preview.Click += new System.EventHandler(this.btn_Print_Preview_Click);
            // 
            // btn_Batch
            // 
            this.btn_Batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Batch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Batch.Location = new System.Drawing.Point(630, 347);
            this.btn_Batch.Name = "btn_Batch";
            this.btn_Batch.Size = new System.Drawing.Size(116, 23);
            this.btn_Batch.TabIndex = 49;
            this.btn_Batch.Text = "Batch";
            this.btn_Batch.UseVisualStyleBackColor = true;
            this.btn_Batch.Click += new System.EventHandler(this.btn_Batch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-4, -1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 344);
            this.tabControl1.TabIndex = 47;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_Personnel);
            this.tabPage1.Controls.Add(this.dtg_PreviewPage);
            this.tabPage1.Controls.Add(this.cbo_date);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.grp_filters);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_rep_date);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filter Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_Personnel
            // 
            this.lbl_Personnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Personnel.AutoSize = true;
            this.lbl_Personnel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Personnel.Location = new System.Drawing.Point(705, 219);
            this.lbl_Personnel.Name = "lbl_Personnel";
            this.lbl_Personnel.Size = new System.Drawing.Size(0, 15);
            this.lbl_Personnel.TabIndex = 24;
            // 
            // dtg_PreviewPage
            // 
            this.dtg_PreviewPage.AllowUserToAddRows = false;
            this.dtg_PreviewPage.AllowUserToDeleteRows = false;
            this.dtg_PreviewPage.AllowUserToOrderColumns = true;
            this.dtg_PreviewPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_PreviewPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_PreviewPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_PreviewPage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_PreviewPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_PreviewPage.Location = new System.Drawing.Point(9, 37);
            this.dtg_PreviewPage.Name = "dtg_PreviewPage";
            this.dtg_PreviewPage.ReadOnly = true;
            this.dtg_PreviewPage.Size = new System.Drawing.Size(737, 171);
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
            this.cbo_date.Location = new System.Drawing.Point(626, 6);
            this.cbo_date.Name = "cbo_date";
            this.cbo_date.Size = new System.Drawing.Size(120, 25);
            this.cbo_date.TabIndex = 21;
            this.cbo_date.Text = "All Dates";
            this.cbo_date.SelectedIndexChanged += new System.EventHandler(this.cbo_date_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(609, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total Personnel:";
            // 
            // grp_filters
            // 
            this.grp_filters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grp_filters.Controls.Add(this.chk_HiredDate);
            this.grp_filters.Controls.Add(this.chk_JobRole);
            this.grp_filters.Controls.Add(this.chk_Address);
            this.grp_filters.Controls.Add(this.chk_Phone);
            this.grp_filters.Controls.Add(this.chk_Email);
            this.grp_filters.Controls.Add(this.chk_LN);
            this.grp_filters.Controls.Add(this.chk_FN);
            this.grp_filters.Controls.Add(this.chk_Emp_ID);
            this.grp_filters.Location = new System.Drawing.Point(6, 214);
            this.grp_filters.Name = "grp_filters";
            this.grp_filters.Size = new System.Drawing.Size(596, 82);
            this.grp_filters.TabIndex = 20;
            this.grp_filters.TabStop = false;
            this.grp_filters.Text = "Data Fields";
            // 
            // chk_HiredDate
            // 
            this.chk_HiredDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_HiredDate.AutoSize = true;
            this.chk_HiredDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HiredDate.Location = new System.Drawing.Point(11, 49);
            this.chk_HiredDate.Name = "chk_HiredDate";
            this.chk_HiredDate.Size = new System.Drawing.Size(83, 19);
            this.chk_HiredDate.TabIndex = 31;
            this.chk_HiredDate.Text = "Hired Date";
            this.chk_HiredDate.UseVisualStyleBackColor = true;
            // 
            // chk_JobRole
            // 
            this.chk_JobRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_JobRole.AutoSize = true;
            this.chk_JobRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_JobRole.Location = new System.Drawing.Point(392, 49);
            this.chk_JobRole.Name = "chk_JobRole";
            this.chk_JobRole.Size = new System.Drawing.Size(71, 19);
            this.chk_JobRole.TabIndex = 30;
            this.chk_JobRole.Text = "Job Role";
            this.chk_JobRole.UseVisualStyleBackColor = true;
            // 
            // chk_Address
            // 
            this.chk_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Address.AutoSize = true;
            this.chk_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Address.Location = new System.Drawing.Point(392, 22);
            this.chk_Address.Name = "chk_Address";
            this.chk_Address.Size = new System.Drawing.Size(68, 19);
            this.chk_Address.TabIndex = 29;
            this.chk_Address.Text = "Address";
            this.chk_Address.UseVisualStyleBackColor = true;
            // 
            // chk_Phone
            // 
            this.chk_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Phone.AutoSize = true;
            this.chk_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Phone.Location = new System.Drawing.Point(270, 49);
            this.chk_Phone.Name = "chk_Phone";
            this.chk_Phone.Size = new System.Drawing.Size(107, 19);
            this.chk_Phone.TabIndex = 27;
            this.chk_Phone.Text = "Phone Number";
            this.chk_Phone.UseVisualStyleBackColor = true;
            // 
            // chk_Email
            // 
            this.chk_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Email.AutoSize = true;
            this.chk_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Email.Location = new System.Drawing.Point(270, 22);
            this.chk_Email.Name = "chk_Email";
            this.chk_Email.Size = new System.Drawing.Size(55, 19);
            this.chk_Email.TabIndex = 15;
            this.chk_Email.Text = "Email";
            this.chk_Email.UseVisualStyleBackColor = true;
            // 
            // chk_LN
            // 
            this.chk_LN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_LN.AutoSize = true;
            this.chk_LN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_LN.Location = new System.Drawing.Point(143, 22);
            this.chk_LN.Name = "chk_LN";
            this.chk_LN.Size = new System.Drawing.Size(82, 19);
            this.chk_LN.TabIndex = 14;
            this.chk_LN.Text = "Last Name";
            this.chk_LN.UseVisualStyleBackColor = true;
            // 
            // chk_FN
            // 
            this.chk_FN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_FN.AutoSize = true;
            this.chk_FN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_FN.Location = new System.Drawing.Point(143, 49);
            this.chk_FN.Name = "chk_FN";
            this.chk_FN.Size = new System.Drawing.Size(83, 19);
            this.chk_FN.TabIndex = 13;
            this.chk_FN.Text = "First Name";
            this.chk_FN.UseVisualStyleBackColor = true;
            // 
            // chk_Emp_ID
            // 
            this.chk_Emp_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Emp_ID.AutoSize = true;
            this.chk_Emp_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Emp_ID.Location = new System.Drawing.Point(11, 22);
            this.chk_Emp_ID.Name = "chk_Emp_ID";
            this.chk_Emp_ID.Size = new System.Drawing.Size(94, 19);
            this.chk_Emp_ID.TabIndex = 12;
            this.chk_Emp_ID.Text = "Employee ID";
            this.chk_Emp_ID.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Report Date";
            // 
            // txt_rep_date
            // 
            this.txt_rep_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_rep_date.Location = new System.Drawing.Point(93, 6);
            this.txt_rep_date.Name = "txt_rep_date";
            this.txt_rep_date.Size = new System.Drawing.Size(119, 25);
            this.txt_rep_date.TabIndex = 2;
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Print.Location = new System.Drawing.Point(386, 347);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(116, 23);
            this.btn_Print.TabIndex = 53;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // classEmployeeVarBindingSource
            // 
            this.classEmployeeVarBindingSource.DataSource = typeof(Inventory_System02.Reports_Dir.Class_Employee_Var);
            // 
            // Employee_Report
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 382);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.chk_Select_All);
            this.Controls.Add(this.chk_Unselect);
            this.Controls.Add(this.btn_Print_Preview);
            this.Controls.Add(this.btn_Batch);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_Report";
            this.Text = "Employee_Report";
            this.Load += new System.EventHandler(this.Employee_Report_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PreviewPage)).EndInit();
            this.grp_filters.ResumeLayout(false);
            this.grp_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classEmployeeVarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Select_All;
        private System.Windows.Forms.CheckBox chk_Unselect;
        private System.Windows.Forms.Button btn_Print_Preview;
        private System.Windows.Forms.Button btn_Batch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grp_filters;
        private System.Windows.Forms.CheckBox chk_Phone;
        private System.Windows.Forms.CheckBox chk_Email;
        private System.Windows.Forms.CheckBox chk_LN;
        private System.Windows.Forms.CheckBox chk_FN;
        private System.Windows.Forms.CheckBox chk_Emp_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rep_date;
        private System.Windows.Forms.CheckBox chk_HiredDate;
        private System.Windows.Forms.CheckBox chk_JobRole;
        private System.Windows.Forms.CheckBox chk_Address;
        private System.Windows.Forms.BindingSource classEmployeeVarBindingSource;
        private System.Windows.Forms.BindingSource jobRolesBindingSource;
        private System.Windows.Forms.ComboBox cbo_date;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label lbl_Personnel;
        public System.Windows.Forms.DataGridView dtg_PreviewPage;
        private System.Windows.Forms.Label label7;
    }
}