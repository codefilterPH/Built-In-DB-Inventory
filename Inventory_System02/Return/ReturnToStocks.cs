using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System02.Includes;

namespace Inventory_System02.Return
{
    public partial class ReturnToStocks : Form
    {
        string Global_ID, Fullname, JobRole, item_id, trans_ref, sql = string.Empty;
        SQLConfig config;
        usableFunction func = new usableFunction();

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (dtg_tobe_returned.Columns.Count > 1)
            {
                if (dtg_tobe_returned.Rows.Count == 1 )
                {
                    if ( num_qty.Value > Convert.ToInt32(dtg_tobe_returned.Rows[0].Cells[4].Value) )
                    {
                        MessageBox.Show("Quantity must not greater than the original! Thank you.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    if ( num_qty.Value == 0 )
                    {
                        MessageBox.Show("Quantity must not equal to zero! Thank you.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }

                    dtg_tobe_returned.Rows[0].Cells[4].Value = num_qty.Text;
                    dtg_tobe_returned.Rows[0].Cells[6].Value = Convert.ToDecimal(num_qty.Value) * Convert.ToDecimal(dtg_tobe_returned.Rows[0].Cells[5].Value);
                }
            }
        }

        private void num_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                btn_change_Click(sender, e);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
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
                if ( JobRole != "Programmer/Developer" && JobRole != "Office Manager")
                {
                    MessageBox.Show("No permission to delete transactions! Thank you.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else
                {
                    foreach( DataGridViewRow rw in dtg_return_list.SelectedRows )
                    {
                        sql = "DELETE FROM `Returned to Stocks` WHERE `Transaction Reference` = '" + rw.Cells[10].Value.ToString() +"' ";
                        config.Execute_Query(sql);
                    }
                    MessageBox.Show("Successfully deleted transactions","Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    chk_select_all.Checked = false;
                    return;
                }
            }
        }

        private void dtg_return_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chk_select_all.Checked = false;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Generate_Trans_To_Inbound();
            config = new SQLConfig();
            sql = "SELECT * FROM Stocks WHERE `Stock ID` = '" + dtg_tobe_returned.Rows[0].Cells[0].Value.ToString() + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count >= 1 )
            {
                int received_qty = Convert.ToInt32(config.dt.Rows[0]["Quantity"]);
                int new_qty = received_qty + Convert.ToInt32(dtg_tobe_returned.Rows[0].Cells[0].Value);
                decimal new_total = new_qty * Convert.ToDecimal(config.dt.Rows[0]["Price"]);
                sql = "UPDATE Stocks set Quantity = '" + new_qty + "', Total = '"+ new_total+"', Status = 'Returned from Outbound (Damage Repaired)' where `Stock ID` = '" + dtg_tobe_returned.Rows[0].Cells[0].Value.ToString() + "' ";
                config.Execute_CUD(sql, "Unable to return to stocks! Please try again thank you.", "Successfully added back to stocks!");
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
                    ",`Transaction Reference` "+
                    ",`Status` ) values (" +
                    " '" + DateTime.Now.ToString(Includes.AppSettings.DateFormatSave) + "' " +
                    ",'" + dtg_tobe_returned.Rows[0].Cells[0].Value.ToString() + "' " +
                    ",'" + dtg_tobe_returned.Rows[0].Cells[1].Value.ToString() + "' " +
                    ",'" + dtg_tobe_returned.Rows[0].Cells[2].Value.ToString() + "' " +
                    ",'" + dtg_tobe_returned.Rows[0].Cells[3].Value.ToString() + "' " +
                    ",'" + Convert.ToInt32(dtg_tobe_returned.Rows[0].Cells[4].Value) + "' " +
                    ",'" + Convert.ToDecimal(dtg_tobe_returned.Rows[0].Cells[5].Value) + "' " +
                    ",'" + Convert.ToDecimal(dtg_tobe_returned.Rows[0].Cells[6].Value) + "' " +
                    ",'" + Global_ID + "' " +
                    ",'" + Fullname + "' " +
                    ",'" + JobRole + "' " +
                    ",'" + Gen_Trans_To_Stocks + "' " +
                    ",'Returned from Outbound (Damage Repaired)' )";
                config.Execute_CUD(sql, "Unable to insert to stocks!", "Item successfully added back to stocks!");
            }
            Generate_Trans_Record();

            sql = "Insert into `Returned to Stocks` ( " +
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
                 ",'" + dtg_tobe_returned.Rows[0].Cells[0].Value.ToString() + "' " +
                 ",'" + dtg_tobe_returned.Rows[0].Cells[1].Value.ToString() + "' " +
                 ",'" + dtg_tobe_returned.Rows[0].Cells[2].Value.ToString() + "' " +
                 ",'" + dtg_tobe_returned.Rows[0].Cells[3].Value.ToString() + "' " +
                 ",'" + Convert.ToInt32(dtg_tobe_returned.Rows[0].Cells[4].Value) + "' " +
                 ",'" + Convert.ToDecimal(dtg_tobe_returned.Rows[0].Cells[5].Value) + "' " +
                 ",'" + Convert.ToDecimal(dtg_tobe_returned.Rows[0].Cells[6].Value) + "' " +
                 ",'" + Global_ID + "' " +
                 ",'" + Fullname + "' " +
                 ",'" + JobRole + "' " +
                 ",'" + Gen_Trans_Record + "' " +
                 ",'Sent to Stocks' )";
            config.Execute_CUD(sql, "Unable to insert to stocks!", "Item successfully added back to stocks!");
            refreshTableToolStripMenuItem_Click(sender, e);
            chk_select_all.Checked = false;

        }

        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config = new SQLConfig();
            //ready the item
            string sql2 = "SELECT `Stock ID`, `Item Name`, Brand, Description, Quantity, Price, Total FROM `Stock Returned` WHERE `Stock ID` = '" + item_id + "' and `Transaction Reference` = '" + trans_ref + "' ";
            config.Load_DTG(sql2, dtg_tobe_returned);
            //list of returned damaged items
            sql = "SELECT * FROM `Returned to Stocks` ORDER BY `Entry Date` DESC";
            config.Load_DTG(sql, dtg_return_list);

            func.Reload_Images(Item_Image, item_id, Includes.AppSettings.Image_DIR);
            DTG_Properties();
        }

        public ReturnToStocks(string id, string name, string role, string transref, string itemid)
        {
            InitializeComponent();
            Global_ID = id;
            Fullname = name;
            JobRole = role;
            item_id = itemid;
            trans_ref = transref;

        }

        private void ReturnToStocks_Load(object sender, EventArgs e)
        {
            refreshTableToolStripMenuItem_Click(sender, e);
        }

        private void DTG_Properties()
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
                dtg_tobe_returned.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_tobe_returned.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtg_tobe_returned.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
        }
      
    }
}
