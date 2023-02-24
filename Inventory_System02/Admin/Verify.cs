using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System02.Includes;


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
        double sum = 0, val1 = 0, val2 = 0, val3 = 0, val4 = 0 , val5 = 0;
        private void btn_validate_Click(object sender, EventArgs e)
        {
            if ( cbo_extend_type.Text == "Trial" )
            {
                sql = "Update `Administration` set Date = '" + dtp_date_extend.Text + "', Status = 'Trial' where Count = '0' ";
                config.Execute_CUD(sql, "Unable to extend trial! Please try again.", "Successfully extended trial!");
                
                Application.Exit();
            }
            else
            {
                double.TryParse(txt_1.Text, out val1);
                double.TryParse(txt_2.Text, out val2);
                double.TryParse(txt_3.Text, out val3);
                double.TryParse(txt_4.Text, out val4);
                double.TryParse(txt_5.Text, out val5);

                sum = val1 + val2 + val3 + val4 + val5;

                sql = "Select Value from Administration";
                config.singleResult(sql);
                if(config.dt.Rows.Count > 0 )
                {
                    double value_code = Convert.ToDouble(config.dt.Rows[0].Field<string>("Value"));
                    if (sum == value_code)
                    {
                       
                        sql = "Update Administration set Status = 'Full' where Count = '0' ";
                        config.Execute_CUD(sql,"Unable to register! Please contact administrator.", "Software successfully registered! Welcome Full Pack Version.");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("The activation key is incorrect please try again!", "Warning Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_1.Focus(); 
                    }
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

            if ( cbo_extend_type.Text == "Trial")
            {
                DisableActivaitonKey();
                EnableTrialDate();
                dtp_date_extend.Text = DateTime.Now.AddDays(90).ToString(Includes.AppSettings.DateFormat);
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
            txt_2.Visible = true;
            txt_3.Visible = true;
            txt_4.Visible = true;
            txt_5.Visible = true;
            lbl_activation_key.Visible = true;
        }

        private void DisableActivaitonKey()
        {
            txt_1.Visible = false;
            txt_2.Visible = false;
            txt_3.Visible = false;
            txt_4.Visible = false;
            txt_5.Visible = false;
            lbl_activation_key.Visible = false;
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
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
                if ( info != "admin")
                {
                    btn_Unlock.Enabled = false;
                }
                else
                {
                    btn_Unlock.Enabled = true;
                }
            }
        }

        private void KeyPress_DoNotAcceptLetters(object sender, KeyPressEventArgs e)
        {
           func.KeyPress_Textbox_Numberonly(sender, e);
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
            dtp_date_extend.Text = DateTime.Now.AddDays(180).ToString(Includes.AppSettings.DateFormat);

        }

        private void btn_Unlock_Click(object sender, EventArgs e)
        {        
            sql = "Select * from Employee where `Employee ID` = '" + txt_Username.Text + "' and `Password` = sha1('" + txt_Password.Text + "') ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0 )
            {
                if ( config.dt.Rows[0].Field<string>("Employee ID") != "admin" )
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
