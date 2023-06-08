using Inventory_System02.Includes;
using Microsoft.Win32;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Inventory_System02
{
    public partial class Login1 : Form
    {
        usableFunction func = new usableFunction();
        string sql;
        SQLConfig config = new SQLConfig();
        private Mutex _mutex;
        public Login1()
        {
            InitializeComponent();
            _mutex = new Mutex(true, "Inventory_System02");

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

            try
            {
                sql = string.Empty;
                config = new SQLConfig();
                sql = "Select * from Employee where `Employee ID` = '" + txt_Username.Text + "' and Password = SHA512('" + txt_Password.Text + "') ";
                config.singleResult(sql);
                if (config.dt.Rows.Count == 1)
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
            catch (Exception ex)
            {
                // Log or display any errors
                MessageBox.Show("Error: " + ex.Message);
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
            System.Windows.Forms.Application.Exit();
        }
        string date = string.Empty;
        string status = string.Empty;
        private void Login1_Load(object sender, EventArgs e)
        {
            bool isPdfInstalled = false;

            // Check if Adobe Reader is installed by looking at the registry
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(".pdf");
            if (key != null)
            {
                string pdfDefault = key.GetValue("") as string;
                if (!string.IsNullOrEmpty(pdfDefault))
                {
                    RegistryKey pdfKey = Registry.ClassesRoot.OpenSubKey(pdfDefault);
                    if (pdfKey != null)
                    {
                        string pdfAppName = pdfKey.GetValue("") as string;
                        if (!string.IsNullOrEmpty(pdfAppName))
                        {
                            isPdfInstalled = true;
                        }
                    }
                }
            }

            if (isPdfInstalled)
            {
                // Get the current date in the format Includes.AppSettings.DateFormat
                string formattedDate = DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve);

                // Check if the current date is not in the desired format
                if (!Regex.IsMatch(formattedDate, @"^\d{4}-\d{2}-\d{2}$"))
                {
                    // Display an error message and exit the application
                    MessageBox.Show("The date format on this computer is not supported by this application. Please set the date format to 'Includes.AppSettings.DateFormat' and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Windows.Forms.Application.Exit();
                }
                else
                {

                    func.Reload_Images(Company_Logo, "Company_Logo1", Includes.AppSettings.Company_DIR);
                    sql = "Select Date, Status from Administration";
                    config.singleResult(sql);
                    if (config.dt.Rows.Count == 1)
                    {
                        status = config.dt.Rows[0]["Status"].ToString();
                        date = config.dt.Rows[0]["Date"].ToString();

                        if (string.IsNullOrWhiteSpace(status))
                        {
                            Admin.Verify frm = new Admin.Verify();
                            frm.ShowDialog();
                        }
                        if (string.IsNullOrWhiteSpace(date))
                        {
                            sql = "Update Administration set Date = '" + DateTime.Now.AddDays(14).ToString(Includes.AppSettings.DateFormatRetrieve) + "' "; ;
                            config.Execute_Query(sql);
                        }

                        if (status == "Trial")
                        {
                            string date1 = DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve);
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
                        else if (status == "Full")
                        {
                            txt_Username.Focus();
                        }
                        else
                        {
                            Admin.Verify frm = new Admin.Verify();
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        sql = "Insert into Administration ( Date ) values ( '" + DateTime.Now.AddDays(14).ToString(Includes.AppSettings.DateFormatRetrieve) + "' ) ";
                        config.Execute_Query(sql);
                        txt_Username.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Adobe Reader is not installed. Please install Adobe Reader before running this application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Windows.Forms.Application.Exit();
            }
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }
        private Mutex mutex = new Mutex(false, "Inventory_System02");
        private void Login1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Acquire the mutex before releasing it
                lock (mutex)
                {
                    mutex.ReleaseMutex();
                }
            }
            catch
            {
                System.Windows.Forms.Application.Exit();
            }

        }
    }
}
