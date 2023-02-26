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
        }

        private void Stock_Returned_Load(object sender, EventArgs e)
        {
            refreshTableToolStripMenuItem_Click(sender, e);
            cbo_srch_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This will delete an entire transaction reference which might consist of 1 or more items on it. Continue?", "Warning Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dtg_return_list.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow rw in dtg_return_list.SelectedRows)
                    {
                        // Check if the config object is initialized properly
                        if (config == null)
                        {
                            MessageBox.Show("Config object is null. Please check the initialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        string transactionRef = rw.Cells[15].Value?.ToString();

                        // Check if the transaction reference is null or empty
                        if (string.IsNullOrEmpty(transactionRef))
                        {
                            MessageBox.Show("Transaction reference is null or empty. Please check the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        string sql = "SELECT * FROM `Stock Returned` WHERE `Transaction Reference` = '" + transactionRef + "'";
                        config.singleResult(sql);

                        // Check if the dt object is properly initialized
                        if (config.dt == null)
                        {
                            MessageBox.Show("DT object is null. Please check the initialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        if (config.dt.Rows.Count > 0)
                        {
                            sql = "DELETE FROM `Stock Returned` WHERE `Transaction Reference` = '" + transactionRef + "'";
                            config.Execute_CUD(sql, "Unable to delete selected transaction", "Transaction successfully deleted!");
                            refreshTableToolStripMenuItem_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Unsucessful deletion of transaction, Please review and try again.", "Warning Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        chk_all.Checked = false;
                    }
                }
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
            if (!string.IsNullOrWhiteSpace(txt_Trans_number.Text) && txt_Trans_number.Text != "Empty Field!")
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
            if (!string.IsNullOrWhiteSpace(txt_Trans_number.Text) && txt_Trans_number.Text != "Empty Field!")
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
            if (!string.IsNullOrWhiteSpace(txt_Trans_number.Text) && txt_Trans_number.Text != "Empty Field!")
            {
                voice.Invoice("return", txt_Trans_number.Text, "print");
            }
            else
            {
                txt_Trans_number.Text = "Empty Field!";
                txt_Trans_number.Focus();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (dtg_return_list.Rows.Count >= 1)
            {
                if (dtg_return_list.SelectedRows.Count > 0 && txt_Trans_number.Text != "Empty Field!"
                    && !string.IsNullOrWhiteSpace(txt_Trans_number.Text))
                {
                    Items.Return_Preview frm = new Items.Return_Preview(
                    dtg_return_list.CurrentRow.Cells[1].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[2].Value.ToString(),
                    txt_Trans_number.Text,
                    dtg_return_list.CurrentRow.Cells[10].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[11].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[3].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[4].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[5].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[6].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[7].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[8].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[13].Value.ToString());

                    frm.ShowDialog();
                }

            }
        }

        private void cbo_srch_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search_TextChanged(sender, e);
        }
        string search_for = string.Empty;
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (cbo_srch_type.Text == "Date")
            {
                search_for = "`Entry Date`";
            }
            else if (cbo_srch_type.Text == "Id")
            {
                search_for = "`Stock ID`";
            }
            else if (cbo_srch_type.Text == "Name")
            {
                search_for = "`Item Name`";
            }
            else if (cbo_srch_type.Text == "Brand")
            {
                search_for = "`Brand`";
            }
            else if (cbo_srch_type.Text == "Description")
            {
                search_for = "`Description`";
            }
            else if (cbo_srch_type.Text == "Quantity")
            {
                search_for = "`Quantity`";
            }
            else if (cbo_srch_type.Text == "Price")
            {
                search_for = "`Price`";
            }
            else if (cbo_srch_type.Text == "Supplier")
            {
                search_for = "`Supplier Name`";
            }
            else if (cbo_srch_type.Text == "Job")
            {
                search_for = "`Job Role`";
            }
            else
            {
                search_for = "`Transaction Reference`";
            }
            sql = "Select * from `Stock Returned` where " + search_for + " like '%" + txt_Search.Text + "%'";
            config.Load_DTG(sql, dtg_return_list);
            DTG_Property();
            if (txt_Search.Text == "")
            {
                refreshTableToolStripMenuItem_Click(sender, e);
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
    }
}
