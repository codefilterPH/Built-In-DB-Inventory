
namespace Inventory_System02
{
    partial class Reports_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports_MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemByQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBySupplierDivisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report_panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemListToolStripMenuItem,
            this.employeeListToolStripMenuItem,
            this.customerReportsToolStripMenuItem,
            this.supplierReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemListToolStripMenuItem
            // 
            this.itemListToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.itemListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemByQuantityToolStripMenuItem,
            this.itemBySupplierDivisionToolStripMenuItem});
            this.itemListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.itemListToolStripMenuItem.Name = "itemListToolStripMenuItem";
            this.itemListToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.itemListToolStripMenuItem.Text = "Item Reports";
            this.itemListToolStripMenuItem.Click += new System.EventHandler(this.itemListToolStripMenuItem_Click);
            // 
            // itemByQuantityToolStripMenuItem
            // 
            this.itemByQuantityToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.itemByQuantityToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.itemByQuantityToolStripMenuItem.Name = "itemByQuantityToolStripMenuItem";
            this.itemByQuantityToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.itemByQuantityToolStripMenuItem.Text = "Item By Quantity";
            this.itemByQuantityToolStripMenuItem.Click += new System.EventHandler(this.itemByQuantityToolStripMenuItem_Click);
            // 
            // itemBySupplierDivisionToolStripMenuItem
            // 
            this.itemBySupplierDivisionToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.itemBySupplierDivisionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.itemBySupplierDivisionToolStripMenuItem.Name = "itemBySupplierDivisionToolStripMenuItem";
            this.itemBySupplierDivisionToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.itemBySupplierDivisionToolStripMenuItem.Text = "Item By Supplier/Division";
            this.itemBySupplierDivisionToolStripMenuItem.Click += new System.EventHandler(this.itemBySupplierDivisionToolStripMenuItem_Click);
            // 
            // employeeListToolStripMenuItem
            // 
            this.employeeListToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.employeeListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            this.employeeListToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.employeeListToolStripMenuItem.Text = "Employee Reports";
            this.employeeListToolStripMenuItem.Click += new System.EventHandler(this.employeeListToolStripMenuItem_Click);
            // 
            // customerReportsToolStripMenuItem
            // 
            this.customerReportsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.customerReportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerReportsToolStripMenuItem.Name = "customerReportsToolStripMenuItem";
            this.customerReportsToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.customerReportsToolStripMenuItem.Text = "Customer Reports";
            this.customerReportsToolStripMenuItem.Click += new System.EventHandler(this.customerReportsToolStripMenuItem_Click);
            // 
            // supplierReportsToolStripMenuItem
            // 
            this.supplierReportsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.supplierReportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.supplierReportsToolStripMenuItem.Name = "supplierReportsToolStripMenuItem";
            this.supplierReportsToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.supplierReportsToolStripMenuItem.Text = "Supplier Reports";
            this.supplierReportsToolStripMenuItem.Click += new System.EventHandler(this.supplierReportsToolStripMenuItem_Click);
            // 
            // report_panel
            // 
            this.report_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_panel.Location = new System.Drawing.Point(7, 29);
            this.report_panel.Name = "report_panel";
            this.report_panel.Size = new System.Drawing.Size(781, 411);
            this.report_panel.TabIndex = 1;
            // 
            // Reports_MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report_panel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reports_MainForm";
            this.Text = "Reports_MainForm";
            this.Load += new System.EventHandler(this.Reports_MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierReportsToolStripMenuItem;
        private System.Windows.Forms.Panel report_panel;
        private System.Windows.Forms.ToolStripMenuItem itemByQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemBySupplierDivisionToolStripMenuItem;
    }
}