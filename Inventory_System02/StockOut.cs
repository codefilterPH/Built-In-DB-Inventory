using Inventory_System02.Includes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Input;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;
using System.Threading;

namespace Inventory_System02
{

    public partial class StockOut : Form
    {
        SQLConfig config = new SQLConfig();
        ID_Generator gen = new ID_Generator();
        usableFunction func = new usableFunction();

        string sql, Global_ID, Fullname, JobRole, Gen_Trans;

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
            btn_Saved.Enabled = false;
        }

        private void btn_Cust_Gen_Click(object sender, EventArgs e)
        {
            gen.Customer_ID();
            sql = "Select `Customer ID` from ID_Generated where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                cbo_CustID.Text = config.dt.Rows[0].Field<string>("Customer ID");
            }
        }

        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "Select * from Stocks order by `Entry Date` desc";
            config.Load_DTG(sql, dtg_Stocks);
         
            DTG_Property();

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
                        rw.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            TOTALS();
        }

        private void DTG_Property()
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

                config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));

                foreach (DataRow rw in config.dt.Rows)
                {
                    if (File.Exists(rw[9].ToString()))
                    {
                        rw["Image"] = File.ReadAllBytes(rw[9].ToString());
                    }
                    else
                    {
                        rw["Image"] = File.ReadAllBytes(Includes.AppSettings.Image_DIR + "DONOTDELETE_SUBIMAGE.PNG");
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

                dtg_Stocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtg_Stocks.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_Stocks.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dtg_Stocks.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_Stocks.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtg_Stocks.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;   
                //STOCK OUTBOUND
                dtg_AddedStocks.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_AddedStocks.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
        }
        private void TOTALS()
        {
            if (dtg_AddedStocks.Rows.Count > 0)
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
                lbl_numb_out_items.Text = "";
                out_qty.Text = "";
                out_amt.Text = "";
            }

            if (dtg_Stocks.Rows.Count > 0)
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
                lbl_items_qty.Text = "";
            }
        }

        private void btn_sup_add_Click(object sender, EventArgs e)
        {
            if (dtg_Stocks.SelectedRows.Count > 0)
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
                    }
                    else if (!found && rw.Cells[6].Value.ToString() == "0")
                    {
                        MessageBox.Show("Cannot add " + rw.Cells[3].Value.ToString() + " because \'quantity\' is zero.", "Error Prompt", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            else
            {
                dtg_Stocks.CurrentRow.Selected = true;
            }

        }
        double quan = 0;
        private void btn_sup_delete_Click(object sender, EventArgs e)
        {

            if (dtg_AddedStocks.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dtg_AddedStocks.SelectedRows)
                {
                    refreshTableToolStripMenuItem.Enabled = false;
                    dtg_AddedStocks.Rows.RemoveAt(item.Index);
                    chk_review.Checked = false;
                }
            }
            else if ( dtg_AddedStocks.Rows.Count >= 1)
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


        private void viewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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
            if ( dtg_AddedStocks.Rows.Count > 0)
            {
                Update_Qty_Stocks();
            }

            if (txt_Search.Text == "")
            {
                refreshTableToolStripMenuItem_Click(sender, e);
            }
        }
  
        private void cbo_CustID_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from `Customer` where `Customer ID` = '" + cbo_CustID.Text + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txt_Cust_Name.Text = config.dt.Rows[0].Field<string>("First Name").ToString() + " " + config.dt.Rows[0].Field<string>("Last Name").ToString();
                txt_Cust_SAddress.Text = config.dt.Rows[0].Field<string>("Address").ToString();
                txt_Type.Text = config.dt.Rows[0].Field<string>("Type").ToString();

                func.Reload_Images(cust_Image, cbo_CustID.Text, Includes.AppSettings.Customer_DIR);


                //dtg_Stocks.Rows[0].Selected = true;
                btn_sup_add.Focus();

            }
            chk_review.Checked = false;
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
        { //Copy and pasting dot not included as well as typing it.
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

        private void dtg_Stocks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_Stocks.CurrentRow.Selected = dtg_Stocks.CurrentCell.Selected;
            btn_sup_add_Click(sender, e);
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (dtg_Stocks.Rows.Count > 0)
            {
                if (dtg_Stocks.SelectedRows.Count >= 1 )
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

        private void btn_edit_Click(object sender, EventArgs e)
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
        private ToolTip toolTip;
        private void btn_searchCustomer_MouseHover(object sender, EventArgs e)
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip ( btn_searchCustomer, "Click to search for an existing customer." );
        }
        private void Update_Qty_Stocks()
        {   
            //verify if there are rows in dtg_return
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
                                    //Change the value of the stocks minus the added stocks
                                    rw.Cells[6].Value = Convert.ToInt32(rw.Cells[6].Value) - Convert.ToInt32(dtg_AddedStocks.Rows[i].Cells[4].Value);
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
                                    else if (Convert.ToInt32(rw.Cells[6].Value) > 0)
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

        private void cbo_srch_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search_TextChanged(sender, e);
        }
        private void EnableAll()
        {
           
            chk_all.Enabled= true;
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
            btn_Saved.Enabled = false;
            refreshTableToolStripMenuItem.Enabled = true;




            return;
        }
        private void chk_review_CheckedChanged(object sender, EventArgs e)
        {
            if (!chk_review.Checked)
            {
                EnableAll();
            }
            else
            {
                chk_review.Checked = false;
                if (dtg_AddedStocks.Rows.Count == 0)
                {
                    MessageBox.Show("You need to add items in stock outbound table below inbound table.\nDouble click on the rows or press the \"add selected below\"", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_sup_add.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(cbo_CustID.Text))
                {
                    MessageBox.Show("Customer or Division \"ID\" should not be emty.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_CustID.Focus();

                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_Cust_Name.Text))
                {
                    MessageBox.Show("Customer or Division \"NAME\" should not be emty.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Cust_Name.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_Cust_SAddress.Text))
                {
                    MessageBox.Show("Customer or Division \"ADDRESS\" should not be emty.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Cust_SAddress.Focus();

                    return;
                }
                else
                {
                    if (MessageBox.Show("Everything is now ready for stock return. Continue stock out?", "Complete Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        chk_all.Checked = false;
                        chk_all2.Checked = false;
                        chk_all.Enabled = false;
                        chk_all2.Enabled = false;
                        menuStrip1.Enabled = false;
                        cbo_CustID.Enabled = false;
                        txt_Cust_Name.Enabled = false;
                        txt_Type.Enabled = false;
                        txt_Cust_SAddress.Enabled = false;
                        btn_sup_add.Enabled = false;
                        btn_sup_delete.Enabled = false;
                        dtg_AddedStocks.Enabled = false;
                        btn_searchCustomer.Enabled = false;
                        btn_Cust_Gen.Enabled = false;
                        btn_edit.Enabled = false;
                        cbo_srch_type.Enabled = false;
                        txt_Search.Enabled = false;
                        btn_Saved.Enabled = true;

                        menuStrip2.Focus();
                        TOTALS();
                       
                    }
                    else
                    {
                        EnableAll();
                    }
                }
            }
        }

        private void chk_review_MouseHover(object sender, EventArgs e)
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(chk_review, "Click me to verify or confirm stock out \'button\' will be enabled.\nIf not. Therefore, you need to follow instruction and complete the process.");
        }

        private void outboundListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //outbound
            StockOutList frm = new StockOutList(Global_ID, Fullname, JobRole);
            frm.ShowDialog();
        }

        private void backgroundStockOut_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            
            if (Gen_Trans != "")
            {
                Invoice_Silent.Invoice_Silent silent_batch = new Invoice_Silent.Invoice_Silent();
                silent_batch.Invoice("out", Gen_Trans, "batch");

                e.Result = "Transaction Sent To \"My Documents\"!";
            }
            else
            {
                e.Result = "No Transaction Reference Number Generated, Batching Failed";
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

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustSupplier.CustSupp frm = new CustSupplier.CustSupp(Global_ID, Fullname, JobRole, "Cust");
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                cbo_CustID.Text = frm.cusID;
            }
        }
        Inventory_System02.Invoice_Code.Invoice_Code out_trans_rec = new Invoice_Code.Invoice_Code();
        private void btn_Saved_Click(object sender, EventArgs e)
        {

            if (cbo_CustID.Text == "" || cbo_CustID.Text == null)
            {
                func.Error_Message1 = "Customer ID";
                func.Error_Message();
                btn_searchCustomer.Focus();
            }
            else if (txt_Cust_Name.Text == "" || txt_Cust_Name.Text == null)
            {
                func.Error_Message1 = "Customer Name";
                func.Error_Message();
                txt_Cust_Name.Focus();

            }
            else if (txt_Cust_SAddress.Text == "" || txt_Cust_SAddress.Text == null)
            {
                func.Error_Message1 = "Customer Address";
                func.Error_Message();
                txt_Cust_SAddress.Focus();
            }
            else if (dtg_AddedStocks.Rows.Count == 0)
            {
                func.Error_Message1 = "Stocks Out table";
                func.Error_Message();
                dtg_AddedStocks.Focus();
            }
            else
            {

                if ( MessageBox.Show("Selected items will be deducted from inbound record. \n\nPlease confirm stock out?", "Important Message", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question ) == DialogResult.Yes )
                {
                  
                    foreach (DataGridViewRow rw in dtg_Stocks.Rows)
                    {
                        sql = "Select Quantity from Stocks where `Stock ID` = '" + rw.Cells[2].Value + "' ";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count == 1)
                        {
                            sql = "Update Stocks set Quantity = '" + rw.Cells[6].Value.ToString() + "' where `Stock ID` = '" + rw.Cells[2].Value + "' ";
                            config.Execute_Query(sql);
                        }
                    }
                    gen.Generate_Transaction();

                    sql = "Select `Transaction Reference` from `ID_Generated` where count = '1' ";
                    config.singleResult(sql);
                    if (config.dt.Rows.Count > 0)
                    {
                        Gen_Trans = config.dt.Rows[0].Field<string>("Transaction Reference");
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
                         ",`Transaction Reference` "+
                         ",`User ID` " +
                         ",`Warehouse Staff Name` " +
                         ",`Job Role`) values ( " +
                         " '" + DateTime.Now.ToString(Includes.AppSettings.DateFormat) + "' " +
                         ",'" + cbo_CustID.Text + "' " +
                         ",'" + txt_Cust_Name.Text + "' " +
                         ",'" + txt_Cust_SAddress.Text + "' " +
                         ",'" + stock_out_row.Cells[0].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[1].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[2].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[3].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[4].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[5].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[6].Value.ToString() + "' " +
                         ",'" + Gen_Trans + "' " +
                         ",'" + Global_ID + "' " +
                         ",'" + Fullname + "' " +
                         ",'" + JobRole + "' )";
                        config.Execute_Query(sql);

                        func.Due_Date_Warranty(Gen_Trans);
                    }

                    if (MessageBox.Show("Print Transaction?", "Important Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Gen_Trans != "")
                        {
                            out_trans_rec.Invoice("out", Gen_Trans, "print");
                        }
                        else
                        {
                            MessageBox.Show("Print unsuccessful due to no Transaction Reference Number Generated! Contact developers for hotfix.",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    backgroundStockOut.RunWorkerAsync();

                    sql = "Select * from `Stock Out` where `Transaction Reference` =   '" + Gen_Trans + "' ";
                    config.singleResult(sql);
                    if ( config.dt.Rows.Count > 0 ) 
                    {
                        MessageBox.Show("Successfully updated \"inbound records\" and Item(s) moved to \"outbound stock\" list! \n\nTransaction Successful!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtg_AddedStocks.Rows.Clear();

                        cbo_CustID.Text = "";
                        txt_Cust_Name.Text = "";
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
                    chk_review.Checked = false;
                    EnableAll();
                }

            }
            TOTALS();
        }
    }
}
