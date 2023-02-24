using Inventory_System02.Includes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

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
                    double quantty = Convert.ToDouble(config.dt.Rows[0].Field<string>("Low_Detection"));
                    if (Convert.ToDouble(rw.Cells[6].Value) <= quantty)
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
                //dtg_Stocks.Columns[2].Visible = false;

                dtg_Stocks.Columns[8].Visible = false;
                dtg_Stocks.Columns[9].Visible = false;
                dtg_Stocks.Columns[10].Visible = false;
                dtg_Stocks.Columns[11].Visible = false;
                dtg_Stocks.Columns[12].Visible = false;
                dtg_Stocks.Columns[13].Visible = false;
                dtg_Stocks.Columns[14].Visible = false;

                config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));


                foreach (DataRow rw in config.dt.Rows)
                {
                    if (File.Exists(rw[8].ToString()))
                    {
                        rw["Image"] = File.ReadAllBytes(rw[8].ToString());
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

                dtg_Stocks.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_Stocks.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dtg_Stocks.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_Stocks.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtg_AddedStocks.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_AddedStocks.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
        }

        private void btn_sup_add_Click(object sender, EventArgs e)
        {
            if (dtg_Stocks.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow rw in dtg_Stocks.SelectedRows)
                {
                    for (int i = 0; i < dtg_AddedStocks.Rows.Count; i++)
                    {
                        if (rw.Cells[2].Value == dtg_AddedStocks.Rows[i].Cells[0].Value)
                        {
                            MessageBox.Show("This item is already added to the table \n\nWarning!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                         
                        }
                    }
                    if (rw.Cells[6].Value.ToString() != "0")
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
                        dtg_AddedStocks.Rows[0].Cells[4].Selected = true;
                        Update_Qty_Stocks();   
                        chk_all.Checked = false;
                        return;
                    }

                }
            }
            else
            {
                dtg_Stocks.CurrentRow.Selected = true;
            }
        }
        double quan = 0;
        
        private void TOTALS()
        {
            if ( dtg_AddedStocks.Rows.Count > 0 )
            {
                HashSet<double> distinctQuantities = new HashSet<double>();
                double totalQty = 0;
                double totalAmt = 0;

                for (int i = 0; i < dtg_AddedStocks.Rows.Count; i++)
                {
                    double.TryParse(dtg_AddedStocks.Rows[i].Cells[4].Value.ToString(), out double qty);
                    double.TryParse(dtg_AddedStocks.Rows[i].Cells[5].Value.ToString(), out double price);

                    totalQty += qty;
                    totalAmt += qty * price;

                    distinctQuantities.Add(qty);
                }

                out_qty.Text = totalQty.ToString();
                out_amt.Text = totalAmt.ToString();
                lbl_numb_out_items.Text = "Number of outbound items: " + distinctQuantities.Count.ToString();

            }
            else
            {
                lbl_numb_out_items.Text = "";
                out_qty.Text = "";
                out_amt.Text = "";
            }
        
            if ( dtg_Stocks.Rows.Count > 0 )
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

        private void btn_sup_delete_Click(object sender, EventArgs e)
        {

            if (dtg_AddedStocks.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dtg_AddedStocks.SelectedRows)
                {
                    refreshTableToolStripMenuItem.Enabled = false;
                    dtg_AddedStocks.Rows.RemoveAt(item.Index);
                    checkBox1.Checked = false;
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
            chk_all.Checked = false;
        }


        private void viewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutList frm = new StockOutList(Global_ID, Fullname, JobRole);
            frm.ShowDialog();
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
            sql = "Select * from Stocks where " + search_for + " like '%" + txt_Search.Text + "%'";
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
            checkBox1.Checked = false;
        }

        private void btn_searchCustomer_Click(object sender, EventArgs e)
        {
            customerListToolStripMenuItem_Click(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dtg_AddedStocks.Rows.Count > 0)
            {
                if (checkBox1.Checked)
                {
                    if (cbo_CustID.Text == "")
                    {
                        cbo_CustID.Focus();
                    }
                    else
                    {
                        btn_Saved.Enabled = true;
                    }
                    dtg_AddedStocks.Enabled = false;
                }
                else
                {
                    btn_Saved.Enabled = false;
                    dtg_AddedStocks.Enabled = true;

                    dtg_AddedStocks.CurrentRow.Selected = true;
                    menuStrip2.Focus();

                }
                TOTALS();
            }
            else
            {
                checkBox1.Checked = false;
            }
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
                chk_all2.Checked = false;   
            }
        }

        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {
            func.Select_All_Dtg(dtg_Stocks, chk_all);
        }

        private void dtg_AddedStocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chk_all.Checked = false;
            chk_all2.Checked = false;
        }

        private void chk_all2_CheckedChanged(object sender, EventArgs e)
        {
            func.Select_All_Dtg(dtg_AddedStocks, chk_all2);

        }

        private void dtg_AddedStocks_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(func.NumbersOnlyDTG_Keypress);
            if (dtg_AddedStocks.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(func.NumbersOnlyDTG_Keypress);
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
                    dtg_Stocks.CurrentRow.Cells[14].Value.ToString(),
                    dtg_Stocks.CurrentRow.Cells[3].Value.ToString(),
                    dtg_Stocks.CurrentRow.Cells[4].Value.ToString(),
                    dtg_Stocks.CurrentRow.Cells[5].Value.ToString(),
                    dtg_Stocks.CurrentRow.Cells[6].Value.ToString(),
                    dtg_Stocks.CurrentRow.Cells[7].Value.ToString(),
                    total_amount.ToString(),
                    dtg_Stocks.CurrentRow.Cells[12].Value.ToString());

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
                                rw.Cells[6].Value = ds.Tables[0].Rows[0].Field<string>("Quantity");
                                //check the quantity if its greater or equal to added stocks
                                if (Convert.ToDouble(rw.Cells[6].Value) >= Convert.ToDouble(dtg_AddedStocks.Rows[i].Cells[4].Value))
                                {
                                    //Change the value of the stocks minus the added stocks
                                    rw.Cells[6].Value = Convert.ToDouble(rw.Cells[6].Value) - Convert.ToDouble(dtg_AddedStocks.Rows[i].Cells[4].Value);
                                    //Calculate the total (qty of added stocks * the price )
                                    dtg_AddedStocks.Rows[i].Cells[6].Value = 0;
                                    dtg_AddedStocks.Rows[i].Cells[6].Value = Convert.ToDouble(dtg_AddedStocks.Rows[i].Cells[4].Value) *
                                        Convert.ToDouble(dtg_AddedStocks.Rows[i].Cells[5].Value);
                                
                                }
                                else
                                {
                                    MessageBox.Show("Quantity is more than Stocks, Invalid Quantity!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    if (Convert.ToDouble(rw.Cells[6].Value) == 0)
                                    {
                                        dtg_AddedStocks.Rows[i].Cells[4].Value = 0;
                                        rw.Cells[6].Value = ds.Tables[0].Rows[0].Field<string>("Quantity");
                                    }
                                    else if (Convert.ToDouble(rw.Cells[6].Value) > 0)
                                    {
                                        dtg_AddedStocks.Rows[i].Cells[4].Value = 1;
                                        rw.Cells[6].Value = Convert.ToDouble(ds.Tables[0].Rows[0].Field<string>("Quantity")) - 1;
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
                                    dtg_AddedStocks.Rows[i].Cells[6].Value = Convert.ToDouble(dtg_AddedStocks.Rows[i].Cells[4].Value) *
                                        Convert.ToDouble(dtg_AddedStocks.Rows[i].Cells[5].Value);
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

        private void cbo_srch_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search_TextChanged(sender, e);
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(checkBox1, "Click me to verify or confirm that stock out button is enabled.\nIf not, therefore you need to add customer info or  just complete the process.");
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

                if ( MessageBox.Show("Warehouse will updated all items will be removed to record. \n\nPlease confirm stock out?", "Important Message", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question ) == DialogResult.Yes )
                {
                  
                    foreach (DataGridViewRow rw in dtg_Stocks.Rows)
                    {
                        sql = "Select Quantity from Stocks where `Stock ID` = '" + rw.Cells[2].Value + "' ";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count >= 0)
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
                         ", `Stock ID` " +
                         ",`Item Name` " +
                         ",`Brand` " +
                         ",`Description` " +
                         ",`Quantity` " +
                         ",`Price` " +
                         ",`Total` " +
                         ",`Customer ID` " +
                         ",`Customer Name` " +
                         ",`Customer Address` " +
                         ",`User ID` " +
                         ",`Warehouse Staff Name` " +
                         ",`Job Role` " +
                         ",`Transaction Reference` ) values ( " +
                         " '" + DateTime.Now.ToString(Includes.AppSettings.DateFormat) + "' " +
                         ", '" + stock_out_row.Cells[0].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[1].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[2].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[3].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[4].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[5].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[6].Value.ToString() + "' " +
                         ",'" + cbo_CustID.Text + "' " +
                         ",'" + txt_Cust_Name.Text + "' " +
                         ",'" + txt_Cust_SAddress.Text + "' " +
                         ",'" + Global_ID + "' " +
                         ",'" + Fullname + "' " +
                         ",'" + JobRole + "' " +
                         ",'" + Gen_Trans + "' )";
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
                            MessageBox.Show("Print unsuccussfel due to no Transaction Reference Number Generated! Contact developers for hotfix.",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    sql = "Select * from `Stock Out` where `Transaction Reference` =   '" + Gen_Trans + "' ";
                    config.singleResult(sql);
                    if ( config.dt.Rows.Count > 0 ) 
                    {
                        MessageBox.Show("Successfully Updated the \"Stock Records\" and Item Move to \"Stock Out\" list! \n\nTransaction Successful!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtg_AddedStocks.Rows.Clear();

                        cbo_CustID.Text = "";
                        txt_Cust_Name.Text = "";
                        txt_Cust_SAddress.Text = "";
                        refreshTableToolStripMenuItem_Click(sender, e);
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
                    checkBox1.Checked = false;
                    return;
                }

            }
            TOTALS();
            checkBox1.Checked = false;
        }
    }
}
