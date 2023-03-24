
namespace Inventory_System02
{
    partial class StockReturned
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReturned));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cust_Image = new System.Windows.Forms.PictureBox();
            this.btn_Clear_Text = new System.Windows.Forms.Button();
            this.txt_CustAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CustName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CustID = new System.Windows.Forms.TextBox();
            this.btn_searchStocks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TransRefOut = new System.Windows.Forms.TextBox();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_view = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cbo_srch_type = new System.Windows.Forms.ComboBox();
            this.lbl_stoksout_qty = new System.Windows.Forms.Label();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.btn_sup_add = new System.Windows.Forms.Button();
            this.dtg_Items = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.out_qty = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Reasons = new System.Windows.Forms.ComboBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_numb_items_return = new System.Windows.Forms.Label();
            this.chk_all2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtg_Return = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoun11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sup_delete = new System.Windows.Forms.Button();
            this.out_amt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_StockReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bworker_return = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Items)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Return)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cust_Image);
            this.panel1.Controls.Add(this.btn_Clear_Text);
            this.panel1.Controls.Add(this.txt_CustAddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_CustName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_CustID);
            this.panel1.Controls.Add(this.btn_searchStocks);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_TransRefOut);
            this.panel1.Location = new System.Drawing.Point(4, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 103);
            this.panel1.TabIndex = 0;
            // 
            // cust_Image
            // 
            this.cust_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cust_Image.Location = new System.Drawing.Point(702, 35);
            this.cust_Image.Name = "cust_Image";
            this.cust_Image.Size = new System.Drawing.Size(70, 57);
            this.cust_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cust_Image.TabIndex = 45;
            this.cust_Image.TabStop = false;
            // 
            // btn_Clear_Text
            // 
            this.btn_Clear_Text.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear_Text.BackgroundImage")));
            this.btn_Clear_Text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear_Text.Location = new System.Drawing.Point(396, 7);
            this.btn_Clear_Text.Name = "btn_Clear_Text";
            this.btn_Clear_Text.Size = new System.Drawing.Size(27, 23);
            this.btn_Clear_Text.TabIndex = 43;
            this.btn_Clear_Text.UseVisualStyleBackColor = true;
            this.btn_Clear_Text.Click += new System.EventHandler(this.btn_Clear_Text_Click);
            // 
            // txt_CustAddress
            // 
            this.txt_CustAddress.Location = new System.Drawing.Point(354, 38);
            this.txt_CustAddress.Multiline = true;
            this.txt_CustAddress.Name = "txt_CustAddress";
            this.txt_CustAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_CustAddress.Size = new System.Drawing.Size(331, 54);
            this.txt_CustAddress.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // txt_CustName
            // 
            this.txt_CustName.Location = new System.Drawing.Point(119, 67);
            this.txt_CustName.Name = "txt_CustName";
            this.txt_CustName.Size = new System.Drawing.Size(167, 25);
            this.txt_CustName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(601, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "OUTBOUND ITEMS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Division Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Division ID";
            // 
            // txt_CustID
            // 
            this.txt_CustID.Location = new System.Drawing.Point(119, 38);
            this.txt_CustID.Name = "txt_CustID";
            this.txt_CustID.Size = new System.Drawing.Size(167, 25);
            this.txt_CustID.TabIndex = 2;
            // 
            // btn_searchStocks
            // 
            this.btn_searchStocks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchStocks.BackgroundImage")));
            this.btn_searchStocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_searchStocks.Location = new System.Drawing.Point(364, 7);
            this.btn_searchStocks.Name = "btn_searchStocks";
            this.btn_searchStocks.Size = new System.Drawing.Size(32, 23);
            this.btn_searchStocks.TabIndex = 0;
            this.btn_searchStocks.UseVisualStyleBackColor = true;
            this.btn_searchStocks.Click += new System.EventHandler(this.btn_searchStocks_Click);
            this.btn_searchStocks.MouseHover += new System.EventHandler(this.btn_searchStocks_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Transaction Reference";
            // 
            // txt_TransRefOut
            // 
            this.txt_TransRefOut.Location = new System.Drawing.Point(191, 7);
            this.txt_TransRefOut.Name = "txt_TransRefOut";
            this.txt_TransRefOut.Size = new System.Drawing.Size(167, 25);
            this.txt_TransRefOut.TabIndex = 1;
            this.txt_TransRefOut.TextChanged += new System.EventHandler(this.txt_TransRefOut_TextChanged);
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DueDate.ForeColor = System.Drawing.Color.Red;
            this.lbl_DueDate.Location = new System.Drawing.Point(16, 505);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(0, 21);
            this.lbl_DueDate.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(63, 3);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(110, 25);
            this.txt_Search.TabIndex = 14;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_view);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cbo_srch_type);
            this.panel2.Controls.Add(this.lbl_stoksout_qty);
            this.panel2.Controls.Add(this.chk_all);
            this.panel2.Controls.Add(this.btn_sup_add);
            this.panel2.Controls.Add(this.dtg_Items);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 168);
            this.panel2.TabIndex = 1;
            // 
            // btn_view
            // 
            this.btn_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view.BackColor = System.Drawing.Color.SlateGray;
            this.btn_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Location = new System.Drawing.Point(514, 25);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(133, 23);
            this.btn_view.TabIndex = 7;
            this.btn_view.Text = "View item";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(180, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 97;
            this.label16.Text = "By";
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
            this.cbo_srch_type.Location = new System.Drawing.Point(204, 6);
            this.cbo_srch_type.Name = "cbo_srch_type";
            this.cbo_srch_type.Size = new System.Drawing.Size(93, 21);
            this.cbo_srch_type.TabIndex = 15;
            this.cbo_srch_type.Text = "Name";
            this.cbo_srch_type.SelectedIndexChanged += new System.EventHandler(this.cbo_srch_type_SelectedIndexChanged);
            // 
            // lbl_stoksout_qty
            // 
            this.lbl_stoksout_qty.AutoSize = true;
            this.lbl_stoksout_qty.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_stoksout_qty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stoksout_qty.Location = new System.Drawing.Point(786, 0);
            this.lbl_stoksout_qty.Name = "lbl_stoksout_qty";
            this.lbl_stoksout_qty.Size = new System.Drawing.Size(0, 13);
            this.lbl_stoksout_qty.TabIndex = 83;
            // 
            // chk_all
            // 
            this.chk_all.AutoSize = true;
            this.chk_all.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_all.Location = new System.Drawing.Point(4, 31);
            this.chk_all.Name = "chk_all";
            this.chk_all.Size = new System.Drawing.Size(71, 17);
            this.chk_all.TabIndex = 6;
            this.chk_all.Text = "Select all";
            this.chk_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_all.UseVisualStyleBackColor = true;
            this.chk_all.CheckedChanged += new System.EventHandler(this.chk_all_CheckedChanged);
            // 
            // btn_sup_add
            // 
            this.btn_sup_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_add.BackColor = System.Drawing.Color.SlateGray;
            this.btn_sup_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_add.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_sup_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sup_add.Location = new System.Drawing.Point(653, 25);
            this.btn_sup_add.Name = "btn_sup_add";
            this.btn_sup_add.Size = new System.Drawing.Size(130, 23);
            this.btn_sup_add.TabIndex = 8;
            this.btn_sup_add.Text = "Add selected below";
            this.btn_sup_add.UseVisualStyleBackColor = false;
            this.btn_sup_add.Click += new System.EventHandler(this.btn_sup_add_Click);
            // 
            // dtg_Items
            // 
            this.dtg_Items.AllowUserToAddRows = false;
            this.dtg_Items.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtg_Items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Items.EnableHeadersVisualStyles = false;
            this.dtg_Items.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_Items.Location = new System.Drawing.Point(3, 50);
            this.dtg_Items.Name = "dtg_Items";
            this.dtg_Items.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Items.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Items.RowTemplate.Height = 40;
            this.dtg_Items.Size = new System.Drawing.Size(780, 104);
            this.dtg_Items.TabIndex = 5;
            this.dtg_Items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Items_CellClick);
            this.dtg_Items.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Items_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.stockOutListToolStripMenuItem,
            this.customerListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.refreshToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.ToolTipText = "Reload table";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // stockOutListToolStripMenuItem
            // 
            this.stockOutListToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.stockOutListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stockOutListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockOutListToolStripMenuItem.Image")));
            this.stockOutListToolStripMenuItem.Name = "stockOutListToolStripMenuItem";
            this.stockOutListToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.stockOutListToolStripMenuItem.Text = "Stock Out List";
            this.stockOutListToolStripMenuItem.Click += new System.EventHandler(this.stockOutListToolStripMenuItem_Click);
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txt_remarks);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.out_qty);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_Reasons);
            this.panel3.Controls.Add(this.btn_edit);
            this.panel3.Controls.Add(this.lbl_numb_items_return);
            this.panel3.Controls.Add(this.chk_all2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dtg_Return);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btn_sup_delete);
            this.panel3.Location = new System.Drawing.Point(4, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 197);
            this.panel3.TabIndex = 2;
            // 
            // txt_remarks
            // 
            this.txt_remarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_remarks.Location = new System.Drawing.Point(493, 159);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remarks.Size = new System.Drawing.Size(291, 35);
            this.txt_remarks.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(436, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 93;
            this.label11.Text = "Remarks";
            // 
            // out_qty
            // 
            this.out_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.out_qty.AutoSize = true;
            this.out_qty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.out_qty.Location = new System.Drawing.Point(172, 160);
            this.out_qty.Name = "out_qty";
            this.out_qty.Size = new System.Drawing.Size(18, 18);
            this.out_qty.TabIndex = 85;
            this.out_qty.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(4, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 18);
            this.label9.TabIndex = 83;
            this.label9.Text = "Total Quantity:";
            // 
            // txt_Reasons
            // 
            this.txt_Reasons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Reasons.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reasons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Reasons.FormattingEnabled = true;
            this.txt_Reasons.Items.AddRange(new object[] {
            "Manufacturing Defect ( Sent back to suppliers )",
            "Damage ( Investigated or Repair )",
            "Return to Stocks"});
            this.txt_Reasons.Location = new System.Drawing.Point(248, 27);
            this.txt_Reasons.Name = "txt_Reasons";
            this.txt_Reasons.Size = new System.Drawing.Size(258, 21);
            this.txt_Reasons.TabIndex = 92;
            this.txt_Reasons.Text = "Return to Stocks";
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.BackColor = System.Drawing.Color.SlateGray;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(514, 26);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(131, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Edit selection";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_numb_items_return
            // 
            this.lbl_numb_items_return.AutoSize = true;
            this.lbl_numb_items_return.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_numb_items_return.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numb_items_return.Location = new System.Drawing.Point(786, 0);
            this.lbl_numb_items_return.Name = "lbl_numb_items_return";
            this.lbl_numb_items_return.Size = new System.Drawing.Size(0, 13);
            this.lbl_numb_items_return.TabIndex = 91;
            // 
            // chk_all2
            // 
            this.chk_all2.AutoSize = true;
            this.chk_all2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_all2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_all2.Location = new System.Drawing.Point(5, 34);
            this.chk_all2.Name = "chk_all2";
            this.chk_all2.Size = new System.Drawing.Size(71, 17);
            this.chk_all2.TabIndex = 13;
            this.chk_all2.Text = "Select all";
            this.chk_all2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_all2.UseVisualStyleBackColor = true;
            this.chk_all2.CheckedChanged += new System.EventHandler(this.chk_all2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(175, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 89;
            this.label10.Text = "Return Type";
            // 
            // dtg_Return
            // 
            this.dtg_Return.AllowUserToAddRows = false;
            this.dtg_Return.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_Return.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Return.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Return.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Return.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Return.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.ItemName,
            this.Brand,
            this.Description,
            this.Quantity,
            this.price111,
            this.amoun11});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Return.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtg_Return.Location = new System.Drawing.Point(5, 53);
            this.dtg_Return.Name = "dtg_Return";
            this.dtg_Return.ReadOnly = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_Return.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtg_Return.Size = new System.Drawing.Size(778, 103);
            this.dtg_Return.TabIndex = 9;
            this.dtg_Return.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Return_CellClick);
            this.dtg_Return.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Return_CellEndEdit);
            this.dtg_Return.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Return_CellEndEdit);
            this.dtg_Return.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtg_Return_EditingControlShowing);
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
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 97;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 81;
            // 
            // price111
            // 
            this.price111.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.price111.DefaultCellStyle = dataGridViewCellStyle7;
            this.price111.HeaderText = "Price";
            this.price111.Name = "price111";
            this.price111.ReadOnly = true;
            this.price111.Width = 61;
            // 
            // amoun11
            // 
            this.amoun11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.amoun11.DefaultCellStyle = dataGridViewCellStyle8;
            this.amoun11.HeaderText = "Amount";
            this.amoun11.Name = "amoun11";
            this.amoun11.ReadOnly = true;
            this.amoun11.Width = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(-2, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "STOCKS TO RETURN";
            // 
            // btn_sup_delete
            // 
            this.btn_sup_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_delete.BackColor = System.Drawing.Color.SlateGray;
            this.btn_sup_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sup_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sup_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_sup_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sup_delete.Location = new System.Drawing.Point(653, 26);
            this.btn_sup_delete.Name = "btn_sup_delete";
            this.btn_sup_delete.Size = new System.Drawing.Size(130, 23);
            this.btn_sup_delete.TabIndex = 11;
            this.btn_sup_delete.Text = "Remove selected";
            this.btn_sup_delete.UseVisualStyleBackColor = false;
            this.btn_sup_delete.Click += new System.EventHandler(this.btn_sup_delete_Click);
            // 
            // out_amt
            // 
            this.out_amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.out_amt.AutoSize = true;
            this.out_amt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_amt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.out_amt.Location = new System.Drawing.Point(176, 482);
            this.out_amt.Name = "out_amt";
            this.out_amt.Size = new System.Drawing.Size(18, 18);
            this.out_amt.TabIndex = 86;
            this.out_amt.Text = "0";
            this.out_amt.TextChanged += new System.EventHandler(this.out_amt_TextChanged);
            this.out_amt.Click += new System.EventHandler(this.out_amt_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(8, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 84;
            this.label5.Text = "Total Amount:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_StockReturn,
            this.previewToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 502);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(794, 29);
            this.menuStrip2.TabIndex = 17;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btn_StockReturn
            // 
            this.btn_StockReturn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_StockReturn.BackColor = System.Drawing.Color.Green;
            this.btn_StockReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StockReturn.ForeColor = System.Drawing.Color.White;
            this.btn_StockReturn.Image = ((System.Drawing.Image)(resources.GetObject("btn_StockReturn.Image")));
            this.btn_StockReturn.Name = "btn_StockReturn";
            this.btn_StockReturn.Size = new System.Drawing.Size(132, 25);
            this.btn_StockReturn.Text = "Return Stock";
            this.btn_StockReturn.Click += new System.EventHandler(this.btn_StockReturn_Click);
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
            // bworker_return
            // 
            this.bworker_return.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bworker_return_DoWork);
            this.bworker_return.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bworker_return_RunWorkerCompleted);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // StockReturned
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 531);
            this.Controls.Add(this.lbl_DueDate);
            this.Controls.Add(this.out_amt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StockReturned";
            this.Text = "StockReturned";
            this.Load += new System.EventHandler(this.StockReturned_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Items)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Return)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtg_Items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockOutListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TransRefOut;
        private System.Windows.Forms.Button btn_searchStocks;
        private System.Windows.Forms.TextBox txt_CustAddress;
        private System.Windows.Forms.TextBox txt_CustName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CustID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_sup_add;
        private System.Windows.Forms.Button btn_sup_delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem btn_StockReturn;
        private System.Windows.Forms.DataGridView dtg_Return;
        private System.Windows.Forms.Button btn_Clear_Text;
        private System.Windows.Forms.Label out_amt;
        private System.Windows.Forms.Label out_qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.PictureBox cust_Image;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chk_all;
        private System.Windows.Forms.CheckBox chk_all2;
        private System.Windows.Forms.Label lbl_stoksout_qty;
        private System.Windows.Forms.Label lbl_numb_items_return;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbo_srch_type;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.ComponentModel.BackgroundWorker bworker_return;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox txt_Reasons;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price111;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoun11;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
    }
}