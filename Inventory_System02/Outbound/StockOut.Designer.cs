
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOut));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.outboundListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_Saved = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.out_amt = new System.Windows.Forms.Label();
            this.out_qty = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.chk_all2 = new System.Windows.Forms.CheckBox();
            this.lbl_numb_out_items = new System.Windows.Forms.Label();
            this.lbl_items_qty = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbo_srch_type = new System.Windows.Forms.ComboBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundStockOut = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chk_paid = new System.Windows.Forms.CheckBox();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PreloadWorker = new System.ComponentModel.BackgroundWorker();
            this.lbl_error_message = new System.Windows.Forms.Label();
            this.timer_error = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Stocks)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AddedStocks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Stocks
            // 
            this.dtg_Stocks.AllowUserToAddRows = false;
            this.dtg_Stocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_Stocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Stocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Stocks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Stocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Stocks.EnableHeadersVisualStyles = false;
            this.dtg_Stocks.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_Stocks.Location = new System.Drawing.Point(11, 191);
            this.dtg_Stocks.Name = "dtg_Stocks";
            this.dtg_Stocks.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Stocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Stocks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Stocks.RowTemplate.Height = 40;
            this.dtg_Stocks.Size = new System.Drawing.Size(842, 143);
            this.dtg_Stocks.TabIndex = 1;
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
            this.groupBox1.Location = new System.Drawing.Point(13, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(453, 22);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(167, 25);
            this.txt_Type.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "Type";
            // 
            // btn_searchCustomer
            // 
            this.btn_searchCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchCustomer.BackgroundImage")));
            this.btn_searchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_searchCustomer.Location = new System.Drawing.Point(286, 20);
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
            this.cust_Image.Location = new System.Drawing.Point(738, 18);
            this.cust_Image.Name = "cust_Image";
            this.cust_Image.Size = new System.Drawing.Size(94, 76);
            this.cust_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cust_Image.TabIndex = 69;
            this.cust_Image.TabStop = false;
            // 
            // cbo_CustID
            // 
            this.cbo_CustID.FormattingEnabled = true;
            this.cbo_CustID.Location = new System.Drawing.Point(108, 20);
            this.cbo_CustID.Name = "cbo_CustID";
            this.cbo_CustID.Size = new System.Drawing.Size(172, 25);
            this.cbo_CustID.TabIndex = 1;
            this.cbo_CustID.TextChanged += new System.EventHandler(this.cbo_CustID_TextChanged);
            // 
            // txt_Cust_SAddress
            // 
            this.txt_Cust_SAddress.Location = new System.Drawing.Point(453, 53);
            this.txt_Cust_SAddress.Multiline = true;
            this.txt_Cust_SAddress.Name = "txt_Cust_SAddress";
            this.txt_Cust_SAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Cust_SAddress.Size = new System.Drawing.Size(262, 39);
            this.txt_Cust_SAddress.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Shipping Address";
            // 
            // btn_Cust_Gen
            // 
            this.btn_Cust_Gen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cust_Gen.Location = new System.Drawing.Point(328, 20);
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
            this.txt_Cust_Name.Location = new System.Drawing.Point(108, 53);
            this.txt_Cust_Name.Name = "txt_Cust_Name";
            this.txt_Cust_Name.Size = new System.Drawing.Size(172, 25);
            this.txt_Cust_Name.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Division Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Division ID";
            // 
            // btn_sup_delete
            // 
            this.btn_sup_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_delete.BackColor = System.Drawing.Color.SlateGray;
            this.btn_sup_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_delete.ForeColor = System.Drawing.Color.White;
            this.btn_sup_delete.Location = new System.Drawing.Point(721, 365);
            this.btn_sup_delete.Name = "btn_sup_delete";
            this.btn_sup_delete.Size = new System.Drawing.Size(132, 23);
            this.btn_sup_delete.TabIndex = 6;
            this.btn_sup_delete.Text = "Remove selected";
            this.btn_sup_delete.UseVisualStyleBackColor = false;
            this.btn_sup_delete.Click += new System.EventHandler(this.btn_sup_delete_Click);
            // 
            // btn_sup_add
            // 
            this.btn_sup_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_add.BackColor = System.Drawing.Color.SlateGray;
            this.btn_sup_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_add.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_add.ForeColor = System.Drawing.Color.White;
            this.btn_sup_add.Location = new System.Drawing.Point(719, 162);
            this.btn_sup_add.Name = "btn_sup_add";
            this.btn_sup_add.Size = new System.Drawing.Size(132, 22);
            this.btn_sup_add.TabIndex = 3;
            this.btn_sup_add.Text = "Add selected below";
            this.btn_sup_add.UseVisualStyleBackColor = false;
            this.btn_sup_add.Click += new System.EventHandler(this.btn_sup_add_Click);
            // 
            // dtg_AddedStocks
            // 
            this.dtg_AddedStocks.AllowUserToAddRows = false;
            this.dtg_AddedStocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_AddedStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_AddedStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_AddedStocks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_AddedStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_AddedStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_AddedStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.ItemName,
            this.Brand,
            this.Description,
            this.Quantity,
            this.pprice,
            this.Total});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_AddedStocks.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtg_AddedStocks.EnableHeadersVisualStyles = false;
            this.dtg_AddedStocks.Location = new System.Drawing.Point(11, 392);
            this.dtg_AddedStocks.Name = "dtg_AddedStocks";
            this.dtg_AddedStocks.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_AddedStocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg_AddedStocks.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtg_AddedStocks.Size = new System.Drawing.Size(843, 107);
            this.dtg_AddedStocks.TabIndex = 4;
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
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 81;
            // 
            // pprice
            // 
            this.pprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.pprice.DefaultCellStyle = dataGridViewCellStyle8;
            this.pprice.HeaderText = "Price";
            this.pprice.Name = "pprice";
            this.pprice.ReadOnly = true;
            this.pprice.Width = 61;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle9;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 61;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(60, 137);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(136, 25);
            this.txt_Search.TabIndex = 9;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 141);
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
            this.customerListToolStripMenuItem,
            this.outboundListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshTableToolStripMenuItem
            // 
            this.refreshTableToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
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
            this.customerListToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.customerListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerListToolStripMenuItem.Image")));
            this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            this.customerListToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.customerListToolStripMenuItem.Text = "Customer List";
            this.customerListToolStripMenuItem.Click += new System.EventHandler(this.customerListToolStripMenuItem_Click);
            // 
            // outboundListToolStripMenuItem
            // 
            this.outboundListToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.outboundListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.outboundListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("outboundListToolStripMenuItem.Image")));
            this.outboundListToolStripMenuItem.Name = "outboundListToolStripMenuItem";
            this.outboundListToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.outboundListToolStripMenuItem.Text = "Outbound List";
            this.outboundListToolStripMenuItem.Click += new System.EventHandler(this.outboundListToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Saved,
            this.previewToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 549);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(863, 29);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btn_Saved
            // 
            this.btn_Saved.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Saved.BackColor = System.Drawing.Color.Green;
            this.btn_Saved.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Saved.ForeColor = System.Drawing.Color.White;
            this.btn_Saved.Image = ((System.Drawing.Image)(resources.GetObject("btn_Saved.Image")));
            this.btn_Saved.Name = "btn_Saved";
            this.btn_Saved.Size = new System.Drawing.Size(173, 25);
            this.btn_Saved.Text = "Confirm Stock Out";
            this.btn_Saved.Click += new System.EventHandler(this.btn_Saved_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.previewToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.previewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.previewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.previewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("previewToolStripMenuItem.Image")));
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(13, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 2);
            this.panel1.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "Total Quantity:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Total Amount:";
            // 
            // out_amt
            // 
            this.out_amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.out_amt.AutoSize = true;
            this.out_amt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_amt.Location = new System.Drawing.Point(188, 555);
            this.out_amt.Name = "out_amt";
            this.out_amt.Size = new System.Drawing.Size(15, 16);
            this.out_amt.TabIndex = 82;
            this.out_amt.Text = "0";
            this.out_amt.TextChanged += new System.EventHandler(this.out_amt_TextChanged);
            // 
            // out_qty
            // 
            this.out_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.out_qty.AutoSize = true;
            this.out_qty.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_qty.Location = new System.Drawing.Point(188, 536);
            this.out_qty.Name = "out_qty";
            this.out_qty.Size = new System.Drawing.Size(15, 16);
            this.out_qty.TabIndex = 81;
            this.out_qty.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(612, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 25);
            this.label9.TabIndex = 84;
            this.label9.Text = "INBOUND TRANSACTIONS";
            // 
            // chk_all
            // 
            this.chk_all.AutoSize = true;
            this.chk_all.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_all.Location = new System.Drawing.Point(13, 171);
            this.chk_all.Name = "chk_all";
            this.chk_all.Size = new System.Drawing.Size(72, 17);
            this.chk_all.TabIndex = 12;
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
            this.chk_all2.Location = new System.Drawing.Point(11, 372);
            this.chk_all2.Name = "chk_all2";
            this.chk_all2.Size = new System.Drawing.Size(71, 17);
            this.chk_all2.TabIndex = 8;
            this.chk_all2.Text = "Select all";
            this.chk_all2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_all2.UseVisualStyleBackColor = true;
            this.chk_all2.CheckedChanged += new System.EventHandler(this.chk_all2_CheckedChanged);
            // 
            // lbl_numb_out_items
            // 
            this.lbl_numb_out_items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_numb_out_items.AutoSize = true;
            this.lbl_numb_out_items.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numb_out_items.Location = new System.Drawing.Point(11, 504);
            this.lbl_numb_out_items.Name = "lbl_numb_out_items";
            this.lbl_numb_out_items.Size = new System.Drawing.Size(39, 16);
            this.lbl_numb_out_items.TabIndex = 93;
            this.lbl_numb_out_items.Text = "none";
            // 
            // lbl_items_qty
            // 
            this.lbl_items_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_items_qty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_items_qty.Location = new System.Drawing.Point(717, 138);
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
            this.label16.Location = new System.Drawing.Point(206, 143);
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
            "Item Name",
            "Brand",
            "Description",
            "Quantity",
            "Price",
            "Supplier",
            "Job",
            "Trans Ref"});
            this.cbo_srch_type.Location = new System.Drawing.Point(263, 140);
            this.cbo_srch_type.Name = "cbo_srch_type";
            this.cbo_srch_type.Size = new System.Drawing.Size(93, 21);
            this.cbo_srch_type.TabIndex = 10;
            this.cbo_srch_type.Text = "Trans Ref";
            this.cbo_srch_type.SelectedIndexChanged += new System.EventHandler(this.cbo_srch_type_SelectedIndexChanged);
            // 
            // btn_view
            // 
            this.btn_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view.BackColor = System.Drawing.Color.SlateGray;
            this.btn_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Location = new System.Drawing.Point(581, 162);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(133, 22);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "View item";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.BackColor = System.Drawing.Color.SlateGray;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(583, 365);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit selection";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(8, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 25);
            this.label8.TabIndex = 98;
            this.label8.Text = "OUTBOUND TRANSACTION";
            // 
            // backgroundStockOut
            // 
            this.backgroundStockOut.WorkerReportsProgress = true;
            this.backgroundStockOut.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundStockOut_DoWork);
            this.backgroundStockOut.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundStockOut_RunWorkerCompleted);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "test";
            this.notifyIcon1.BalloonTipTitle = "test";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // chk_paid
            // 
            this.chk_paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_paid.AutoSize = true;
            this.chk_paid.Checked = true;
            this.chk_paid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_paid.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_paid.Location = new System.Drawing.Point(487, 370);
            this.chk_paid.Name = "chk_paid";
            this.chk_paid.Size = new System.Drawing.Size(92, 17);
            this.chk_paid.TabIndex = 99;
            this.chk_paid.Text = "Mark as paid";
            this.chk_paid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_paid.UseVisualStyleBackColor = true;
            // 
            // txt_remarks
            // 
            this.txt_remarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_remarks.Location = new System.Drawing.Point(583, 503);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remarks.Size = new System.Drawing.Size(271, 43);
            this.txt_remarks.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(528, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Remarks";
            // 
            // PreloadWorker
            // 
            this.PreloadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PreloadWorker_DoWork);
            this.PreloadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PreloadWorker_RunWorkerCompleted);
            // 
            // lbl_error_message
            // 
            this.lbl_error_message.AutoSize = true;
            this.lbl_error_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_error_message.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_message.Location = new System.Drawing.Point(0, 0);
            this.lbl_error_message.Name = "lbl_error_message";
            this.lbl_error_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_message.TabIndex = 102;
            // 
            // timer_error
            // 
            this.timer_error.Interval = 3000;
            this.timer_error.Tick += new System.EventHandler(this.timer_error_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbl_error_message);
            this.panel2.Location = new System.Drawing.Point(89, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 16);
            this.panel2.TabIndex = 102;
            // 
            // StockOut
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_remarks);
            this.Controls.Add(this.chk_paid);
            this.Controls.Add(this.out_amt);
            this.Controls.Add(this.out_qty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbo_srch_type);
            this.Controls.Add(this.lbl_numb_out_items);
            this.Controls.Add(this.lbl_items_qty);
            this.Controls.Add(this.chk_all2);
            this.Controls.Add(this.chk_all);
            this.Controls.Add(this.label9);
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
            this.Text = "Outbound Form";
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbo_CustID;
        private System.Windows.Forms.PictureBox cust_Image;
        private System.Windows.Forms.Button btn_searchCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label out_amt;
        private System.Windows.Forms.Label out_qty;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chk_all;
        private System.Windows.Forms.CheckBox chk_all2;
        private System.Windows.Forms.Label lbl_numb_out_items;
        private System.Windows.Forms.Label lbl_items_qty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbo_srch_type;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem outboundListToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundStockOut;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn pprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_paid;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker PreloadWorker;
        private System.Windows.Forms.Label lbl_error_message;
        private System.Windows.Forms.Timer timer_error;
        private System.Windows.Forms.Panel panel2;
    }
}