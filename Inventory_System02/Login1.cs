using Inventory_System02.Includes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory_System02
{
    public partial class Login1 : Form
    {
        usableFunction func = new usableFunction();
        string sql;
        SQLConfig config = new SQLConfig();
        App_Settings settngs = new App_Settings();

        public Login1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == null || txt_Username.Text == "")
            {
                func.Error_Message1 = "Username";
                func.Error_Message();
                txt_Username.Focus();
                return;
            }
            else if (txt_Password.Text == null || txt_Password.Text == "")
            {
                func.Error_Message1 = "Password";
                func.Error_Message();
                txt_Password.Focus();
                return;
            }

            sql = "Select * from Employee where `Employee ID` = '" + txt_Username.Text + "' and `Password` = sha1('" + txt_Password.Text + "') ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {

                string id = config.dt.Rows[0].Field<string>("Employee ID");
                string name = config.dt.Rows[0].Field<string>("First Name") + " " + config.dt.Rows[0].Field<string>("Last Name");
                string acctype = config.dt.Rows[0].Field<string>("Job Role");
                string phone = config.dt.Rows[0].Field<string>("Phone Number");
                string email = config.dt.Rows[0].Field<string>("Email");

                MainForm frm = new MainForm(id, name, acctype, phone, email);
                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                lbl_error.Text = "Invalid Credentials";
            }
        }

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            lbl_error.Text = "";
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            lbl_error.Text = "";
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }

        private void Login1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        string date = string.Empty;
        string status = string.Empty;
        private void Login1_Load(object sender, EventArgs e)
        {


            func.Reload_Images(Company_Logo, "Company_Logo1", @"CommonSql\Pictures\Company\");


            sql = "Select * from Administration";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                status = config.dt.Rows[0].Field<string>("Status");
                date = config.dt.Rows[0].Field<string>("Date");

                if (status == "Full") 
                {
                    txt_Username.Focus();
                }
                else
                {
                    if (date == "")
                    {             
                        sql = "Update Administration set Date = '" + DateTime.Now.AddDays(90).ToString("dd-MM-yyyy") + "' where Count = '0'";
                        config.Execute_Query(sql);
                        txt_Username.Focus();
                    }
                    else
                    {
                        string date1 = DateTime.Now.ToString("dd-MM-yyyy");
                        if (Convert.ToDateTime(date1) >= Convert.ToDateTime(date))
                        {
                            Admin.Verify frm = new Admin.Verify();
                            frm.ShowDialog();
                        }
                        else
                        {
                            txt_Username.Focus();
                        }
                    }
                }
            }   
            else
            {
                sql = "Insert into Administration ( Date, Value ) values ('" + DateTime.Now.AddDays(90).ToString("dd-MM-yyyy") + "' , '100' ) ";
                config.Execute_Query(sql);
                txt_Username.Focus();
            }
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }
    }
}
