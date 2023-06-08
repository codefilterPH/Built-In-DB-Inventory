using Inventory_System02.Includes;
using Inventory_System02.Return;
using System;
using System.Windows.Forms;

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
            if (dtg_return_list.Columns.Count >= 1)
            {
                dtg_return_list.Columns.Clear();
            }
            this.Refresh();

            sql = "Select * from `Stock Returned` order by `Entry Date` desc";
            Load_Items(sql);
            if (dtg_return_list.Columns.Count > 0)
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
            try
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
            catch (InvalidOperationException ex)
            {
                lbl_exception.Text = "Error: " + ex.Message;
            }
        }

        private void Stock_Returned_Load(object sender, EventArgs e)
        {
            refreshTableToolStripMenuItem_Click(sender, e);
            cbo_srch_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Load_Items(string sql)
        {

            // calculate the total number of records and pages
            int totalRecords = config.GetTotalRecords(sql);

            double num_records = 0;
            double.TryParse(cbo_num_records.Text, out num_records);

            double totalPages = (int)Math.Ceiling((double)totalRecords / num_records);

            // update the maximum number
            num_max_pages.Maximum = Convert.ToDecimal(totalPages);
            num_max_pages.Value = Convert.ToDecimal(totalPages);

            // get the current page number and records per page from the paginator control

            int currentpage = (int)current_page_val.Value;
            int recordsperpage = (int)num_records;

            // build the sql query based on the search criteria

            // load the data into the datagridview with pagination
            config = new SQLConfig();
            config.Load_DTG_Paginator(sql, dtg_return_list, currentpage, recordsperpage);
            DTG_Property();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dtg_return_list.Rows.Count >= 1)
            {
                if (JobRole != "Programmer/Developer" && JobRole != "Office Manager")
                {
                    MessageBox.Show("No permission to delete all transactions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    chk_select_all.Checked = false;
                    return;
                }

                if (MessageBox.Show("This will delete an entire transaction reference which might consist of 1 or more items on it. Continue?", "Warning Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (chk_select_all.Checked)
                    {
                        sql = "DELETE FROM `Return Reasons`";
                        config.Execute_Query(sql);

                        sql = "DELETE FROM `Stock Returned` WHERE count = '1' ";
                        config.Execute_CUD(sql, "Unable to delete all items. Please try again!", "Successfully deleted all stock returned!");
                        chk_select_all.Checked = false;
                        refreshTableToolStripMenuItem_Click(sender, e);
                        return;
                    }
                    else
                    {
                        sql = string.Empty;
                        if (dtg_return_list.SelectedRows.Count > 0)
                        {
                            foreach (DataGridViewRow rw in dtg_return_list.SelectedRows)
                            {
                                string transactionRef = rw.Cells[12].Value?.ToString();

                                sql = "DELETE FROM `Return Reasons` WHERE `Transaction Ref` = '" + transactionRef + "' ";
                                config.Execute_Query(sql);


                                // Check if the config object is initialized properly
                                if (config == null)
                                {
                                    lbl_exception.Text = "Error: Config object is null. Please check the initialization.";
                                    break;
                                }



                                // Check if the transaction reference is null or empty
                                if (string.IsNullOrEmpty(transactionRef))
                                {
                                    lbl_exception.Text = "Error: Transaction reference is null or empty. Please check the data.";
                                    continue;
                                }

                                sql = "SELECT * FROM `Stock Returned` WHERE `Transaction Reference` = '" + transactionRef + "'";
                                config.singleResult(sql);

                                // Check if the dt object is properly initialized
                                if (config.dt == null)
                                {
                                    lbl_exception.Text = "Error: DT object is null. Please check the initialization.";
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
                            chk_select_all.Checked = false;
                            refreshTableToolStripMenuItem_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("No selection from the table", "Nothing to Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            chk_select_all.Checked = false;
                            return;
                        }
                    }

                    txt_Trans_number.Text = string.Empty;
                    txt_address.Text = string.Empty;
                    txt_Cust_ID.Text = string.Empty;
                    txt_Cust_name.Text = string.Empty;
                    txt_Remarks.Text = string.Empty;
                    lbl_return_type.Text = string.Empty;

                }
            }

        }
        private void DTG_Property()
        {
            try
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
                    dtg_return_list.Columns[10].DefaultCellStyle.Format = "#,##0.00";
                    dtg_return_list.Columns[11].DefaultCellStyle.Format = "#,##0.00";

                    func.Count_person(dtg_return_list, lbl_items_count);
                }
            }
            catch (System.InvalidOperationException)
            {
                // Handle the exception by waiting for a short period of time and then trying the operation again
                System.Threading.Thread.Sleep(500);
                DTG_Property();
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
            if (txt_Trans_number.Text == "" || txt_Trans_number.Text == null)
            {
                func.Error_Message1 = "Transaction Number Field";
                func.Error_Message();
                txt_Trans_number.Focus();
                return;
            }
            else if (txt_Cust_ID.Text == "" || txt_Cust_ID.Text == null)
            {
                func.Error_Message1 = "Customer ID Field";
                func.Error_Message();
                txt_Cust_ID.Focus();
                return;
            }
            else if (txt_Remarks.Text == "" || txt_Remarks.Text == null)
            {
                func.Error_Message1 = "Return Reason";
                func.Error_Message();
                txt_Remarks.Focus();
                return;
            }
            else
            {

                cal.ReturnReason(txt_Trans_number.Text, txt_Cust_ID.Text, lbl_return_type.Text, txt_Remarks.Text);
                MessageBox.Show("Reason Updated!", "Update Successful Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (dtg_return_list.Rows.Count >= 1)
            {
                if (dtg_return_list.SelectedRows.Count <= 0)
                {
                    dtg_return_list.CurrentRow.Selected = true;
                }
                else if (dtg_return_list.SelectedRows.Count == 1 && txt_Trans_number.Text != "Empty Field!"
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
                System.Threading.Tasks.Task task = voice.Invoice("return", txt_Trans_number.Text, "preview");
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
                System.Threading.Tasks.Task task = voice.Invoice("return", txt_Trans_number.Text, "batch");
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
                System.Threading.Tasks.Task task = voice.Invoice("return", txt_Trans_number.Text, "print");
            }
            else
            {
                txt_Trans_number.Text = "Empty Field!";
                txt_Trans_number.Focus();
            }
        }

        private void view_tbl_return_Click(object sender, EventArgs e)
        {
            if (dtg_return_list.Rows.Count >= 1)
            {
                Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
                frm.Search_Result("RETURN SUMMARY", "preview", dtg_return_list, lbl_items_count.Text, out_qty.Text, out_amt.Text, cbo_srch_type.Text, txt_Search.Text);
            }
            else
            {
                MessageBox.Show("Table is empty", "Missing Rows", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void batch_tbl_return_Click(object sender, EventArgs e)
        {
            if (dtg_return_list.Rows.Count >= 1)
            {
                Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
                frm.Search_Result("RETURN SUMMARY", "batch", dtg_return_list, lbl_items_count.Text, out_qty.Text, out_amt.Text, cbo_srch_type.Text, txt_Search.Text);
                MessageBox.Show("Sent to \"My Documents\"!");
            }
            else
            {
                MessageBox.Show("Table is empty", "Missing Rows", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void print_tbl_return_Click(object sender, EventArgs e)
        {
            if (dtg_return_list.Rows.Count >= 1)
            {
                Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
                frm.Search_Result("RETURN SUMMARY", "print", dtg_return_list, lbl_items_count.Text, out_qty.Text, out_amt.Text, cbo_srch_type.Text, txt_Search.Text);
            }
            else
            {
                MessageBox.Show("Table is empty", "Missing Rows", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                txt_Search.Enabled = false;

                if (dtg_return_list.Columns.Count > 0)
                {
                    dtg_return_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtg_return_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    dtg_return_list.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }

                lbl_items_count.Text = dtg_return_list.Rows.Count.ToString();
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
                txt_Search.Enabled = true;
            }
        }
        private void TableRefresher()
        {
            //Refresh and clear the columns this is important to remain the sorting
            if (dtg_return_list.Columns.Count > 0)
            {
                dtg_return_list.Columns.Clear();
            }
        }
        private void most_brand_return_tool_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT Brand, COUNT(*) AS `Total Occurences` FROM `Stock Returned` GROUP BY Brand ORDER BY `Total Occurences` DESC";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();

        }

        private void least_brand_return_tool_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT Brand, COUNT(*) AS `Total Occurences` FROM `Stock Returned` GROUP BY Brand ORDER BY `Total Occurences` ASC";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void most_product_return_tool_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT `Item Name`, COUNT(*) AS `Total Occurences`, Brand FROM `Stock Returned` GROUP BY `Item Name` ORDER BY `Total Occurences` DESC";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void least_product_return_tool_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT `Item Name`, COUNT(*) AS `Total Occurences`, Brand FROM `Stock Returned` GROUP BY `Item Name` ORDER BY `Total Occurences` ASC";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void most_division_return_tool_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT `Customer Name`, COUNT(*) AS `Total Occurences` FROM `Stock Returned` GROUP BY `Customer Name` ORDER BY `Total Occurences` DESC";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void least_division_return_tool_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT `Customer Name`, COUNT(*) AS `Total Occurences` FROM `Stock Returned` GROUP BY `Customer Name` ORDER BY `Total Occurences` ASC";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        bool dtg_clicked = false;
        private void btn_return_to_stocks_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lbl_return_type.Text))
            {
                if (dtg_return_list.Rows.Count >= 1)
                {
                    if (dtg_clicked == true)
                    {
                        if (!string.IsNullOrWhiteSpace(txt_Trans_number.Text))
                        {
                            if (dtg_return_list.SelectedRows.Count == 1)
                            {
                                if (Convert.ToInt32(dtg_return_list.CurrentRow.Cells["Quantity"].Value) != 0)
                                {
                                    ReturnToStocks frm = new ReturnToStocks(Global_ID, Fullname, JobRole, txt_Trans_number.Text, dtg_return_list.CurrentRow.Cells[5].Value.ToString());
                                    DialogResult result = frm.ShowDialog();
                                    if (result == DialogResult.OK)
                                    {
                                        Stock_Returned_Load(sender, e);
                                    }
                                    dtg_clicked = false;
                                }
                                else
                                {
                                    if (MessageBox.Show("Quantity is zero nothing to return! Open the \"investigated return list\" instead?", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
                                    {
                                        damageToolStripMenuItem_Click(sender, e);
                                    }
                                    else
                                    {
                                        return;
                                    }

                                }

                            }
                        }
                    }
                }
            }
        }

        private void filterByReturnTypeTool_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT Reason, COUNT(*) AS `Total Occurences` FROM `Return Reasons` GROUP BY Reason ORDER BY `Total Occurences` DESC";
            config.Load_DTG(sql, dtg_return_list);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void damageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Investigated_Return_Records frm = new Investigated_Return_Records(Global_ID, Fullname, JobRole);
            frm.ShowDialog();
        }

        private void chk_select_all_CheckedChanged(object sender, EventArgs e)
        {
            if (dtg_return_list.Columns.Count >= 1)
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

        private void current_page_val_ValueChanged(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            if (current_page_val.Value <= num_max_pages.Value)
            {
                tooltip.SetToolTip(current_page_val, "Hit \'ENTER\' key to apply changes.");
                sql = "Select * from `Stock Returned` order by `Entry Date` desc";
                Load_Items(sql);
            }
            else
            {
                current_page_val.Text = "0";
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            current_page_val_ValueChanged(sender, e);
        }

        private void cbo_num_records_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_page_val_ValueChanged(sender, e);
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
            chk_select_all.Checked = false;
            if (enable_them == true)
            {
                if (dtg_return_list.Rows.Count > 0)
                {
                    txt_Remarks.Text = "";
                    txt_Trans_number.Text = dtg_return_list.CurrentRow.Cells[12].Value.ToString();
                    txt_Trans_number.Focus();
                    txt_Cust_ID.Text = dtg_return_list.CurrentRow.Cells[2].Value.ToString();
                    txt_Cust_name.Text = dtg_return_list.CurrentRow.Cells[3].Value.ToString();
                    txt_address.Text = dtg_return_list.CurrentRow.Cells[4].Value.ToString();
                    func.Reload_Images(cust_Image, txt_Cust_ID.Text, Includes.AppSettings.Customer_DIR);
                    if (txt_Trans_number.Text != "" || txt_Trans_number.Text != null)
                    {
                        sql = "Select Reason, Remarks from `Return Reasons` where `Transaction Ref` = '" + txt_Trans_number.Text + "' and `Customer ID` = '" + txt_Cust_ID.Text + "' ";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count > 0)
                        {
                            lbl_return_type.Text = config.dt.Rows[0]["Reason"].ToString();
                            txt_Remarks.Text = config.dt.Rows[0]["Remarks"].ToString();
                            if (lbl_return_type.Text == "Damage ( Investigated or Repair )")
                            {
                                btn_return_to_stocks.Visible = true;
                            }
                            else
                            {
                                btn_return_to_stocks.Visible = false;
                            }
                        }
                    }
                    func.Change_Font_DTG(sender, e, dtg_return_list);
                }
                dtg_clicked = true;
            }
        }
    }
}
