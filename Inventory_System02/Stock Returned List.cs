﻿using System;
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

        Inventory_System02.Invoice_Code.Invoice_Code voice = new Invoice_Code.Invoice_Code();
    

        public Stock_Returned(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }
        
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
                    CalculateValue();
                    DTG_Property();
                }
                else
                {
                    lbl_items_count.Text = "0";
                    out_amt.Text = "0";
                    out_qty.Text = "0";
                }
            }
            enable_them = true;
            SpecialFilterDisabler();
        }
        decimal total_val;
        int total_qty;
        private void CalculateValue()
        {
            total_qty = 0;
            total_val = 0;
            for (int i = 0; i < dtg_return_list.Rows.Count; i++)
            {
                int qty = 0;
                decimal amount = 0;
             
                int.TryParse(dtg_return_list.Rows[i].Cells[9].Value.ToString(), out qty);
                decimal.TryParse(dtg_return_list.Rows[i].Cells[11].Value.ToString(), out amount);

                total_qty += qty;
                total_val += amount;

            }
            out_qty.Text = total_qty.ToString();
            out_amt.Text = total_val.ToString();
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

                        string transactionRef = rw.Cells[12].Value?.ToString();

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
                        }
                        else
                        {
                            MessageBox.Show("Unsucessful deletion of transaction, Please review and try again.", "Warning Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    refreshTableToolStripMenuItem_Click(sender, e);
                }
            }

        }
        private void DTG_Property()
        {

            if (dtg_return_list.Columns.Count > 0)
            {
                dtg_return_list.Columns[0].Visible = false;
                dtg_return_list.Columns[2].Visible = false;
                dtg_return_list.Columns[5].Visible = false;
                dtg_return_list.Columns[8].Visible = false;
                dtg_return_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_return_list.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_return_list.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtg_return_list.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                func.Count_person(dtg_return_list, lbl_items_count);
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

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (dtg_return_list.Rows.Count >= 1)
            {
                if (dtg_return_list.SelectedRows.Count > 0 && txt_Trans_number.Text != "Empty Field!"
                    && !string.IsNullOrWhiteSpace(txt_Trans_number.Text))
                {
                    Items.Return_Preview frm = new Items.Return_Preview(
                    dtg_return_list.CurrentRow.Cells[1].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[5].Value.ToString(),
                    txt_Trans_number.Text,
                    dtg_return_list.CurrentRow.Cells[3].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[4].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[6].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[7].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[8].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[9].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[10].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[11].Value.ToString(),
                    dtg_return_list.CurrentRow.Cells[14].Value.ToString());

                    frm.ShowDialog();
                }
                else
                {
                    txt_Trans_number.Text = "Empty Field!";
                    txt_Trans_number.Focus();
                }

            }
        }

        private void cbo_srch_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search_TextChanged(sender, e);
        }

        private void selectedTransactionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void batch_trans_return_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Trans_number.Text) && txt_Trans_number.Text != "Empty Field!")
            {
                voice.Invoice("return", txt_Trans_number.Text, "batch");
            }
            else
            {
                txt_Trans_number.Text = "Empty Field!";
                txt_Trans_number.Focus();
            }
        }

        private void print_trans_return_Click(object sender, EventArgs e)
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

        private void view_tbl_return_Click(object sender, EventArgs e)
        {
            Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
            frm.Search_Result("RETURN SUMMARY", "preview", dtg_return_list, lbl_items_count.Text, out_qty.Text, out_amt.Text, cbo_srch_type.Text, txt_Search.Text);
        }

        private void batch_tbl_return_Click(object sender, EventArgs e)
        {
            Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
            frm.Search_Result("RETURN SUMMARY", "batch", dtg_return_list, lbl_items_count.Text, out_qty.Text, out_amt.Text, cbo_srch_type.Text, txt_Search.Text);
            MessageBox.Show("Sent to \"My Documents\"!");
        }

        private void print_tbl_return_Click(object sender, EventArgs e)
        {
            Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
            frm.Search_Result("RETURN SUMMARY", "print", dtg_return_list, lbl_items_count.Text, out_qty.Text, out_amt.Text, cbo_srch_type.Text, txt_Search.Text);
        }

        private void out_amt_TextChanged(object sender, EventArgs e)
        {
            func.Label_Two_Decimal_Places(sender, e, out_amt);
        }
        bool enable_them = false;
        private void SpecialFilterDisabler()
        {
            if (enable_them == false)
            {
                printInvoiceToolStripMenuItem.Enabled = false;
                batchTransactionToolStripMenuItem.Enabled = false;
                view_main_btn.Enabled = false;
                btn_view.Enabled = false;
                btn_edit.Enabled = false;
                btn_Delete.Enabled = false;
                dtg_return_list.Enabled = false;
                txt_Search.Enabled = false;


                dtg_return_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_return_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtg_return_list.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg_return_list.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                lbl_items_count.Text = "1";
                out_amt.Text = "0";
                out_qty.Text = "0";
            }
            else
            {
                printInvoiceToolStripMenuItem.Enabled = true;
                batchTransactionToolStripMenuItem.Enabled = true;
                view_main_btn.Enabled = true;
                btn_view.Enabled = true;
                btn_edit.Enabled = true;
                btn_Delete.Enabled = true;
                dtg_return_list.Enabled = true;
                txt_Search.Enabled = true;

                dtg_return_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtg_return_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_return_list.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg_return_list.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }

        private void most_brand_return_tool_Click(object sender, EventArgs e)
        {
            sql = "SELECT Brand, COUNT(*) AS `Total Occurences` FROM `Stock Returned` GROUP BY Brand ORDER BY `Total Occurences` DESC LIMIT 1";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
     
        }

        private void least_brand_return_tool_Click(object sender, EventArgs e)
        {
            sql = "SELECT Brand, COUNT(*) AS `Total Occurences` FROM `Stock Returned` GROUP BY Brand ORDER BY `Total Occurences` ASC LIMIT 1";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void most_product_return_tool_Click(object sender, EventArgs e)
        {
            sql = "SELECT `Item Name`, COUNT(*) AS `Total Occurences`, Brand FROM `Stock Returned` GROUP BY `Item Name` ORDER BY `Total Occurences` DESC LIMIT 1";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void least_product_return_tool_Click(object sender, EventArgs e)
        {
            sql = "SELECT `Item Name`, COUNT(*) AS `Total Occurences`, Brand FROM `Stock Returned` GROUP BY `Item Name` ORDER BY `Total Occurences` ASC LIMIT 1";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void most_division_return_tool_Click(object sender, EventArgs e)
        {
            sql = "SELECT `Customer Name`, COUNT(*) AS `Total Occurences` FROM `Stock Returned` GROUP BY `Customer Name` ORDER BY `Total Occurences` DESC LIMIT 1";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void least_division_return_tool_Click(object sender, EventArgs e)
        {
            sql = "SELECT `Customer Name`, COUNT(*) AS `Total Occurences` FROM `Stock Returned` GROUP BY `Customer Name` ORDER BY `Total Occurences` ASC LIMIT 1";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        string search_for = string.Empty;
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (cbo_srch_type.Text == "DATE")
            {
                search_for = "`Entry Date`";
            }
            else if (cbo_srch_type.Text == "ID")
            {
                search_for = "`Stock ID`";
            }
            else if (cbo_srch_type.Text == "NAME")
            {
                search_for = "`Item Name`";
            }
            else if (cbo_srch_type.Text == "BRAND")
            {
                search_for = "`Brand`";
            }
            else if (cbo_srch_type.Text == "DESCRIPTION")
            {
                search_for = "`Description`";
            }
            else if (cbo_srch_type.Text == "QUANTITY")
            {
                search_for = "`Quantity`";
            }
            else if (cbo_srch_type.Text == "PRICE")
            {
                search_for = "`Price`";
            }
            else if (cbo_srch_type.Text == "TOTAL")
            {
                search_for = "`Total`";
            }
            else if (cbo_srch_type.Text == "DIVISION")
            {
                search_for = "`Customer Name`";
            }
            else if (cbo_srch_type.Text == "ADDRESS")
            {
                search_for = "`Customer Address`";
            }
            else if (cbo_srch_type.Text == "STAFF NAME")
            {
                search_for = "`Warehouse Staff Name`";
            }
            else if (cbo_srch_type.Text == "JOB")
            {
                search_for = "`Job Role`";
            }
            else if (cbo_srch_type.Text == "TRANS REF")
            {
                search_for = "`Transaction Reference`";
            }
            else
            {
                search_for = "`Customer Name`";
            }
            sql = "Select * from `Stock Returned` where " + search_for + " like '%" + txt_Search.Text + "%'";
            config.Load_DTG(sql, dtg_return_list);
            CalculateValue();
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
                txt_Trans_number.Text = dtg_return_list.CurrentRow.Cells[12].Value.ToString();
                txt_Trans_number.Focus();
                txt_Cust_ID.Text = dtg_return_list.CurrentRow.Cells[2].Value.ToString();
                txt_Cust_name.Text = dtg_return_list.CurrentRow.Cells[3].Value.ToString();
                txt_address.Text = dtg_return_list.CurrentRow.Cells[4].Value.ToString();
                func.Reload_Images(cust_Image, txt_Cust_ID.Text, Includes.AppSettings.Customer_DIR);
                if (txt_Trans_number.Text != "" || txt_Trans_number.Text != null)
                {
                    sql = "Select * from `Return Reasons` where `Transaction Ref` = '" + txt_Trans_number.Text + "' and `Customer ID` = '" + txt_Cust_ID.Text + "' ";
                    config.singleResult(sql);
                    if (config.dt.Rows.Count > 0)
                    {
                        txt_Reasons.Text = config.dt.Rows[0].Field<string>("Reason");

                    }
                }
                func.Change_Font_DTG(sender, e, dtg_return_list);
            }
        }
    }
}
