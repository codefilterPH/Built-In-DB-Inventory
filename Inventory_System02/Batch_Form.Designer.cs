using AxAcroPDFLib;

namespace Inventory_System02
{
    partial class Batch_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Batch_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adobe_show = new System.Windows.Forms.Panel();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chk_Select_all = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.inboundFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboundTransToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outboundTransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboundReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outboundReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.adobe_show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "MY BATCHED DOCUMENTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 47);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(642, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 47);
            this.panel2.TabIndex = 0;
            // 
            // adobe_show
            // 
            this.adobe_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adobe_show.Controls.Add(this.axAcroPDF1);
            this.adobe_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adobe_show.Location = new System.Drawing.Point(361, 49);
            this.adobe_show.Name = "adobe_show";
            this.adobe_show.Size = new System.Drawing.Size(439, 401);
            this.adobe_show.TabIndex = 2;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(437, 399);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.chk_Select_all);
            this.panel5.Controls.Add(this.menuStrip1);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(361, 401);
            this.panel5.TabIndex = 3;
            // 
            // chk_Select_all
            // 
            this.chk_Select_all.AutoSize = true;
            this.chk_Select_all.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Select_all.Location = new System.Drawing.Point(3, 27);
            this.chk_Select_all.Name = "chk_Select_all";
            this.chk_Select_all.Size = new System.Drawing.Size(74, 19);
            this.chk_Select_all.TabIndex = 5;
            this.chk_Select_all.Text = "Select All";
            this.chk_Select_all.UseVisualStyleBackColor = true;
            this.chk_Select_all.CheckedChanged += new System.EventHandler(this.chk_Select_all_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allItemsToolStripMenuItem,
            this.btn_Delete,
            this.inboundFilesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allItemsToolStripMenuItem
            // 
            this.allItemsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.allItemsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.allItemsToolStripMenuItem.Name = "allItemsToolStripMenuItem";
            this.allItemsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.allItemsToolStripMenuItem.Text = "All Items";
            this.allItemsToolStripMenuItem.Click += new System.EventHandler(this.allItemsToolStripMenuItem_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(68, 20);
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // inboundFilesToolStripMenuItem
            // 
            this.inboundFilesToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.inboundFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inboundTransToolStripMenuItem1,
            this.outboundTransToolStripMenuItem,
            this.returnTransactionsToolStripMenuItem});
            this.inboundFilesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inboundFilesToolStripMenuItem.Name = "inboundFilesToolStripMenuItem";
            this.inboundFilesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.inboundFilesToolStripMenuItem.Text = "Transactions";
            // 
            // inboundTransToolStripMenuItem1
            // 
            this.inboundTransToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.inboundTransToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.inboundTransToolStripMenuItem1.Name = "inboundTransToolStripMenuItem1";
            this.inboundTransToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.inboundTransToolStripMenuItem1.Text = "Inbound Transactions";
            this.inboundTransToolStripMenuItem1.Click += new System.EventHandler(this.inboundTransToolStripMenuItem1_Click);
            // 
            // outboundTransToolStripMenuItem
            // 
            this.outboundTransToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outboundTransToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.outboundTransToolStripMenuItem.Name = "outboundTransToolStripMenuItem";
            this.outboundTransToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.outboundTransToolStripMenuItem.Text = "Outbound Transactions";
            this.outboundTransToolStripMenuItem.Click += new System.EventHandler(this.outboundTransToolStripMenuItem_Click);
            // 
            // returnTransactionsToolStripMenuItem
            // 
            this.returnTransactionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.returnTransactionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.returnTransactionsToolStripMenuItem.Name = "returnTransactionsToolStripMenuItem";
            this.returnTransactionsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.returnTransactionsToolStripMenuItem.Text = "Return Transactions";
            this.returnTransactionsToolStripMenuItem.Click += new System.EventHandler(this.returnTransactionsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.supplierReportToolStripMenuItem,
            this.customerReportToolStripMenuItem,
            this.employeeReportToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inboundReportToolStripMenuItem,
            this.outboundReportToolStripMenuItem,
            this.returnReportToolStripMenuItem});
            this.itemToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.itemToolStripMenuItem.Text = "Item Report";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // inboundReportToolStripMenuItem
            // 
            this.inboundReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inboundReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inboundReportToolStripMenuItem.Name = "inboundReportToolStripMenuItem";
            this.inboundReportToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.inboundReportToolStripMenuItem.Text = "Inbound Report";
            this.inboundReportToolStripMenuItem.Click += new System.EventHandler(this.inboundReportToolStripMenuItem_Click);
            // 
            // outboundReportToolStripMenuItem
            // 
            this.outboundReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outboundReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.outboundReportToolStripMenuItem.Name = "outboundReportToolStripMenuItem";
            this.outboundReportToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.outboundReportToolStripMenuItem.Text = "Outbound Report";
            this.outboundReportToolStripMenuItem.Click += new System.EventHandler(this.outboundReportToolStripMenuItem_Click);
            // 
            // returnReportToolStripMenuItem
            // 
            this.returnReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnReportToolStripMenuItem.Name = "returnReportToolStripMenuItem";
            this.returnReportToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.returnReportToolStripMenuItem.Text = "Return Report";
            this.returnReportToolStripMenuItem.Click += new System.EventHandler(this.returnReportToolStripMenuItem_Click);
            // 
            // supplierReportToolStripMenuItem
            // 
            this.supplierReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplierReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.supplierReportToolStripMenuItem.Name = "supplierReportToolStripMenuItem";
            this.supplierReportToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.supplierReportToolStripMenuItem.Text = "Supplier Report";
            this.supplierReportToolStripMenuItem.Click += new System.EventHandler(this.supplierReportToolStripMenuItem_Click);
            // 
            // customerReportToolStripMenuItem
            // 
            this.customerReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.customerReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerReportToolStripMenuItem.Name = "customerReportToolStripMenuItem";
            this.customerReportToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.customerReportToolStripMenuItem.Text = "Customer Report";
            this.customerReportToolStripMenuItem.Click += new System.EventHandler(this.customerReportToolStripMenuItem_Click);
            // 
            // employeeReportToolStripMenuItem
            // 
            this.employeeReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.employeeReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.employeeReportToolStripMenuItem.Text = "Employee Report";
            this.employeeReportToolStripMenuItem.Click += new System.EventHandler(this.employeeReportToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(353, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // Batch_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adobe_show);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Batch_Form";
            this.Text = "Batch_Form";
            this.Load += new System.EventHandler(this.Batch_Form_Load);
            this.panel1.ResumeLayout(false);
            this.adobe_show.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel adobe_show;
        private System.Windows.Forms.Panel panel5;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.CheckBox chk_Select_all;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Delete;
        private System.Windows.Forms.ToolStripMenuItem inboundFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboundTransToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outboundTransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboundReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outboundReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnReportToolStripMenuItem;
    }
}