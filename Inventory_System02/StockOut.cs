using Inventory_System02.Includes;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Inventory_System02
{

    public partial class StockOut : Form
    {
        SQLConfig config = new SQLConfig();
        ID_Generator gen = new ID_Generator();
        usableFunction func = new usableFunction();

        string sql, Global_ID, Fullname, JobRole, Gen_Trans;


        string item_image_location = @"CommonSql\Pictures\Item\Image\";

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
            chk_ItemID.Checked = true;
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
                        rw["Image"] = File.ReadAllBytes(item_image_location + "DONOTDELETE_SUBIMAGE.PNG");
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
                            TOTALS();
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
                        TOTALS();
                        chk_all.Checked = false;
                    }

                }
            }
            else
            {
                dtg_Stocks.CurrentRow.Selected = true;
            }
            TOTALS();

        }
        double qty1 = 0, amt1 = 0, price1 = 0, amt2 = 0, quan = 0;
        private void TOTALS()
        {
            if ( dtg_AddedStocks.Rows.Count > 0 )
            {
                for (int i = 0; i < dtg_AddedStocks.Rows.Count; i++)
                {
                    double.TryParse(dtg_AddedStocks.Rows[i].Cells[4].Value.ToString(), out qty1);
                    double.TryParse(dtg_AddedStocks.Rows[i].Cells[6].Value.ToString(), out price1);
                    amt1 += qty1;
                    amt2 += price1;
                    quan = i;
                    
                }
                out_qty.Text = amt1.ToString();
                out_amt.Text = amt2.ToString();
                quan += 1;
                lbl_numb_out_items.Text = "Number of outbound items: " + quan.ToString();
            }
            else
            {
                lbl_numb_out_items.Text = "";
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
            TOTALS();
            Update_Qty_Stocks();
            chk_all.Checked = false;
        }


        private void viewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutList frm = new StockOutList(Global_ID, Fullname, JobRole);
            frm.ShowDialog();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (what_to_search != "" || what_to_search != null)
            {
                sql = "Select * from Stocks where " + what_to_search + " like '%" + txt_Search.Text + "%'";
                config.Load_DTG(sql, dtg_Stocks);
                DTG_Property();
            }
        }
        string what_to_search = string.Empty;
        private void chk_ItemID_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ItemID.Checked)
            {
                chk_ItemName.Checked = false;
                chk_Cat.Checked = false;
                chk_Desc.Checked = false;
                chk_Date.Checked = false;

                what_to_search = "`Stock ID`";
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

                what_to_search = "`Item Name`";
            }

            txt_Search.Focus();

        }

        private void chk_Cat_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Cat.Checked)
            {
                chk_ItemName.Checked = false;
                chk_ItemID.Checked = false;
                chk_Desc.Checked = false;
                chk_Date.Checked = false;

                what_to_search = "`Category`";
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

                what_to_search = "`Description`";
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

                what_to_search = "`Entry Date`";
            }

            txt_Search.Focus();
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

                func.Reload_Images(cust_Image, cbo_CustID.Text, @"CommonSql\Pictures\Customers\");


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
                TextBox tb = e.Control as TextBox;
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

        private void cbo_CustID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Update_Qty_Stocks()
        {
            if (dtg_AddedStocks.Rows.Count > 0)
            {
                foreach (DataGridViewRow rw in dtg_Stocks.Rows)
                {
                    for (int i = 0; i < dtg_AddedStocks.Rows.Count; i++)
                    {
                        if (rw.Cells[2].Value.ToString() == dtg_AddedStocks.Rows[i].Cells[0].Value.ToString())
                        {
                            DataSet ds = new DataSet();
                            sql = "Select Quantity from `Stocks` where `Stock ID` = '" + dtg_AddedStocks.Rows[i].Cells[0].Value.ToString() + "' ";
                            config.Load_Datasource(sql, ds);
                            if (config.dt.Rows.Count > 0)
                            {
                                rw.Cells[6].Value = ds.Tables[0].Rows[0].Field<string>("Quantity");

                                if (Convert.ToDouble(rw.Cells[6].Value) >= Convert.ToDouble(dtg_AddedStocks.Rows[i].Cells[4].Value))
                                {
                                    rw.Cells[6].Value = Convert.ToDouble(rw.Cells[6].Value) - Convert.ToDouble(dtg_AddedStocks.Rows[i].Cells[4].Value);
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
                                }
                            }
                        }
                    }
                }
            }

            if (dtg_AddedStocks.Rows.Count > 0)
            {
                refreshTableToolStripMenuItem.Enabled = false;
            }
            else
            {
                refreshTableToolStripMenuItem.Enabled = true;
            }
        }
        private void dtg_AddedStocks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Update_Qty_Stocks();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustSupplier.CustSupp frm = new CustSupplier.CustSupp(Global_ID, Fullname, JobRole, "Cust");
            frm.ShowDialog();
        }

        private void btn_Saved_Click(object sender, EventArgs e)
        {

            if (cbo_CustID.Text == "" || cbo_CustID.Text == null)
            {
                func.Error_Message1 = "Customer ID";
                btn_searchCustomer.Focus();
                func.Error_Message();
            }
            else if (txt_Cust_Name.Text == "" || txt_Cust_Name.Text == null)
            {
                func.Error_Message1 = "Customer Name";
                txt_Cust_Name.Focus();
                func.Error_Message();

            }
            else if (txt_Cust_SAddress.Text == "" || txt_Cust_SAddress.Text == null)
            {
                func.Error_Message1 = "Customer Address";
                txt_Cust_SAddress.Focus();
                func.Error_Message();
            }
            else if (dtg_AddedStocks.Rows.Count == 0)
            {
                func.Error_Message1 = "Stocks Out table";
                dtg_AddedStocks.Focus();
                func.Error_Message();
            }
            else
            {

                if (MessageBox.Show("Warehouse will updated all items will be removed to record. \n\nPlease confirm stock out?", "Important Message", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
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
                         ",`Category` " +
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
                         " '" + DateTime.Now.ToString("dd-MM-yyyy") + "' " +
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

                    MessageBox.Show("Successfully Updated the \"Stock Records\" and Item Move to \"Stock Out\" list! \n\nTransaction Successful!", "Important Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtg_AddedStocks.Rows.Clear();

                    cbo_CustID.Text = "";
                    txt_Cust_Name.Text = "";
                    txt_Cust_SAddress.Text = "";
                    refreshTableToolStripMenuItem_Click(sender, e);

                }
                else
                {
                    checkBox1.Checked = false;
                    TOTALS();
                    return;
                }

            }
            TOTALS();
            checkBox1.Checked = false;
        }
    }
}
