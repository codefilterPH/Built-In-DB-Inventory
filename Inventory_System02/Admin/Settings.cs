using Inventory_System02.Includes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory_System02
{
    public partial class Settings : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        string sql, Global_ID, Fullname, JobRole, setting_name;
        string col;

        public Settings(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;

            func.Reload_Images(Company_Logo, "Company_Logo1", Includes.AppSettings.Company_DIR);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            sql = "Select * from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txt_company_name.Text = config.dt.Rows[0].Field<string>("Company_Name");
                num_SL_Detection.Text = config.dt.Rows[0]["Low_Detection"].ToString();
                num_Warranty.Text = config.dt.Rows[0]["Warranty"].ToString();
                txt_Com_Address.Text = config.dt.Rows[0].Field<string>("Company Address");
            }

            dtg_settings.Columns.Clear();
            timer1.Start();
            if (cbo_type.Text == "Product Name")
            {
                sql = "Select * from `Product Name`";
                config.Load_DTG(sql, dtg_settings);
            }
            else
            {
                sql = "Select * from Brand";
                config.Load_DTG(sql, dtg_settings);
            }

            txt_Def_text.Text = "";

            dtg_settings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_settings.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cbo_type_SelectedIndexChanged(sender, e);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            setting_name = string.Empty;
            col = string.Empty;

            if (txt_Def_text.Text != null || txt_Def_text.Text != string.Empty)
            {
                Check_What_Table();
                sql = "Select * from " + setting_name + " where Count = '" + txt_ID.Text + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    MessageBox.Show("Count already exist!");
                    txt_ID.Focus();
                    txt_ID.Enabled = true;
                    txt_Def_text.Enabled = true;
                    return;
                }
                sql = "Select * from " + setting_name + " where " + col + " = '" + txt_Def_text.Text + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    MessageBox.Show("Name or Type already exist!");
                    txt_Def_text.Focus();
                    txt_ID.Enabled = true;
                    txt_Def_text.Enabled = true;
                    return;
                }

                sql = "Insert into " + setting_name + " ( Count,  " + col + " ) values ( '" + txt_ID.Text + "' , '" + txt_Def_text.Text + "'  )";
                config.Execute_CUD(sql, "Unsuccessful to add settings \n\nEither an error occured or Needs to Highlight from the table!",
                    "Settings for product name successfully added");
                btn_Clear_Text_Click(sender, e);

            }
            else
            {
                MessageBox.Show("The Definition text is empty!");
                txt_Def_text.Focus();
            }
            sql = "Select * from `" + cbo_type.Text + "` ";
            config.Load_DTG(sql, dtg_settings);
            timer1.Start();
            btn_Clear_Text_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dtg_settings.Rows.Count < 1)
            {
                txt_ID.Text = "1";
            }
            else
            {
                for (int i = 0; i <= dtg_settings.Rows.Count; i++)
                {
                    double res = i + 1;
                    txt_ID.Text = res.ToString();
                }

                timer1.Stop();
            }
        }
        private void Check_What_Table()
        {
            col = string.Empty;
            setting_name = string.Empty;
            if (cbo_type.Text == "Product Name")
            {
                setting_name = "`Product Name`";
                col = "Name";
            }
            else if (cbo_type.Text == "Brand")
            {
                setting_name = "`Brand`";
                col = "Name";
            }
            else if (cbo_type.Text == "Customer Type")
            {
                setting_name = "`Customer Type`";
                col = "Type";
            }
            else if (cbo_type.Text == "Customer Models")
            {
                setting_name = "`Customer Models`";
                col = "Type";
            }
            else
            {
                setting_name = "`Employee Role`";
                col = "Type";
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Def_text.Text))
            {


                string selectedType = string.Empty;
                foreach (DataGridViewRow rw in dtg_settings.SelectedRows)
                {

                    selectedType = rw.Cells[1].Value.ToString();
                    break;
                }

                if (selectedType == "Office Manager" || selectedType == "Programmer/Developer")
                {
                    MessageBox.Show("You cannot alter this employee role because the system or other employees are using this role! Thank you.", "Not Allowed",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                Check_What_Table();
                sql = "Update " + setting_name + " set " + col + " =  '" + txt_Def_text.Text + "'  where Count = '" + txt_ID.Text + "' ";
                config.Execute_CUD(sql, "Unsuccessful to update settings \n\n Either an error occured or Needs to Highlight from the table!",
                    "Settings successfully updated");
            }
            else
            {
                MessageBox.Show("The table is empty! \n\nAdd then highlight or click the arrow from the left to edit unwanted entries!");
                txt_Def_text.Focus();
            }

            sql = "Select * from `" + cbo_type.Text + "` ";
            config.Load_DTG(sql, dtg_settings);
            timer1.Start();
            btn_Clear_Text_Click(sender, e);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (dtg_settings.Rows.Count >= 1)
            {
                foreach (DataGridViewRow rw in dtg_settings.SelectedRows)
                {
                    Check_What_Table();
                    if (setting_name == "`Employee Role`")
                    {
                        string type = rw.Cells["Type"].Value.ToString();
                        if (type == "Office Manager" || type == "Programmer/Developer")
                        {
                            MessageBox.Show("This employee role cannot be deleted!");
                            continue; // skip to next row
                        }
                    }
                    sql = "DELETE FROM " + setting_name + " WHERE Count = '" + rw.Cells[0].Value + "' ";
                    config.Execute_Query(sql);
                }
            }
            else
            {
                MessageBox.Show("The table is empty! \n\nAdd then highlight or click the arrow from the left to delete unwanted entries!");
                txt_Def_text.Focus();
            }
            sql = "Select * from `" + cbo_type.Text + "` ";
            config.Load_DTG(sql, dtg_settings);
            timer1.Start();
            btn_Clear_Text_Click(sender, e);
        }

        private void btn_Clear_Text_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_Def_text.Text = "";
            if (dtg_settings.Rows.Count >= 1)
            {
                txt_ID.Text = Convert.ToString(dtg_settings.Rows.Count + 1);
            }

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {

            func.DoubleClick_Picture_Then_Replace_Existing(Company_Logo, "Company_Logo1", Includes.AppSettings.Company_DIR);
            func.Reload_Images(Company_Logo, "Company_Logo1", Includes.AppSettings.Company_DIR);

            sql = "Select Company_Image from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                sql = "Update Settings set Company_Image = '" + Includes.AppSettings.Company_DIR + "\\" + "Company_Logo1.PNG" + "' ";
                config.Execute_Query(sql);
            }

            Application.Exit();
            Application.Restart();


        }

        private void btn_company_name_Click(object sender, EventArgs e)
        {
            if (txt_company_name.Enabled == false)
            {
                txt_company_name.Enabled = true;
                txt_company_name.Focus();
            }
        }

        private void txt_company_name_Leave(object sender, EventArgs e)
        {
            txt_company_name.Enabled = false;
            sql = "Select * from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {

                sql = "Update Settings set Company_Name = '" + txt_company_name.Text + "' ";
                config.Execute_CUD(sql, "No way to change company name. Failed!", "Name of business successfully modified! Thank you.");
                Settings_Load(sender, e);

            }
            else
            {
                sql = "Insert into Settings ( `Company_Name` ) values ( '" + txt_company_name.Text + "' ) ";
                config.Execute_CUD(sql, "No way to change company name. Failed!", "Name of business successfully saved! Thank you.");
                Settings_Load(sender, e);
            }

        }
        private void btn_SL_save_Click(object sender, EventArgs e)
        {
            num_SL_Detection.Enabled = false;
            sql = "Select * from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {

                sql = "Update Settings set Low_Detection = '" + num_SL_Detection.Text + "' ";
                config.Execute_CUD(sql, "Unable to update stock low detection, Please try again or contact administrator.",
                    "Successfully updated stock low detection!");
                Settings_Load(sender, e);
            }
            else
            {
                sql = "Insert into Settings ( `Low_Detection` ) values ( '" + num_SL_Detection.Text + "' ) ";
                config.Execute_CUD(sql, "Unable to add stock low detection. Please contact administrator!", "Successfully setup stock low detection!");
                Settings_Load(sender, e);
            }
        }

        private void num_SL_Detection_Leave(object sender, EventArgs e)
        {
            btn_SL_save_Click(sender, e);
        }

        private void num_SL_Detection_DoubleClick(object sender, EventArgs e)
        {
            num_SL_Detection.Enabled = true;
        }

        private void btn_Warranty_Click(object sender, EventArgs e)
        {
            num_Warranty.Enabled = false;
            sql = "Select * from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {

                sql = "Update Settings set Warranty = '" + num_Warranty.Text + "' ";
                config.Execute_CUD(sql, "Unable to update warranty, Please contact administrator!", "Successfully updated warranty value!");
                Settings_Load(sender, e);
            }
            else
            {
                sql = "Insert into Settings ( `Warranty` ) values ( '" + num_Warranty.Text + "' ) ";
                config.Execute_CUD(sql, "Unable to insert warranty value, Please contact administrator!", "Successfully inserted warranty value!");
                Settings_Load(sender, e);
            }
        }

        private void num_Warranty_DoubleClick(object sender, EventArgs e)
        {
            num_Warranty.Enabled = true;
            num_Warranty.Focus();
        }

        private void btn_edit_warranty_Click(object sender, EventArgs e)
        {
            num_Warranty.Enabled = true;
            num_Warranty.Focus();
        }

        private void btn_edit_detection_Click(object sender, EventArgs e)
        {
            num_SL_Detection.Enabled = true;
            num_SL_Detection.Focus();
        }

        private void num_Warranty_Leave(object sender, EventArgs e)
        {
            num_Warranty.Enabled = false;
        }

        private void btn_Address_Click(object sender, EventArgs e)
        {
            if (txt_Com_Address.Enabled == false)
            {
                txt_Com_Address.Enabled = true;
                btn_Address.Focus();
            }
            else
            {
                btn_Address.Focus();
                txt_Com_Address.Enabled = false;
                MessageBox.Show("Saved! Try to restart the app to apply changes!", "Prompt Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txt_Com_Address_Leave(object sender, EventArgs e)
        {
            txt_Com_Address.Enabled = false;

            sql = "Select * from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {

                sql = "Update Settings set `Company Address` = '" + txt_Com_Address.Text + "' ";
                config.singleResult(sql);
                Settings_Load(sender, e);
            }
            else
            {
                sql = "Insert into Settings ( `Company Address` ) values ( '" + txt_Com_Address.Text + "' ) ";
                config.singleResult(sql);
                Settings_Load(sender, e);
            }
            txt_Com_Address.Enabled = false;
        }

        private void dtg_settings_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            txt_ID.Text = "";
            txt_Def_text.Text = "";

            txt_Def_text.Enabled = false;
            txt_ID.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_settings.Rows.Count > 0)
            {

                txt_ID.Text = dtg_settings.CurrentRow.Cells[0].Value.ToString();
                txt_Def_text.Text = dtg_settings.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void txt_Def_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_Click(sender, e);
            }
        }

        private void cbo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_type.Text == "Product Name")
            {
                sql = "Select * from `Product Name`";
                config.Load_DTG(sql, dtg_settings);
            }
            else if (cbo_type.Text == "Brand")
            {
                sql = "Select * from Brand";
                config.Load_DTG(sql, dtg_settings);
            }
            else if (cbo_type.Text == "Customer Type")
            {
                sql = "Select * from `Customer Type`";
                config.Load_DTG(sql, dtg_settings);

            }
            else if (cbo_type.Text == "Customer Models")
            {
                sql = "Select * from `Customer Models`";
                config.Load_DTG(sql, dtg_settings);
            }
            else
            {
                sql = "Select * from `Employee Role`";
                config.Load_DTG(sql, dtg_settings);

            }
            timer1.Start();
            txt_Def_text.Text = "";
            txt_Def_text.Focus();
        }
    }
}
