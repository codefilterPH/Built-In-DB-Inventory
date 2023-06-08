using Inventory_System02.Includes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_System02
{
    public partial class MainForm : Form
    {
        private Login1 _loginForm;
        private bool sidebarExpand = false;
        string Global_ID, Fullname, JobRole;
        usableFunction func = new usableFunction();



        public MainForm(string userid, string name, string acctype, string phone, string email)
        {
            InitializeComponent();
            _loginForm = new Login1();

            this.Text = "Inventory System - Welcome " + name;
            Global_ID = userid;
            lbl_Fullname.Text = userid.ToUpper() + " - " + name.ToUpper();

            Fullname = name;
            JobRole = acctype;

            if (!string.IsNullOrWhiteSpace(acctype))
            {
                lbl_Acc.Text = "Role " + acctype;
            }
            else
            {
                lbl_Acc.Text = "";
            }
            if (!string.IsNullOrWhiteSpace(phone))
            {
                lbl_Phone.Text = "Phone Number " + phone;
            }
            else
            {
                lbl_Phone.Text = "";
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                lbl_Email.Text = "Email " + email;
            }
            else
            {
                lbl_Email.Text = "";
            }

        }

        private void btn_Stocks_Click(object sender, EventArgs e)
        {
            Panel_content_remove();
            AddStock frm = new AddStock(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);

        }
        public static void ShowFormInContainerControl(Control ctl, Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            ctl.Controls.Add(frm);
        }
        public void Panel_content_remove()
        {
            foreach (Control item in show_panel.Controls.OfType<Form>())
            {
                item.Dispose();
                show_panel.Controls.Remove(item);
            }
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            btn_Stocks_Click(sender, e);
            func.Reload_Images(employee_Profile, Global_ID, Includes.AppSettings.Employee_DIR);
            func.Reload_Images(Company_Logo, "Company_Logo1", Includes.AppSettings.Company_DIR);
            Load_Company_name();

        }
        SQLConfig config = new SQLConfig();
        public void Load_Company_name()
        {
            string sql = string.Empty;
            sql = "Select * from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                company_Name.Text = config.dt.Rows[0].Field<string>("Company_Name");
            }

        }

        public string to, from;

        private void btn_DCenter_Click(object sender, EventArgs e)
        {
            Panel_content_remove();
            Batch_Form frm = new Batch_Form(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, Includes.AppSettings.Employee_DIR);
        }

        private void btn_nav_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                sideBar.Width -= 45;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                    btn_nav.BackgroundImage = Properties.Resources.expand2;
                }
            }
            else
            {
                sideBar.Width += 45;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                    btn_nav.BackgroundImage = Properties.Resources.nav; // assign an image to the button
                }
            }
            btn_nav.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btn_stocks_out_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            StockOut frm = new StockOut(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, Includes.AppSettings.Employee_DIR);
        }

        private void btn_StockOutList_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            StockOutList frm = new StockOutList(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, Includes.AppSettings.Employee_DIR);
        }

        private void btn_stockreturned_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            StockReturned frm = new StockReturned(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, Includes.AppSettings.Employee_DIR);
        }

        private void btn_stock_returned_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            Stock_Returned frm = new Stock_Returned(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, Includes.AppSettings.Employee_DIR);
        }

        private void btn_settings_Click_1(object sender, EventArgs e)
        {
            if (JobRole == "Programmer/Developer" || JobRole == "Office Manager")
            {
                Settings frm = new Settings(Global_ID, Fullname, JobRole);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Permission to access this panel. Thank you!", "No Rights", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_custsupp_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            CustSupplier.CustSupp frm = new CustSupplier.CustSupp(Global_ID, Fullname, JobRole, "Cust");
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, Includes.AppSettings.Employee_DIR);
        }

        private void btn_employee_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            Profiles.Employees frm = new Profiles.Employees(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, Includes.AppSettings.Employee_DIR);
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Login1 frm = new Login1();
            frm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_DCenter_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            Batch_Form frm = new Batch_Form(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, Includes.AppSettings.Employee_DIR);
        }

        private void btn_reports_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            Reports_MainForm frm = new Reports_MainForm(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, Includes.AppSettings.Employee_DIR);
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
            Login1 frm = new Login1();
            frm.ShowDialog();


        }

    }
}
