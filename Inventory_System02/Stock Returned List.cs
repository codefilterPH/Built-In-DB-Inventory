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
using Inventory_System02.Invoice_Code;

namespace Inventory_System02
{
    public partial class Stock_Returned : Form
    {
        SQLConfig config = new SQLConfig();
        Calculations cal = new Calculations();
        usableFunction func = new usableFunction();
        string sql, Global_ID, Fullname, JobRole;
        public Stock_Returned(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }
        double val = 0, qty = 0;
        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "Select * from `Stock Returned` order by `Entry Date` desc";
            config.Load_DTG(sql, dtg_return_list);
            if ( dtg_return_list.Columns.Count > 0 )
            {
                dtg_return_list.Columns[0].Visible = false;
                dtg_return_list.Columns[2].Visible = false;

                if (config.dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dtg_return_list.Rows.Count; i++)
                    {
                        qty += Convert.ToDouble(dtg_return_list.Rows[i].Cells[6].Value);
                        val += Convert.ToDouble(dtg_return_list.Rows[i].Cells[7].Value);
                    }
                    out_qty.Text = qty.ToString();
                    out_amt.Text = val.ToString();

                    dtg_return_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtg_return_list.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dtg_return_list.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dtg_return_list.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    func.Count_person(dtg_return_list, lbl_items_count);
                }
            }
            chk_ItemName.Checked = true;
        }

        private void Stock_Returned_Load(object sender, EventArgs e)
        {
            refreshTableToolStripMenuItem_Click(sender, e);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dtg_return_list.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow rw in dtg_return_list.SelectedRows)
                {
                    sql = "Delete from `Stock Returned` where `Stock ID` = '" + rw.Cells[2].Value.ToString() + "' ";
                    config.Execute_Query(sql);         
                }
                MessageBox.Show("Returned Stocks successfully deleted");
                refreshTableToolStripMenuItem_Click(sender, e);
                chk_all.Checked = false;
            }

        }
        string what_column = string.Empty;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (chk_ItemID.Checked)
            {
                what_column = "`Stock ID`";
            }
            if (chk_ItemName.Checked)
            {
                what_column = "`Item Name`";
            }
            if (chk_Desc.Checked)
            {
                what_column = "`Description`";
            }
            if (chk_Cat.Checked)
            {
                what_column = "`Brand`";
            }
            if (chk_Date.Checked)
            {
                what_column = "`Entry Date`";
            }

            foreach (CheckBox bx in panel1.Controls)
            {
                if (bx is CheckBox)
                {
                    if (bx.Checked)
                    {
                        sql = "Select * from `Stock Returned` where " + what_column + " like '%" + txt_Search.Text + "%'";
                        config.Load_DTG(sql, dtg_return_list);
                        DTG_Property();

                    }
                }
            }

            if (txt_Search.Text == "")
            {
                refreshTableToolStripMenuItem_Click(sender, e);
            }
        }
        private void DTG_Property()
        {
            if (dtg_return_list.Columns.Count > 0)
            {
                dtg_return_list.Columns[0].Visible = false;
                dtg_return_list.Columns[2].Visible = false;
                dtg_return_list.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_return_list.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

              //  dtg_return_list.Rows[0].Selected = true;
            }

        }

        private void chk_ItemID_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ItemID.Checked)
            {
                chk_ItemName.Checked = false;
                chk_Cat.Checked = false;
                chk_Desc.Checked = false;
                chk_Date.Checked = false;
            }
            txt_Search.Focus();
        }

        private void chk_ItemName_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ItemName.Checked)
            {
                chk_ItemID.Checked = false;
                chk_Cat.Checked = false;
                chk_Desc.Checked = false;
                chk_Date.Checked = false;
            }

            txt_Search.Focus();
        }


        private void txt_Trans_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if ( txt_Trans_number.Text == "" || txt_Trans_number.Text == null )
            {
                func.Error_Message1 = "Transaction Number Field";
                func.Error_Message();
                txt_Trans_number.Focus();
                return;
            }
            else if ( txt_Cust_ID.Text == "" || txt_Cust_ID.Text == null )
            {
                func.Error_Message1 = "Customer ID Field";
                func.Error_Message();
                txt_Cust_ID.Focus();
                return;
            }
            else if ( txt_Reasons.Text == "" || txt_Reasons.Text == null )
            {
                func.Error_Message1 = "Return Reason";
                func.Error_Message();
                txt_Reasons.Focus();
                return;
            }
            else
            {

                cal.ReturnReason(txt_Trans_number.Text, txt_Cust_ID.Text, txt_Reasons.Text);
                MessageBox.Show("Reason Updated!", "Update Successful Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_all.Checked)
            {
                foreach (DataGridViewRow rw in dtg_return_list.Rows)
                {
                    rw.Selected = true;
                    btn_Delete.Focus();
                }
            }
            else
            {
                foreach (DataGridViewRow rw in dtg_return_list.Rows)
                {
                    rw.Selected = false;
                }
            }
        }
        Inventory_System02.Invoice_Code.Invoice_Code voice = new Invoice_Code.Invoice_Code();
        private void btn_print_invoice_Click(object sender, EventArgs e)
        {
            if (txt_Trans_number.Text != "")
            {
                voice.Invoice("return", txt_Trans_number.Text, "preview");
            }
            else
            {
                txt_Trans_number.Text = "Empty Field!";
                txt_Trans_number.Focus();
            }
        }

        private void batchTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_Trans_number.Text != "")
            {
                voice.Invoice("return",txt_Trans_number.Text, "batch");
            }
            else
            {
                txt_Trans_number.Text = "Empty Field!";
                txt_Trans_number.Focus();
            }
        }

        private void printInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_Trans_number.Text != "")
            {
                voice.Invoice("return", txt_Trans_number.Text, "print");
            }
            else
            {
                txt_Trans_number.Text = "Empty Field!";
                txt_Trans_number.Focus();
            }
        }

        private void dtg_return_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_return_list.Rows.Count > 0)
            {
                txt_Reasons.Text = "";
                txt_Trans_number.Text = dtg_return_list.CurrentRow.Cells[15].Value.ToString();
                txt_Trans_number.Focus();
                txt_Cust_ID.Text = dtg_return_list.CurrentRow.Cells[9].Value.ToString();
                txt_Cust_name.Text = dtg_return_list.CurrentRow.Cells[10].Value.ToString();
                txt_address.Text = dtg_return_list.CurrentRow.Cells[11].Value.ToString();
                func.Reload_Images(cust_Image, txt_Cust_ID.Text, @"CommonSql\Pictures\Customers\");
                if (txt_Trans_number.Text != "" || txt_Trans_number.Text != null)
                {
                    sql = "Select * from `Return Reasons` where `Transaction Ref` = '" + txt_Trans_number.Text + "' and `Customer ID` = '" + txt_Cust_ID.Text + "' ";
                    config.singleResult(sql);
                    if (config.dt.Rows.Count > 0)
                    {
                        txt_Reasons.Text = config.dt.Rows[0].Field<string>("Reason");

                    }
                }

            }
        }

        private void chk_Cat_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Cat.Checked)
            {
                chk_ItemName.Checked = false;
                chk_ItemID.Checked = false;
                chk_Desc.Checked = false;
                chk_Date.Checked = false;
            }

            txt_Search.Focus();
        }

        private void chk_Desc_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Desc.Checked)
            {
                chk_ItemName.Checked = false;
                chk_ItemID.Checked = false;
                chk_Cat.Checked = false;
                chk_Date.Checked = false;
            }

            txt_Search.Focus();
        }

        private void chk_Date_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Date.Checked)
            {
                chk_ItemName.Checked = false;
                chk_ItemID.Checked = false;
                chk_Cat.Checked = false;
                chk_Desc.Checked = false;
            }

            txt_Search.Focus();
        }
    }
}
