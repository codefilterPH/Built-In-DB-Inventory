
namespace Inventory_System02.CustSupplier
{
    partial class CustSupp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustSupp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cust_Phone = new System.Windows.Forms.TextBox();
            this.btn_cusid_select = new System.Windows.Forms.Button();
            this.lbl_total_cust = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtg_Customer = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.Cust_Image = new System.Windows.Forms.PictureBox();
            this.btn_Clear_Text = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cust_SAddress = new System.Windows.Forms.TextBox();
            this.btn_Gen_ID = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cust_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cust_FN = new System.Windows.Forms.TextBox();
            this.btn_Cust_Delete = new System.Windows.Forms.Button();
            this.btn_Cust_edit = new System.Windows.Forms.Button();
            this.btn_Cust_add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Upload_Cust = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_new_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_total_sup = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sup_Phone = new System.Windows.Forms.TextBox();
            this.btn_supid_select = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_Search_sup = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtg_Supplier = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.sup_Email = new System.Windows.Forms.TextBox();
            this.Sup_Image = new System.Windows.Forms.PictureBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_Upload_sup = new System.Windows.Forms.ToolStripMenuItem();
            this.supplier_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_new_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_GenerateID = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Sup_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sup_CName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sup_Address = new System.Windows.Forms.TextBox();
            this.btn_sup_delete = new System.Windows.Forms.Button();
            this.btn_sup_edit = new System.Windows.Forms.Button();
            this.btn_sup_add = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cust_Image)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Supplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sup_Image)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(861, 521);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cust_Phone);
            this.tabPage1.Controls.Add(this.btn_cusid_select);
            this.tabPage1.Controls.Add(this.lbl_total_cust);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txt_Search);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.cbo_type);
            this.tabPage1.Controls.Add(this.Cust_Image);
            this.tabPage1.Controls.Add(this.btn_Clear_Text);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.cust_SAddress);
            this.tabPage1.Controls.Add(this.btn_Gen_ID);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cust_ID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cust_FN);
            this.tabPage1.Controls.Add(this.btn_Cust_Delete);
            this.tabPage1.Controls.Add(this.btn_Cust_edit);
            this.tabPage1.Controls.Add(this.btn_Cust_add);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(853, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "Division Management Form";
            // 
            // cust_Phone
            // 
            this.cust_Phone.Location = new System.Drawing.Point(279, 101);
            this.cust_Phone.MaxLength = 23;
            this.cust_Phone.Name = "cust_Phone";
            this.cust_Phone.Size = new System.Drawing.Size(185, 25);
            this.cust_Phone.TabIndex = 7;
            this.cust_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cust_Phone_KeyPress);
            // 
            // btn_cusid_select
            // 
            this.btn_cusid_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cusid_select.BackColor = System.Drawing.Color.SlateGray;
            this.btn_cusid_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cusid_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cusid_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cusid_select.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusid_select.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cusid_select.Location = new System.Drawing.Point(733, 192);
            this.btn_cusid_select.Name = "btn_cusid_select";
            this.btn_cusid_select.Size = new System.Drawing.Size(111, 23);
            this.btn_cusid_select.TabIndex = 1;
            this.btn_cusid_select.Text = "Select";
            this.btn_cusid_select.UseVisualStyleBackColor = false;
            this.btn_cusid_select.Click += new System.EventHandler(this.btn_cusid_select_Click);
            // 
            // lbl_total_cust
            // 
            this.lbl_total_cust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_total_cust.AutoSize = true;
            this.lbl_total_cust.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_cust.Location = new System.Drawing.Point(197, 430);
            this.lbl_total_cust.Name = "lbl_total_cust";
            this.lbl_total_cust.Size = new System.Drawing.Size(18, 18);
            this.lbl_total_cust.TabIndex = 78;
            this.lbl_total_cust.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 430);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 18);
            this.label16.TabIndex = 77;
            this.label16.Text = "Total customer(s):";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtg_Customer);
            this.panel2.Location = new System.Drawing.Point(6, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 202);
            this.panel2.TabIndex = 76;
            // 
            // dtg_Customer
            // 
            this.dtg_Customer.AllowUserToAddRows = false;
            this.dtg_Customer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_Customer.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_Customer.Location = new System.Drawing.Point(0, 0);
            this.dtg_Customer.Name = "dtg_Customer";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Customer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Customer.RowTemplate.Height = 40;
            this.dtg_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Customer.Size = new System.Drawing.Size(839, 202);
            this.dtg_Customer.TabIndex = 0;
            this.dtg_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Customer_CellClick);
            this.dtg_Customer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Customer_CellContentDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 75;
            this.label15.Text = "Search";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(50, 189);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(137, 25);
            this.txt_Search.TabIndex = 14;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(484, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 73;
            this.label13.Text = "Type";
            // 
            // cbo_type
            // 
            this.cbo_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(551, 101);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(160, 25);
            this.cbo_type.TabIndex = 6;
            // 
            // Cust_Image
            // 
            this.Cust_Image.Location = new System.Drawing.Point(8, 61);
            this.Cust_Image.Name = "Cust_Image";
            this.Cust_Image.Size = new System.Drawing.Size(133, 120);
            this.Cust_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cust_Image.TabIndex = 71;
            this.Cust_Image.TabStop = false;
            this.Cust_Image.DoubleClick += new System.EventHandler(this.Cust_Image_DoubleClick);
            // 
            // btn_Clear_Text
            // 
            this.btn_Clear_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear_Text.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Clear_Text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear_Text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear_Text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear_Text.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clear_Text.Location = new System.Drawing.Point(733, 166);
            this.btn_Clear_Text.Name = "btn_Clear_Text";
            this.btn_Clear_Text.Size = new System.Drawing.Size(111, 23);
            this.btn_Clear_Text.TabIndex = 13;
            this.btn_Clear_Text.Text = "Clear Text";
            this.btn_Clear_Text.UseVisualStyleBackColor = false;
            this.btn_Clear_Text.Click += new System.EventHandler(this.btn_Clear_Text_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 66;
            this.label12.Text = "Shipping Address";
            // 
            // cust_SAddress
            // 
            this.cust_SAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cust_SAddress.Location = new System.Drawing.Point(279, 132);
            this.cust_SAddress.Multiline = true;
            this.cust_SAddress.Name = "cust_SAddress";
            this.cust_SAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cust_SAddress.Size = new System.Drawing.Size(432, 46);
            this.cust_SAddress.TabIndex = 8;
            // 
            // btn_Gen_ID
            // 
            this.btn_Gen_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Gen_ID.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Gen_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gen_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Gen_ID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gen_ID.ForeColor = System.Drawing.Color.White;
            this.btn_Gen_ID.Location = new System.Drawing.Point(733, 62);
            this.btn_Gen_ID.Name = "btn_Gen_ID";
            this.btn_Gen_ID.Size = new System.Drawing.Size(111, 23);
            this.btn_Gen_ID.TabIndex = 9;
            this.btn_Gen_ID.Text = "Generate ID";
            this.btn_Gen_ID.UseVisualStyleBackColor = false;
            this.btn_Gen_ID.Click += new System.EventHandler(this.btn_Gen_ID_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(484, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "Division ID";
            // 
            // cust_ID
            // 
            this.cust_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cust_ID.Location = new System.Drawing.Point(580, 69);
            this.cust_ID.Name = "cust_ID";
            this.cust_ID.Size = new System.Drawing.Size(131, 25);
            this.cust_ID.TabIndex = 3;
            this.cust_ID.TextChanged += new System.EventHandler(this.cust_ID_TextChanged);
            this.cust_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cust_ID_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name";
            // 
            // cust_FN
            // 
            this.cust_FN.Location = new System.Drawing.Point(279, 69);
            this.cust_FN.Name = "cust_FN";
            this.cust_FN.Size = new System.Drawing.Size(185, 25);
            this.cust_FN.TabIndex = 4;
            // 
            // btn_Cust_Delete
            // 
            this.btn_Cust_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cust_Delete.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Cust_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cust_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cust_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cust_Delete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cust_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cust_Delete.Location = new System.Drawing.Point(733, 140);
            this.btn_Cust_Delete.Name = "btn_Cust_Delete";
            this.btn_Cust_Delete.Size = new System.Drawing.Size(111, 23);
            this.btn_Cust_Delete.TabIndex = 12;
            this.btn_Cust_Delete.Text = "Delete Selected";
            this.btn_Cust_Delete.UseVisualStyleBackColor = false;
            this.btn_Cust_Delete.Click += new System.EventHandler(this.btn_Cust_Delete_Click);
            // 
            // btn_Cust_edit
            // 
            this.btn_Cust_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cust_edit.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Cust_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cust_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cust_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cust_edit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cust_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cust_edit.Location = new System.Drawing.Point(733, 114);
            this.btn_Cust_edit.Name = "btn_Cust_edit";
            this.btn_Cust_edit.Size = new System.Drawing.Size(111, 23);
            this.btn_Cust_edit.TabIndex = 11;
            this.btn_Cust_edit.Text = "Save Current";
            this.btn_Cust_edit.UseVisualStyleBackColor = false;
            this.btn_Cust_edit.Click += new System.EventHandler(this.btn_Cust_edit_Click);
            // 
            // btn_Cust_add
            // 
            this.btn_Cust_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cust_add.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Cust_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cust_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cust_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cust_add.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cust_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cust_add.Location = new System.Drawing.Point(733, 88);
            this.btn_Cust_add.Name = "btn_Cust_add";
            this.btn_Cust_add.Size = new System.Drawing.Size(111, 23);
            this.btn_Cust_add.TabIndex = 10;
            this.btn_Cust_add.Text = "Add to Record";
            this.btn_Cust_add.UseVisualStyleBackColor = false;
            this.btn_Cust_add.Click += new System.EventHandler(this.btn_Cust_add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Upload_Cust,
            this.refreshToolStripMenuItem,
            this.customerModelsToolStripMenuItem,
            this.btn_new_customer});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Upload_Cust
            // 
            this.btn_Upload_Cust.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Upload_Cust.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Upload_Cust.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload_Cust.ForeColor = System.Drawing.Color.White;
            this.btn_Upload_Cust.Image = ((System.Drawing.Image)(resources.GetObject("btn_Upload_Cust.Image")));
            this.btn_Upload_Cust.Name = "btn_Upload_Cust";
            this.btn_Upload_Cust.Size = new System.Drawing.Size(110, 20);
            this.btn_Upload_Cust.Text = "Upload Image";
            this.btn_Upload_Cust.Click += new System.EventHandler(this.btn_Upload_Cust_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.refreshToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // customerModelsToolStripMenuItem
            // 
            this.customerModelsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.customerModelsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerModelsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerModelsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerModelsToolStripMenuItem.Image")));
            this.customerModelsToolStripMenuItem.Name = "customerModelsToolStripMenuItem";
            this.customerModelsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.customerModelsToolStripMenuItem.Text = "Customer Models";
            this.customerModelsToolStripMenuItem.Click += new System.EventHandler(this.customerModelsToolStripMenuItem_Click);
            // 
            // btn_new_customer
            // 
            this.btn_new_customer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_new_customer.BackColor = System.Drawing.Color.Peru;
            this.btn_new_customer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_customer.ForeColor = System.Drawing.Color.White;
            this.btn_new_customer.Image = ((System.Drawing.Image)(resources.GetObject("btn_new_customer.Image")));
            this.btn_new_customer.Name = "btn_new_customer";
            this.btn_new_customer.Size = new System.Drawing.Size(105, 20);
            this.btn_new_customer.Text = "New Division";
            this.btn_new_customer.Click += new System.EventHandler(this.btn_new_customer_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lbl_total_sup);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.sup_Phone);
            this.tabPage2.Controls.Add(this.btn_supid_select);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txt_Search_sup);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.sup_Email);
            this.tabPage2.Controls.Add(this.Sup_Image);
            this.tabPage2.Controls.Add(this.btn_Clear);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Controls.Add(this.btn_GenerateID);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.Sup_ID);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.sup_CName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.sup_Address);
            this.tabPage2.Controls.Add(this.btn_sup_delete);
            this.tabPage2.Controls.Add(this.btn_sup_edit);
            this.tabPage2.Controls.Add(this.btn_sup_add);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(853, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supplier";
            // 
            // lbl_total_sup
            // 
            this.lbl_total_sup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_total_sup.AutoSize = true;
            this.lbl_total_sup.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_sup.Location = new System.Drawing.Point(197, 439);
            this.lbl_total_sup.Name = "lbl_total_sup";
            this.lbl_total_sup.Size = new System.Drawing.Size(18, 18);
            this.lbl_total_sup.TabIndex = 82;
            this.lbl_total_sup.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(575, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 25);
            this.label8.TabIndex = 83;
            this.label8.Text = "Supplier\'s Management Form";
            // 
            // sup_Phone
            // 
            this.sup_Phone.Location = new System.Drawing.Point(254, 99);
            this.sup_Phone.MaxLength = 23;
            this.sup_Phone.Name = "sup_Phone";
            this.sup_Phone.Size = new System.Drawing.Size(205, 25);
            this.sup_Phone.TabIndex = 5;
            this.sup_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sup_Phone_KeyPress);
            // 
            // btn_supid_select
            // 
            this.btn_supid_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supid_select.BackColor = System.Drawing.Color.SlateGray;
            this.btn_supid_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_supid_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_supid_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_supid_select.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supid_select.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_supid_select.Location = new System.Drawing.Point(713, 197);
            this.btn_supid_select.Name = "btn_supid_select";
            this.btn_supid_select.Size = new System.Drawing.Size(128, 23);
            this.btn_supid_select.TabIndex = 1;
            this.btn_supid_select.Text = "Select";
            this.btn_supid_select.UseVisualStyleBackColor = false;
            this.btn_supid_select.Click += new System.EventHandler(this.btn_supid_select_Click);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 438);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(188, 18);
            this.label18.TabIndex = 81;
            this.label18.Text = "Total Supplier(s):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 80;
            this.label19.Text = "Search";
            // 
            // txt_Search_sup
            // 
            this.txt_Search_sup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search_sup.Location = new System.Drawing.Point(55, 196);
            this.txt_Search_sup.Name = "txt_Search_sup";
            this.txt_Search_sup.Size = new System.Drawing.Size(141, 22);
            this.txt_Search_sup.TabIndex = 13;
            this.txt_Search_sup.TextChanged += new System.EventHandler(this.txt_Search_sup_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.dtg_Supplier);
            this.panel1.Location = new System.Drawing.Point(11, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 202);
            this.panel1.TabIndex = 73;
            // 
            // dtg_Supplier
            // 
            this.dtg_Supplier.AllowUserToAddRows = false;
            this.dtg_Supplier.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_Supplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Supplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Supplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_Supplier.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_Supplier.Location = new System.Drawing.Point(0, 0);
            this.dtg_Supplier.Name = "dtg_Supplier";
            this.dtg_Supplier.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Supplier.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_Supplier.RowTemplate.Height = 40;
            this.dtg_Supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Supplier.Size = new System.Drawing.Size(830, 202);
            this.dtg_Supplier.TabIndex = 0;
            this.dtg_Supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dtg_Supplier.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Supplier_CellContentDoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(507, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 17);
            this.label14.TabIndex = 72;
            this.label14.Text = "Email";
            // 
            // sup_Email
            // 
            this.sup_Email.Location = new System.Drawing.Point(563, 99);
            this.sup_Email.Name = "sup_Email";
            this.sup_Email.Size = new System.Drawing.Size(141, 25);
            this.sup_Email.TabIndex = 6;
            // 
            // Sup_Image
            // 
            this.Sup_Image.Location = new System.Drawing.Point(11, 62);
            this.Sup_Image.Name = "Sup_Image";
            this.Sup_Image.Size = new System.Drawing.Size(128, 110);
            this.Sup_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sup_Image.TabIndex = 70;
            this.Sup_Image.TabStop = false;
            this.Sup_Image.DoubleClick += new System.EventHandler(this.Sup_Image_DoubleClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clear.Location = new System.Drawing.Point(713, 171);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(128, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear Text";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Upload_sup,
            this.supplier_refresh,
            this.btn_new_supplier});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(847, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btn_Upload_sup
            // 
            this.btn_Upload_sup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Upload_sup.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Upload_sup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload_sup.ForeColor = System.Drawing.Color.White;
            this.btn_Upload_sup.Image = ((System.Drawing.Image)(resources.GetObject("btn_Upload_sup.Image")));
            this.btn_Upload_sup.Name = "btn_Upload_sup";
            this.btn_Upload_sup.Size = new System.Drawing.Size(110, 20);
            this.btn_Upload_sup.Text = "Upload Image";
            this.btn_Upload_sup.Click += new System.EventHandler(this.btn_Upload_sup_Click);
            // 
            // supplier_refresh
            // 
            this.supplier_refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.supplier_refresh.BackColor = System.Drawing.Color.SteelBlue;
            this.supplier_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_refresh.ForeColor = System.Drawing.Color.White;
            this.supplier_refresh.Image = ((System.Drawing.Image)(resources.GetObject("supplier_refresh.Image")));
            this.supplier_refresh.Name = "supplier_refresh";
            this.supplier_refresh.Size = new System.Drawing.Size(74, 20);
            this.supplier_refresh.Text = "Refresh";
            this.supplier_refresh.Click += new System.EventHandler(this.supplier_refresh_Click);
            // 
            // btn_new_supplier
            // 
            this.btn_new_supplier.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_new_supplier.BackColor = System.Drawing.Color.Peru;
            this.btn_new_supplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_supplier.ForeColor = System.Drawing.Color.White;
            this.btn_new_supplier.Image = ((System.Drawing.Image)(resources.GetObject("btn_new_supplier.Image")));
            this.btn_new_supplier.Name = "btn_new_supplier";
            this.btn_new_supplier.Size = new System.Drawing.Size(113, 20);
            this.btn_new_supplier.Text = "New Customer";
            this.btn_new_supplier.Click += new System.EventHandler(this.btn_new_supplier_Click);
            // 
            // btn_GenerateID
            // 
            this.btn_GenerateID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GenerateID.BackColor = System.Drawing.Color.SlateGray;
            this.btn_GenerateID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GenerateID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GenerateID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateID.ForeColor = System.Drawing.Color.White;
            this.btn_GenerateID.Location = new System.Drawing.Point(713, 67);
            this.btn_GenerateID.Name = "btn_GenerateID";
            this.btn_GenerateID.Size = new System.Drawing.Size(128, 23);
            this.btn_GenerateID.TabIndex = 8;
            this.btn_GenerateID.Text = "Generate ID";
            this.btn_GenerateID.UseVisualStyleBackColor = false;
            this.btn_GenerateID.Click += new System.EventHandler(this.btn_GenerateID_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(526, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "ID";
            // 
            // Sup_ID
            // 
            this.Sup_ID.Location = new System.Drawing.Point(563, 70);
            this.Sup_ID.Name = "Sup_ID";
            this.Sup_ID.Size = new System.Drawing.Size(141, 25);
            this.Sup_ID.TabIndex = 3;
            this.Sup_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sup_ID_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Company Name";
            // 
            // sup_CName
            // 
            this.sup_CName.Location = new System.Drawing.Point(254, 70);
            this.sup_CName.Name = "sup_CName";
            this.sup_CName.Size = new System.Drawing.Size(205, 25);
            this.sup_CName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Address";
            // 
            // sup_Address
            // 
            this.sup_Address.Location = new System.Drawing.Point(254, 132);
            this.sup_Address.Multiline = true;
            this.sup_Address.Name = "sup_Address";
            this.sup_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sup_Address.Size = new System.Drawing.Size(451, 48);
            this.sup_Address.TabIndex = 7;
            // 
            // btn_sup_delete
            // 
            this.btn_sup_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_delete.BackColor = System.Drawing.Color.SlateGray;
            this.btn_sup_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sup_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_delete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sup_delete.Location = new System.Drawing.Point(713, 145);
            this.btn_sup_delete.Name = "btn_sup_delete";
            this.btn_sup_delete.Size = new System.Drawing.Size(128, 23);
            this.btn_sup_delete.TabIndex = 11;
            this.btn_sup_delete.Text = "Delete Selected";
            this.btn_sup_delete.UseVisualStyleBackColor = false;
            this.btn_sup_delete.Click += new System.EventHandler(this.btn_sup_delete_Click);
            // 
            // btn_sup_edit
            // 
            this.btn_sup_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_edit.BackColor = System.Drawing.Color.SlateGray;
            this.btn_sup_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sup_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_edit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sup_edit.Location = new System.Drawing.Point(713, 119);
            this.btn_sup_edit.Name = "btn_sup_edit";
            this.btn_sup_edit.Size = new System.Drawing.Size(128, 23);
            this.btn_sup_edit.TabIndex = 10;
            this.btn_sup_edit.Text = "Save Current";
            this.btn_sup_edit.UseVisualStyleBackColor = false;
            this.btn_sup_edit.Click += new System.EventHandler(this.btn_sup_edit_Click);
            // 
            // btn_sup_add
            // 
            this.btn_sup_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_add.BackColor = System.Drawing.Color.SlateGray;
            this.btn_sup_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sup_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_add.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sup_add.Location = new System.Drawing.Point(713, 93);
            this.btn_sup_add.Name = "btn_sup_add";
            this.btn_sup_add.Size = new System.Drawing.Size(128, 23);
            this.btn_sup_add.TabIndex = 9;
            this.btn_sup_add.Text = "Add to Record";
            this.btn_sup_add.UseVisualStyleBackColor = false;
            this.btn_sup_add.Click += new System.EventHandler(this.btn_sup_add_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // CustSupp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 526);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustSupp";
            this.Text = "Customer & Supplier Form";
            this.Load += new System.EventHandler(this.CustSupp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cust_Image)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Supplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sup_Image)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtg_Customer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Cust_Delete;
        private System.Windows.Forms.Button btn_Cust_edit;
        private System.Windows.Forms.Button btn_Cust_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cust_FN;
        private System.Windows.Forms.Button btn_sup_delete;
        private System.Windows.Forms.Button btn_sup_edit;
        private System.Windows.Forms.Button btn_sup_add;
        private System.Windows.Forms.DataGridView dtg_Supplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sup_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sup_CName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Sup_ID;
        private System.Windows.Forms.Button btn_GenerateID;
        private System.Windows.Forms.Button btn_Gen_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cust_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cust_SAddress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem supplier_refresh;
        private System.Windows.Forms.Button btn_Clear_Text;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.PictureBox Sup_Image;
        private System.Windows.Forms.PictureBox Cust_Image;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sup_Email;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ToolStripMenuItem customerModelsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem btn_new_customer;
        private System.Windows.Forms.ToolStripMenuItem btn_new_supplier;
        private System.Windows.Forms.Label lbl_total_cust;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_total_sup;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_Search_sup;
        private System.Windows.Forms.ToolStripMenuItem btn_Upload_Cust;
        private System.Windows.Forms.ToolStripMenuItem btn_Upload_sup;
        private System.Windows.Forms.Button btn_cusid_select;
        private System.Windows.Forms.Button btn_supid_select;
        private System.Windows.Forms.TextBox cust_Phone;
        private System.Windows.Forms.TextBox sup_Phone;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}