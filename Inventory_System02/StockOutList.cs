using Inventory_System02.Includes;
using System;
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
            if (dtg_outlist.Columns.Count > 0)
            {
                if (dtg_outlist.SelectedRows.Count > 0)
                {
                    txt_Trans_number.Text = dtg_outlist.CurrentRow.Cells[16].Value.ToString();
                }
            }
        }
        double val = 0, qty = 0;
        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "Select * from `Stock Out` order by `Entry Date` desc";
            config.Load_DTG(sql, dtg_outlist);
            if (config.dt.Rows.Count > 0)
            {
                for (int i = 0; i < dtg_outlist.Rows.Count; i++)
                {
                    qty += Convert.ToDouble(dtg_outlist.Rows[i].Cells[6].Value);
                    val += Convert.ToDouble(dtg_outlist.Rows[i].Cells[8].Value);
                }
                dtg_outlist.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_outlist.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_outlist.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtg_outlist.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                out_qty.Text = qty.ToString();
                out_amt.Text = val.ToString();
            }
            DTG_Property();

        }
        private void DTG_Property()
        {
            if (config.dt.Rows.Count > 0)
            {
                dtg_outlist.Columns[0].Visible = false;
                dtg_outlist.Columns[2].Visible = false;
                dtg_outlist.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg_outlist.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtg_outlist.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // dtg_outlist.Rows[0].Selected = true;
                func.Count_person(dtg_outlist, lbl_items_count);

                foreach (DataGridViewRow rw in dtg_outlist.Rows)
                {
                    if (Convert.ToDateTime(rw.Cells[1].Value) >= Convert.ToDateTime(rw.Cells[15].Value))
                    {
                        rw.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_outlist.Columns.Count > 0)
            {
                txt_Trans_number.Text = dtg_outlist.CurrentRow.Cells[16].Value.ToString();
                txt_Cust_ID.Text = dtg_outlist.CurrentRow.Cells[9].Value.ToString();
                txt_Cust_name.Text = dtg_outlist.CurrentRow.Cells[10].Value.ToString();
                txt_address.Text = dtg_outlist.CurrentRow.Cells[11].Value.ToString();

                func.Reload_Images(cust_Image, txt_Cust_ID.Text, @"CommonSql\Pictures\Customers\");
                txt_Trans_number.Focus();
                if (dtg_outlist.Rows.Count > 0)
                {
                    if (Convert.ToDateTime(dtg_outlist.CurrentRow.Cells[1].Value) >= Convert.ToDateTime(dtg_outlist.CurrentRow.Cells[15].Value))
                    {
                        lbl_DueDate.Text = "Warning this Transaction is due on " + dtg_outlist.CurrentRow.Cells[15].Value.ToString();
                    }
                    else
                    {
                        lbl_DueDate.Text = "";
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("This will delete an entire transaction reference which consist of 1 or more items on it!", "Warning Message", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                if (dtg_outlist.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow rw in dtg_outlist.SelectedRows)
                    {
                        sql = "Delete from `Stock Out` where `Transaction Reference` = '" + rw.Cells[16].Value.ToString() + "' ";
                        config.Execute_Query(sql);

                    }
                    MessageBox.Show("Out Stocks successfully deleted");
                    refreshTableToolStripMenuItem_Click(sender, e);
                    chk_all.Checked = false;
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

        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_all.Checked)
            {
                foreach (DataGridViewRow rw in dtg_outlist.Rows)
                {
                    rw.Selected = true;
                    btn_Delete.Focus();
                }
            }
            else
            {
                foreach (DataGridViewRow rw in dtg_outlist.Rows)
                {
                    rw.Selected = false;
                }
            }
        }

        private void batchTransactionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void printInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
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
            sql = "Select * from `Stock Out` where " + search_for + " like '%" + txt_Search.Text + "%' ";
            config.Load_DTG(sql, dtg_outlist);
            DTG_Property();

            if (txt_Search.Text == "")
            {
                refreshTableToolStripMenuItem_Click(sender, e);
            }

        }

        private void btn_print_invoice_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Trans_number.Text) && txt_Trans_number.Text != "Empty Field!" )
            {
                voice.Invoice("out", txt_Trans_number.Text, "preview");
            }
            else
            {
                txt_Trans_number.Text = "Empty Field!";
                txt_Trans_number.Focus();
            }

        }
    }
}
