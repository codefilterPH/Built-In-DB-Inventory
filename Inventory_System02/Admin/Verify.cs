using Inventory_System02.Includes;
using System;
using System.Data;
using System.Windows.Forms;


namespace Inventory_System02.Admin
{
    public partial class Verify : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        string sql = string.Empty;
        //string date_format;
        public Verify()
        {
            InitializeComponent();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (cbo_extend_type.Text == "Trial")
            {
                sql = "Update `Administration` set Date = '" + dtp_date_extend.Value.ToString(Includes.AppSettings.DateFormatRetrieve) + "' , Status = 'Trial' ";
                config.Execute_CUD(sql, "Unable to extend trial! Please try again.", "Successfully extended trial!");
                Application.Restart();
            }
            else
            {
                if (txt_1.Text == Includes.AppSettings.app_value)
                {

                    sql = "Update Administration set Status = 'Full' where Count = '0' ";
                    config.Execute_CUD(sql, "Unable to register! Please contact administrator.", "Software successfully registered! Welcome Full Pack Version.");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("The activation key is incorrect please try again!", "Warning Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_1.Focus();
                }
            }
            btn_validate.Enabled = false;
        }
        private void Verify_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbo_extend_type_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_extend_type.Text == "Trial")
            {
                DisableActivaitonKey();
                EnableTrialDate();
                dtp_date_extend.Text = DateTime.Now.AddDays(90).ToString(Includes.AppSettings.DateFormatRetrieve);
                dtp_date_extend.Focus();

            }
            else
            {
                EnableActivationKey();
                DisableTrialDate();
                txt_1.Focus();
            }
        }
        private void EnableActivationKey()
        {
            txt_1.Visible = true;
            lbl_activation_key.Visible = true;
        }

        private void DisableActivaitonKey()
        {
            txt_1.Visible = false;
            lbl_activation_key.Visible = false;
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Unlock_Click(sender, e);
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Unlock_Click(sender, e);
            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from Employee where `Employee ID` like '%" + txt_Username.Text + "%' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                string info = config.dt.Rows[0].Field<string>("Employee ID");
                if (info != "admin")
                {
                    btn_Unlock.Enabled = false;
                }
                else
                {
                    btn_Unlock.Enabled = true;
                }
            }
        }

        private void DisableTrialDate()
        {
            dtp_date_extend.Visible = false;
            lbl_exp_date.Visible = false;
        }
        private void EnableTrialDate()
        {
            dtp_date_extend.Visible = true;
            lbl_exp_date.Visible = true;
        }

        private void Verify_Load(object sender, EventArgs e)
        {
            DisableActivaitonKey();
            EnableTrialDate();
            dtp_date_extend.Focus();
            dtp_date_extend.Text = DateTime.Now.AddDays(14).ToString(Includes.AppSettings.DateFormatSave);

        }

        private void btn_Unlock_Click(object sender, EventArgs e)
        {
            sql = "Select * from Employee where `Employee ID` = '" + txt_Username.Text + "' and `Password` = SHA512('" + txt_Password.Text + "') ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                if (config.dt.Rows[0].Field<string>("Employee ID") != "admin")
                {
                    btn_validate.Enabled = false;
                }
                else
                {
                    btn_validate.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials! Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
