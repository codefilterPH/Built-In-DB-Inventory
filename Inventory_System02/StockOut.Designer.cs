
namespace Inventory_System02
{
    partial class StockOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOut));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_Stocks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_searchCustomer = new System.Windows.Forms.Button();
            this.cust_Image = new System.Windows.Forms.PictureBox();
            this.cbo_CustID = new System.Windows.Forms.ComboBox();
            this.txt_Cust_SAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cust_Gen = new System.Windows.Forms.Button();
            this.txt_Cust_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sup_delete = new System.Windows.Forms.Button();
            this.btn_sup_add = new System.Windows.Forms.Button();
            this.dtg_AddedStocks = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_Saved = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_Cat = new System.Windows.Forms.CheckBox();
            this.chk_ItemID = new System.Windows.Forms.CheckBox();
            this.chk_Desc = new System.Windows.Forms.CheckBox();
            this.chk_ItemName = new System.Windows.Forms.CheckBox();
            this.chk_Date = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.out_amt = new System.Windows.Forms.Label();
            this.out_qty = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.chk_all2 = new System.Windows.Forms.CheckBox();
            this.lbl_numb_out_items = new System.Windows.Forms.Label();
            this.lbl_items_qty = new System.Windows.Forms.Label();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Stocks)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AddedStocks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Stocks
            // 
            this.dtg_Stocks.AllowUserToAddRows = false;
            this.dtg_Stocks.AllowUserToDeleteRows = false;
            this.dtg_Stocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Stocks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Stocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Stocks.EnableHeadersVisualStyles = false;
            this.dtg_Stocks.GridColor = System.Drawing.Color.White;
            this.dtg_Stocks.Location = new System.Drawing.Point(11, 209);
            this.dtg_Stocks.Name = "dtg_Stocks";
            this.dtg_Stocks.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Stocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Stocks.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Stocks.RowTemplate.Height = 70;
            this.dtg_Stocks.Size = new System.Drawing.Size(842, 127);
            this.dtg_Stocks.TabIndex = 8;
            this.dtg_Stocks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Stocks_CellClick);
            this.dtg_Stocks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Stocks_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_Type);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_searchCustomer);
            this.groupBox1.Controls.Add(this.cust_Image);
            this.groupBox1.Controls.Add(this.cbo_CustID);
            this.groupBox1.Controls.Add(this.txt_Cust_SAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Cust_Gen);
            this.groupBox1.Controls.Add(this.txt_Cust_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(123, 80);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(157, 25);
            this.txt_Type.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "Type";
            // 
            // btn_searchCustomer
            // 
            this.btn_searchCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchCustomer.BackgroundImage")));
            this.btn_searchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_searchCustomer.Location = new System.Drawing.Point(286, 16);
            this.btn_searchCustomer.Name = "btn_searchCustomer";
            this.btn_searchCustomer.Size = new System.Drawing.Size(32, 23);
            this.btn_searchCustomer.TabIndex = 0;
            this.btn_searchCustomer.UseVisualStyleBackColor = true;
            this.btn_searchCustomer.Click += new System.EventHandler(this.btn_searchCustomer_Click);
            // 
            // cust_Image
            // 
            this.cust_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cust_Image.Location = new System.Drawing.Point(727, 19);
            this.cust_Image.Name = "cust_Image";
            this.cust_Image.Size = new System.Drawing.Size(105, 87);
            this.cust_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cust_Image.TabIndex = 69;
            this.cust_Image.TabStop = false;
            // 
            // cbo_CustID
            // 
            this.cbo_CustID.FormattingEnabled = true;
            this.cbo_CustID.Location = new System.Drawing.Point(123, 16);
            this.cbo_CustID.Name = "cbo_CustID";
            this.cbo_CustID.Size = new System.Drawing.Size(157, 25);
            this.cbo_CustID.TabIndex = 1;
            this.cbo_CustID.SelectedIndexChanged += new System.EventHandler(this.cbo_CustID_SelectedIndexChanged);
            this.cbo_CustID.TextChanged += new System.EventHandler(this.cbo_CustID_TextChanged);
            // 
            // txt_Cust_SAddress
            // 
            this.txt_Cust_SAddress.Location = new System.Drawing.Point(431, 49);
            this.txt_Cust_SAddress.Multiline = true;
            this.txt_Cust_SAddress.Name = "txt_Cust_SAddress";
            this.txt_Cust_SAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Cust_SAddress.Size = new System.Drawing.Size(290, 56);
            this.txt_Cust_SAddress.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Shipping Address";
            // 
            // btn_Cust_Gen
            // 
            this.btn_Cust_Gen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cust_Gen.Location = new System.Drawing.Point(324, 17);
            this.btn_Cust_Gen.Name = "btn_Cust_Gen";
            this.btn_Cust_Gen.Size = new System.Drawing.Size(78, 23);
            this.btn_Cust_Gen.TabIndex = 65;
            this.btn_Cust_Gen.Text = "Generate ID";
            this.btn_Cust_Gen.UseVisualStyleBackColor = true;
            this.btn_Cust_Gen.Click += new System.EventHandler(this.btn_Cust_Gen_Click);
            // 
            // txt_Cust_Name
            // 
            this.txt_Cust_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cust_Name.Location = new System.Drawing.Point(123, 49);
            this.txt_Cust_Name.Name = "txt_Cust_Name";
            this.txt_Cust_Name.Size = new System.Drawing.Size(157, 25);
            this.txt_Cust_Name.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // btn_sup_delete
            // 
            this.btn_sup_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_sup_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sup_delete.BackgroundImage")));
            this.btn_sup_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_delete.Location = new System.Drawing.Point(827, 345);
            this.btn_sup_delete.Name = "btn_sup_delete";
            this.btn_sup_delete.Size = new System.Drawing.Size(27, 23);
            this.btn_sup_delete.TabIndex = 13;
            this.btn_sup_delete.UseVisualStyleBackColor = false;
            this.btn_sup_delete.Click += new System.EventHandler(this.btn_sup_delete_Click);
            // 
            // btn_sup_add
            // 
            this.btn_sup_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_add.BackColor = System.Drawing.Color.Green;
            this.btn_sup_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sup_add.BackgroundImage")));
            this.btn_sup_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_add.Location = new System.Drawing.Point(827, 182);
            this.btn_sup_add.Name = "btn_sup_add";
            this.btn_sup_add.Size = new System.Drawing.Size(27, 23);
            this.btn_sup_add.TabIndex = 9;
            this.btn_sup_add.UseVisualStyleBackColor = false;
            this.btn_sup_add.Click += new System.EventHandler(this.btn_sup_add_Click);
            // 
            // dtg_AddedStocks
            // 
            this.dtg_AddedStocks.AllowUserToAddRows = false;
            this.dtg_AddedStocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_AddedStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_AddedStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_AddedStocks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_AddedStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_AddedStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_AddedStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.ItemName,
            this.Brand,
            this.Description,
            this.Quantity,
            this.pprice,
            this.Total});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_AddedStocks.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtg_AddedStocks.EnableHeadersVisualStyles = false;
            this.dtg_AddedStocks.Location = new System.Drawing.Point(11, 372);
            this.dtg_AddedStocks.Name = "dtg_AddedStocks";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_AddedStocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg_AddedStocks.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtg_AddedStocks.Size = new System.Drawing.Size(843, 107);
            this.dtg_AddedStocks.TabIndex = 10;
            this.dtg_AddedStocks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AddedStocks_CellClick);
            this.dtg_AddedStocks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AddedStocks_CellEndEdit);
            this.dtg_AddedStocks.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtg_AddedStocks_EditingControlShowing);
            this.dtg_AddedStocks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_AddedStocks_KeyDown);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(59, 163);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(136, 25);
            this.txt_Search.TabIndex = 7;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshTableToolStripMenuItem,
            this.customerListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 70;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshTableToolStripMenuItem
            // 
            this.refreshTableToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.refreshTableToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshTableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshTableToolStripMenuItem.Image")));
            this.refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            this.refreshTableToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.refreshTableToolStripMenuItem.Text = "Refresh Table";
            this.refreshTableToolStripMenuItem.Click += new System.EventHandler(this.refreshTableToolStripMenuItem_Click);
            // 
            // customerListToolStripMenuItem
            // 
            this.customerListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.customerListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerListToolStripMenuItem.Image")));
            this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            this.customerListToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.customerListToolStripMenuItem.Text = "Customer List";
            this.customerListToolStripMenuItem.Click += new System.EventHandler(this.customerListToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Saved,
            this.viewListToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 516);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(863, 24);
            this.menuStrip2.TabIndex = 71;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btn_Saved
            // 
            this.btn_Saved.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Saved.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Saved.ForeColor = System.Drawing.Color.White;
            this.btn_Saved.Image = ((System.Drawing.Image)(resources.GetObject("btn_Saved.Image")));
            this.btn_Saved.Name = "btn_Saved";
            this.btn_Saved.Size = new System.Drawing.Size(134, 20);
            this.btn_Saved.Text = "Confirm Stock Out";
            this.btn_Saved.Click += new System.EventHandler(this.btn_Saved_Click);
            // 
            // viewListToolStripMenuItem
            // 
            this.viewListToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.viewListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewListToolStripMenuItem.Image")));
            this.viewListToolStripMenuItem.Name = "viewListToolStripMenuItem";
            this.viewListToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.viewListToolStripMenuItem.Text = "View List";
            this.viewListToolStripMenuItem.Click += new System.EventHandler(this.viewListToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(13, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 2);
            this.panel1.TabIndex = 72;
            // 
            // chk_Cat
            // 
            this.chk_Cat.AutoSize = true;
            this.chk_Cat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Cat.Location = new System.Drawing.Point(489, 166);
            this.chk_Cat.Name = "chk_Cat";
            this.chk_Cat.Size = new System.Drawing.Size(56, 17);
            this.chk_Cat.TabIndex = 5;
            this.chk_Cat.Text = "Brand";
            this.chk_Cat.UseVisualStyleBackColor = true;
            this.chk_Cat.CheckedChanged += new System.EventHandler(this.chk_Cat_CheckedChanged);
            // 
            // chk_ItemID
            // 
            this.chk_ItemID.AutoSize = true;
            this.chk_ItemID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ItemID.Location = new System.Drawing.Point(201, 166);
            this.chk_ItemID.Name = "chk_ItemID";
            this.chk_ItemID.Size = new System.Drawing.Size(114, 17);
            this.chk_ItemID.TabIndex = 2;
            this.chk_ItemID.Text = "Search by Item ID";
            this.chk_ItemID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_ItemID.UseVisualStyleBackColor = true;
            this.chk_ItemID.CheckedChanged += new System.EventHandler(this.chk_ItemID_CheckedChanged);
            // 
            // chk_Desc
            // 
            this.chk_Desc.AutoSize = true;
            this.chk_Desc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Desc.Location = new System.Drawing.Point(398, 166);
            this.chk_Desc.Name = "chk_Desc";
            this.chk_Desc.Size = new System.Drawing.Size(85, 17);
            this.chk_Desc.TabIndex = 4;
            this.chk_Desc.Text = "Description";
            this.chk_Desc.UseVisualStyleBackColor = true;
            this.chk_Desc.CheckedChanged += new System.EventHandler(this.chk_Desc_CheckedChanged);
            // 
            // chk_ItemName
            // 
            this.chk_ItemName.AutoSize = true;
            this.chk_ItemName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ItemName.Location = new System.Drawing.Point(313, 166);
            this.chk_ItemName.Name = "chk_ItemName";
            this.chk_ItemName.Size = new System.Drawing.Size(80, 17);
            this.chk_ItemName.TabIndex = 3;
            this.chk_ItemName.Text = "Item Name";
            this.chk_ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_ItemName.UseVisualStyleBackColor = true;
            this.chk_ItemName.CheckedChanged += new System.EventHandler(this.chk_ItemName_CheckedChanged);
            // 
            // chk_Date
            // 
            this.chk_Date.AutoSize = true;
            this.chk_Date.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Date.Location = new System.Drawing.Point(567, 166);
            this.chk_Date.Name = "chk_Date";
            this.chk_Date.Size = new System.Drawing.Size(50, 17);
            this.chk_Date.TabIndex = 6;
            this.chk_Date.Text = "Date";
            this.chk_Date.UseVisualStyleBackColor = true;
            this.chk_Date.CheckedChanged += new System.EventHandler(this.chk_Date_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(663, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Total Quantity:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(663, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Total Amount:";
            // 
            // out_amt
            // 
            this.out_amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.out_amt.AutoSize = true;
            this.out_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_amt.Location = new System.Drawing.Point(748, 495);
            this.out_amt.Name = "out_amt";
            this.out_amt.Size = new System.Drawing.Size(0, 13);
            this.out_amt.TabIndex = 82;
            // 
            // out_qty
            // 
            this.out_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.out_qty.AutoSize = true;
            this.out_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_qty.Location = new System.Drawing.Point(748, 480);
            this.out_qty.Name = "out_qty";
            this.out_qty.Size = new System.Drawing.Size(0, 13);
            this.out_qty.TabIndex = 81;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(765, 351);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Done";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(695, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 84;
            this.label9.Text = "Outbound Stocks";
            // 
            // chk_all
            // 
            this.chk_all.AutoSize = true;
            this.chk_all.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_all.Location = new System.Drawing.Point(11, 189);
            this.chk_all.Name = "chk_all";
            this.chk_all.Size = new System.Drawing.Size(72, 17);
            this.chk_all.TabIndex = 85;
            this.chk_all.Text = "Select All";
            this.chk_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_all.UseVisualStyleBackColor = true;
            this.chk_all.CheckedChanged += new System.EventHandler(this.chk_all_CheckedChanged);
            // 
            // chk_all2
            // 
            this.chk_all2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_all2.AutoSize = true;
            this.chk_all2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_all2.Location = new System.Drawing.Point(688, 351);
            this.chk_all2.Name = "chk_all2";
            this.chk_all2.Size = new System.Drawing.Size(71, 17);
            this.chk_all2.TabIndex = 11;
            this.chk_all2.Text = "Select all";
            this.chk_all2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_all2.UseVisualStyleBackColor = true;
            this.chk_all2.CheckedChanged += new System.EventHandler(this.chk_all2_CheckedChanged);
            // 
            // lbl_numb_out_items
            // 
            this.lbl_numb_out_items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_numb_out_items.AutoSize = true;
            this.lbl_numb_out_items.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numb_out_items.Location = new System.Drawing.Point(10, 350);
            this.lbl_numb_out_items.Name = "lbl_numb_out_items";
            this.lbl_numb_out_items.Size = new System.Drawing.Size(0, 13);
            this.lbl_numb_out_items.TabIndex = 93;
            // 
            // lbl_items_qty
            // 
            this.lbl_items_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_items_qty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_items_qty.Location = new System.Drawing.Point(718, 166);
            this.lbl_items_qty.Name = "lbl_items_qty";
            this.lbl_items_qty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_items_qty.Size = new System.Drawing.Size(136, 18);
            this.lbl_items_qty.TabIndex = 92;
            this.lbl_items_qty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StockID
            // 
            this.StockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockID.HeaderText = "Stock ID";
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            this.StockID.Width = 80;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 67;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 99;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 81;
            // 
            // pprice
            // 
            this.pprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pprice.DefaultCellStyle = dataGridViewCellStyle7;
            this.pprice.HeaderText = "Price";
            this.pprice.Name = "pprice";
            this.pprice.ReadOnly = true;
            this.pprice.Width = 61;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle8;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 61;
            // 
            // StockOut
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 540);
            this.Controls.Add(this.lbl_numb_out_items);
            this.Controls.Add(this.lbl_items_qty);
            this.Controls.Add(this.chk_all2);
            this.Controls.Add(this.chk_all);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.out_amt);
            this.Controls.Add(this.out_qty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_Date);
            this.Controls.Add(this.chk_Desc);
            this.Controls.Add(this.chk_ItemName);
            this.Controls.Add(this.chk_ItemID);
            this.Controls.Add(this.chk_Cat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtg_AddedStocks);
            this.Controls.Add(this.btn_sup_delete);
            this.Controls.Add(this.btn_sup_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_Stocks);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StockOut";
            this.Text = "StockOut";
            this.Load += new System.EventHandler(this.StockOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Stocks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AddedStocks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Stocks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Cust_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sup_delete;
        private System.Windows.Forms.Button btn_sup_add;
        private System.Windows.Forms.Button btn_Cust_Gen;
        private System.Windows.Forms.TextBox txt_Cust_SAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_AddedStocks;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshTableToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btn_Saved;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem viewListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_Cat;
        private System.Windows.Forms.CheckBox chk_ItemID;
        private System.Windows.Forms.CheckBox chk_Desc;
        private System.Windows.Forms.CheckBox chk_ItemName;
        private System.Windows.Forms.CheckBox chk_Date;
        private System.Windows.Forms.ComboBox cbo_CustID;
        private System.Windows.Forms.PictureBox cust_Image;
        private System.Windows.Forms.Button btn_searchCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label out_amt;
        private System.Windows.Forms.Label out_qty;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chk_all;
        private System.Windows.Forms.CheckBox chk_all2;
        private System.Windows.Forms.Label lbl_numb_out_items;
        private System.Windows.Forms.Label lbl_items_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn pprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}