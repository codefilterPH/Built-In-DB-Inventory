using Inventory_System02.Includes;
using System;
using System.Windows.Forms;

namespace Inventory_System02.CustSupplier
{
    public partial class CustModels : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        string cust_id, sql, name1;
        public CustModels(string id, string name)
        {
            InitializeComponent();
            cust_id = id;
            name1 = name;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (cbo_def_text.Text == null || cbo_def_text.Text == "")
            {
                MessageBox.Show("Empty fields!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_def_text.Focus();
                return;
            }
            else if (cust_id == "")
            {
                MessageBox.Show("No user selected! Unable to add models please close and select customer and open again.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else if (txt_Id.Text == "" || txt_Id.Text == null)
            {

                MessageBox.Show("Empty fields!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Id.Focus();
                return;
            }
            else
            {
                sql = "Update `Customer Model Entries` set Model = '" + cbo_def_text.Text + "' where Id = '" + cust_id + "' and Count = '" + txt_Id.Text + "' ";
                config.Execute_CUD(sql, "Unsuccessful update", "1 record found! Updated successfully");
                RefreshandLoadTable();
                txt_Id.Focus();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cbo_def_text.Text == null || cbo_def_text.Text == "")
            {
                MessageBox.Show("Empty fields!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_def_text.Focus();

            }
            else if (cust_id == "" || cust_id == null)
            {
                MessageBox.Show("No user selected! Unable to add models please close and select customer and open again.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                sql = "Delete from `Customer Model Entries` where Id = '" + cust_id + "' and Model = '" + cbo_def_text.Text + "' and Count = '" + txt_Id.Text + "' ";
                config.Execute_CUD(sql, "Unable to delete! Please try again.", "Successfully deleted record!");
                RefreshandLoadTable();
                txt_Id.Focus();
            }

        }

        private void btn_Clear_Text_Click(object sender, EventArgs e)
        {
            cbo_def_text.Text = "";
            RefreshandLoadTable();
            txt_Id.Focus();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from `Customer Model Entries` where `Model` like '%" + cbo_def_text.Text + "%' and Id = '" + cust_id + "' ";
            config.Load_DTG(sql, dtg_models);

            if (txt_search.Text == "" || txt_search.Text == null)
            {
                RefreshandLoadTable();
                txt_search.Focus();
            }
            DTG_properties();

        }

        private void dtg_models_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_models.Rows.Count > 0)
            {
                txt_Id.Text = dtg_models.CurrentRow.Cells[0].Value.ToString();
                cbo_def_text.Text = dtg_models.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void CustModels_Load(object sender, EventArgs e)
        {
            func.Reload_Images(Sup_Image, cust_id, Includes.AppSettings.Customer_DIR);
            lbl_ID.Text = name1;

            sql = "Select Type from `Customer Models`";
            config.fiil_CBO(sql, cbo_def_text);

            RefreshandLoadTable();

        }
        private void DTG_properties()
        {
            if (dtg_models.Rows.Count > 0)
            {
                dtg_models.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_models.Columns[1].Visible = false;
                dtg_models.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }
        private void RefreshandLoadTable()
        {
            sql = "Select * from `Customer Model Entries` where Id = '" + cust_id + "' ";
            config.Load_DTG(sql, dtg_models);
            DTG_properties();


            if (dtg_models.Rows.Count > 0)
            {
                for (int i = 0; i < dtg_models.Rows.Count; i++)
                {
                    txt_Id.Text = Convert.ToString(dtg_models.Rows.Count + 1);
                }
            }


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cbo_def_text.Text == null || cbo_def_text.Text == "")
            {
                MessageBox.Show("Empty fields!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_def_text.Focus();
                return;
            }
            else if (cust_id == "")
            {
                MessageBox.Show("No user selected! Unable to add models please close and select customer and open again.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else if (txt_Id.Text == "" || txt_Id.Text == null)
            {

                MessageBox.Show("Empty fields!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Id.Focus();
                return;
            }
            else
            {


                sql = " Select * from `Customer Model Entries` where `Id` = '" + cust_id + "' and Model = '" + cbo_def_text.Text + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count <= 0)
                {
                    sql = "Insert into `Customer Model Entries` ( `Count`, `Id`, `Model` ) values (" +
                       " '" + txt_Id.Text + "' , '" + cust_id + "', '" + cbo_def_text.Text + "' ) ";
                    config.Execute_CUD(sql, "Unable to add to Database! Please try again.", "Successfully added to record!");

                }
                RefreshandLoadTable();
                txt_Id.Focus();
            }

        }
    }
}
