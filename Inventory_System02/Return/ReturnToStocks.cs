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
        string Global_ID, Fullname, JobRole, item_id, trans_ref = string.Empty;

        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLConfig config = new SQLConfig();
            usableFunction func = new usableFunction();
            //ready the item
            string sql2 = "SELECT `Stock ID`, `Item Name`, Brand, Description, Quantity, Price, Total FROM `Stock Returned` WHERE `Stock ID` = '" + item_id + "' and `Transaction Reference` = '" + trans_ref + "' ";
            config.Load_DTG(sql2, dtg_tobe_returned);
            //list of returned damaged items
            string sql = "SELECT * FROM `Returned to Stocks` ORDER BY `Entry Date` DESC";
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
                dtg_return_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_return_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_return_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_return_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_return_list.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_return_list.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_return_list.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_return_list.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_return_list.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtg_return_list.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
        }
    }
}
