using Inventory_System02.Includes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Inventory_System02
{
    public partial class StockReturned : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction(); Calculations cal = new Calculations();
        ID_Generator gen = new ID_Generator();
        string sql, Global_ID, JobRole, Fullname, Gen_Trans, due, date;

        string sup_image_location = @"CommonSql\Pictures\Customers\";
        string item_image_location = @"CommonSql\Pictures\Item\Image\";

        public StockReturned(string globalid, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = globalid;
            Fullname = fullname;
            JobRole = jobrole;
            date = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void stockOutListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutList frm = new StockOutList(Global_ID, Fullname, JobRole);
            frm.ShowDialog();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustSupplier.CustSupp frm = new CustSupplier.CustSupp(Global_ID, Fullname, JobRole, "Cust");
            frm.ShowDialog();
        }

        private void btn_searchStocks_Click(object sender, EventArgs e)
        {
            StockOutList frm = new StockOutList(Global_ID, Fullname, JobRole);
            frm.ShowDialog();
        }

        private void txt_TransRefOut_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from `Stock Out` where `Transaction Reference` = '" + txt_TransRefOut.Text + "' ";
            config.Load_DTG(sql, dtg_Items);
            DTG_Properties();
            if (config.dt.Rows.Count > 0)
            {
                dtg_Items.Rows[0].Selected = true;
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
            TOTALS();
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
        private void DTG_Properties()
        {
            if (dtg_Items.Columns.Count > 0)
            {
                dtg_Items.Columns[0].Visible = false;
                dtg_Items.Columns[1].Visible = false;
                dtg_Items.Columns[8].Visible = false;
                dtg_Items.Columns[9].Visible = false;
                dtg_Items.Columns[10].Visible = false;
                dtg_Items.Columns[11].Visible = false;
                dtg_Items.Columns[12].Visible = false;
                dtg_Items.Columns[13].Visible = false;
                dtg_Items.Columns[14].Visible = false;
                dtg_Items.Columns[15].Visible = false;
                dtg_Items.Columns[16].Visible = false;

                config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));

                foreach (DataRow rw in config.dt.Rows)
                {
                    if (File.Exists(item_image_location + rw[2].ToString() + ".PNG"))
                    {
                        rw["Image"] = File.ReadAllBytes(item_image_location + rw[2].ToString() + ".PNG");
                    }
                    else
                    {
                        rw["Image"] = File.ReadAllBytes(item_image_location + "DONOTDELETE_SUBIMAGE.PNG");
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


                dtg_Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg_Items.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_Items.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_Items.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_Items.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtg_Return.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_Return.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                TOTALS();
            }
        }
        string db_column = string.Empty;
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (chk_ItemID.Checked)
            {
                db_column = "`Stock ID`";
            }
            if (chk_ItemName.Checked)
            {
                db_column = "`Item Name`";
            }
            if (chk_Cat.Checked)
            {
                db_column = "`Brand`";
            }
            if (chk_Desc.Checked)
            {
                db_column = "`Description`";
            }
            if (chk_Date.Checked)
            {
                db_column = "`Entry Date`";
            }
            sql = "Select * from `Stock Out` where " + db_column + " = '" + txt_Search.Text + "' and `Transaction Reference` = '" + txt_TransRefOut.Text + "' ";
            config.Load_DTG(sql, dtg_Items);
            DTG_Properties();
        }

        private void StockReturned_Load(object sender, EventArgs e)
        {
            chk_ItemID.Checked = true;
        }

        private void btn_sup_add_Click(object sender, EventArgs e)
        {
            if (dtg_Items.Rows.Count <= 0)
            {
                if (MessageBox.Show("Please find a transaction first and load it to the TextBox!", "Empty Query Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
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
                    for (int i = 0; i < dtg_Return.Rows.Count; i++)
                    {
                        if (rw.Cells[2].Value == dtg_Return.Rows[i].Cells[0].Value)
                        {
                            MessageBox.Show("This item is already added to the table \n\nWarning!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TOTALS();
                            return;
                        }

                    }
                    if (rw.Cells[6].Value.ToString() != "0")
                    {
                        dtg_Return.Rows.Add(
                       rw.Cells[2].Value.ToString(),
                       rw.Cells[3].Value.ToString(),
                       rw.Cells[4].Value.ToString(),
                       rw.Cells[5].Value.ToString(),
                       rw.Cells[6].Value.ToString(),
                       rw.Cells[7].Value.ToString(),
                      Convert.ToString(Convert.ToDouble(rw.Cells[6].Value) * Convert.ToDouble(rw.Cells[7].Value))
                      );

                        dtg_Return.Rows[0].Cells[4].Selected = true;
                        chk_all.Checked = false;
                        Update_Qty_Stocks();
                        TOTALS();
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
            chk_all.Checked = false;
            if (dtg_Items.Rows.Count > 0)
            {
                func.Change_Font_DTG(sender, e, dtg_Items);
                chk_all.Checked = false;
                chk_all2.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (dtg_Return.Rows.Count > 0)
            {
                if (checkBox1.Checked)
                {
                    btn_StockReturn.Enabled = true;
                    dtg_Return.Enabled = false;
                    menuStrip2.Focus();
                }
                else
                {
                    btn_StockReturn.Enabled = false;
                    dtg_Return.Enabled = true;

                    dtg_Return.CurrentRow.Selected = true;

                }
                TOTALS();
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        double amt = 0, price = 0, amt1 = 0, qty = 0, quan = 0;

        private void dtg_Return_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chk_all.Checked = false;
            chk_all2.Checked = false;
        }

        private void TOTALS()
        {
            if (dtg_Return.Rows.Count > 0)
            {
                for (int i = 0; i < dtg_Return.Rows.Count; i++)
                {
                    double.TryParse(dtg_Return.Rows[i].Cells[4].Value.ToString(), out qty);
                    double.TryParse(dtg_Return.Rows[i].Cells[6].Value.ToString(), out price);
                    amt += qty;
                    amt1 += price;
                    quan = i;
                }
                quan += 1;
                out_qty.Text = amt.ToString();
                out_amt.Text = amt1.ToString();
                lbl_numb_items_return.Text = "Number of return items: " + quan.ToString();
            }
            else
            {
                lbl_numb_items_return.Text = "";
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


        private void btn_sup_delete_Click(object sender, EventArgs e)
        {
            if (dtg_Return.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dtg_Return.SelectedRows)
                {
                    dtg_Return.Rows.RemoveAt(item.Index);
                    checkBox1.Checked = false;
                    Update_Qty_Stocks();
                    chk_all2.Checked = false;
                    dtg_Return.ClearSelection();
                }
            }
            else if ( dtg_Return.Rows.Count >= 1)
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
            if (dtg_Return.Rows.Count > 0)
            {
                foreach (DataGridViewRow rw in dtg_Items.Rows)
                {
                    for (int i = 0; i < dtg_Return.Rows.Count; i++)
                    {
                        if (rw.Cells[2].Value.ToString() == dtg_Return.Rows[i].Cells[0].Value.ToString())
                        {
                            DataSet ds = new DataSet();
                            sql = "Select Quantity from `Stock Out` where `Stock ID` = '" + dtg_Return.Rows[i].Cells[0].Value.ToString() + "' and `Transaction Reference` = '" + txt_TransRefOut.Text + "'  ";
                            config.Load_Datasource(sql, ds);
                            if (config.dt.Rows.Count > 0)
                            {
                                rw.Cells[6].Value = ds.Tables[0].Rows[0].Field<string>("Quantity");

                                if (Convert.ToDouble(rw.Cells[6].Value) >= Convert.ToDouble(dtg_Return.Rows[i].Cells[4].Value))
                                {
                                    rw.Cells[6].Value = Convert.ToDouble(rw.Cells[6].Value) - Convert.ToDouble(dtg_Return.Rows[i].Cells[4].Value);
                                }
                                else
                                {
                                    dtg_Return.Rows[i].Cells[4].Value = 0;
                                    rw.Cells[6].Value = ds.Tables[0].Rows[0].Field<string>("Quantity");
                                    MessageBox.Show("Quantity is more than Stocks, Invalid Quantity!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_StockReturn_Click(object sender, EventArgs e)
        {

            if (dtg_Return.Rows.Count > 0)
            {
                foreach (DataGridViewRow rw in dtg_Items.Rows)
                {

                    due = rw.Cells[15].Value.ToString();

                    if (Convert.ToDateTime(date) > Convert.ToDateTime(due))
                    {
                        if (MessageBox.Show("Passed Due for item " + rw.Cells[2].Value.ToString() + " " + rw.Cells[3].Value.ToString()
                        + " which is due on " + due + " where date now is " + date + ", Do you wish to proceed?", "Passed Due Item",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                            == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                }
            }

            if (txt_TransRefOut.Text == null || txt_TransRefOut.Text == "")
            {
                func.Error_Message1 = "Transaction Number Field";
                func.Error_Message();
                txt_TransRefOut.Focus();

                //NEEDS CLEAR ADDED ROWS!

            }
            else if (txt_CustID.Text == null || txt_TransRefOut.Text == "")
            {
                func.Error_Message1 = "Customer ID";
                func.Error_Message();
                txt_CustID.Focus();
            }
            else if (txt_CustName.Text == null || txt_CustName.Text == "")
            {
                func.Error_Message1 = "Customer Name";
                func.Error_Message();
                txt_CustName.Focus();
            }
            else if (txt_CustAddress.Text == null || txt_CustAddress.Text == "")
            {
                func.Error_Message1 = "Customer Address";
                func.Error_Message();
                txt_CustAddress.Focus();
            }
            else
            {
                if (MessageBox.Show("Warehouse will updated all items will be added back to record. \n\nPlease confirm stock return?", "Important Message", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    foreach (DataGridViewRow rw in dtg_Items.Rows)
                    {
                        sql = "Select Quantity from `Stock Out` where `Stock ID` = '" + rw.Cells[2].Value + "' and `Transaction Reference` = '" + txt_TransRefOut.Text + "' ";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count > 0)
                        {
                            sql = "Update `Stock Out` set Quantity = '" + rw.Cells[6].Value.ToString() + "' where  `Stock ID` = '" + rw.Cells[2].Value + "' and " +
                                " `Transaction Reference` = '" + txt_TransRefOut.Text + "' ";
                            config.Execute_Query(sql);
                        }
                    }


                    gen.Generate_Transaction();

                    foreach (DataGridViewRow rw in dtg_Return.Rows)
                    {

                        sql = "Select Quantity from `Stocks` where `Stock ID` = '" + rw.Cells[0].Value.ToString() + "' ";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count > 0)
                        {
                            double quant = Convert.ToDouble(rw.Cells[4].Value.ToString()) + Convert.ToDouble(config.dt.Rows[0].Field<string>("Quantity"));
                            sql = "Update `Stocks` set Quantity = '" + quant.ToString() + "' where  `Stock ID` = '" + rw.Cells[0].Value.ToString() + "' ";
                            config.Execute_Query(sql);

                        }
                        else
                        {
                            Generate_Trans();

                            sql = "Insert into Stocks ( " +
                                " `Entry Date` " +
                                ",`Stock ID` " +
                                ",`Item Name` " +
                                ",`Brand` " +
                                ",`Description` " +
                                ",`Quantity` " +
                                ",`Price` " +
                                ",`User ID` " +
                                ",`Warehouse Staff Name`    " +
                                ",`Job Role` " +
                                ",`Transaction Reference` ) values (" +
                                " '" + DateTime.Now.ToString("dd-MM-yyyy") + "' " +
                                ",'" + rw.Cells[0].Value.ToString() + "' " +
                                ",'" + rw.Cells[1].Value.ToString() + "' " +
                                ",'" + rw.Cells[2].Value.ToString() + "' " +
                                ",'" + rw.Cells[3].Value.ToString() + "' " +
                                ",'" + rw.Cells[4].Value.ToString() + "' " +
                                ",'" + rw.Cells[5].Value.ToString() + "' " +
                                ",'" + Global_ID + "' " +
                                ",'" + Fullname + "' " +
                                ",'" + JobRole + "' " +
                                ",'" + Gen_Trans + "'  )";
                            config.Execute_CUD(sql, "Unable to Record Item!", "Item successfully added to database!");
                        }
                    }

                    foreach (DataGridViewRow stock_out_row in dtg_Return.Rows)
                    {
                        Generate_Trans();

                        sql = "Insert into `Stock Returned` ( " +
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
                         " '" + DateTime.Now.ToString("dd-MM-yyyy") + "' " +
                         ", '" + stock_out_row.Cells[0].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[1].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[2].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[3].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[4].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[5].Value.ToString() + "' " +
                         ",'" + stock_out_row.Cells[6].Value.ToString() + "' " +
                         ",'" + txt_CustID.Text + "' " +
                         ",'" + txt_CustName.Text + "' " +
                         ",'" + txt_CustAddress.Text + "' " +
                         ",'" + Global_ID + "' " +
                         ",'" + Fullname + "' " +
                         ",'" + JobRole + "' " +
                         ",'" + Gen_Trans + "' )";
                        config.Execute_Query(sql);
                    }

                    cal.ReturnReason(Gen_Trans, txt_CustID.Text, txt_Reasons.Text);

                    MessageBox.Show("Successfully Updated the \"Stock Records\" and Item Move to \"Stock Out\" list! \n\nTransaction Successful!", "Important Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtg_Return.Rows.Clear();
                    txt_CustID.Text = "";
                    txt_CustName.Text = "";
                    txt_CustAddress.Text = "";
                    checkBox1.Checked = false;
                    txt_TransRefOut_TextChanged(sender, e);
                    txt_Reasons.Text = "";
                }
                else
                {
                    return;
                }
            }
        }
        private void Generate_Trans()
        {
            gen.Generate_Transaction();
            sql = "Select `Transaction Reference` from `ID_Generated` where count = '1' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                Gen_Trans = config.dt.Rows[0].Field<string>("Transaction Reference");
            }
        }

        private void dtg_Return_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Update_Qty_Stocks();
        }
    }
}
