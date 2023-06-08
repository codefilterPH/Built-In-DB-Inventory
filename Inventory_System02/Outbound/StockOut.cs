using Inventory_System02.Includes;
using Inventory_System02.Invoice_Code;
using Inventory_System02.Reports_Dir;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Inventory_System02
{

    public partial class StockOut : Form
    {
        SQLConfig config = new SQLConfig();
        ID_Generator gen = new ID_Generator();
        usableFunction func = new usableFunction();

        string sql, Global_ID, Fullname, JobRole;

        public StockOut(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }

        private void StockOut_Load(object sender, EventArgs e)
        {
            refreshTableToolStripMenuItem_Click(sender, e);
            cbo_srch_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_Cust_Gen_Click(object sender, EventArgs e)
        {
            try
            {
                gen.Customer_ID();
                sql = "Select `Customer ID` from ID_Generated where count = '1'";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    cbo_CustID.Text = config.dt.Rows[0].Field<string>("Customer ID");
                }
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occurred: " + ex.Message;
            }

        }

        bool isWorkerBusy = false;
        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isWorkerBusy)
            {
                isWorkerBusy = true;
                PreloadWorker.RunWorkerAsync();
            }

        }

        private void DTG_Property()
        {
            try
            {
                if (dtg_Stocks.Columns.Count > 0)
                {
                    dtg_Stocks.Columns[0].Visible = false;
                    dtg_Stocks.Columns[1].Visible = false;
                    dtg_Stocks.Columns[2].Visible = false;
                    dtg_Stocks.Columns[9].Visible = false;
                    dtg_Stocks.Columns[10].Visible = false;
                    dtg_Stocks.Columns[11].Visible = false;
                    dtg_Stocks.Columns[12].Visible = false;
                    dtg_Stocks.Columns[13].Visible = false;
                    dtg_Stocks.Columns[14].Visible = false;
                    dtg_Stocks.Columns[15].Visible = false;
                    dtg_Stocks.Columns[16].Visible = false;

                    if (!config.dt.Columns.Contains("Image"))
                    {
                        config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
                    }
                    foreach (DataRow rw in config.dt.Rows)
                    {
                        if (File.Exists(rw[9].ToString()))
                        {
                            rw["Image"] = File.ReadAllBytes(rw[9].ToString());
                        }
                        else
                        {
                            string imagePath = Includes.AppSettings.Image_DIR + "\\" + "DONOTDELETE_SUBIMAGE";
                            string[] extensions = { ".jpg", ".JPG", ".png", ".PNG" };
                            foreach (string ext in extensions)
                            {
                                if (File.Exists(imagePath + ext))
                                {
                                    rw["Image"] = File.ReadAllBytes(imagePath + ext);
                                    break;
                                }
                            }
                            // If none of the image files exist, set the image to null or an empty byte array
                            if (rw["Image"] == null || ((byte[])rw["Image"]).Length == 0)
                            {
                                rw["Image"] = null;
                                // rw["Image"] = new byte[0];
                            }
                        }
                    }

                    dtg_Stocks.Columns["Image"].DisplayIndex = 0;

                    for (int i = 0; i < dtg_Stocks.Columns.Count; i++)
                    {
                        if (dtg_Stocks.Columns[i] is DataGridViewImageColumn)
                        {
                            ((DataGridViewImageColumn)dtg_Stocks.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                            break;
                        }
                    }

                    dtg_Stocks.Columns[7].DefaultCellStyle.Format = "#,##0.00";
                    dtg_Stocks.Columns[8].DefaultCellStyle.Format = "#,##0.00";
                    dtg_Stocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dtg_Stocks.Columns["Image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_Stocks.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtg_Stocks.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtg_Stocks.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_Stocks.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_Stocks.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                    dtg_Stocks.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dtg_Stocks.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dtg_Stocks.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //STOCK OUTBOUND
                    dtg_AddedStocks.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dtg_AddedStocks.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dtg_AddedStocks.Columns[5].DefaultCellStyle.Format = "#,##0.00";

                }
            }
            catch (InvalidOperationException)
            {
                // Handle the exception by waiting for a short period of time and then trying the operation again
                System.Threading.Thread.Sleep(500);
                DTG_Property();
            }
        }
        private void TOTALS()
        {
            try
            {
                if (dtg_AddedStocks.Rows.Count >= 1)
                {
                    HashSet<double> distinctQuantities = new HashSet<double>();
                    int totalQty = 0;
                    decimal totalAmt = 0;
                    int qty = 0;
                    decimal price = 0;

                    for (int i = 0; i < dtg_AddedStocks.Rows.Count; i++)
                    {
                        int.TryParse(dtg_AddedStocks.Rows[i].Cells[4].Value.ToString(), out qty);
                        decimal.TryParse(dtg_AddedStocks.Rows[i].Cells[5].Value.ToString(), out price);

                        totalQty += qty;
                        totalAmt += qty * price;

                        distinctQuantities.Add(qty);
                    }

                    out_qty.Text = totalQty.ToString();
                    out_amt.Text = totalAmt.ToString();
                    lbl_numb_out_items.Text = "Rows count: " + dtg_AddedStocks.Rows.Count.ToString();

                }
                else
                {
                    lbl_numb_out_items.Text = "Rows count: 0";
                    out_qty.Text = "0";
                    out_amt.Text = "0.00";
                }

                if (dtg_Stocks.Rows.Count >= 1)
                {
                    quan = 0;
                    for (int i = 0; i < dtg_Stocks.Rows.Count; i++)
                    {
                        quan = i;
                    }
                    quan += 1;
                    lbl_items_qty.Text = "Number of items: " + quan.ToString();
                }
                else
                {
                    lbl_items_qty.Text = "0";
                }
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "Error: " + ex.Message;
            }
        }

        private void btn_sup_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_Stocks.Rows.Count >= 1)
                {
                    if (dtg_Stocks.SelectedRows.Count >= 1)
                    {
                        foreach (DataGridViewRow rw in dtg_Stocks.SelectedRows)
                        {
                            bool found = false;
                            // Check if item is already added to dtg_AddedStocks
                            foreach (DataGridViewRow addedRow in dtg_AddedStocks.Rows)
                            {
                                if (addedRow.Cells[0].Value.ToString() == rw.Cells[2].Value.ToString())
                                {
                                    MessageBox.Show("This " + rw.Cells[3].Value.ToString() + " is already added to the table \n\nWarning!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    found = true;
                                    continue; // Skip adding the duplicate item and continue with the next item
                                }
                            }
                            if (!found && rw.Cells[6].Value.ToString() != "0")
                            {
                                dtg_AddedStocks.Rows.Add(
                                    rw.Cells[2].Value.ToString(),
                                    rw.Cells[3].Value.ToString(),
                                    rw.Cells[4].Value.ToString(),
                                    rw.Cells[5].Value.ToString(),
                                    rw.Cells[6].Value.ToString(),
                                    rw.Cells[7].Value.ToString(),
                                    Convert.ToString(Convert.ToDouble(rw.Cells[6].Value) * Convert.ToDouble(rw.Cells[7].Value))
                                );
                                Update_Qty_Stocks();
                                TOTALS();
                                chk_all.Checked = false;
                                btn_edit.Focus();
                            }
                            else if (!found && rw.Cells[6].Value.ToString() == "0")
                            {
                                MessageBox.Show("Cannot add " + rw.Cells[3].Value.ToString() + " because \'quantity\' is zero.", "Error Prompt", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                    }
                    else
                    {
                        if (dtg_Stocks.CurrentRow != null)
                        {
                            dtg_Stocks.CurrentRow.Selected = true;
                        }
                    }
                    TOTALS();
                }
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occured: " + ex.Message;
            }

        }
        double quan = 0;
        private void btn_sup_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_AddedStocks.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in this.dtg_AddedStocks.SelectedRows)
                    {
                        refreshTableToolStripMenuItem.Enabled = false;
                        dtg_AddedStocks.Rows.RemoveAt(item.Index);
                        // recalculate main items
                        for (int i = 0; i < dtg_Stocks.Rows.Count; i++)
                        {
                            if (item.Cells[0].Value.ToString() == dtg_Stocks.Rows[i].Cells["Stock ID"].Value.ToString())
                            {
                                dtg_Stocks.Rows[i].Cells["Quantity"].Value = item.Cells[4].Value.ToString();
                                dtg_Stocks.Rows[i].Cells["Total"].Value = Convert.ToDecimal(dtg_Stocks.Rows[i].Cells["Quantity"].Value) * Convert.ToDecimal(dtg_Stocks.Rows[i].Cells["Price"].Value);
                            }
                        }
                    }
                }
                else if (dtg_AddedStocks.Rows.Count >= 1)
                {
                    dtg_AddedStocks.CurrentRow.Selected = true;
                }
                if (dtg_AddedStocks.Rows.Count <= 0)
                {
                    refreshTableToolStripMenuItem.Enabled = true;
                    refreshTableToolStripMenuItem_Click(sender, e);
                }
                Update_Qty_Stocks();
                chk_all2.Checked = false;
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "Am error occred: " + ex.Message;
            }
        }

        string search_for = string.Empty;
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_srch_type.Text == "Date")
                {
                    search_for = "`Entry Date`";
                }
                else if (cbo_srch_type.Text == "Id")
                {
                    search_for = "`Stock ID`";
                }
                else if (cbo_srch_type.Text == "Item Name")
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
                sql = "Select * from Stocks where " + search_for + " like '%" + txt_Search.Text + "%' ORDER BY `Entry Date` DESC";
                config.Load_DTG(sql, dtg_Stocks);
                DTG_Property();
                if (dtg_AddedStocks.Rows.Count > 0)
                {
                    Update_Qty_Stocks();
                }

                if (txt_Search.Text == "")
                {
                    refreshTableToolStripMenuItem_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occured: " + ex.Message;
            }
        }

        private void cbo_CustID_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from `Customer` where `Customer ID` = '" + cbo_CustID.Text + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txt_Cust_Name.Text = config.dt.Rows[0].Field<string>("Name").ToString();
                txt_Cust_SAddress.Text = config.dt.Rows[0].Field<string>("Address").ToString();
                txt_Type.Text = config.dt.Rows[0].Field<string>("Type").ToString();

                func.Reload_Images(cust_Image, cbo_CustID.Text, Includes.AppSettings.Customer_DIR);

                //dtg_Stocks.Rows[0].Selected = true;
                btn_sup_add.Focus();

            }
        }

        private void btn_searchCustomer_Click(object sender, EventArgs e)
        {
            customerListToolStripMenuItem_Click(sender, e);
        }
        private void dtg_AddedStocks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Saved.Enabled = true;
            }
        }

        private void dtg_Stocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sup_add.Focus();
            if (dtg_Stocks.Rows.Count > 0)
            {
                func.Change_Font_DTG(sender, e, dtg_Stocks);
                chk_all.Checked = false;
            }
        }

        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {
            func.Select_All_Dtg(dtg_Stocks, chk_all);
        }

        private void dtg_AddedStocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chk_all2.Checked = false;
        }

        private void chk_all2_CheckedChanged(object sender, EventArgs e)
        {
            func.Select_All_Dtg(dtg_AddedStocks, chk_all2);
        }

        private void dtg_AddedStocks_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                //Copy and pasting dot not included as well as typing it.
                e.Control.KeyPress -= new KeyPressEventHandler(func.NumbersOnlyDTG_Keypress);

                if (dtg_AddedStocks.CurrentCell.ColumnIndex == 4) // Desired Column
                {
                    System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(func.NumbersOnlyDTG_Keypress);
                        tb.KeyDown += (s, ev) =>
                        {
                            // Check for the dot character in the clipboard data
                            if (ev.Control && ev.KeyCode == Keys.V)
                            {
                                string clipboardText = Clipboard.GetText();
                                if (clipboardText.Contains("."))
                                {
                                    ev.Handled = true;
                                }
                            }
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occured: " + ex.Message;
            }
        }

        private void dtg_Stocks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtg_Stocks.CurrentRow.Selected = dtg_Stocks.CurrentCell.Selected;
                btn_sup_add_Click(sender, e);
                btn_edit.Focus();
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occured: " + ex.Message;
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_Stocks.Rows.Count > 0)
                {
                    if (dtg_Stocks.SelectedRows.Count >= 1)
                    {
                        decimal total_amount = Convert.ToDecimal(dtg_Stocks.CurrentRow.Cells[6].Value) * Convert.ToDecimal(dtg_Stocks.CurrentRow.Cells[7].Value);

                        Items.Item_Preview frm = new Items.Item_Preview(
                        dtg_Stocks.CurrentRow.Cells[1].Value.ToString(),
                        dtg_Stocks.CurrentRow.Cells[2].Value.ToString(),
                        dtg_Stocks.CurrentRow.Cells[15].Value.ToString(),
                        dtg_Stocks.CurrentRow.Cells[3].Value.ToString(),
                        dtg_Stocks.CurrentRow.Cells[4].Value.ToString(),
                        dtg_Stocks.CurrentRow.Cells[5].Value.ToString(),
                        dtg_Stocks.CurrentRow.Cells[6].Value.ToString(),
                        dtg_Stocks.CurrentRow.Cells[7].Value.ToString(),
                        total_amount.ToString(),
                        dtg_Stocks.CurrentRow.Cells[13].Value.ToString());

                        frm.ShowDialog();
                    }
                    else
                    {
                        dtg_Stocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dtg_Stocks.Rows[0].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An exception error occured: " + ex.Message;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_AddedStocks.Rows.Count > 0)
                {
                    if (dtg_AddedStocks.SelectedRows.Count > 0)
                    {
                        Edit_Form.Edit_Form myForm = new Edit_Form.Edit_Form(dtg_AddedStocks.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dtg_AddedStocks.CurrentRow.Cells[4].Value));

                        DialogResult result = myForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            // Get the data entered by the user from the MyData property of the form
                            dtg_AddedStocks.CurrentRow.Cells[4].Value = myForm.MyData_qty;
                            Update_Qty_Stocks();
                        }
                    }
                    else
                    {
                        dtg_AddedStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dtg_AddedStocks.Rows[0].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occured: " + ex.Message;
            }
        }
        private ToolTip toolTip;
        private void btn_searchCustomer_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip = new ToolTip();
                toolTip.SetToolTip(btn_searchCustomer, "Click to search for an existing customer.");
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occured: " + ex.Message;
            }
        }
        private void Update_Qty_Stocks()
        {
            try
            { //verify if there are rows in dtg_return
                if (dtg_AddedStocks.Rows.Count > 0)
                {
                    //do the ff code to each rows
                    foreach (DataGridViewRow rw in dtg_Stocks.Rows)
                    {
                        //i will be used as row number # in dtg_outstack
                        for (int i = 0; i < dtg_AddedStocks.Rows.Count; i++)
                        {
                            //verify if the item is already added below cell 2 is item id of the stock table
                            if (rw.Cells[2].Value.ToString() == dtg_AddedStocks.Rows[i].Cells[0].Value.ToString())
                            {
                                //if added get the quantity based on every item row id only
                                DataSet ds = new DataSet();
                                sql = "Select Quantity from `Stocks` where `Stock ID` = '" + dtg_AddedStocks.Rows[i].Cells[0].Value.ToString() + "' ";
                                config.Load_Datasource(sql, ds);
                                //if there are any of item found
                                if (config.dt.Rows.Count > 0)
                                {
                                    //assign the result from the stock table
                                    rw.Cells[6].Value = ds.Tables[0].Rows[0]["Quantity"];
                                    //check the quantity if its greater or equal to added stocks
                                    if (Convert.ToInt32(rw.Cells[6].Value) >= Convert.ToInt32(dtg_AddedStocks.Rows[i].Cells[4].Value))
                                    {
                                        //Change the value of the current inbound stocks minus the added stocks
                                        rw.Cells[6].Value = Convert.ToInt32(rw.Cells[6].Value) - Convert.ToInt32(dtg_AddedStocks.Rows[i].Cells[4].Value);
                                        //Calculate the current total inbound value times the new qty
                                        rw.Cells[8].Value = Convert.ToDecimal(rw.Cells[6].Value) * Convert.ToDecimal(rw.Cells[7].Value);
                                        //Calculate the total (qty of added stocks * the price )
                                        dtg_AddedStocks.Rows[i].Cells[6].Value = 0;
                                        dtg_AddedStocks.Rows[i].Cells[6].Value = Convert.ToDecimal(dtg_AddedStocks.Rows[i].Cells[4].Value) *
                                            Convert.ToDecimal(dtg_AddedStocks.Rows[i].Cells[5].Value);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Quantity is more than Stocks, Invalid Quantity!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        if (Convert.ToInt32(rw.Cells[6].Value) == 0)
                                        {
                                            dtg_AddedStocks.Rows[i].Cells[4].Value = 0;
                                            rw.Cells[6].Value = ds.Tables[0].Rows[0]["Quantity"];
                                        }
                                        else if (Convert.ToInt32(rw.Cells[6].Value) >= 1)
                                        {
                                            dtg_AddedStocks.Rows[i].Cells[4].Value = 1;
                                            rw.Cells[6].Value = Convert.ToInt32(ds.Tables[0].Rows[0]["Quantity"]) - 1;
                                        }
                                        return;
                                    }

                                    if (Convert.ToDouble(dtg_AddedStocks.Rows[i].Cells[4].Value) == 0)
                                    {
                                        func.Error_Message1 = "Quantiy is zero";
                                        func.Error_Message();
                                        dtg_AddedStocks.Focus();
                                        btn_Saved.Enabled = false;
                                        return;
                                    }
                                    else
                                    {
                                        //Calculate the total (qty of added stocks * the price )
                                        dtg_AddedStocks.Rows[i].Cells[6].Value = 0;
                                        dtg_AddedStocks.Rows[i].Cells[6].Value = Convert.ToDecimal(dtg_AddedStocks.Rows[i].Cells[4].Value) *
                                            Convert.ToDecimal(dtg_AddedStocks.Rows[i].Cells[5].Value);
                                        btn_Saved.Enabled = true;

                                    }
                                }
                            }
                        }
                    }
                    TOTALS();
                    refreshTableToolStripMenuItem.Enabled = false;
                }
                else
                {
                    refreshTableToolStripMenuItem.Enabled = true;
                }
            }
            catch (InvalidOperationException ex)
            {
                lbl_error_message.Text = "An invalid operation exception occured: " + ex.Message;
            }
            catch (Exception ex)
            {
                // Handle any other exception
                lbl_error_message.Text = "An exception error occured: " + ex.Message;
            }
        }

        private void cbo_srch_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search_TextChanged(sender, e);
        }
        private void EnableAll()
        {
            try
            {
                chk_all.Enabled = true;
                chk_all2.Enabled = true;
                menuStrip1.Enabled = true;
                cbo_CustID.Enabled = true;
                txt_Cust_Name.Enabled = true;
                txt_Type.Enabled = true;
                txt_Cust_SAddress.Enabled = true;
                btn_sup_add.Enabled = true;
                btn_sup_delete.Enabled = true;
                dtg_AddedStocks.Enabled = true;
                btn_searchCustomer.Enabled = true;
                btn_Cust_Gen.Enabled = true;
                btn_edit.Enabled = true;
                cbo_srch_type.Enabled = true;
                txt_Search.Enabled = true;
                refreshTableToolStripMenuItem.Enabled = true;

                return;
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occured from enable all: " + ex.Message;
            }
        }

        private void outboundListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //outbound
                StockOutList frm = new StockOutList(Global_ID, Fullname, JobRole);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occured: " + ex.Message;
            }
        }

        private void backgroundStockOut_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                if (Gen_Trans != "")
                {
                    Invoice_Silent.Invoice_Silent silent_batch = new Invoice_Silent.Invoice_Silent();
                    System.Threading.Tasks.Task task = silent_batch.Invoice("out", Gen_Trans, "batch");

                    e.Result = "Transaction Sent To \"My Documents\"!";
                }
                else
                {
                    e.Result = "No Transaction Reference Number Generated, Batching Failed";
                }
            }
            catch (Exception ex)
            {
                e.Result = "Error: " + ex.Message;
            }
        }

        private void backgroundStockOut_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // Handle any errors that occurred during the background task
                notifyIcon1.ShowBalloonTip(10000, "Batching Failed", e.Error.Message, ToolTipIcon.Warning);
            }
            else
            {
                // Handle completion of the background task
                if (e.Result != null)
                {
                    notifyIcon1.ShowBalloonTip(10000, "Batching Successful", e.Result.ToString(), ToolTipIcon.Info);
                }
            }
        }

        private void dtg_AddedStocks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Update_Qty_Stocks();
        }

        private void out_amt_TextChanged(object sender, EventArgs e)
        {
            func.Label_Two_Decimal_Places(sender, e, out_amt);
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CustSupplier.CustSupp frm = new CustSupplier.CustSupp(Global_ID, Fullname, JobRole, "Cust");
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cbo_CustID.Text = frm.cusID;
                }
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occured: " + ex.Message;
            }
        }
        string Gen_Trans;

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_AddedStocks.Rows.Count == 0)
                {
                    MessageBox.Show("Table is empty! Please add some items to return", "Nothing to Return", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                Generate_Trans();

                Report_Viewer frm = new Report_Viewer();
                ReportDataSource rs = new ReportDataSource();
                ReportParameterCollection reportParameters = new ReportParameterCollection();

                string report_date = DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve);
                string cust_name = txt_Cust_Name.Text;
                string address = txt_Cust_SAddress.Text;
                List<Items_DataSet> list2 = new List<Items_DataSet>();
                if (dtg_AddedStocks.Rows.Count >= 1)
                {
                    list2 = dtg_AddedStocks.Rows.Cast<DataGridViewRow>()
                    .Select(row => new Items_DataSet
                    {
                        Item_Name = row.Cells["ItemName"].Value.ToString(),
                        Description = row.Cells["ItemName"].Value.ToString(),
                        Brand = row.Cells["Brand"].Value.ToString(),
                        Quantity = row.Cells["Quantity"].Value.ToString(),
                        Price = row.Cells["pprice"].Value.ToString(),
                        Amount = row.Cells["Total"].Value.ToString(),
                    }).ToList();
                }

                rs.Name = "Out_DataSet";
                rs.Value = list2;


                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.ProcessingMode = ProcessingMode.Local;
                frm.reportViewer1.LocalReport.ReportPath = Includes.AppSettings.Invoice_RDLC_Path + @"\\Invoice_out.rdlc";

                reportParameters.Add(new ReportParameter("ReportDate", report_date));
                reportParameters.Add(new ReportParameter("TransRef", Gen_Trans));
                reportParameters.Add(new ReportParameter("Customer_Name", cust_name));
                reportParameters.Add(new ReportParameter("Address", address));
                reportParameters.Add(new ReportParameter("Total_Items", dtg_AddedStocks.Rows.Count.ToString()));
                reportParameters.Add(new ReportParameter("Total_QTY", out_qty.Text));
                reportParameters.Add(new ReportParameter("Total", out_amt.Text));
                //Load out status and remarks
                string status = string.Empty;
                if (chk_paid.Checked)
                {
                    status = "PAID";
                }
                else
                {
                    status = "UNPAID";
                }
                reportParameters.Add(new ReportParameter("PaymentStatus", status));
                reportParameters.Add(new ReportParameter("Remarks", txt_remarks.Text));

                RDLCSupportingClass supportingClass = new RDLCSupportingClass();
                //load company info
                CompanyInfo companyinfo = supportingClass.LoadCompanyInfo();
                if (companyinfo != null)
                {
                    reportParameters.Add(new ReportParameter("Company", companyinfo.Name));

                }
                else
                {
                    reportParameters.Add(new ReportParameter("Company", ""));
                }
                frm.reportViewer1.LocalReport.SetParameters(reportParameters);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An exception error occured: " + ex.Message;
            }
        }

        private void Generate_Trans()
        {
            try
            {
                ID_Generator gen = new ID_Generator();
                string id = string.Empty;
                bool hasDuplicate = true;
                while (hasDuplicate)
                {
                    gen.Generate_Transaction();
                    sql = "Select `Transaction Reference` from `ID_Generated` ";
                    config.singleResult(sql);
                    if (config.dt.Rows.Count > 0)
                    {
                        id = Convert.ToString(config.dt.Rows[0]["Transaction Reference"]);

                        sql = "SELECT COUNT(*) FROM `Stock Out` WHERE `Transaction Reference` = '" + id + "'";
                        config.singleResult(sql);
                        if (Convert.ToInt32(config.dt.Rows[0][0]) > 0)
                        {
                            gen.Generate_Transaction();
                        }
                        else
                        {
                            Gen_Trans = id;
                            hasDuplicate = false;

                        }
                    }

                }
            }
            catch (SqlException ex)
            {
                lbl_error_message.Text = "A sql exception error occured: " + ex.Message;
            }
        }

        private void PreloadWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                sql = "Select * from Stocks order by `Entry Date` desc limit 10";
                this.Invoke(new MethodInvoker(delegate { config.Load_DTG(sql, dtg_Stocks); }));


                this.Invoke(new MethodInvoker(delegate { DTG_Property(); }));
                sql = "Select Low_Detection from Settings";
                config.singleResult(sql);
                //DTG STOCKS LOW DETECTION
                if (config.dt.Rows.Count > 0)
                {
                    foreach (DataGridViewRow rw in dtg_Stocks.Rows)
                    {
                        int qty;
                        int.TryParse(Convert.ToString(config.dt.Rows[0]["Low_Detection"]), out qty);
                        if (Convert.ToInt32(rw.Cells[6].Value) <= qty)
                        {
                            //rw.DefaultCellStyle.ForeColor = Color.Red;
                            this.Invoke(new MethodInvoker(delegate { rw.DefaultCellStyle.ForeColor = Color.Red; }));
                        }
                    }
                }
                TOTALS();
            }
            catch (SqlException ex)
            {
                e.Result = ex.Message;
            }
            catch (Exception exc)
            {
                e.Result = exc.Message;
            }

        }

        private void PreloadWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    lbl_error_message.Text = e.Error.Message;
                    lbl_error_message.ForeColor = Color.Red;
                    timer_error.Enabled = true;
                }));
            }
            isWorkerBusy = false;
            lbl_error_message.Text = "Inventory item list limit by 10. Please search for the exact item. Thank you";
            lbl_error_message.ForeColor = Color.Green;
            timer_error.Enabled = true;

        }

        private void timer_error_Tick(object sender, EventArgs e)
        {
            lbl_error_message.Text = "";
            timer_error.Enabled = false;
        }

        private void SaveStatus()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Gen_Trans))
                {
                    try
                    {
                        string status = string.Empty;
                        if (chk_paid.Checked)
                        {
                            status = "PAID";
                        }
                        else
                        {
                            status = "UNPAID";
                        }

                        sql = string.Empty;
                        SQLConfig config = new SQLConfig();
                        sql = "Select * from StockOutStatus where TransRef = '" + Gen_Trans + "'";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count == 0)
                        {
                            sql = "Insert into StockOutStatus ( TransRef, Status, Remarks ) values ( '" + Gen_Trans + "', '" + status + "', '" + txt_remarks.Text + "') ";
                            config.Execute_Query(sql);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An exception error occured at saving status: " + ex.Message;
            }
        }
        Inventory_System02.Invoice_Code.Invoice_Code out_trans_rec = new Invoice_Code.Invoice_Code();
        private void btn_Saved_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_AddedStocks.Rows.Count == 0)
                {
                    MessageBox.Show("You need to add items in stock outbound table below inbound table.\nDouble click on the rows or press the \"add selected below\"", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_sup_add.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(cbo_CustID.Text))
                {
                    MessageBox.Show("Customer or Division \"ID\" should not be empty. Thank you", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_CustID.Focus();

                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_Cust_Name.Text))
                {
                    MessageBox.Show("Customer or Division \"NAME\" should not be empty. Thank you", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Cust_Name.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_Cust_SAddress.Text))
                {
                    MessageBox.Show("Customer or Division \"ADDRESS\" should not be empty. Thank you", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Cust_SAddress.Focus();

                    return;
                }

                if (MessageBox.Show("Selected items will be deducted from inbound record. \n\nPlease confirm stock out?", "Important Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Gen_Trans = string.Empty;
                    Generate_Trans();
                    foreach (DataGridViewRow rw in dtg_Stocks.Rows)
                    {
                        sql = "Select Quantity, Total, Status from Stocks where `Stock ID` = '" + rw.Cells[2].Value + "' ";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count == 1)
                        {
                            string info = "Item was altered an outbound was made! ref " + Gen_Trans;
                            sql = "Update Stocks set Quantity = '" + Convert.ToInt32(rw.Cells[6].Value) + "', Total ='" + Convert.ToDecimal(rw.Cells[8].Value) + "', Status = '" + info + "' where `Stock ID` = '" + rw.Cells[2].Value + "' ";
                            config.Execute_Query(sql);
                        }
                    }


                    foreach (DataGridViewRow stock_out_row in dtg_AddedStocks.Rows)
                    {
                        sql = "Insert into `Stock Out` ( " +
                            " `Entry Date` " +
                            ",`Customer ID` " +
                            ",`Customer Name` " +
                            ",`Customer Address` " +
                            ",`Stock ID` " +
                            ",`Item Name` " +
                            ",`Brand` " +
                            ",`Description` " +
                            ",`Quantity` " +
                            ",`Price` " +
                            ",`Total` " +
                            ",`Transaction Reference` " +
                            ",`User ID` " +
                            ",`Warehouse Staff Name` " +
                            ",`Job Role`" +
                            ",`Status` ) values ( " +
                            " '" + DateTime.Now.ToString(Includes.AppSettings.DateFormatSave) + "' " +
                            ",'" + cbo_CustID.Text + "' " +
                            ",'" + txt_Cust_Name.Text + "' " +
                            ",'" + txt_Cust_SAddress.Text + "' " +
                            ",'" + stock_out_row.Cells[0].Value.ToString() + "' " +
                            ",'" + stock_out_row.Cells[1].Value.ToString() + "' " +
                            ",'" + stock_out_row.Cells[2].Value.ToString() + "' " +
                            ",'" + stock_out_row.Cells[3].Value.ToString() + "' " +
                            ",'" + Convert.ToInt32(stock_out_row.Cells[4].Value) + "' " +
                            ",'" + Convert.ToDecimal(stock_out_row.Cells[5].Value) + "' " +
                            ",'" + Convert.ToDecimal(stock_out_row.Cells[6].Value) + "' " +
                            ",'" + Gen_Trans + "' " +
                            ",'" + Global_ID + "' " +
                            ",'" + Fullname + "' " +
                            ",'" + JobRole + "'" +
                            ",'New outbound transaction' )";
                        config.Execute_Query(sql);

                        func.Due_Date_Warranty(Gen_Trans);
                    }

                    if (MessageBox.Show("Print Transaction?", "Important Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Gen_Trans != "")
                        {
                            System.Threading.Tasks.Task task = out_trans_rec.Invoice("out", Gen_Trans, "print");
                        }
                        else
                        {
                            MessageBox.Show("Print unsuccessful due to no Transaction Reference Number Generated! Contact developers for hotfix.",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    backgroundStockOut.RunWorkerAsync();
                    SaveStatus();

                    sql = "Select * from `Stock Out` where `Transaction Reference` =   '" + Gen_Trans + "' ";
                    config.singleResult(sql);
                    if (config.dt.Rows.Count > 0)
                    {

                        MessageBox.Show("Successfully updated \"inbound records\" and Item(s) moved to \"outbound stock\" list! \n\nTransaction Successful!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        previewToolStripMenuItem_Click(sender, e);
                        dtg_AddedStocks.Rows.Clear();

                        cbo_CustID.Text = "";
                        txt_Cust_Name.Text = "";
                        txt_Type.Text = "";
                        txt_Cust_SAddress.Text = "";
                        refreshTableToolStripMenuItem_Click(sender, e);
                        EnableAll();

                        return;
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful transaction please try again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    EnableAll();
                }
                TOTALS();
            }
            catch (Exception ex)
            {
                lbl_error_message.Text = "An error occured: " + ex.Message;
            }
        }
    }
}
