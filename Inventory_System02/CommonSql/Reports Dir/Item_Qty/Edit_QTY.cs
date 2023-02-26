﻿using Inventory_System02.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System02.CommonSql.Reports_Dir.Item_Qty
{
    public partial class Edit_QTY : Form
    {
        public int from_qty { get; set; }
        public int to_qty { get; set; }

        public Edit_QTY()
        {
            InitializeComponent();
        }

        private void Edit_QTY_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace( txt_qty_from.Text ) || txt_qty_from.Text != "0" && !string.IsNullOrWhiteSpace(txt_qty_to.Text) || txt_qty_to.Text != "0" )
            {
                from_qty = Convert.ToInt32(txt_qty_from.Text);
                to_qty = Convert.ToInt32(txt_qty_to.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void txt_qty_to_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 btn_ok_Click(sender, e);
            }
        }

        private void txt_qty_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            usableFunction func = new usableFunction();
            func.Make_Numeric_Only(sender, e);
        }
    }
}
