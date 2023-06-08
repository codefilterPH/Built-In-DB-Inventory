using Inventory_System02.Includes;
using System;
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
            if (txt_qty_from.Text != "" || txt_qty_to.Text != "")
            {
                if (!string.IsNullOrWhiteSpace(txt_qty_from.Text) || txt_qty_from.Text != "0" && !string.IsNullOrWhiteSpace(txt_qty_to.Text) || txt_qty_to.Text != "0")
                {
                    from_qty = Convert.ToInt32(txt_qty_from.Text);
                    to_qty = Convert.ToInt32(txt_qty_to.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
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
            func.KeyPress_Textbox_NumbersOnlyNoDot(sender, e);
        }

        private void txt_qty_from_TextChanged(object sender, EventArgs e)
        {
            txt_qty_from.Text = txt_qty_from.Text.Replace(".", "");
        }

        private void txt_qty_to_TextChanged(object sender, EventArgs e)
        {
            txt_qty_to.Text = txt_qty_to.Text.Replace(".", "");
        }
    }
}
