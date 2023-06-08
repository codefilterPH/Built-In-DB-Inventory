using Inventory_System02.Includes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_System02.Return
{
    public partial class ReturnToStocks : Form
    {
        string Global_ID, Fullname, JobRole, item_id, trans_ref, sql = string.Empty;
        SQLConfig config;
        usableFunction func = new usableFunction();
        public ReturnToStocks(string id, string name, string role, string transref, string itemid)
        {
            InitializeComponent();
            Global_ID = id;
            Fullname = name;
            JobRole = role;
            item_id = itemid;
            trans_ref = transref;

        }
        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_tobe_returned.Columns.Count > 1)
                {
                    if (dtg_tobe_returned.Rows.Count == 1)
                    {
                        if (num_qty.Value > Convert.ToInt32(dtg_tobe_returned.Rows[0].Cells[4].Value))
                        {
                            if (MessageBox.Show("Quantity must not greater than the original! Thank you. Reset?", "Error Message", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                            {
                                btn_reset_Click(sender, e);
                            }
                            return;
                        }
                        if (num_qty.Value == 0)
                        {
                            MessageBox.Show("Quantity must not equal to zero! Thank you.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }

                        dtg_tobe_returned.Rows[0].Cells[4].Value = num_qty.Text;
                        dtg_tobe_returned.Rows[0].Cells[6].Value = Convert.ToDecimal(num_qty.Value) * Convert.ToDecimal(dtg_tobe_returned.Rows[0].Cells[5].Value);
                        btn_return.Enabled = true;
                        dtg_tobe_returned.Rows[0].Cells[4].Selected = true;
                        lbl_status.Text = "Successfully changed quantity!";
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                lbl_status.Text = "Error: change button. " + ex.Message;
                lbl_status.ForeColor = Color.Red;
            }
        }

        private void num_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_change_Click(sender, e);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        string Gen_Trans_To_Stocks;
        string Gen_Trans_Record;
        private void Generate_Trans_To_Inbound()
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

                    sql = "SELECT COUNT(*) FROM `Stocks` WHERE `Transaction Reference` = '" + id + "'";
                    config.singleResult(sql);
                    if (Convert.ToInt32(config.dt.Rows[0][0]) > 0)
                    {
                        gen.Generate_Transaction();
                    }
                    else
                    {
                        Gen_Trans_To_Stocks = id;
                        hasDuplicate = false;

                    }
                }
            }
        }
        private void Generate_Trans_Record()
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

                    sql = "SELECT COUNT(*) FROM `Returned to Stocks` WHERE `Transaction Reference` = '" + id + "'";
                    config.singleResult(sql);
                    if (Convert.ToInt32(config.dt.Rows[0][0]) > 0)
                    {
                        gen.Generate_Transaction();
                    }
                    else
                    {
                        Gen_Trans_Record = id;
                        hasDuplicate = false;

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtg_return_list.Rows.Count >= 1)
            {
                if (JobRole != "Programmer/Developer" && JobRole != "Office Manager")
                {
                    MessageBox.Show("No permission to delete transactions! Thank you.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Deleting record will not be retrieved again. Continue?", "Delete Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow rw in dtg_return_list.SelectedRows)
                        {
                            sql = "DELETE FROM `Returned to Stocks` WHERE `Transaction Reference` = '" + rw.Cells[11].Value.ToString() + "' ";
                            config.Execute_Query(sql);
                        }
                        MessageBox.Show("Successfully deleted transactions", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chk_select_all.Checked = false;
                        refreshTableToolStripMenuItem_Click(sender, e);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void chk_select_all_CheckedChanged(object sender, EventArgs e)
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

        private void dtg_return_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chk_select_all.Checked = false;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (dtg_tobe_returned.Rows.Count == 1)
            {
                if (dtg_tobe_returned.DataSource != null)
                {
                    if (Convert.ToInt32(dtg_tobe_returned.Rows[0].Cells[4].Value) == 0)
                    {
                        MessageBox.Show("Quantity is zero!", "Nothing to Return", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to return this pending transaction?", "Confirm Stock Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Generate_Trans_To_Inbound();
                        string mydate = DateTime.Now.ToString(Includes.AppSettings.DateFormatSave);
                        string item = dtg_tobe_returned.Rows[0].Cells[1].Value.ToString();
                        string brand = dtg_tobe_returned.Rows[0].Cells[2].Value.ToString();
                        string desc = dtg_tobe_returned.Rows[0].Cells[3].Value.ToString();
                        int qty = Convert.ToInt32(dtg_tobe_returned.Rows[0].Cells["Quantity"].Value);
                        decimal price = Convert.ToDecimal(dtg_tobe_returned.Rows[0].Cells[5].Value);
                        decimal total = Convert.ToDecimal(dtg_tobe_returned.Rows[0].Cells[6].Value);

                        //Add back to stock in
                        config = new SQLConfig();
                        sql = "SELECT * FROM Stocks WHERE `Stock ID` = '" + item_id + "' ";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count >= 1)
                        {
                            int received_qty = Convert.ToInt32(config.dt.Rows[0]["Quantity"]);
                            int new_qty = received_qty + qty;
                            decimal new_total = new_qty * Convert.ToDecimal(config.dt.Rows[0]["Price"]);
                            sql = "UPDATE Stocks set Quantity = '" + new_qty + "', Total = '" + new_total + "', Status = 'Returned from Outbound (Damage Repaired)' where `Stock ID` = '" + item_id + "' ";
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
                                ",`Warehouse Staff Name` " +
                                ",`Job Role` " +
                                ",`Transaction Reference` " +
                                ",`Status` ) values (" +
                                " '" + DateTime.Now.ToString(Includes.AppSettings.DateFormatSave) + "' " +
                                ",'" + item_id + "' " +
                                ",'" + item + "' " +
                                ",'" + brand + "' " +
                                ",'" + desc + "' " +
                                ",'" + qty + "' " +
                                ",'" + price + "' " +
                                ",'" + total + "' " +
                                ",'" + Global_ID + "' " +
                                ",'" + Fullname + "' " +
                                ",'" + JobRole + "' " +
                                ",'" + Gen_Trans_To_Stocks + "' " +
                                ",'Returned from outbound with tag Damaged.' )";
                            config.Execute_Query(sql);
                        }
                        //Update stock out
                        sql = "SELECT `Stock ID`, `Quantity`, `Price`, `Transaction Reference` FROM `Stock Returned` WHERE `Stock ID` = '" + item_id + "' and `Transaction Reference` = '" + trans_ref + "' ";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count == 1)
                        {
                            int received_qty = Convert.ToInt32(config.dt.Rows[0]["Quantity"]);
                            int new_qty = received_qty - qty;
                            decimal new_total = new_qty * Convert.ToDecimal(config.dt.Rows[0]["Price"]);
                            sql = "UPDATE `Stock Returned` set Quantity = '" + new_qty + "', Total = '" + new_total + "', Status = 'Return record sent to (Damage Repaired Table)' where `Stock ID` = '" + item_id + "' ";
                            config.Execute_Query(sql);
                        }

                        //Record the transactions
                        Generate_Trans_Record();

                        sql = "INSERT INTO `Returned to Stocks` ( " +
                             " `Entry Date` " +
                             ",`Stock ID` " +
                             ",`Item Name` " +
                             ",`Brand` " +
                             ",`Description` " +
                             ",`Quantity` " +
                             ",`Price` " +
                             ",`Total` " +
                             ",`Remarks` " +
                             ",`Status` " +
                             ",`Transaction Reference` " +
                             ",`Customer Name` " +
                             ",`Customer Address` " +
                             ",`User ID` " +
                             ",`Staff Name` " +
                             ",`Job Role` ) values (" +
                             " '" + mydate + "' " +
                             ",'" + item_id + "' " +
                             ",'" + item + "' " +
                             ",'" + brand + "' " +
                             ",'" + desc + "' " +
                             ",'" + qty + "' " +
                             ",'" + price + "' " +
                             ",'" + total + "' " +
                             ",'" + txt_remarks.Text + "' " +
                             ",'Sent to Stocks' " +
                             ",'" + Gen_Trans_Record + "' " +
                             ",'" + name + "' " +
                             ",'" + address + "' " +
                             ",'" + Global_ID + "' " +
                             ",'" + Fullname + "' " +
                             ",'" + JobRole + "' )";
                        config.Execute_CUD(sql, "Unable to insert to stocks!", "Item successfully added back to stocks!");
                        refreshTableToolStripMenuItem_Click(sender, e);
                        chk_select_all.Checked = false;

                    }
                    else
                    {
                        return;
                    }

                }
            }
        }
        string name = string.Empty;
        string address = string.Empty;
        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
            config = new SQLConfig();
            //ready the item
            string sql2 = "SELECT `Stock ID`, `Item Name`, Brand, Description, Quantity, Price, Total, `Customer Name`, `Customer Address` FROM `Stock Returned` WHERE `Stock ID` = '" + item_id + "' and `Transaction Reference` = '" + trans_ref + "' ";
            config.Load_DTG(sql2, dtg_tobe_returned);
            if (config.dt.Rows.Count == 1)
            {
                name = string.Empty;
                address = string.Empty;
                name = config.dt.Rows[0]["Customer Name"].ToString();
                address = config.dt.Rows[0]["Customer Address"].ToString();
            }

            //list of returned damaged items
            sql = "SELECT * FROM `Returned to Stocks` ORDER BY `Entry Date` DESC";
            config.Load_DTG(sql, dtg_return_list);

            func.Reload_Images(Item_Image, item_id, Includes.AppSettings.Image_DIR);
            DTG_Properties();
            Calculate();
            btn_return.Enabled = false;

            lbl_status.Text = "";
        }

        private void num_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            func = new usableFunction();
            func.KeyPress_Textbox_NumbersOnlyNoDot(sender, e);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            refreshTableToolStripMenuItem_Click(sender, e);
        }

        private void return_amt_Click(object sender, EventArgs e)
        {
            func.Label_Two_Decimal_Places(sender, e, return_amt);
        }

        private void ReturnToStocks_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        int total_qty;
        decimal total_amount;
        private void Calculate()
        {

            if (dtg_return_list.Columns.Count >= 1)
            {
                if (dtg_return_list.Rows.Count >= 1)
                {
                    total_qty = 0;
                    total_amount = 0;
                    int qty;
                    decimal total;
                    for (int i = 0; i < dtg_return_list.Rows.Count; i++)
                    {
                        int.TryParse(dtg_return_list.Rows[i].Cells["Quantity"].Value.ToString(), out qty);
                        total_qty += qty;

                        decimal.TryParse(dtg_return_list.Rows[i].Cells["Total"].Value.ToString(), out total);
                        total_amount += total;
                    }
                    return_items_count.Text = dtg_return_list.Rows.Count.ToString();
                    return_qty.Text = total_qty.ToString();
                    return_amt.Text = total_amount.ToString();

                }
            }
        }

        private void ReturnToStocks_Load(object sender, EventArgs e)
        {
            refreshTableToolStripMenuItem_Click(sender, e);
        }

        private void DTG_Properties()
        {
            try
            {
                if (dtg_tobe_returned.Columns.Count > 0)
                {
                    dtg_tobe_returned.Columns[5].DefaultCellStyle.Format = "#,##0.00";
                    dtg_tobe_returned.Columns[6].DefaultCellStyle.Format = "#,##0.00";
                    dtg_tobe_returned.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_tobe_returned.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtg_tobe_returned.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtg_tobe_returned.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtg_tobe_returned.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_tobe_returned.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_tobe_returned.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtg_tobe_returned.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtg_tobe_returned.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtg_tobe_returned.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dtg_tobe_returned.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dtg_tobe_returned.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (InvalidOperationException)
            {
                // Handle the exception by waiting for a short period of time and then trying the operation again
                System.Threading.Thread.Sleep(500);
                DTG_Properties();
            }
        }
    }
}
