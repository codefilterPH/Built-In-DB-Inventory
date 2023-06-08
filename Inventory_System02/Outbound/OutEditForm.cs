using Inventory_System02.Includes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_System02.Outbound
{
    public partial class OutEditForm : Form
    {
        string trans_reference = string.Empty;
        public OutEditForm(string TransRef)
        {
            InitializeComponent();
            trans_reference = TransRef;
        }

        private void OutEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                SQLConfig config = new SQLConfig();
                string sql = string.Empty;
                //Load Status and Remarks
                sql = "Select Status, Remarks from StockOutStatus where TransRef = '" + trans_reference + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count == 1)
                {
                    txt_remarks.Text = config.dt.Rows[0]["Remarks"].ToString();
                    string out_status = config.dt.Rows[0]["Status"].ToString();
                    lbl_status.Text = out_status;
                    if (out_status == "PAID")
                    {
                        chk_paid.Checked = true;
                        lbl_status.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbl_status.ForeColor = Color.Red;
                        chk_paid.Checked = false;
                    }
                }

                //Load Items from current transaction
                sql = "Select `Item Name`, Quantity, Price, Total from `Stock Out` where `Transaction Reference` = '" + trans_reference + "' ";
                config.Load_DTG(sql, dtg_outlist);
                if (config.dt.Columns.Count >= 1)
                {
                    DTG_Properties();
                }
                if (!string.IsNullOrWhiteSpace(trans_reference))
                {
                    lbl_reference.Text = trans_reference;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DTG_Properties()
        {
            dtg_outlist.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg_outlist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_outlist.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_outlist.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_outlist.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_outlist.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtg_outlist.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtg_outlist.Columns[2].DefaultCellStyle.Format = "#,##0.00";
            dtg_outlist.Columns[3].DefaultCellStyle.Format = "#,##0.00";
        }

        private void chk_paid_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_paid.Checked)
            {
                lbl_status.ForeColor = Color.Green;
                lbl_status.Text = "PAID";
            }
            else
            {
                lbl_status.ForeColor = Color.Red;
                lbl_status.Text = "UNPAID";
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConfig config = new SQLConfig();
                string sql;
                sql = "Select Status, Remarks from StockOutStatus where TransRef = '" + trans_reference + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count == 1)
                {
                    sql = "Update StockOutStatus set Status = '" + lbl_status.Text + "', Remarks = '" + txt_remarks.Text + "' where TransRef = '" + trans_reference + "' ";
                    config.Execute_CUD(sql, "Unable to update transaction! Please contact administrator. Thank you", "Successfully updated transaction " + trans_reference + "' ");
                }
                else
                {
                    sql = "Insert into StockOutStatus ( Status, Remarks ) values ( '" + lbl_status.Text + "', '" + txt_remarks.Text + "' )";
                    config.Execute_CUD(sql, "Unable to add transaction\'s info! Please contact administrator. Thank you", "Successfully added transaction\'s info!" + trans_reference + "' ");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
