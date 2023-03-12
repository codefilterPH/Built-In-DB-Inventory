namespace Inventory_System02.CommonSql.Reports_Dir.Item_Qty
{
    partial class Edit_QTY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_QTY));
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_qty_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_qty_to = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(182, 237);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 29);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_qty_from
            // 
            this.txt_qty_from.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty_from.Location = new System.Drawing.Point(93, 142);
            this.txt_qty_from.Name = "txt_qty_from";
            this.txt_qty_from.Size = new System.Drawing.Size(120, 35);
            this.txt_qty_from.TabIndex = 0;
            this.txt_qty_from.Text = "0";
            this.txt_qty_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qty_from.TextChanged += new System.EventHandler(this.txt_qty_from_TextChanged);
            this.txt_qty_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_from_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "QUANTITY RANGE";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "To";
            // 
            // txt_qty_to
            // 
            this.txt_qty_to.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty_to.Location = new System.Drawing.Point(252, 142);
            this.txt_qty_to.Name = "txt_qty_to";
            this.txt_qty_to.Size = new System.Drawing.Size(120, 35);
            this.txt_qty_to.TabIndex = 1;
            this.txt_qty_to.Text = "0";
            this.txt_qty_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qty_to.TextChanged += new System.EventHandler(this.txt_qty_to_TextChanged);
            this.txt_qty_to.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qty_to_KeyDown);
            this.txt_qty_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_from_KeyPress);
            // 
            // Edit_QTY
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(472, 316);
            this.Controls.Add(this.txt_qty_to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_qty_from);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(488, 355);
            this.Name = "Edit_QTY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Form";
            this.Load += new System.EventHandler(this.Edit_QTY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_qty_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_qty_to;
    }
}