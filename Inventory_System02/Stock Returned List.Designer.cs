
namespace Inventory_System02
{
    partial class Stock_Returned
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Returned));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_main_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.view_trans_return = new System.Windows.Forms.ToolStripMenuItem();
            this.view_tbl_return = new System.Windows.Forms.ToolStripMenuItem();
            this.batchTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batch_trans_return = new System.Windows.Forms.ToolStripMenuItem();
            this.batch_tbl_return = new System.Windows.Forms.ToolStripMenuItem();
            this.printInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.print_trans_return = new System.Windows.Forms.ToolStripMenuItem();
            this.print_tbl_return = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.most_brand_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.least_brand_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.most_product_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.least_product_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.most_division_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.least_division_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_return_list = new System.Windows.Forms.DataGridView();
            this.txt_Trans_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cust_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cust_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cust_Image = new System.Windows.Forms.PictureBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.out_amt = new System.Windows.Forms.Label();
            this.out_qty = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_items_count = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_srch_type = new System.Windows.Forms.ComboBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_return_to_stocks = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_return_type = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_select_all = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_return_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshTableToolStripMenuItem,
            this.view_main_btn,
            this.batchTransactionToolStripMenuItem,
            this.printInvoiceToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshTableToolStripMenuItem
            // 
            this.refreshTableToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshTableToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.refreshTableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshTableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshTableToolStripMenuItem.Image")));
            this.refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            this.refreshTableToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.refreshTableToolStripMenuItem.Text = "Refresh Table";
            this.refreshTableToolStripMenuItem.Click += new System.EventHandler(this.refreshTableToolStripMenuItem_Click);
            // 
            // view_main_btn
            // 
            this.view_main_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.view_main_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_trans_return,
            this.view_tbl_return});
            this.view_main_btn.ForeColor = System.Drawing.Color.White;
            this.view_main_btn.Image = ((System.Drawing.Image)(resources.GetObject("view_main_btn.Image")));
            this.view_main_btn.Name = "view_main_btn";
            this.view_main_btn.Size = new System.Drawing.Size(60, 20);
            this.view_main_btn.Text = "View";
            // 
            // view_trans_return
            // 
            this.view_trans_return.BackColor = System.Drawing.Color.Peru;
            this.view_trans_return.ForeColor = System.Drawing.Color.White;
            this.view_trans_return.Name = "view_trans_return";
            this.view_trans_return.Size = new System.Drawing.Size(181, 22);
            this.view_trans_return.Text = "Selected Transaction";
            this.view_trans_return.Click += new System.EventHandler(this.selectedTransactionToolStripMenuItem_Click);
            // 
            // view_tbl_return
            // 
            this.view_tbl_return.BackColor = System.Drawing.Color.SteelBlue;
            this.view_tbl_return.ForeColor = System.Drawing.Color.White;
            this.view_tbl_return.Name = "view_tbl_return";
            this.view_tbl_return.Size = new System.Drawing.Size(181, 22);
            this.view_tbl_return.Text = "Table Result";
            this.view_tbl_return.Click += new System.EventHandler(this.view_tbl_return_Click);
            // 
            // batchTransactionToolStripMenuItem
            // 
            this.batchTransactionToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.batchTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batch_trans_return,
            this.batch_tbl_return});
            this.batchTransactionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.batchTransactionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("batchTransactionToolStripMenuItem.Image")));
            this.batchTransactionToolStripMenuItem.Name = "batchTransactionToolStripMenuItem";
            this.batchTransactionToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.batchTransactionToolStripMenuItem.Text = "Batch";
            // 
            // batch_trans_return
            // 
            this.batch_trans_return.BackColor = System.Drawing.Color.Peru;
            this.batch_trans_return.ForeColor = System.Drawing.Color.White;
            this.batch_trans_return.Name = "batch_trans_return";
            this.batch_trans_return.Size = new System.Drawing.Size(181, 22);
            this.batch_trans_return.Text = "Selected Transaction";
            this.batch_trans_return.Click += new System.EventHandler(this.batch_trans_return_Click);
            // 
            // batch_tbl_return
            // 
            this.batch_tbl_return.BackColor = System.Drawing.Color.SteelBlue;
            this.batch_tbl_return.ForeColor = System.Drawing.Color.White;
            this.batch_tbl_return.Name = "batch_tbl_return";
            this.batch_tbl_return.Size = new System.Drawing.Size(181, 22);
            this.batch_tbl_return.Text = "Table Result";
            this.batch_tbl_return.Click += new System.EventHandler(this.batch_tbl_return_Click);
            // 
            // printInvoiceToolStripMenuItem
            // 
            this.printInvoiceToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.printInvoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.print_trans_return,
            this.print_tbl_return});
            this.printInvoiceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInvoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printInvoiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printInvoiceToolStripMenuItem.Image")));
            this.printInvoiceToolStripMenuItem.Name = "printInvoiceToolStripMenuItem";
            this.printInvoiceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.printInvoiceToolStripMenuItem.Text = "Print";
            // 
            // print_trans_return
            // 
            this.print_trans_return.BackColor = System.Drawing.Color.Peru;
            this.print_trans_return.ForeColor = System.Drawing.Color.White;
            this.print_trans_return.Name = "print_trans_return";
            this.print_trans_return.Size = new System.Drawing.Size(183, 22);
            this.print_trans_return.Text = "Selected Transaction";
            this.print_trans_return.Click += new System.EventHandler(this.print_trans_return_Click);
            // 
            // print_tbl_return
            // 
            this.print_tbl_return.BackColor = System.Drawing.Color.SteelBlue;
            this.print_tbl_return.ForeColor = System.Drawing.Color.White;
            this.print_tbl_return.Name = "print_tbl_return";
            this.print_tbl_return.Size = new System.Drawing.Size(183, 22);
            this.print_tbl_return.Text = "Table Result";
            this.print_tbl_return.Click += new System.EventHandler(this.print_tbl_return_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.most_brand_return_tool,
            this.least_brand_return_tool,
            this.most_product_return_tool,
            this.least_product_return_tool,
            this.most_division_return_tool,
            this.least_division_return_tool});
            this.filtersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filtersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filtersToolStripMenuItem.Image")));
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.filtersToolStripMenuItem.Text = "Special Information";
            // 
            // most_brand_return_tool
            // 
            this.most_brand_return_tool.BackColor = System.Drawing.Color.Peru;
            this.most_brand_return_tool.ForeColor = System.Drawing.Color.White;
            this.most_brand_return_tool.Name = "most_brand_return_tool";
            this.most_brand_return_tool.Size = new System.Drawing.Size(242, 22);
            this.most_brand_return_tool.Text = "Most Brand Returned";
            this.most_brand_return_tool.Click += new System.EventHandler(this.most_brand_return_tool_Click);
            // 
            // least_brand_return_tool
            // 
            this.least_brand_return_tool.BackColor = System.Drawing.Color.SteelBlue;
            this.least_brand_return_tool.ForeColor = System.Drawing.Color.White;
            this.least_brand_return_tool.Name = "least_brand_return_tool";
            this.least_brand_return_tool.Size = new System.Drawing.Size(242, 22);
            this.least_brand_return_tool.Text = "Least Brand Returned";
            this.least_brand_return_tool.Click += new System.EventHandler(this.least_brand_return_tool_Click);
            // 
            // most_product_return_tool
            // 
            this.most_product_return_tool.BackColor = System.Drawing.Color.Gray;
            this.most_product_return_tool.ForeColor = System.Drawing.Color.White;
            this.most_product_return_tool.Name = "most_product_return_tool";
            this.most_product_return_tool.Size = new System.Drawing.Size(242, 22);
            this.most_product_return_tool.Text = "Product with the Most Returns";
            this.most_product_return_tool.Click += new System.EventHandler(this.most_product_return_tool_Click);
            // 
            // least_product_return_tool
            // 
            this.least_product_return_tool.BackColor = System.Drawing.Color.Peru;
            this.least_product_return_tool.ForeColor = System.Drawing.Color.White;
            this.least_product_return_tool.Name = "least_product_return_tool";
            this.least_product_return_tool.Size = new System.Drawing.Size(242, 22);
            this.least_product_return_tool.Text = "Product with the Least Returns";
            this.least_product_return_tool.Click += new System.EventHandler(this.least_product_return_tool_Click);
            // 
            // most_division_return_tool
            // 
            this.most_division_return_tool.BackColor = System.Drawing.Color.SteelBlue;
            this.most_division_return_tool.ForeColor = System.Drawing.Color.White;
            this.most_division_return_tool.Name = "most_division_return_tool";
            this.most_division_return_tool.Size = new System.Drawing.Size(242, 22);
            this.most_division_return_tool.Text = "Division with the Most Returnee";
            this.most_division_return_tool.Click += new System.EventHandler(this.most_division_return_tool_Click);
            // 
            // least_division_return_tool
            // 
            this.least_division_return_tool.BackColor = System.Drawing.Color.Gray;
            this.least_division_return_tool.ForeColor = System.Drawing.Color.White;
            this.least_division_return_tool.Name = "least_division_return_tool";
            this.least_division_return_tool.Size = new System.Drawing.Size(242, 22);
            this.least_division_return_tool.Text = "Division with the Least Returnee";
            this.least_division_return_tool.Click += new System.EventHandler(this.least_division_return_tool_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(675, 170);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(113, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(54, 149);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(122, 23);
            this.txt_Search.TabIndex = 4;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Search";
            // 
            // dtg_return_list
            // 
            this.dtg_return_list.AllowUserToAddRows = false;
            this.dtg_return_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtg_return_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_return_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_return_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_return_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_return_list.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_return_list.Location = new System.Drawing.Point(8, 199);
            this.dtg_return_list.Name = "dtg_return_list";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_return_list.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_return_list.RowTemplate.Height = 60;
            this.dtg_return_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_return_list.Size = new System.Drawing.Size(780, 182);
            this.dtg_return_list.TabIndex = 0;
            this.dtg_return_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_return_list_CellClick);
            // 
            // txt_Trans_number
            // 
            this.txt_Trans_number.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Trans_number.Location = new System.Drawing.Point(153, 33);
            this.txt_Trans_number.Name = "txt_Trans_number";
            this.txt_Trans_number.Size = new System.Drawing.Size(146, 25);
            this.txt_Trans_number.TabIndex = 6;
            this.txt_Trans_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Trans_number_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Current Transaction #";
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.BackColor = System.Drawing.Color.White;
            this.txt_Remarks.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remarks.ForeColor = System.Drawing.Color.Firebrick;
            this.txt_Remarks.Location = new System.Drawing.Point(10, 105);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Remarks.Size = new System.Drawing.Size(289, 39);
            this.txt_Remarks.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 100;
            this.label3.Text = "Remarks";
            // 
            // txt_Cust_ID
            // 
            this.txt_Cust_ID.Location = new System.Drawing.Point(153, 64);
            this.txt_Cust_ID.Name = "txt_Cust_ID";
            this.txt_Cust_ID.Size = new System.Drawing.Size(146, 25);
            this.txt_Cust_ID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 101;
            this.label4.Text = "Division ID";
            // 
            // txt_Cust_name
            // 
            this.txt_Cust_name.Location = new System.Drawing.Point(415, 35);
            this.txt_Cust_name.Name = "txt_Cust_name";
            this.txt_Cust_name.Size = new System.Drawing.Size(256, 25);
            this.txt_Cust_name.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 103;
            this.label5.Text = "Division Name";
            // 
            // txt_address
            // 
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address.Location = new System.Drawing.Point(415, 64);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_address.Size = new System.Drawing.Size(256, 61);
            this.txt_address.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 105;
            this.label6.Text = "Address";
            // 
            // cust_Image
            // 
            this.cust_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cust_Image.BackColor = System.Drawing.Color.Transparent;
            this.cust_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cust_Image.Location = new System.Drawing.Point(677, 36);
            this.cust_Image.Name = "cust_Image";
            this.cust_Image.Size = new System.Drawing.Size(111, 89);
            this.cust_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cust_Image.TabIndex = 107;
            this.cust_Image.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_edit.Location = new System.Drawing.Point(305, 105);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(63, 23);
            this.btn_edit.TabIndex = 108;
            this.btn_edit.Text = "Save Text";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // out_amt
            // 
            this.out_amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.out_amt.AutoSize = true;
            this.out_amt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_amt.Location = new System.Drawing.Point(614, 416);
            this.out_amt.Name = "out_amt";
            this.out_amt.Size = new System.Drawing.Size(18, 18);
            this.out_amt.TabIndex = 112;
            this.out_amt.Text = "0";
            this.out_amt.TextChanged += new System.EventHandler(this.out_amt_TextChanged);
            // 
            // out_qty
            // 
            this.out_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.out_qty.AutoSize = true;
            this.out_qty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_qty.Location = new System.Drawing.Point(614, 391);
            this.out_qty.Name = "out_qty";
            this.out_qty.Size = new System.Drawing.Size(18, 18);
            this.out_qty.TabIndex = 111;
            this.out_qty.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 110;
            this.label7.Text = "Total Amount:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 18);
            this.label9.TabIndex = 109;
            this.label9.Text = "Total Quantity:";
            // 
            // lbl_items_count
            // 
            this.lbl_items_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_items_count.AutoSize = true;
            this.lbl_items_count.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_items_count.Location = new System.Drawing.Point(108, 387);
            this.lbl_items_count.Name = "lbl_items_count";
            this.lbl_items_count.Size = new System.Drawing.Size(15, 16);
            this.lbl_items_count.TabIndex = 119;
            this.lbl_items_count.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 387);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 16);
            this.label16.TabIndex = 118;
            this.label16.Text = "Rows count:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(182, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 122;
            this.label8.Text = "By";
            // 
            // cbo_srch_type
            // 
            this.cbo_srch_type.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_srch_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbo_srch_type.FormattingEnabled = true;
            this.cbo_srch_type.Items.AddRange(new object[] {
            "DATE",
            "ID",
            "NAME",
            "BRAND",
            "DESCRIPTION",
            "QUANTITY",
            "PRICE",
            "TOTAL",
            "DIVISION",
            "ADDRESS",
            "STAFF NAME",
            "JOB",
            "TRANS REF"});
            this.cbo_srch_type.Location = new System.Drawing.Point(206, 150);
            this.cbo_srch_type.Name = "cbo_srch_type";
            this.cbo_srch_type.Size = new System.Drawing.Size(93, 21);
            this.cbo_srch_type.TabIndex = 5;
            this.cbo_srch_type.Text = "DIVISION";
            this.cbo_srch_type.SelectedIndexChanged += new System.EventHandler(this.cbo_srch_type_SelectedIndexChanged);
            // 
            // btn_view
            // 
            this.btn_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view.BackColor = System.Drawing.Color.Peru;
            this.btn_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_view.Location = new System.Drawing.Point(556, 170);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(113, 23);
            this.btn_view.TabIndex = 1;
            this.btn_view.Text = "View Details";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_return_to_stocks
            // 
            this.btn_return_to_stocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_return_to_stocks.BackColor = System.Drawing.Color.SlateGray;
            this.btn_return_to_stocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_return_to_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return_to_stocks.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return_to_stocks.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_return_to_stocks.Location = new System.Drawing.Point(437, 170);
            this.btn_return_to_stocks.Name = "btn_return_to_stocks";
            this.btn_return_to_stocks.Size = new System.Drawing.Size(113, 23);
            this.btn_return_to_stocks.TabIndex = 123;
            this.btn_return_to_stocks.Text = "Return To Stocks";
            this.btn_return_to_stocks.UseVisualStyleBackColor = false;
            this.btn_return_to_stocks.Visible = false;
            this.btn_return_to_stocks.Click += new System.EventHandler(this.btn_return_to_stocks_Click);
            // 
            // lbl_return_type
            // 
            this.lbl_return_type.AutoSize = true;
            this.lbl_return_type.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_return_type.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_return_type.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_return_type.Location = new System.Drawing.Point(373, 0);
            this.lbl_return_type.Name = "lbl_return_type";
            this.lbl_return_type.Size = new System.Drawing.Size(0, 21);
            this.lbl_return_type.TabIndex = 124;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_return_type);
            this.panel1.Location = new System.Drawing.Point(415, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 32);
            this.panel1.TabIndex = 125;
            // 
            // chk_select_all
            // 
            this.chk_select_all.AutoSize = true;
            this.chk_select_all.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chk_select_all.Location = new System.Drawing.Point(8, 178);
            this.chk_select_all.Name = "chk_select_all";
            this.chk_select_all.Size = new System.Drawing.Size(71, 17);
            this.chk_select_all.TabIndex = 126;
            this.chk_select_all.Text = "Select all";
            this.chk_select_all.UseVisualStyleBackColor = true;
            // 
            // Stock_Returned
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_select_all);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_return_to_stocks);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbo_srch_type);
            this.Controls.Add(this.lbl_items_count);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.out_amt);
            this.Controls.Add(this.out_qty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.cust_Image);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Cust_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Cust_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Remarks);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_return_list);
            this.Controls.Add(this.txt_Trans_number);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock_Returned";
            this.Text = "Stock_Returned";
            this.Load += new System.EventHandler(this.Stock_Returned_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_return_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshTableToolStripMenuItem;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_return_list;
        private System.Windows.Forms.TextBox txt_Trans_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cust_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Cust_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox cust_Image;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label out_amt;
        private System.Windows.Forms.Label out_qty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem view_main_btn;
        private System.Windows.Forms.ToolStripMenuItem batchTransactionToolStripMenuItem;
        private System.Windows.Forms.Label lbl_items_count;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem printInvoiceToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_srch_type;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.ToolStripMenuItem view_trans_return;
        private System.Windows.Forms.ToolStripMenuItem view_tbl_return;
        private System.Windows.Forms.ToolStripMenuItem batch_trans_return;
        private System.Windows.Forms.ToolStripMenuItem print_trans_return;
        private System.Windows.Forms.ToolStripMenuItem batch_tbl_return;
        private System.Windows.Forms.ToolStripMenuItem print_tbl_return;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem most_brand_return_tool;
        private System.Windows.Forms.ToolStripMenuItem least_brand_return_tool;
        private System.Windows.Forms.ToolStripMenuItem most_product_return_tool;
        private System.Windows.Forms.ToolStripMenuItem least_product_return_tool;
        private System.Windows.Forms.ToolStripMenuItem most_division_return_tool;
        private System.Windows.Forms.ToolStripMenuItem least_division_return_tool;
        private System.Windows.Forms.Button btn_return_to_stocks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_return_type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_select_all;
    }
}