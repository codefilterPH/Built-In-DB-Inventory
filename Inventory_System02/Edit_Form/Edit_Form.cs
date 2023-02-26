using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System02.Includes;

namespace Inventory_System02.Edit_Form
{
    public partial class Edit_Form : Form
    {
        public string MyData_qty { get; set; }
        int quantity = 0;
        string item_name = string.Empty;
        public Edit_Form(string name, int qty)
        {
            InitializeComponent();
            item_name = name;
            quantity = qty;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            MyData_qty = txt_qty.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void Edit_Form_Load(object sender, EventArgs e)
        {
            txt_qty.Text = quantity.ToString();
            lbl_name.Text = item_name;
        }

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                btn_ok_Click(sender, e);
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            usableFunction func = new usableFunction();
            func.Make_Numeric_Only(sender,e);
        }
    }
}
