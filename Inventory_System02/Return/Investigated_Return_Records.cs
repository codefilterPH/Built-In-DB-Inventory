using Inventory_System02.Includes;
using System;
using System.Windows.Forms;

namespace Inventory_System02.Return
{
    public partial class Investigated_Return_Records : Form
    {
        string sql, Global_ID, Fullname, JobRole;
        public Investigated_Return_Records(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }
        SQLConfig config = new SQLConfig();
        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //list of returned damaged items
            sql = "SELECT * FROM `Returned to Stocks` ORDER BY `Entry Date` DESC";
            config.Load_DTG(sql, dtg_return_list);
            DTG_Properties();
            Calculate();
        }

        private void Investigated_Return_Records_Load(object sender, EventArgs e)
        {
            refreshTableToolStripMenuItem_Click(sender, e);
        }
        private void DTG_Properties()
        {
            if (dtg_return_list.Columns.Count >= 1)
            {
                dtg_return_list.Columns[0].Visible = false;
            }
        }
        int total_qty;
        decimal total_amount;

        private void return_amt_Click(object sender, EventArgs e)
        {
            usableFunction func = new usableFunction();
            func.Label_Two_Decimal_Places(sender, e, return_amt);
        }

        private void Calculate()
        {

            if (dtg_return_list.Columns.Count >= 1)
            {
                if (dtg_return_list.Rows.Count >= 1)
                {
                    total_qty = 0;
                    total_amount = 0;
                    int qty;
                    decimal total;
                    for (int i = 0; i < dtg_return_list.Rows.Count; i++)
                    {
                        int.TryParse(dtg_return_list.Rows[i].Cells["Quantity"].Value.ToString(), out qty);
                        total_qty += qty;

                        decimal.TryParse(dtg_return_list.Rows[i].Cells["Total"].Value.ToString(), out total);
                        total_amount += total;
                    }
                    return_items_count.Text = dtg_return_list.Rows.Count.ToString();
                    return_qty.Text = total_qty.ToString();
                    return_amt.Text = total_amount.ToString();

                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (dtg_return_list.Rows.Count >= 1)
            {
                if (JobRole != "Programmer/Developer" && JobRole != "Office Manager")
                {
                    MessageBox.Show("No permission to delete transactions! Thank you.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Deleting record will not be retrieved again. Continue?", "Delete Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow rw in dtg_return_list.SelectedRows)
                        {
                            sql = "DELETE FROM `Returned to Stocks` WHERE `Transaction Reference` = '" + rw.Cells[11].Value.ToString() + "' ";
                            config.Execute_Query(sql);
                        }
                        MessageBox.Show("Successfully deleted transactions", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chk_select_all.Checked = false;
                        refreshTableToolStripMenuItem_Click(sender, e);
                        return;
                    }

                }
            }
        }

        private void chk_select_all_CheckedChanged(object sender, EventArgs e)
        {
            if (dtg_return_list.Rows.Count >= 1)
            {
                foreach (DataGridViewRow rw in dtg_return_list.Rows)
                {
                    if (chk_select_all.Checked)
                    {
                        rw.Selected = true;
                    }
                    else
                    {
                        rw.Selected = false;
                    }
                }
            }
        }
    }
}
