using Inventory_System02.Includes;
using Inventory_System02.Invoice_Code;
using Inventory_System02.Reports_Dir;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Inventory_System02
{
    public partial class StockReturned : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction(); Calculations cal = new Calculations();
        ID_Generator gen = new ID_Generator();
        string sql, Global_ID, JobRole, Fullname, due, date;
        double price = 0, qty = 0, quan = 0;
        string sup_image_location = Includes.AppSettings.Customer_DIR;
        string item_image_location = Includes.AppSettings.Image_DIR;

        public StockReturned(string globalid, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = globalid;
            Fullname = fullname;
            JobRole = jobrole;
            date = DateTime.Now.ToString(Includes.AppSettings.DateFormatSave);
        }

        private void StockReturned_Load(object sender, EventArgs e)
        {
            cbo_srch_type.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_Reasons.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void stockOutListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutList frm = new StockOutList(Global_ID, Fullname, JobRole);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_TransRefOut.Text = frm.passed_trans_ref;
            }
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustSupplier.CustSupp frm = new CustSupplier.CustSupp(Global_ID, Fullname, JobRole, "Cust");
            frm.ShowDialog();
        }

        private void btn_searchStocks_Click(object sender, EventArgs e)
        {
            stockOutListToolStripMenuItem_Click(sender, e);
        }

        private void txt_TransRefOut_TextChanged(object sender, EventArgs e)
        {
            //Suggestions while typing

            try
            {
                config = new SQLConfig();
                sql = string.Empty;
                sql = "SELECT `Transaction Reference` FROM `Stock Out` WHERE `Transaction Reference` like '%" + txt_TransRefOut.Text + "%' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count >= 1)
                {
                    sql = string.Empty;
                    config = new SQLConfig();
                    sql = "Select `Transaction Reference` from `Stock Out` where `Transaction Reference` like '%" + txt_TransRefOut.Text + "%'  order by `Entry Date` limit 10";
                    config.New_Autocomplete(sql, txt_TransRefOut);

                    if (!string.IsNullOrWhiteSpace(txt_TransRefOut.Text))
                    {
                        sql = string.Empty;
                        config = new SQLConfig();
                        //After typing

                        sql = "Select * from `Stock Out` where `Transaction Reference` = '" + txt_TransRefOut.Text + "' ";
                        config.Load_DTG(sql, dtg_Items);
                        DTG_Properties();
                        if (config.dt.Rows.Count > 0)
                        {
                            TOTALS();
                        }
                        config.singleResult(sql);
                        if (config.dt.Rows.Count > 0)
                        {
                            txt_CustID.Text = config.dt.Rows[0].Field<string>("Customer ID");
                            txt_CustName.Text = config.dt.Rows[0].Field<string>("Customer Name");
                            txt_CustAddress.Text = config.dt.Rows[0].Field<string>("Customer Address");
                            due = config.dt.Rows[0].Field<string>("Warranty Due Date");
                            func.Reload_Images(cust_Image, txt_CustID.Text, sup_image_location);

                            if (Convert.ToDateTime(date) >= Convert.ToDateTime(due))
                            {
                                lbl_DueDate.Text = "Warning Due Date is " + due;
                            }

                            chk_all.Checked = true;
                            if (dtg_Return.Rows.Count > 0)
                            {
                                dtg_Return.Rows.Clear();

                                for (int i = 0; i < dtg_Items.Rows.Count; i++)
                                {
                                    lbl_stoksout_qty.Text = "Number of items: " + i.ToString();
                                }
                            }
                            else
                            {
                                lbl_stoksout_qty.Text = "";
                            }

                        }
                        if (string.IsNullOrWhiteSpace(txt_TransRefOut.Text))
                        {
                            refreshToolStripMenuItem.Enabled = true;
                            btn_StockReturn.Enabled = true;
                        }
                        TOTALS();
                    }
                    else
                    {
                        txt_CustID.Text = "";
                        txt_CustName.Text = "";
                        txt_CustAddress.Text = "";
                        this.Refresh();
                        dtg_Items.Columns.Clear();
                        chk_all.Checked = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void DTG_Properties()
        {
            try
            {
                if (dtg_Items.Columns.Count > 0)
                {
                    dtg_Items.Columns[0].Visible = false;
                    dtg_Items.Columns[1].Visible = false;
                    dtg_Items.Columns[2].Visible = false;
                    dtg_Items.Columns[3].Visible = false;
                    dtg_Items.Columns[4].Visible = false;
                    dtg_Items.Columns[5].Visible = false;
                    dtg_Items.Columns[12].Visible = false;
                    dtg_Items.Columns[13].Visible = false;
                    dtg_Items.Columns[14].Visible = false;
                    dtg_Items.Columns[15].Visible = false;
                    dtg_Items.Columns[16].Visible = false;
                    dtg_Items.Columns[17].Visible = false;

                    if (!config.dt.Columns.Contains("Image"))
                    {
                        config.dt.Columns.Add("Image", typeof(byte[]));
                    }
                    foreach (DataRow row in config.dt.Rows)
                    {
                        string imagePath = Path.Combine(item_image_location, row[5].ToString() + ".PNG");

                        if (File.Exists(imagePath))
                        {
                            row["Image"] = File.ReadAllBytes(imagePath);
                        }
                        else
                        {
                            string subimagePath = Path.Combine(Includes.AppSettings.Image_DIR, "DONOTDELETE_SUBIMAGE.JPG");

                            if (File.Exists(subimagePath))
                            {
                                row["Image"] = File.ReadAllBytes(subimagePath);
                            }
                            else
                            {
                                subimagePath = Path.Combine(Includes.AppSettings.Image_DIR, "DONOTDELETE_SUBIMAGE.PNG");

                                if (File.Exists(subimagePath))
                                {
                                    row["Image"] = File.ReadAllBytes(subimagePath);
                                }
                                else
                                {
                                    row["Image"] = null; // or new byte[0];
                                }
                            }
                        }
                    }

                    dtg_Items.Columns["Image"].DisplayIndex = 0;



                    for (int i = 0; i < dtg_Items.Columns.Count; i++)
                    {
                        if (dtg_Items.Columns[i] is DataGridViewImageColumn)
                        {
                            ((DataGridViewImageColumn)dtg_Items.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                            break;
                        }
                    }

                    //Stock Outbound
                    //dtg_Items.Columns["Image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtg_Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtg_Items.Columns[10].DefaultCellStyle.Format = "#,##0.00";
                    dtg_Items.Columns[11].DefaultCellStyle.Format = "#,##0.00";

                    dtg_Items.Columns["Image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_Items.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtg_Items.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    dtg_Items.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_Items.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_Items.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_Items.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dtg_Items.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dtg_Items.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //Stock Return
                    dtg_Return.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dtg_Return.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dtg_Return.Columns[5].DefaultCellStyle.Format = "#,##0.00";

                    TOTALS();
                }
            }
            catch (NullReferenceException)
            {
                // Handle the exception by waiting for a short period of time and then trying the operation again
                System.Threading.Thread.Sleep(500);
                DTG_Properties();
            }
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
            sql = "Select * from `Stock Out` where " + search_for + " = '" + txt_Search.Text + "' and `Transaction Reference` = '" + txt_TransRefOut.Text + "' ORDER BY `Entry Date` DESC";
            config.Load_DTG(sql, dtg_Items);
            DTG_Properties();

            if (txt_Search.Text == "")
            {
                refreshToolStripMenuItem_Click(sender, e);
            }
        }

        private void btn_sup_add_Click(object sender, EventArgs e)
        {
            if (dtg_Items.Rows.Count <= 0)
            {
                if (MessageBox.Show("Please find a transaction first and select outbound transaction!", "Empty Table!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                     == DialogResult.Yes)
                {
                    stockOutListToolStripMenuItem_Click(sender, e);
                    TOTALS();
                }
                return;

            }
            if (dtg_Items.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow rw in dtg_Items.SelectedRows)
                {
                    bool found = false;
                    for (int i = 0; i < dtg_Return.Rows.Count; i++)
                    {
                        if (rw.Cells[5].Value == dtg_Return.Rows[i].Cells[0].Value)
                        {
                            MessageBox.Show("This " + rw.Cells[6].Value.ToString() + " is already added to the table \n\nWarning!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            found = true;
                            continue; // Skip adding the duplicate item and continue with the next item
                        }
                    }

                    due = rw.Cells[12].Value.ToString();

                    if (Convert.ToDateTime(date) > Convert.ToDateTime(due))
                    {
                        if (MessageBox.Show("The item " + rw.Cells[6].Value.ToString() + " from " + rw.Cells[3].Value.ToString()
                        + " is already past its due date. The due date was " + due + " and the system entry date was " + date + ", Do you wish to proceed?", "Passed Due Item",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }



                    if (!found && rw.Cells[9].Value.ToString() != "0")
                    {
                        dtg_Return.Rows.Add(
                       rw.Cells[5].Value.ToString(),
                       rw.Cells[6].Value.ToString(),
                       rw.Cells[7].Value.ToString(),
                       rw.Cells[8].Value.ToString(),
                       rw.Cells[9].Value.ToString(),
                       rw.Cells[10].Value.ToString(),
                       rw.Cells[11].Value.ToString()
                      );

                        Update_Qty_Stocks();
                        TOTALS();
                        chk_all.Checked = false;
                        btn_edit.Focus();
                    }
                    else if (!found && rw.Cells[9].Value.ToString() == "0")
                    {
                        MessageBox.Show("Cannot add " + rw.Cells[9].Value.ToString() + " because \'quantity\' is zero.", "Error Prompt", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
            }
            else
            {
                dtg_Items.CurrentRow.Selected = true;
            }
            TOTALS();
        }

        private void dtg_Items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_Items.CurrentRow.Selected = dtg_Items.CurrentCell.Selected;
            btn_sup_add_Click(sender, e);
            btn_edit.Focus();
        }

        private void chk_all2_CheckedChanged(object sender, EventArgs e)
        {
            func.Select_All_Dtg(dtg_Return, chk_all2);
        }

        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_all.Checked)
            {
                foreach (DataGridViewRow rw in dtg_Items.Rows)
                {
                    rw.Selected = true;
                    btn_sup_add.Focus();
                }

            }
            else
            {
                foreach (DataGridViewRow rw in dtg_Items.Rows)
                {
                    rw.Selected = false;
                    txt_CustID.Focus();
                }
            }
        }

        private void dtg_Return_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(func.NumbersOnlyDTG_Keypress);
            if (dtg_Return.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(func.NumbersOnlyDTG_Keypress);
                }
            }
        }

        private void dtg_Items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sup_add.Focus();
            if (dtg_Items.Rows.Count > 0)
            {
                func.Change_Font_DTG(sender, e, dtg_Items);
                chk_all.Checked = false;
            }
        }

        private void cbo_srch_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search_TextChanged(sender, e);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
            func.clearTxt(panel1);
        }

        private void btn_view_Click(object sender, EventArgs e)
        {

            if (dtg_Items.Rows.Count > 0)
            {
                if (dtg_Items.SelectedRows.Count >= 1)
                {
                    Items.Outbound_Preview frm = new Items.Outbound_Preview(
                    dtg_Items.CurrentRow.Cells[1].Value.ToString(),
                    dtg_Items.CurrentRow.Cells[5].Value.ToString(),
                    txt_TransRefOut.Text,
                    dtg_Items.CurrentRow.Cells[3].Value.ToString(),
                    dtg_Items.CurrentRow.Cells[4].Value.ToString(),
                    dtg_Items.CurrentRow.Cells[6].Value.ToString(),
                    dtg_Items.CurrentRow.Cells[7].Value.ToString(),
                    dtg_Items.CurrentRow.Cells[8].Value.ToString(),
                    dtg_Items.CurrentRow.Cells[9].Value.ToString(),
                    dtg_Items.CurrentRow.Cells[10].Value.ToString(),
                    dtg_Items.CurrentRow.Cells[11].Value.ToString(),
                    dtg_Items.CurrentRow.Cells[15].Value.ToString(),
                    dtg_Items.CurrentRow.Cells[12].Value.ToString());

                    frm.ShowDialog();
                }
                else
                {
                    dtg_Items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dtg_Items.Rows[0].Selected = true;
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dtg_Return.Rows.Count > 0)
            {
                if (dtg_Return.SelectedRows.Count > 0)
                {
                    Edit_Form.Edit_Form myForm = new Edit_Form.Edit_Form(dtg_Return.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dtg_Return.CurrentRow.Cells[4].Value));

                    DialogResult result = myForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Get the data entered by the user from the MyData property of the form
                        dtg_Return.CurrentRow.Cells[4].Value = myForm.MyData_qty;
                        Update_Qty_Stocks();
                    }
                }
                else
                {
                    dtg_Return.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dtg_Return.Rows[0].Selected = true;
                }
            }
        }

        private ToolTip toolTip;
        private void btn_searchStocks_MouseHover(object sender, EventArgs e)
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(btn_searchStocks, "Click to search for an existing stocks out transaction.");
        }

        private void dtg_Return_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chk_all2.Checked = false;
        }
        private void EnableAll()
        {

            chk_all.Enabled = true;
            chk_all2.Enabled = true;
            txt_TransRefOut.Enabled = true;
            txt_CustID.Enabled = true;
            txt_CustName.Enabled = true;
            txt_CustAddress.Enabled = true;
            btn_sup_add.Enabled = true;
            btn_sup_delete.Enabled = true;
            dtg_Items.Enabled = true;
            dtg_Return.Enabled = true;
            btn_searchStocks.Enabled = true;
            btn_Clear_Text.Enabled = true;
            btn_edit.Enabled = true;
            txt_Reasons.Enabled = true;
            cbo_srch_type.Enabled = true;
            txt_Search.Enabled = true;
            menuStrip1.Enabled = true;
            btn_StockReturn.Enabled = true;
            return;
        }

        private void bworker_return_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (Gen_Trans != "")
            {
                Invoice_Silent.Invoice_Silent silent_batch = new Invoice_Silent.Invoice_Silent();
                System.Threading.Tasks.Task task = silent_batch.Invoice("return", Gen_Trans, "batch");
                e.Result = "Transaction Sent To \"My Documents\"!";
            }
            else
            {
                e.Result = "Print unsuccessful due to no Transaction Reference Number Generated! Contact developers for hotfix";
            }
        }

        private void bworker_return_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
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

        private void TOTALS()
        {
            if (dtg_Return.Rows.Count > 0)
            {
                HashSet<double> distinctQuantities = new HashSet<double>();
                double totalQty = 0;
                double totalAmt = 0;

                for (int i = 0; i < dtg_Return.Rows.Count; i++)
                {
                    double.TryParse(dtg_Return.Rows[i].Cells[4].Value.ToString(), out qty);
                    double.TryParse(dtg_Return.Rows[i].Cells[5].Value.ToString(), out price);
                    totalQty += qty;
                    totalAmt += qty * price;
                    distinctQuantities.Add(qty);
                }
                quan += 1;
                out_qty.Text = totalQty.ToString();
                out_amt.Text = totalAmt.ToString();
                lbl_numb_items_return.Text = "Number of return items: " + dtg_Return.Rows.Count.ToString();
            }
            else
            {
                lbl_numb_items_return.Text = "";
                out_qty.Text = "";
                out_amt.Text = "";
            }

            if (dtg_Items.Rows.Count > 0)
            {
                quan = 0;
                for (int i = 0; i < dtg_Items.Rows.Count; i++)
                {
                    quan = i;
                }
                quan += 1;
                lbl_stoksout_qty.Text = "Number of items: " + quan.ToString();
            }
            else
            {
                lbl_stoksout_qty.Text = "";
            }

        }

        private void btn_Clear_Text_Click(object sender, EventArgs e)
        {
            func.clearTxt(panel1);
        }

        private void out_amt_Click(object sender, EventArgs e)
        {
            func.Label_Two_Decimal_Places(sender, e, out_amt);
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtg_Return.Rows.Count == 0)
            {
                MessageBox.Show("Table is empty! Please add some items to return", "Nothing to Return", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            Generate_Trans("insert2return");

            Report_Viewer frm = new Report_Viewer();
            ReportDataSource rs = new ReportDataSource();
            ReportParameterCollection reportParameters = new ReportParameterCollection();

            string report_date = DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve);
            string cust_name = txt_CustName.Text;
            string address = txt_CustAddress.Text;
            List<Items_DataSet> list2 = new List<Items_DataSet>();
            if (dtg_Return.Rows.Count >= 1)
            {
                list2 = dtg_Return.Rows.Cast<DataGridViewRow>()
                .Select(row => new Items_DataSet
                {
                    Item_Name = row.Cells["ItemName"].Value.ToString(),
                    Description = row.Cells["ItemName"].Value.ToString(),
                    Brand = row.Cells["Brand"].Value.ToString(),
                    Quantity = row.Cells["Quantity"].Value.ToString(),
                    Price = row.Cells["price111"].Value.ToString(),
                    Amount = row.Cells["amoun11"].Value.ToString(),
                }).ToList();
            }

            rs.Name = "Out_DataSet";
            rs.Value = list2;

            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.ProcessingMode = ProcessingMode.Local;
            frm.reportViewer1.LocalReport.ReportPath = Includes.AppSettings.Invoice_RDLC_Path + @"\\Invoice_return.rdlc";

            reportParameters.Add(new ReportParameter("ReportDate", report_date));
            reportParameters.Add(new ReportParameter("TransRef", Gen_Trans));
            reportParameters.Add(new ReportParameter("Customer_Name", cust_name));
            reportParameters.Add(new ReportParameter("Address", address));
            reportParameters.Add(new ReportParameter("Total_Items", dtg_Return.Rows.Count.ToString()));
            reportParameters.Add(new ReportParameter("Total_QTY", out_qty.Text));
            reportParameters.Add(new ReportParameter("Total", out_amt.Text));


            //load company info
            RDLCSupportingClass supportingClass = new RDLCSupportingClass();
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

        private void out_amt_TextChanged(object sender, EventArgs e)
        {
            func.Label_Two_Decimal_Places(sender, e, out_amt);
        }

        private void btn_sup_delete_Click(object sender, EventArgs e)
        {
            if (dtg_Return.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dtg_Return.SelectedRows)
                {
                    dtg_Return.Rows.RemoveAt(item.Index);

                    // recalculate main items
                    for (int i = 0; i < dtg_Items.Rows.Count; i++)
                    {
                        if (item.Cells[0].Value.ToString() == dtg_Items.Rows[i].Cells["Stock ID"].Value.ToString())
                        {
                            dtg_Items.Rows[i].Cells["Quantity"].Value = item.Cells[4].Value.ToString();
                            dtg_Items.Rows[i].Cells["Total"].Value = Convert.ToDecimal(dtg_Items.Rows[i].Cells["Quantity"].Value) * Convert.ToDecimal(dtg_Items.Rows[i].Cells["Price"].Value);
                        }
                    }
                    Update_Qty_Stocks();
                    chk_all2.Checked = false;
                    dtg_Return.ClearSelection();
                }
            }
            else if (dtg_Return.Rows.Count >= 1)
            {
                dtg_Return.CurrentRow.Selected = true;
            }

            if (dtg_Return.Rows.Count <= 0)
            {
                txt_TransRefOut_TextChanged(sender, e);
            }
            TOTALS();

        }
        private void Update_Qty_Stocks()
        {
            //check if there are existing rows added in return dtg
            if (dtg_Return.Rows.Count >= 1)
            {
                //do the ff code to each rows
                foreach (DataGridViewRow rw in dtg_Items.Rows)
                {
                    //i will be used as row # in dtg_return
                    for (int i = 0; i < dtg_Return.Rows.Count; i++)
                    {

                        //verify if the item is already added below cell 2 is item id of the stock table
                        if (rw.Cells[5].Value.ToString() == dtg_Return.Rows[i].Cells[0].Value.ToString())
                        {
                            //if added get the quantity based on every item row id and reference #

                            sql = "Select Quantity from `Stock Out` where `Stock ID` = '" + dtg_Return.Rows[i].Cells[0].Value.ToString() + "' and `Transaction Reference` = '" + txt_TransRefOut.Text + "'  ";
                            config.singleResult(sql);
                            //there are any items found
                            if (config.dt.Rows.Count > 0)
                            {
                                //assign the result from the stock out table
                                rw.Cells[9].Value = config.dt.Rows[0]["Quantity"].ToString();
                                //check the quantity if its greater or equal to added stocks
                                if (Convert.ToInt32(rw.Cells[9].Value) >= Convert.ToInt32(dtg_Return.Rows[i].Cells[4].Value))
                                {
                                    //Change the value of the current outbound stock minus the added for return stocks
                                    rw.Cells[9].Value = Convert.ToInt32(rw.Cells[9].Value) - Convert.ToInt32(dtg_Return.Rows[i].Cells[4].Value);
                                    //Calculate the current total inbound value times the new qty
                                    rw.Cells[11].Value = Convert.ToDecimal(rw.Cells[9].Value) * Convert.ToDecimal(rw.Cells[10].Value);
                                    dtg_Return.Rows[i].Cells[6].Value = 0;
                                    dtg_Return.Rows[i].Cells[6].Value = Convert.ToDecimal(dtg_Return.Rows[i].Cells[4].Value) *
                                       Convert.ToDecimal(dtg_Return.Rows[i].Cells[5].Value);
                                }
                                else
                                {

                                    MessageBox.Show("Quantity is more than Stocks, Invalid Quantity!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    if (Convert.ToInt32(rw.Cells[9].Value) == 0)
                                    {
                                        dtg_Return.Rows[i].Cells[4].Value = 0;
                                        rw.Cells[9].Value = config.dt.Rows[0]["Quantity"].ToString();
                                    }
                                    else if (Convert.ToInt32(rw.Cells[9].Value) >= 1)
                                    {
                                        dtg_Return.Rows[i].Cells[4].Value = 1;
                                        rw.Cells[9].Value = Convert.ToInt32(config.dt.Rows[0]["Quantity"]) - 1;
                                    }
                                    return;
                                }
                                if (Convert.ToDouble(dtg_Return.Rows[i].Cells[4].Value) == 0)
                                {

                                    func.Error_Message1 = "Quantiy is zero";
                                    dtg_Return.Rows[i].Cells[4].Value = 1;
                                    func.Error_Message();
                                    dtg_Return.Focus();
                                    btn_StockReturn.Enabled = false;
                                    return;
                                }
                                else
                                {
                                    //Calculate the total (qty of added stocks * the price )
                                    dtg_Return.Rows[i].Cells[6].Value = 0;
                                    dtg_Return.Rows[i].Cells[6].Value = Convert.ToDecimal(dtg_Return.Rows[i].Cells[4].Value) *
                                        Convert.ToDecimal(dtg_Return.Rows[i].Cells[5].Value);
                                    btn_StockReturn.Enabled = true;

                                }
                            }
                        }
                    }
                }
                TOTALS();
                refreshToolStripMenuItem.Enabled = false;
            }
            else
            {
                refreshToolStripMenuItem.Enabled = true;
            }

        }

        Inventory_System02.Invoice_Code.Invoice_Code return_trans_rec = new Invoice_Code.Invoice_Code();
        private void btn_StockReturn_Click(object sender, EventArgs e)
        {
            if (dtg_Items.Rows.Count == 0)
            {
                MessageBox.Show("You need to add items in first stock out table.\nEnter outbound transaction then double click from the row\'s table.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TransRefOut.Focus();
                return;
            }
            if (dtg_Return.Rows.Count == 0)
            {
                MessageBox.Show("You need to add items in stock return table below inbound table.\nDouble click on the rows or press the \"add selected below\"", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_sup_add.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_TransRefOut.Text))
            {
                MessageBox.Show("Transaction ID should not be emty, please add outbound transaction reference number. Thank you", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TransRefOut.Focus();

                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_CustID.Text))
            {
                MessageBox.Show("Customer or Division \"ID\" should not be emty. Thank you", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CustID.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(txt_CustName.Text))
            {
                MessageBox.Show("Customer or Division \"NAME\" should not be emty. Thank you", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CustName.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_CustAddress.Text))
            {
                MessageBox.Show("Customer or Division \"ADDRESS\" should not be emty. Thank you.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CustAddress.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Reasons.Text))
            {
                MessageBox.Show("Select or enter \"Return Reason\"! Thank you.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Reasons.Focus();

                return;
            }


            string status_words = string.Empty;
            string success_message = string.Empty;
            if (MessageBox.Show("All items will be recorded. Please confirm stock return?", "Important Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (txt_Reasons.Text == "Manufacturing Defect ( Sent back to suppliers )")
                {
                    status_words = "No return to inbound tag as Manufacturing Defect. Item sent back to supplier.";
                    success_message = "Successfully sent back to suppliers! Thank you";
                }
                else if (txt_Reasons.Text == "Damage ( Investigated or Repair )")
                {
                    status_words = "Pending return to inbound tag as Damaged. It will be investigated before return or sent back to supplier.";
                    success_message = "Successfully processed return and mark as pending. This record will be temporarily not added back to stocks! Thank you.";
                }
                else
                {
                    status_words = "A return transaction was made with the recent reference number " + Gen_Trans + ".";
                    success_message = "Successfully added to \"inbound stock record\" and item(s) moved back to \"inbound stock\" list! \n\nTransaction Successful!";
                }


                if (txt_Reasons.Text == "Manufacturing Defect ( Sent back to suppliers )")
                {
                    if (MessageBox.Show("Manufacturing Defect will not be returned to inventory rather it will be sent to the supplier. Proceed?", "Return Type Choice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        EnableAll();
                        return;
                    }
                }
                else if (txt_Reasons.Text == "Damage ( Investigated or Repair )")
                {
                    if (MessageBox.Show("Damage return type will be investigated first and tag as pending. Therefore, it will not be returned immediately to the stock list. Proceed?", "Return Type Choice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        EnableAll();
                        return;
                    }
                }
                else
                {
                    Generate_Trans("back2stocks");
                    // Transfer items back to stocks
                    foreach (DataGridViewRow rw in dtg_Return.Rows)
                    {
                        sql = "Select Quantity, Price, Total, Status from `Stocks` where `Stock ID` = '" + rw.Cells[0].Value.ToString() + "' ";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count > 0)
                        {
                            string status_info = "Item was altered, a return transaction was made! ref " + Gen_Trans;
                            int quant = Convert.ToInt32(rw.Cells[4].Value.ToString()) + Convert.ToInt32(config.dt.Rows[0]["Quantity"].ToString());
                            decimal new_total = Convert.ToDecimal(quant) * Convert.ToDecimal(config.dt.Rows[0]["Price"].ToString());
                            sql = "Update `Stocks` set Quantity = '" + quant + "', Total = '" + new_total + "', Status = '" + status_info + "' where `Stock ID` = '" + rw.Cells[0].Value.ToString() + "' ";
                            config.Execute_Query(sql);

                        }
                        else
                        {

                            sql = "Insert into Stocks ( " +
                                " `Entry Date` " +
                                ",`Stock ID` " +
                                ",`Item Name` " +
                                ",`Brand` " +
                                ",`Description` " +
                                ",`Quantity` " +
                                ",`Price` " +
                                ",`Total` " +
                                ",`User ID` " +
                                ",`Warehouse Staff Name`    " +
                                ",`Job Role` " +
                                ",`Transaction Reference` " +
                                ",`Status` ) values (" +
                                " '" + DateTime.Now.ToString(Includes.AppSettings.DateFormatSave) + "' " +
                                ",'" + rw.Cells[0].Value.ToString() + "' " +
                                ",'" + rw.Cells[1].Value.ToString() + "' " +
                                ",'" + rw.Cells[2].Value.ToString() + "' " +
                                ",'" + rw.Cells[3].Value.ToString() + "' " +
                                ",'" + Convert.ToInt32(rw.Cells[4].Value) + "' " +
                                ",'" + Convert.ToDecimal(rw.Cells[5].Value) + "' " +
                                ",'" + Convert.ToDecimal(rw.Cells[6].Value) + "' " +
                                ",'" + Global_ID + "' " +
                                ",'" + Fullname + "' " +
                                ",'" + JobRole + "' " +
                                ",'" + Gen_Trans + "'  " +
                                ",'" + status_words + "' )";
                            config.Execute_CUD(sql, "Unable to Record Item!", "Item successfully added to database!");
                        }
                    }
                }

                //Update stock out
                foreach (DataGridViewRow rw in dtg_Items.Rows)
                {
                    sql = "Select Quantity from `Stock Out` where `Stock ID` = '" + rw.Cells[5].Value + "' and `Transaction Reference` = '" + txt_TransRefOut.Text + "' ";
                    config.singleResult(sql);
                    if (config.dt.Rows.Count > 0)
                    {
                        decimal new_total = Convert.ToDecimal(rw.Cells[9].Value) * Convert.ToDecimal(rw.Cells[10].Value);
                        sql = "Update `Stock Out` set Quantity = '" + rw.Cells[9].Value.ToString() + "', Total = '" + new_total.ToString() + "' where  `Stock ID` = '" + rw.Cells[5].Value + "' and " + " `Transaction Reference` = '" + txt_TransRefOut.Text + "' ";
                        config.Execute_Query(sql);
                    }
                }
                Generate_Trans("insert2return");
                //insert items to return
                foreach (DataGridViewRow stock_out_row in dtg_Return.Rows)
                {
                    sql = "Insert into `Stock Returned` ( " +
                        " `Entry Date` " +
                        ",`Customer ID` " +
                        ",`Customer Name` " +
                        ",`Customer Address` " +
                        ", `Stock ID` " +
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
                        ",'" + txt_CustID.Text + "' " +
                        ",'" + txt_CustName.Text + "' " +
                        ",'" + txt_CustAddress.Text + "' " +
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
                        ",'" + status_words + "' )";

                    config.Execute_Query(sql);
                }
                string reason = string.Empty;
                if (txt_Reasons.Text == "Return to Stocks")
                {
                    reason = "Returned to Stocks";
                    cal.ReturnReason(Gen_Trans, txt_CustID.Text, reason, txt_remarks.Text);
                }
                else
                {
                    cal.ReturnReason(Gen_Trans, txt_CustID.Text, txt_Reasons.Text, txt_remarks.Text);
                }

                if (MessageBox.Show("Print Transaction?", "Important Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Gen_Trans != "")
                    {
                        System.Threading.Tasks.Task task = return_trans_rec.Invoice("return", Gen_Trans, "print");
                    }
                    else
                    {
                        MessageBox.Show("Print unsuccessful due to no \"Transaction Reference Number Generated\"! Contact developer for hotfix.",
                            "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                bworker_return.RunWorkerAsync();
                sql = "Select * from `Stock Returned` where `Transaction Reference` =   '" + Gen_Trans + "' ";
                config.singleResult(sql);

                if (config.dt.Rows.Count > 0)
                {

                    MessageBox.Show(success_message, "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    previewToolStripMenuItem_Click(sender, e);

                    dtg_Return.Rows.Clear();
                    txt_CustID.Text = "";
                    txt_CustName.Text = "";
                    txt_CustAddress.Text = "";
                    txt_TransRefOut_TextChanged(sender, e);
                    txt_Reasons.Text = "";
                    EnableAll();
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

        }
        string Gen_Trans;
        private void Generate_Trans(string what_table)
        {
            Gen_Trans = string.Empty;
            ID_Generator gen = new ID_Generator();
            string id = string.Empty;
            sql = string.Empty;
            bool hasDuplicate = true;
            while (hasDuplicate)
            {
                gen.Generate_Transaction();
                sql = "Select `Transaction Reference` from `ID_Generated` ";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    id = Convert.ToString(config.dt.Rows[0]["Transaction Reference"]);
                    if (what_table == "insert2return")
                    {
                        sql = "SELECT COUNT(*) FROM `Stock Returned` WHERE `Transaction Reference` = '" + id + "'";
                    }
                    else if (what_table == "back2stocks")
                    {
                        sql = "SELECT COUNT(*) FROM `Stocks` WHERE `Transaction Reference` = '" + id + "'";
                    }
                    if (!string.IsNullOrWhiteSpace(sql))
                    {
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
        }

        private void dtg_Return_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Update_Qty_Stocks();
        }
    }
}
