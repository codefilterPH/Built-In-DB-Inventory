
namespace Inventory_System02
{
    partial class StockOutList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOutList));
            this.dtg_outlist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_print_invoice = new System.Windows.Forms.ToolStripMenuItem();
            this.batchTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Trans_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.out_amt = new System.Windows.Forms.Label();
            this.out_qty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cust_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cust_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cust_Image = new System.Windows.Forms.PictureBox();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.lbl_items_count = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_srch_type = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_outlist)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_outlist
            // 
            this.dtg_outlist.AllowUserToAddRows = false;
            this.dtg_outlist.AllowUserToDeleteRows = false;
            this.dtg_outlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_outlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_outlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_outlist.GridColor = System.Drawing.Color.White;
            this.dtg_outlist.Location = new System.Drawing.Point(12, 192);
            this.dtg_outlist.Name = "dtg_outlist";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_outlist.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_outlist.RowTemplate.Height = 60;
            this.dtg_outlist.Size = new System.Drawing.Size(783, 214);
            this.dtg_outlist.TabIndex = 0;
            this.dtg_outlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(57, 137);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(121, 22);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Location = new System.Drawing.Point(645, 165);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 23);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "By transaction delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshTableToolStripMenuItem,
            this.btn_print_invoice,
            this.batchTransactionToolStripMenuItem,
            this.printInvoiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 82;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshTableToolStripMenuItem
            // 
            this.refreshTableToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.refreshTableToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refreshTableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshTableToolStripMenuItem.Image")));
            this.refreshTableToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            this.refreshTableToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.refreshTableToolStripMenuItem.Text = "Refresh Table";
            this.refreshTableToolStripMenuItem.Click += new System.EventHandler(this.refreshTableToolStripMenuItem_Click);
            // 
            // btn_print_invoice
            // 
            this.btn_print_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_print_invoice.ForeColor = System.Drawing.Color.White;
            this.btn_print_invoice.Image = ((System.Drawing.Image)(resources.GetObject("btn_print_invoice.Image")));
            this.btn_print_invoice.Name = "btn_print_invoice";
            this.btn_print_invoice.Size = new System.Drawing.Size(105, 20);
            this.btn_print_invoice.Text = "Show Invoice";
            this.btn_print_invoice.Click += new System.EventHandler(this.btn_print_invoice_Click);
            // 
            // batchTransactionToolStripMenuItem
            // 
            this.batchTransactionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.batchTransactionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.batchTransactionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("batchTransactionToolStripMenuItem.Image")));
            this.batchTransactionToolStripMenuItem.Name = "batchTransactionToolStripMenuItem";
            this.batchTransactionToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.batchTransactionToolStripMenuItem.Text = "Batch Transaction";
            this.batchTransactionToolStripMenuItem.Click += new System.EventHandler(this.batchTransactionToolStripMenuItem_Click);
            // 
            // printInvoiceToolStripMenuItem
            // 
            this.printInvoiceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.printInvoiceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInvoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printInvoiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printInvoiceToolStripMenuItem.Image")));
            this.printInvoiceToolStripMenuItem.Name = "printInvoiceToolStripMenuItem";
            this.printInvoiceToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.printInvoiceToolStripMenuItem.Text = "Print Invoice";
            this.printInvoiceToolStripMenuItem.Click += new System.EventHandler(this.printInvoiceToolStripMenuItem_Click);
            // 
            // txt_Trans_number
            // 
            this.txt_Trans_number.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Trans_number.Location = new System.Drawing.Point(155, 34);
            this.txt_Trans_number.Name = "txt_Trans_number";
            this.txt_Trans_number.Size = new System.Drawing.Size(121, 25);
            this.txt_Trans_number.TabIndex = 84;
            this.txt_Trans_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Trans_number_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Current Transaction #";
            // 
            // out_amt
            // 
            this.out_amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.out_amt.AutoSize = true;
            this.out_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_amt.Location = new System.Drawing.Point(656, 435);
            this.out_amt.Name = "out_amt";
            this.out_amt.Size = new System.Drawing.Size(0, 13);
            this.out_amt.TabIndex = 90;
            // 
            // out_qty
            // 
            this.out_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.out_qty.AutoSize = true;
            this.out_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_qty.Location = new System.Drawing.Point(656, 420);
            this.out_qty.Name = "out_qty";
            this.out_qty.Size = new System.Drawing.Size(0, 13);
            this.out_qty.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Total Amount:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(549, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Over All Quantity:";
            // 
            // txt_address
            // 
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address.Location = new System.Drawing.Point(399, 65);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_address.Size = new System.Drawing.Size(271, 53);
            this.txt_address.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "Ship To";
            // 
            // txt_Cust_name
            // 
            this.txt_Cust_name.Location = new System.Drawing.Point(399, 34);
            this.txt_Cust_name.Name = "txt_Cust_name";
            this.txt_Cust_name.Size = new System.Drawing.Size(271, 25);
            this.txt_Cust_name.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 110;
            this.label3.Text = "Customer Name";
            // 
            // txt_Cust_ID
            // 
            this.txt_Cust_ID.Location = new System.Drawing.Point(155, 65);
            this.txt_Cust_ID.Name = "txt_Cust_ID";
            this.txt_Cust_ID.Size = new System.Drawing.Size(121, 25);
            this.txt_Cust_ID.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Customer ID";
            // 
            // cust_Image
            // 
            this.cust_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cust_Image.BackColor = System.Drawing.Color.Transparent;
            this.cust_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cust_Image.Location = new System.Drawing.Point(676, 34);
            this.cust_Image.Name = "cust_Image";
            this.cust_Image.Size = new System.Drawing.Size(119, 97);
            this.cust_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cust_Image.TabIndex = 114;
            this.cust_Image.TabStop = false;
            // 
            // chk_all
            // 
            this.chk_all.AutoSize = true;
            this.chk_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_all.Location = new System.Drawing.Point(11, 165);
            this.chk_all.Name = "chk_all";
            this.chk_all.Size = new System.Drawing.Size(76, 19);
            this.chk_all.TabIndex = 115;
            this.chk_all.Text = "Select All";
            this.chk_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_all.UseVisualStyleBackColor = true;
            this.chk_all.CheckedChanged += new System.EventHandler(this.chk_all_CheckedChanged);
            // 
            // lbl_items_count
            // 
            this.lbl_items_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_items_count.AutoSize = true;
            this.lbl_items_count.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_items_count.Location = new System.Drawing.Point(75, 420);
            this.lbl_items_count.Name = "lbl_items_count";
            this.lbl_items_count.Size = new System.Drawing.Size(0, 13);
            this.lbl_items_count.TabIndex = 117;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 420);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 116;
            this.label16.Text = "Total Item:";
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DueDate.ForeColor = System.Drawing.Color.Red;
            this.lbl_DueDate.Location = new System.Drawing.Point(14, 94);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(0, 21);
            this.lbl_DueDate.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(186, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Search by";
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
            this.cbo_srch_type.Location = new System.Drawing.Point(248, 139);
            this.cbo_srch_type.Name = "cbo_srch_type";
            this.cbo_srch_type.Size = new System.Drawing.Size(93, 21);
            this.cbo_srch_type.TabIndex = 119;
            this.cbo_srch_type.Text = "Trans Ref";
            // 
            // StockOutList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 462);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_srch_type);
            this.Controls.Add(this.lbl_DueDate);
            this.Controls.Add(this.lbl_items_count);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chk_all);
            this.Controls.Add(this.cust_Image);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Cust_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Cust_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.out_amt);
            this.Controls.Add(this.out_qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Trans_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_outlist);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockOutList";
            this.Text = "StockOutList";
            this.Load += new System.EventHandler(this.StockOutList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_outlist)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_outlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshTableToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Trans_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label out_amt;
        private System.Windows.Forms.Label out_qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cust_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cust_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox cust_Image;
        private System.Windows.Forms.ToolStripMenuItem btn_print_invoice;
        private System.Windows.Forms.CheckBox chk_all;
        private System.Windows.Forms.ToolStripMenuItem batchTransactionToolStripMenuItem;
        private System.Windows.Forms.Label lbl_items_count;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.ToolStripMenuItem printInvoiceToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_srch_type;
    }
}