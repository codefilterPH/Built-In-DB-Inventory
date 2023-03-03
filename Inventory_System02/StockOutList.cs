using Inventory_System02.Includes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Inventory_System02
{
    public partial class StockOutList : Form
    {
        Inventory_System02.Invoice_Code.Invoice_Code voice = new Invoice_Code.Invoice_Code();
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        string sql, Global_ID, Fullname, JobRole;
        public string passed_trans_ref { get; set; }

        public StockOutList(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }

        private void StockOutList_Load(object sender, EventArgs e)
        {
            refreshTableToolStripMenuItem_Click(sender, e);
            cbo_srch_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }
       
        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "Select * from `Stock Out` order by `Entry Date` desc";
            config.Load_DTG(sql, dtg_outlist);
            if (config.dt.Rows.Count > 0)
            {
                CalculateValue();
            }
            else
            {
                lbl_items_count.Text = "0";
                out_amt.Text = "0";
                out_qty.Text = "0";
            }
            DTG_Property();
            //Enable everyone because they are not using specialfilters
            enable_them = true;
            SpecialFilterDisabler();
        }
        private void DTG_Property()
        {
            if (config.dt.Rows.Count > 0)
            {
                dtg_outlist.Columns[0].Visible = false;
                dtg_outlist.Columns[2].Visible = false;
                dtg_outlist.Columns[5].Visible = false;
                dtg_outlist.Columns[8].Visible = false;
                dtg_outlist.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_outlist.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_outlist.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_outlist.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtg_outlist.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // dtg_outlist.Rows[0].Selected = true;
                func.Count_person(dtg_outlist, lbl_items_count);

                foreach (DataGridViewRow rw in dtg_outlist.Rows)
                {
                    if (!string.IsNullOrEmpty(rw.Cells[12].Value.ToString()))
                    {
                        if (Convert.ToDateTime(rw.Cells[1].Value) >= Convert.ToDateTime(rw.Cells[12].Value))
                        {
                            rw.DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }


        private void CalculateValue()
        {

            decimal total_val = 0;
            int total_qty = 0;
            for (int i = 0; i < dtg_outlist.Rows.Count; i++)
            {
                int qty = 0;
                decimal amount = 0;
                int.TryParse(dtg_outlist.Rows[i].Cells[9].Value.ToString(), out qty);
                decimal.TryParse(dtg_outlist.Rows[i].Cells[11].Value.ToString(), out amount);

                total_qty += qty;
                total_val += amount;
                
            }
            out_qty.Text = total_qty.ToString();
            out_amt.Text = total_val.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_outlist.Columns.Count > 0)
            {
                txt_Trans_number.Text = dtg_outlist.CurrentRow.Cells[13].Value.ToString();
                txt_Cust_ID.Text = dtg_outlist.CurrentRow.Cells[2].Value.ToString();
                txt_Cust_name.Text = dtg_outlist.CurrentRow.Cells[3].Value.ToString();
                txt_address.Text = dtg_outlist.CurrentRow.Cells[4].Value.ToString();

                func.Reload_Images(cust_Image, txt_Cust_ID.Text, Includes.AppSettings.Customer_DIR);
                txt_Trans_number.Focus();
                if (dtg_outlist.Rows.Count > 0)
                {
                    if (Convert.ToDateTime(dtg_outlist.CurrentRow.Cells[1].Value) >= Convert.ToDateTime(dtg_outlist.CurrentRow.Cells[12].Value))
                    {
                        lbl_DueDate.Text = "Warning this Transaction is due " + dtg_outlist.CurrentRow.Cells[12].Value.ToString();
                    }
                    else
                    {
                        lbl_DueDate.Text = "";
                    }

                    func.Change_Font_DTG(sender, e, dtg_outlist);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete an entire transaction reference which might consist of 1 or more items on it. Continue?", "Warning Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dtg_outlist.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow rw in dtg_outlist.SelectedRows)
                    {
                        // Check if the config object is initialized properly
                        if (config == null)
                        {
                            MessageBox.Show("Config object is null. Please check the initialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        string transactionRef = rw.Cells[13].Value?.ToString();

                        // Check if the transaction reference is null or empty
                        if (string.IsNullOrEmpty(transactionRef))
                        {
                            MessageBox.Show("Transaction reference is null or empty. Please check the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        string sql = "SELECT * FROM `Stock Out` WHERE `Transaction Reference` = '" + transactionRef + "'";
                        config.singleResult(sql);

                        // Check if the dt object is properly initialized
                        if (config.dt == null)
                        {
                            MessageBox.Show("DT object is null. Please check the initialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        if (config.dt.Rows.Count > 0)
                        {
                            sql = "DELETE FROM `Stock Out` WHERE `Transaction Reference` = '" + transactionRef + "'";
                            config.Execute_CUD(sql, "Unable to delete selected transaction", "Transaction successfully deleted!");
                           
                        }
                        else
                        {
                            MessageBox.Show("Unsucessful deletion of transaction, Please review and try again.", "Warning Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    refreshTableToolStripMenuItem_Click(sender, e);
                }
            }

        }

        private void txt_Trans_number_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                passed_trans_ref = txt_Trans_number.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dtg_outlist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            passed_trans_ref = txt_Trans_number.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbo_srch_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search_TextChanged(sender, e);
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (dtg_outlist.Rows.Count >= 1)
            {
                if ( dtg_outlist.SelectedRows.Count > 0  && txt_Trans_number.Text != "Empty Field!" &&
                    !string.IsNullOrWhiteSpace(txt_Trans_number.Text))
                {
                    Items.Outbound_Preview frm = new Items.Outbound_Preview(
                    dtg_outlist.CurrentRow.Cells[1].Value.ToString(),
                    dtg_outlist.CurrentRow.Cells[5].Value.ToString(),
                    txt_Trans_number.Text,
                    dtg_outlist.CurrentRow.Cells[3].Value.ToString(),
                    dtg_outlist.CurrentRow.Cells[4].Value.ToString(),
                    dtg_outlist.CurrentRow.Cells[6].Value.ToString(),
                    dtg_outlist.CurrentRow.Cells[7].Value.ToString(),
                    dtg_outlist.CurrentRow.Cells[8].Value.ToString(),
                    dtg_outlist.CurrentRow.Cells[9].Value.ToString(),
                    dtg_outlist.CurrentRow.Cells[10].Value.ToString(),
                    dtg_outlist.CurrentRow.Cells[11].Value.ToString(),
                    dtg_outlist.CurrentRow.Cells[15].Value.ToString(),
                    dtg_outlist.CurrentRow.Cells[12].Value.ToString()
                    );

                    frm.ShowDialog();
                }
                else
                {
                    txt_Trans_number.Text = "Empty Field!";
                    txt_Trans_number.Focus();
                }

            }
        }

        private void curTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Trans_number.Text) && txt_Trans_number.Text != "Empty Field!")
            {
                voice.Invoice("out", txt_Trans_number.Text, "preview");
            }
            else
            {
                txt_Trans_number.Text = "Empty Field!";
                txt_Trans_number.Focus();
            }
        }

        private void currentTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Trans_number.Text) && txt_Trans_number.Text != "Empty Field!")
            {
                voice.Invoice("out", txt_Trans_number.Text, "print");
            }
            else
            {
                txt_Trans_number.Text = "Empty Field!";
                txt_Trans_number.Focus();
            }
        }

        private void curTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Trans_number.Text) && txt_Trans_number.Text != "Empty Field!")
            {
                voice.Invoice("out", txt_Trans_number.Text, "batch");
            }
            else
            {
                txt_Trans_number.Text = "Empty Field!";
                txt_Trans_number.Focus();
            }
        }

        private void view_table_result_Click(object sender, EventArgs e)
        {
            Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
            frm.Search_Result("OUTBOUND SUMMARY", "preview", dtg_outlist, lbl_items_count.Text, out_qty.Text, out_amt.Text, cbo_srch_type.Text, txt_Search.Text);
        }

        private void batch_table_result_Click(object sender, EventArgs e)
        {
            Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
            frm.Search_Result("OUTBOUND SUMMARY", "batch", dtg_outlist, lbl_items_count.Text, out_qty.Text, out_amt.Text, cbo_srch_type.Text, txt_Search.Text);
            MessageBox.Show("Sent to My Documents!");
        }

        private void print_table_result_Click(object sender, EventArgs e)
        {
            Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
            frm.Search_Result("OUTBOUND SUMMARY", "print", dtg_outlist, lbl_items_count.Text, out_qty.Text, out_amt.Text, cbo_srch_type.Text, txt_Search.Text);
        }

        private void out_amt_TextChanged(object sender, EventArgs e)
        {
            func.Label_Two_Decimal_Places(sender, e, out_amt);
        }
        bool enable_them = false;
        private void SpecialFilterDisabler()
        {
            if (enable_them == false)
            {
                printInvoiceToolStripMenuItem.Enabled = false;
                batchTransactionToolStripMenuItem.Enabled = false;
                view_main_btn.Enabled = false;
                btn_view.Enabled = false;
                btn_select.Enabled = false;
                btn_Delete.Enabled = false;
                dtg_outlist.Enabled = false;
                txt_Search.Enabled = false;
                
            
                dtg_outlist.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_outlist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_outlist.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg_outlist.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                lbl_items_count.Text = dtg_outlist.Rows.Count.ToString();
                out_amt.Text = "0";
                out_qty.Text = "0";
            }
            else
            {
                printInvoiceToolStripMenuItem.Enabled = true;
                batchTransactionToolStripMenuItem.Enabled = true;
                view_main_btn.Enabled = true;
                btn_view.Enabled = true;
                btn_select.Enabled = true;
                btn_Delete.Enabled = true;
                dtg_outlist.Enabled = true;
                txt_Search.Enabled = true;

                dtg_outlist.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtg_outlist.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_outlist.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg_outlist.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }
        private void mostProductPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT Brand, COUNT(*) AS `Total Occurences` FROM `Stock Out` GROUP BY Brand ORDER BY `Total Occurences` DESC LIMIT 1";
            config.Load_DTG(sql, dtg_outlist);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void leastProductPurchasedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT Brand, COUNT(*) AS `Total Occurences` FROM `Stock Out` GROUP BY Brand ORDER BY `Total Occurences` ASC LIMIT 1";
            config.Load_DTG(sql, dtg_outlist);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void mostItemPurchasedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT `Item Name`, Brand, COUNT(*) AS `Total Occurences` FROM `Stock Out` GROUP BY `Item Name` ORDER BY `Total Occurences` DESC LIMIT 1";
            config.Load_DTG(sql, dtg_outlist);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void mostItemPurchasedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sql = "SELECT `Item Name`, Brand, COUNT(*) AS `Total Occurences` FROM `Stock Out` GROUP BY `Item Name` ORDER BY `Total Occurences` ASC LIMIT 1";
            config.Load_DTG(sql, dtg_outlist);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void mosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT `Customer Name`, COUNT(*) AS `Total Occurences` FROM `Stock Out` GROUP BY `Customer Name` ORDER BY `Total Occurences` DESC LIMIT 1";
            config.Load_DTG(sql, dtg_outlist);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void divisionWithTheLeastPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT `Customer Name`, COUNT(*) AS `Total Occurences` FROM `Stock Out` GROUP BY `Customer Name` ORDER BY `Total Occurences` ASC LIMIT 1";
            config.Load_DTG(sql, dtg_outlist);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (dtg_outlist.Rows.Count >= 1)
            {
                if (dtg_outlist.SelectedRows.Count > 0 )
                {
                    if ( txt_Trans_number.Text != "Empty Field!" || !string.IsNullOrWhiteSpace(txt_Trans_number.Text))
                    {
                        txt_Trans_number.Text = dtg_outlist.CurrentRow.Cells[13].Value.ToString();
                    }
                    passed_trans_ref = txt_Trans_number.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        string search_for = string.Empty;
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (cbo_srch_type.Text == "DATE")
            {
                search_for = "`Entry Date`";
            }
            else if (cbo_srch_type.Text == "ID")
            {
                search_for = "`Stock ID`";
            }
            else if (cbo_srch_type.Text == "NAME")
            {
                search_for = "`Item Name`";
            }
            else if (cbo_srch_type.Text == "BRAND")
            {
                search_for = "`Brand`";
            }
            else if (cbo_srch_type.Text == "DESCRIPTION")
            {
                search_for = "`Description`";
            }
            else if (cbo_srch_type.Text == "QUANTITY")
            {
                search_for = "`Quantity`";
            }
            else if (cbo_srch_type.Text == "PRICE")
            {
                search_for = "`Price`";
            }
            else if (cbo_srch_type.Text == "TOTAL")
            {
                search_for = "`Total`";
            }
            else if (cbo_srch_type.Text == "DIVISION")
            {
                search_for = "`Customer Name`";
            }
            else if (cbo_srch_type.Text == "ADDRESS")
            {
                search_for = "`Customer Address`";
            }
            else if (cbo_srch_type.Text == "STAFF NAME")
            {
                search_for = "`Warehouse Staff Name`";
            }
            else if (cbo_srch_type.Text == "JOB")
            {
                search_for = "`Job Role`";
            }
            else if ( cbo_srch_type.Text == "WARRANTY DUE DATE")
            {
                search_for = "`Warranty Due Date`";
            }
            else if ( cbo_srch_type.Text == "TRANS REF")
            {
                search_for = "`Transaction Reference`";
            }
            else
            {
                search_for = "`Customer Name`";
            }
            sql = "Select * from `Stock Out` where " + search_for + " like '%" + txt_Search.Text + "%' ORDER BY `Entry Date` DESC";
            config.Load_DTG(sql, dtg_outlist);
            if (config.dt.Rows.Count > 0 )
            {
                CalculateValue();
            }
            DTG_Property();

            if (txt_Search.Text == "")
            {
                refreshTableToolStripMenuItem_Click(sender, e);
            }

        }
    }
}
