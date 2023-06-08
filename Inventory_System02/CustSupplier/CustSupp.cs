using Inventory_System02.Includes;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Inventory_System02.CustSupplier
{
    public partial class CustSupp : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        ID_Generator gen = new ID_Generator();
        string sql, Global_ID, Fullname, JobRole, CustSup;

        string main_path = string.Empty;
        public string cusID { get; set; }
        public string supID { get; set; }

        public CustSupp(string global_id, string fullname, string jobrole, string Type_of_Need)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
            CustSup = Type_of_Need;

            string main_path = string.Empty;

        }

        private void btn_GenerateID_Click(object sender, EventArgs e)
        {
            gen.Supplier_ID();
            sql = "Select `Supplier ID` from ID_Generated where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                Sup_ID.Text = config.dt.Rows[0].Field<string>("Supplier ID");
            }
        }

        private void CustSupp_Load(object sender, EventArgs e)
        {
            supplier_refresh_Click(sender, e);
            refreshToolStripMenuItem_Click(sender, e);
            if (CustSup == "Sup")
            {
                tabControl1.SelectedTab = tabPage2;
                func.Reload_Images(Sup_Image, Sup_ID.Text, Includes.AppSettings.Supplier_DIR);
                Sup_ID.Focus();

            }
            else
            {
                tabControl1.SelectedTab = tabPage1;
                func.Reload_Images(Cust_Image, cust_ID.Text, Includes.AppSettings.Customer_DIR);

            }
            timer1.Start();
            UnlockModels();



        }
        private void UnlockModels()
        {
            if (cust_ID.Text == "")
            {
                customerModelsToolStripMenuItem.Enabled = false;
            }
            else
            {
                customerModelsToolStripMenuItem.Enabled = true;
            }
        }

        public void btn_sup_add_Click(object sender, EventArgs e)
        {

            if (Sup_ID.Text == "" || Sup_ID.Text == null)
            {
                func.Error_Message1 = "ID";
                func.Error_Message();
                btn_GenerateID.Focus();
            }
            else if (sup_CName.Text == "" || sup_CName.Text == null)
            {
                func.Error_Message1 = "First Name";
                func.Error_Message();
                sup_CName.Focus();
            }
            else if (sup_Address.Text == "" || sup_Address.Text == null)
            {
                func.Error_Message1 = "Address";
                func.Error_Message();
                sup_Address.Focus();
            }
            else
            {
                sql = "Select * from Supplier where `Company ID` = '" + Sup_ID.Text + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    MessageBox.Show("There is an existing supplier using this ID. Please replace the ID.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sql = "Insert into Supplier (`Entry Date`, `Company ID`, `Company Name`, Email ,`Phone`, `Address`) values (" +
                    " '" + DateTime.Now.ToString(Includes.AppSettings.DateFormatSave) + "' " +
                    ", '" + Sup_ID.Text + "' " +
                    ", '" + sup_CName.Text + "'" +
                    ", '" + sup_Email.Text + "' " +
                    ", '" + sup_Phone.Text + "' " +
                    ", '" + sup_Address.Text + "'  ) ";
                    config.Execute_CUD(sql, "Unsuccessful to Record " + sup_CName.Text, "Successfully recorded " + sup_CName.Text);
                    tabControl1.SelectedTab = tabPage2;
                    supplier_refresh_Click(sender, e);

                }

            }
        }

        private void btn_sup_delete_Click(object sender, EventArgs e)
        {
            if (JobRole != "Programmer/Developer" && JobRole != "Office Manager")
            {
                MessageBox.Show("No permission to delete supplier! Thank you.", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (dtg_Supplier.Rows.Count >= 1)
            {
                if (dtg_Supplier.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Are you sure you want to delete " + dtg_Supplier.CurrentRow.Cells[3].Value.ToString() + "?", "Warning Deletion Prompt",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sql = "Delete from Supplier where `Company ID` = '" + dtg_Supplier.CurrentRow.Cells[2].Value.ToString() + "' ";
                        config.Execute_CUD(sql, "Unable to delete supplier " + dtg_Supplier.CurrentRow.Cells[3].Value.ToString() + "!", "Successfully deleted supplier " + dtg_Supplier.CurrentRow.Cells[3].Value.ToString() + "!");
                        supplier_refresh_Click(sender, e);

                    }
                }
                else if (dtg_Supplier.SelectedRows.Count > 1)
                {

                    if (MessageBox.Show("Are you sure you want to delete selected?", "Warning Deletion Prompt",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow rw in dtg_Supplier.SelectedRows)
                        {
                            sql = "Delete from Supplier where `Company ID` = '" + rw.Cells[2].Value.ToString() + "' ";
                            config.Execute_Query(sql);
                        }
                        MessageBox.Show("Successfully deleted supplier\'s profile!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        supplier_refresh_Click(sender, e);
                    }
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Supplier.Rows.Count > 0)
            {

                Sup_ID.Text = dtg_Supplier.CurrentRow.Cells[2].Value.ToString();
                sup_CName.Text = dtg_Supplier.CurrentRow.Cells[3].Value.ToString();
                sup_Email.Text = dtg_Supplier.CurrentRow.Cells[4].Value.ToString();
                sup_Phone.Text = dtg_Supplier.CurrentRow.Cells[5].Value.ToString();
                sup_Address.Text = dtg_Supplier.CurrentRow.Cells[6].Value.ToString();
                func.Reload_Images(Sup_Image, Sup_ID.Text, Includes.AppSettings.Supplier_DIR);
                func.Change_Font_DTG(sender, e, dtg_Supplier);
                Sup_ID.Focus();
            }
        }

        private void btn_Gen_ID_Click(object sender, EventArgs e)
        {
            gen.Customer_ID();
            sql = "Select `Customer ID` from ID_Generated where count = '1' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                cust_ID.Text = config.dt.Rows[0].Field<string>("Customer ID");
            }
        }

        private void btn_Cust_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cust_ID.Text))
            {
                func.Error_Message1 = "ID";
                func.Error_Message();
                cust_ID.Focus();

            }
            else if (string.IsNullOrWhiteSpace(cust_FN.Text))
            {
                func.Error_Message1 = "First Name";
                func.Error_Message();
                cust_FN.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cust_SAddress.Text))
            {
                func.Error_Message1 = "Address";
                func.Error_Message();
                cust_FN.Focus();
            }
            else
            {
                sql = "Select * from Customer where `Customer ID` = '" + cust_ID.Text + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count == 0)
                {
                    sql = "Insert into Customer ( " +
                    " `Entry Date` " +
                    ", `Customer ID` " +
                    ",`Name` " +
                    ",`Phone Number` " +
                    ",`Address`" +
                    ",`Type`) values ( " +
                    " '" + DateTime.Now.ToString(Includes.AppSettings.DateFormatSave) + "' " +
                    ",'" + cust_ID.Text + "' " +
                    ",'" + cust_FN.Text + "' " +
                    ",'" + cust_Phone.Text + "' " +
                    ",'" + cust_SAddress.Text + "'" +
                    ",'" + cbo_type.Text + "')";
                    config.Execute_CUD(sql, "Unable to save customer information", "Customer information successfully saved to record");
                    refreshToolStripMenuItem_Click(sender, e);

                }
                else
                {
                    MessageBox.Show(cust_ID.Text + " is already added to the list", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "Select * from Customer ORDER BY `Entry Date` DESC";
            config.Load_DTG(sql, dtg_Customer);
            DTG_SubProperty_Cust();
        }
        private void DTG_SubProperty_Cust()
        {
            if (dtg_Customer.Rows.Count > 0)
            {
                dtg_Customer.Columns[0].Visible = false;
                main_path = Includes.AppSettings.Customer_DIR + "\\";
                Load_Images(dtg_Customer);
            }
            if (dtg_Customer.Columns.Count > 0)
            {
                dtg_Customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg_Customer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_Customer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_Customer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_Customer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_Customer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_Customer.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_Customer.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }

            func.Count_person(dtg_Customer, lbl_total_cust);
        }


        private void supplier_refresh_Click(object sender, EventArgs e)
        {
            sql = "Select * from Supplier ORDER BY `Entry Date` DESC";
            config.Load_DTG(sql, dtg_Supplier);
            DTG_SubProperty_Sup();
        }
        private void DTG_SubProperty_Sup()
        {
            if (dtg_Supplier.Rows.Count > 0)
            {
                dtg_Supplier.Columns[0].Visible = false;
                main_path = Includes.AppSettings.Supplier_DIR + "\\";
                Load_Images(dtg_Supplier);

            }
            if (dtg_Customer.Columns.Count > 0)
            {
                dtg_Supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg_Supplier.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_Supplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_Supplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_Supplier.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtg_Supplier.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_Supplier.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_Supplier.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

            func.Count_person(dtg_Supplier, lbl_total_sup);
        }
        private void Load_Images(DataGridView dtg)
        {
            if (!config.dt.Columns.Contains("Image"))
            {
                config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
            }
            foreach (DataRow rw in config.dt.Rows)
            {
                if (File.Exists(main_path + rw[2].ToString() + ".JPG"))
                {
                    rw["Image"] = File.ReadAllBytes(main_path + rw[2].ToString() + ".JPG");
                }
                else
                {
                    rw["Image"] = File.ReadAllBytes(main_path + "DONOTDELETE_SUBIMAGE.JPG");
                }
            }

            for (int i = 0; i < dtg.Columns.Count; i++)
            {
                if (dtg.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dtg.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
            }
            dtg.Columns["Image"].DisplayIndex = 0;
            dtg.Columns["Image"].Width = 100;
        }

        private void btn_sup_edit_Click(object sender, EventArgs e)
        {
            supplier_refresh_Click(sender, e);

            if (Sup_ID.Text != "")
            {
                sql = "Select * from Supplier where `Company ID` = '" + Sup_ID.Text + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count <= 0)
                {
                    btn_sup_add_Click(sender, e);
                    return;
                }

                sql = "Update Supplier set " +
                "`Company Name` = '" + sup_CName.Text + "'" +
                ", Email = '" + sup_Email.Text + "' " +
                ", Phone = '" + sup_Phone.Text + "'" +
                ", Address = '" + sup_Address.Text + "'" +
                "where `Company ID` ='" + Sup_ID.Text + "' ";
                config.Execute_CUD(sql, "Unable to update supplier\'s profile!", "Supplier\'s Profile successfully updated");
                supplier_refresh_Click(sender, e);
            }
        }

        private void btn_Clear_Text_Click(object sender, EventArgs e)
        {
            func.clearTxt(tabPage1);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                timer1.Start();
                func.Reload_Images(Sup_Image, Sup_ID.Text, Includes.AppSettings.Supplier_DIR);
                supplier_refresh_Click(sender, e);

            }
            else
            {
                refreshToolStripMenuItem_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sql = "Select Type from `Customer Type`";
            config.fiil_CBO(sql, cbo_type);
            timer1.Stop();
        }

        private void Cust_Image_DoubleClick(object sender, EventArgs e)
        {
            func.DoubleClick_Picture_Then_Replace_Existing(Cust_Image, cust_ID.Text, Includes.AppSettings.Customer_DIR);
            func.Reload_Images(Cust_Image, cust_ID.Text, Includes.AppSettings.Customer_DIR);
            refreshToolStripMenuItem_Click(sender, e);

        }

        private void Sup_Image_DoubleClick(object sender, EventArgs e)
        {
            func.DoubleClick_Picture_Then_Replace_Existing(Sup_Image, Sup_ID.Text, Includes.AppSettings.Supplier_DIR);
            func.Reload_Images(Sup_Image, Sup_ID.Text, Includes.AppSettings.Supplier_DIR);
            supplier_refresh_Click(sender, e);
        }

        private void cust_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cusID = cust_ID.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Sup_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                supID = Sup_ID.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void customerModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustModels frm = new CustModels(cust_ID.Text, cust_FN.Text);
            frm.ShowDialog();
        }

        private void cust_ID_TextChanged(object sender, EventArgs e)
        {
            UnlockModels();
        }

        private void btn_new_customer_Click(object sender, EventArgs e)
        {
            refreshToolStripMenuItem_Click(sender, e);
            btn_Clear_Text_Click(sender, e);
            btn_Gen_ID_Click(sender, e);
            cust_ID.Focus();
            cust_ID.SelectionLength = cust_ID.Text.Length;
        }

        private void btn_new_supplier_Click(object sender, EventArgs e)
        {
            supplier_refresh_Click(sender, e);
            btn_Clear_Click(sender, e);
            btn_GenerateID_Click(sender, e);
            Sup_ID.Focus();
            Sup_ID.SelectionLength = Sup_ID.Text.Length;
        }

        private void txt_Search_sup_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from Supplier where `Company ID` like '%" + txt_Search_sup.Text + "%' or `Company Name` like '%" + txt_Search_sup.Text + "%' ORDER BY `Entry Date` DESC";
            config.Load_DTG(sql, dtg_Supplier);
            DTG_SubProperty_Sup();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from Customer where `Customer ID` like '%" + txt_Search.Text + "%' or `Name` like '%" + txt_Search.Text + "%' ORDER BY `Entry Date` DESC";
            config.Load_DTG(sql, dtg_Customer);
            DTG_SubProperty_Cust();
        }

        private void btn_Upload_Cust_Click(object sender, EventArgs e)
        {
            if (cust_ID.Text != "" && cust_ID.Text != "Empty Field!")
            {
                Cust_Image_DoubleClick(sender, e);
            }
            else
            {
                cust_ID.Text = "Empty Field!";
                cust_ID.SelectionLength = cust_ID.Text.Length;
                cust_ID.Focus();
            }
        }

        private void btn_Upload_sup_Click(object sender, EventArgs e)
        {
            if (Sup_ID.Text != "" && Sup_ID.Text != "Empty Field!")
            {
                Sup_Image_DoubleClick(sender, e);
            }
            else
            {
                Sup_ID.Text = "Empty Field!";
                Sup_ID.SelectionLength = cust_ID.Text.Length;
                Sup_ID.Focus();
            }
        }

        private void dtg_Customer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cusID = cust_ID.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dtg_Supplier_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            supID = Sup_ID.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cusid_select_Click(object sender, EventArgs e)
        {
            if (dtg_Customer.Rows.Count >= 1)
            {
                if (dtg_Customer.SelectedRows.Count > 0)
                {
                    if (cust_ID.Text != "Empty Field!" || !string.IsNullOrWhiteSpace(cust_ID.Text))
                    {
                        cust_ID.Text = dtg_Customer.CurrentRow.Cells[2].Value.ToString();
                    }
                    cusID = cust_ID.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btn_supid_select_Click(object sender, EventArgs e)
        {
            if (dtg_Supplier.Rows.Count >= 1)
            {
                if (dtg_Supplier.SelectedRows.Count > 0)
                {
                    if (Sup_ID.Text != "Empty Field!" || !string.IsNullOrWhiteSpace(Sup_ID.Text))
                    {
                        Sup_ID.Text = dtg_Supplier.CurrentRow.Cells[2].Value.ToString();
                    }
                    supID = Sup_ID.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void sup_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            func.KeyPress_Textbox_NumbersOnlyNoDot(sender, e);
        }

        private void cust_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            func.KeyPress_Textbox_NumbersOnlyNoDot(sender, e);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Execute the UI code on the UI thread
            //dtg_Customer.Invoke((MethodInvoker)delegate {
            //dtg_Customer.Columns["Image"].Width = 100;
            // });

            //dtg_Supplier.Invoke((MethodInvoker)delegate {
            //     dtg_Supplier.Columns["Image"].Width = 100;
            //});

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            func.clearTxt(tabPage2);
        }

        private void btn_Cust_Delete_Click(object sender, EventArgs e)
        {
            if (JobRole != "Programmer/Developer" && JobRole != "Office Manager")
            {
                MessageBox.Show("No permission to delete customer! Thank you.", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (dtg_Customer.Rows.Count >= 1)
            {
                if (dtg_Customer.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Are you sure you want to delete " + cust_FN.Text + "?", "Warning Deletion Prompt",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sql = "Delete from Customer where `Customer ID` = '" + dtg_Customer.CurrentRow.Cells[2].Value.ToString() + "' ";
                        config.Execute_CUD(sql, "Unable to delete customer!", "Successfully deleted customer!");
                        refreshToolStripMenuItem_Click(sender, e);

                    }
                }
                else if (dtg_Customer.SelectedRows.Count > 1)
                {

                    if (MessageBox.Show("Are you sure you want to delete selected?", "Warning Deletion Prompt",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow rw in dtg_Customer.SelectedRows)
                        {
                            sql = "Delete from Customer where `Customer ID` = '" + rw.Cells[2].Value.ToString() + "' ";
                            config.Execute_Query(sql);
                        }
                        MessageBox.Show("Successfully deleted customer\'s profile!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }

        private void dtg_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Customer.Rows.Count > 0)
            {
                cust_ID.Text = dtg_Customer.CurrentRow.Cells[2].Value.ToString();
                cust_FN.Text = dtg_Customer.CurrentRow.Cells[3].Value.ToString();
                cust_Phone.Text = dtg_Customer.CurrentRow.Cells[4].Value.ToString();
                cust_SAddress.Text = dtg_Customer.CurrentRow.Cells[5].Value.ToString();
                cbo_type.Text = dtg_Customer.CurrentRow.Cells[6].Value.ToString();

                func.Reload_Images(Cust_Image, cust_ID.Text, Includes.AppSettings.Customer_DIR);
                func.Change_Font_DTG(sender, e, dtg_Customer);
                cust_ID.Focus();
            }
        }

        public void btn_Cust_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cust_ID.Text))
            {
                MessageBox.Show("Customer \"ID\" should not be empty!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cust_ID.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(cust_FN.Text))
            {
                MessageBox.Show("Customer \"NAME\" should not be empty!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cust_FN.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(cust_SAddress.Text))
            {
                MessageBox.Show("Customer \"ADDRESS\" should not be empty!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cust_SAddress.Focus();
                return;
            }
            else
            {
                sql = "Select * from Customer where `Customer ID` = '" + cust_ID.Text + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count <= 0)
                {
                    btn_Cust_add_Click(sender, e);
                    return;
                }

                sql = "Update Customer set " +
                    "`Name` = '" + cust_FN.Text + "'" +
                    ",`Phone Number` = '" + cust_Phone.Text + "'" +
                    ",`Address` = '" + cust_SAddress.Text + "' " +
                    ", Type = '" + cbo_type.Text + "' " +
                    "where `Customer ID` = '" + cust_ID.Text + "' ";
                config.Execute_CUD(sql, "Unable to update " + cust_FN.Text, "Successfully updated " + cust_FN.Text);
                refreshToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
