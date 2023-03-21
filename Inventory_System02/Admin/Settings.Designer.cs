
namespace Inventory_System02
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Def_text = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.dtg_settings = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Clear_Text = new System.Windows.Forms.Button();
            this.txt_company_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_company_name = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Company_Logo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num_SL_Detection = new System.Windows.Forms.NumericUpDown();
            this.btn_SL_save = new System.Windows.Forms.Button();
            this.btn_Warranty = new System.Windows.Forms.Button();
            this.num_Warranty = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_edit_detection = new System.Windows.Forms.Button();
            this.btn_edit_warranty = new System.Windows.Forms.Button();
            this.btn_Address = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Com_Address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_settings)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Company_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SL_Detection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Warranty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Definition Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(54, 113);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(55, 25);
            this.txt_ID.TabIndex = 2;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Def_text
            // 
            this.txt_Def_text.Location = new System.Drawing.Point(115, 113);
            this.txt_Def_text.Name = "txt_Def_text";
            this.txt_Def_text.Size = new System.Drawing.Size(252, 25);
            this.txt_Def_text.TabIndex = 3;
            this.txt_Def_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Def_text_KeyDown);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add.Location = new System.Drawing.Point(373, 54);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(27, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbo_type
            // 
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Items.AddRange(new object[] {
            "Product Name",
            "Brand",
            "Customer Type",
            "Employee Role",
            "Customer Models"});
            this.cbo_type.Location = new System.Drawing.Point(54, 55);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(313, 25);
            this.cbo_type.TabIndex = 5;
            this.cbo_type.Text = "Product Name";
            this.cbo_type.SelectedIndexChanged += new System.EventHandler(this.cbo_type_SelectedIndexChanged);
            // 
            // dtg_settings
            // 
            this.dtg_settings.AllowUserToAddRows = false;
            this.dtg_settings.AllowUserToDeleteRows = false;
            this.dtg_settings.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtg_settings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_settings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_settings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_settings.Location = new System.Drawing.Point(54, 142);
            this.dtg_settings.Name = "dtg_settings";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_settings.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_settings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_settings.Size = new System.Drawing.Size(314, 124);
            this.dtg_settings.TabIndex = 6;
            this.dtg_settings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.Location = new System.Drawing.Point(373, 82);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(27, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Location = new System.Drawing.Point(373, 111);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(27, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Clear_Text
            // 
            this.btn_Clear_Text.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear_Text.BackgroundImage")));
            this.btn_Clear_Text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear_Text.Location = new System.Drawing.Point(373, 140);
            this.btn_Clear_Text.Name = "btn_Clear_Text";
            this.btn_Clear_Text.Size = new System.Drawing.Size(27, 23);
            this.btn_Clear_Text.TabIndex = 9;
            this.btn_Clear_Text.UseVisualStyleBackColor = true;
            this.btn_Clear_Text.Click += new System.EventHandler(this.btn_Clear_Text_Click);
            // 
            // txt_company_name
            // 
            this.txt_company_name.Enabled = false;
            this.txt_company_name.Location = new System.Drawing.Point(24, 32);
            this.txt_company_name.Name = "txt_company_name";
            this.txt_company_name.Size = new System.Drawing.Size(262, 25);
            this.txt_company_name.TabIndex = 10;
            this.txt_company_name.Leave += new System.EventHandler(this.txt_company_name_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(330, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Company Logo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Company Name";
            // 
            // btn_company_name
            // 
            this.btn_company_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_company_name.BackgroundImage")));
            this.btn_company_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_company_name.Location = new System.Drawing.Point(289, 32);
            this.btn_company_name.Name = "btn_company_name";
            this.btn_company_name.Size = new System.Drawing.Size(27, 23);
            this.btn_company_name.TabIndex = 14;
            this.btn_company_name.UseVisualStyleBackColor = true;
            this.btn_company_name.Click += new System.EventHandler(this.btn_company_name_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Upload.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.ForeColor = System.Drawing.Color.White;
            this.btn_Upload.Location = new System.Drawing.Point(326, 181);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(157, 23);
            this.btn_Upload.TabIndex = 16;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.txt_Def_text);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.dtg_settings);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_Clear_Text);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Location = new System.Drawing.Point(22, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 299);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definitions";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Company_Logo
            // 
            this.Company_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Company_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Company_Logo.Location = new System.Drawing.Point(326, 55);
            this.Company_Logo.Name = "Company_Logo";
            this.Company_Logo.Size = new System.Drawing.Size(157, 120);
            this.Company_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Company_Logo.TabIndex = 40;
            this.Company_Logo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Stock Low Detection";
            // 
            // num_SL_Detection
            // 
            this.num_SL_Detection.Enabled = false;
            this.num_SL_Detection.Location = new System.Drawing.Point(151, 152);
            this.num_SL_Detection.Name = "num_SL_Detection";
            this.num_SL_Detection.Size = new System.Drawing.Size(60, 25);
            this.num_SL_Detection.TabIndex = 44;
            this.num_SL_Detection.DoubleClick += new System.EventHandler(this.num_SL_Detection_DoubleClick);
            this.num_SL_Detection.Leave += new System.EventHandler(this.num_SL_Detection_Leave);
            // 
            // btn_SL_save
            // 
            this.btn_SL_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SL_save.BackgroundImage")));
            this.btn_SL_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SL_save.Location = new System.Drawing.Point(259, 152);
            this.btn_SL_save.Name = "btn_SL_save";
            this.btn_SL_save.Size = new System.Drawing.Size(27, 23);
            this.btn_SL_save.TabIndex = 45;
            this.btn_SL_save.UseVisualStyleBackColor = true;
            this.btn_SL_save.Click += new System.EventHandler(this.btn_SL_save_Click);
            // 
            // btn_Warranty
            // 
            this.btn_Warranty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Warranty.BackgroundImage")));
            this.btn_Warranty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Warranty.Location = new System.Drawing.Point(259, 181);
            this.btn_Warranty.Name = "btn_Warranty";
            this.btn_Warranty.Size = new System.Drawing.Size(27, 23);
            this.btn_Warranty.TabIndex = 48;
            this.btn_Warranty.UseVisualStyleBackColor = true;
            this.btn_Warranty.Click += new System.EventHandler(this.btn_Warranty_Click);
            // 
            // num_Warranty
            // 
            this.num_Warranty.Enabled = false;
            this.num_Warranty.Location = new System.Drawing.Point(151, 181);
            this.num_Warranty.Name = "num_Warranty";
            this.num_Warranty.Size = new System.Drawing.Size(60, 25);
            this.num_Warranty.TabIndex = 47;
            this.num_Warranty.DoubleClick += new System.EventHandler(this.num_Warranty_DoubleClick);
            this.num_Warranty.Leave += new System.EventHandler(this.num_Warranty_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Warranty";
            // 
            // btn_edit_detection
            // 
            this.btn_edit_detection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit_detection.BackgroundImage")));
            this.btn_edit_detection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit_detection.Location = new System.Drawing.Point(287, 151);
            this.btn_edit_detection.Name = "btn_edit_detection";
            this.btn_edit_detection.Size = new System.Drawing.Size(27, 23);
            this.btn_edit_detection.TabIndex = 49;
            this.btn_edit_detection.UseVisualStyleBackColor = true;
            this.btn_edit_detection.Click += new System.EventHandler(this.btn_edit_detection_Click);
            // 
            // btn_edit_warranty
            // 
            this.btn_edit_warranty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit_warranty.BackgroundImage")));
            this.btn_edit_warranty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit_warranty.Location = new System.Drawing.Point(287, 181);
            this.btn_edit_warranty.Name = "btn_edit_warranty";
            this.btn_edit_warranty.Size = new System.Drawing.Size(27, 23);
            this.btn_edit_warranty.TabIndex = 50;
            this.btn_edit_warranty.UseVisualStyleBackColor = true;
            this.btn_edit_warranty.Click += new System.EventHandler(this.btn_edit_warranty_Click);
            // 
            // btn_Address
            // 
            this.btn_Address.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Address.BackgroundImage")));
            this.btn_Address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Address.Location = new System.Drawing.Point(289, 83);
            this.btn_Address.Name = "btn_Address";
            this.btn_Address.Size = new System.Drawing.Size(27, 23);
            this.btn_Address.TabIndex = 53;
            this.btn_Address.UseVisualStyleBackColor = true;
            this.btn_Address.Click += new System.EventHandler(this.btn_Address_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Company Address";
            // 
            // txt_Com_Address
            // 
            this.txt_Com_Address.Enabled = false;
            this.txt_Com_Address.Location = new System.Drawing.Point(24, 83);
            this.txt_Com_Address.Multiline = true;
            this.txt_Com_Address.Name = "txt_Com_Address";
            this.txt_Com_Address.Size = new System.Drawing.Size(262, 63);
            this.txt_Com_Address.TabIndex = 51;
            this.txt_Com_Address.Leave += new System.EventHandler(this.txt_Com_Address_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Day(s)";
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 541);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Com_Address);
            this.Controls.Add(this.btn_edit_warranty);
            this.Controls.Add(this.btn_edit_detection);
            this.Controls.Add(this.btn_Warranty);
            this.Controls.Add(this.num_Warranty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_SL_save);
            this.Controls.Add(this.num_SL_Detection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Company_Logo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_company_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_company_name);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_settings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Company_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SL_Detection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Warranty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Def_text;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.DataGridView dtg_settings;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Clear_Text;
        private System.Windows.Forms.TextBox txt_company_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_company_name;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox Company_Logo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_SL_Detection;
        private System.Windows.Forms.Button btn_SL_save;
        private System.Windows.Forms.Button btn_Warranty;
        private System.Windows.Forms.NumericUpDown num_Warranty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_edit_detection;
        private System.Windows.Forms.Button btn_edit_warranty;
        private System.Windows.Forms.Button btn_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Com_Address;
        private System.Windows.Forms.Label label8;
    }
}