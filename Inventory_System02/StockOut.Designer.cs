
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOut));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_Saved = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label16 = new System.Windows.Forms.Label();
            this.cbo_srch_type = new System.Windows.Forms.ComboBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Stocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.dtg_Stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Stocks.EnableHeadersVisualStyles = false;
            this.dtg_Stocks.GridColor = System.Drawing.Color.White;
            this.dtg_Stocks.Location = new System.Drawing.Point(11, 209);
            this.dtg_Stocks.Name = "dtg_Stocks";
            this.dtg_Stocks.ReadOnly = true;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Stocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle46;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Stocks.RowsDefaultCellStyle = dataGridViewCellStyle47;
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
            this.btn_searchCustomer.Size = new System.Drawing.Size(36, 23);
            this.btn_searchCustomer.TabIndex = 0;
            this.btn_searchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_searchCustomer.UseVisualStyleBackColor = true;
            this.btn_searchCustomer.Click += new System.EventHandler(this.btn_searchCustomer_Click);
            this.btn_searchCustomer.MouseHover += new System.EventHandler(this.btn_searchCustomer_MouseHover);
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
            this.btn_Cust_Gen.Location = new System.Drawing.Point(328, 16);
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
            this.btn_sup_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_delete.ForeColor = System.Drawing.Color.White;
            this.btn_sup_delete.Location = new System.Drawing.Point(721, 345);
            this.btn_sup_delete.Name = "btn_sup_delete";
            this.btn_sup_delete.Size = new System.Drawing.Size(133, 23);
            this.btn_sup_delete.TabIndex = 13;
            this.btn_sup_delete.Text = "Remove selection";
            this.btn_sup_delete.UseVisualStyleBackColor = false;
            this.btn_sup_delete.Click += new System.EventHandler(this.btn_sup_delete_Click);
            // 
            // btn_sup_add
            // 
            this.btn_sup_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_add.BackColor = System.Drawing.Color.Green;
            this.btn_sup_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_add.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_add.ForeColor = System.Drawing.Color.White;
            this.btn_sup_add.Location = new System.Drawing.Point(721, 182);
            this.btn_sup_add.Name = "btn_sup_add";
            this.btn_sup_add.Size = new System.Drawing.Size(133, 23);
            this.btn_sup_add.TabIndex = 9;
            this.btn_sup_add.Text = "Add selected below";
            this.btn_sup_add.UseVisualStyleBackColor = false;
            this.btn_sup_add.Click += new System.EventHandler(this.btn_sup_add_Click);
            // 
            // dtg_AddedStocks
            // 
            this.dtg_AddedStocks.AllowUserToAddRows = false;
            this.dtg_AddedStocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_AddedStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle48;
            this.dtg_AddedStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_AddedStocks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_AddedStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.dtg_AddedStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_AddedStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.ItemName,
            this.Brand,
            this.Description,
            this.Quantity,
            this.pprice,
            this.Total});
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_AddedStocks.DefaultCellStyle = dataGridViewCellStyle53;
            this.dtg_AddedStocks.EnableHeadersVisualStyles = false;
            this.dtg_AddedStocks.Location = new System.Drawing.Point(11, 372);
            this.dtg_AddedStocks.Name = "dtg_AddedStocks";
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_AddedStocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg_AddedStocks.RowsDefaultCellStyle = dataGridViewCellStyle55;
            this.dtg_AddedStocks.Size = new System.Drawing.Size(843, 107);
            this.dtg_AddedStocks.TabIndex = 10;
            this.dtg_AddedStocks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AddedStocks_CellClick);
            this.dtg_AddedStocks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AddedStocks_CellEndEdit);
            this.dtg_AddedStocks.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtg_AddedStocks_EditingControlShowing);
            this.dtg_AddedStocks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_AddedStocks_KeyDown);
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
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle50;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 81;
            // 
            // pprice
            // 
            this.pprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pprice.DefaultCellStyle = dataGridViewCellStyle51;
            this.pprice.HeaderText = "Price";
            this.pprice.Name = "pprice";
            this.pprice.ReadOnly = true;
            this.pprice.Width = 61;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle52.Format = "N2";
            dataGridViewCellStyle52.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle52;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 61;
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
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 480);
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
            this.label6.Location = new System.Drawing.Point(642, 495);
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
            this.checkBox1.Location = new System.Drawing.Point(451, 349);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Auto Review/Check";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
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
            this.chk_all2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_all2.AutoSize = true;
            this.chk_all2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_all2.Location = new System.Drawing.Point(11, 351);
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
            this.lbl_numb_out_items.Location = new System.Drawing.Point(10, 482);
            this.lbl_numb_out_items.Name = "lbl_numb_out_items";
            this.lbl_numb_out_items.Size = new System.Drawing.Size(34, 13);
            this.lbl_numb_out_items.TabIndex = 93;
            this.lbl_numb_out_items.Text = "none";
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(205, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 95;
            this.label16.Text = "Search by";
            // 
            // cbo_srch_type
            // 
            this.cbo_srch_type.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_srch_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbo_srch_type.FormattingEnabled = true;
            this.cbo_srch_type.Items.AddRange(new object[] {
            "Date",
            "Id",
            "Name",
            "Brand",
            "Description",
            "Quantity",
            "Price",
            "Supplier",
            "Job",
            "Trans Ref"});
            this.cbo_srch_type.Location = new System.Drawing.Point(262, 167);
            this.cbo_srch_type.Name = "cbo_srch_type";
            this.cbo_srch_type.Size = new System.Drawing.Size(93, 21);
            this.cbo_srch_type.TabIndex = 94;
            this.cbo_srch_type.Text = "Name";
            this.cbo_srch_type.SelectedIndexChanged += new System.EventHandler(this.cbo_srch_type_SelectedIndexChanged);
            // 
            // btn_view
            // 
            this.btn_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Location = new System.Drawing.Point(583, 183);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(133, 23);
            this.btn_view.TabIndex = 96;
            this.btn_view.Text = "View item";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.BackColor = System.Drawing.Color.Gray;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(583, 345);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 23);
            this.btn_edit.TabIndex = 97;
            this.btn_edit.Text = "Edit selection";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // StockOut
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 540);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbo_srch_type);
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbo_srch_type;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_edit;
    }
}