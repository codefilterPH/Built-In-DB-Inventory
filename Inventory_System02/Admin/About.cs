using Inventory_System02.Includes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory_System02
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SQLConfig config = new SQLConfig();
            string sql = "Select Date, Status from Administration";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                lbl_activation.Text = config.dt.Rows[0].Field<string>("Status").ToString();
                if (lbl_activation.Text == "Trial")
                {
                    lbl_exp.Text = config.dt.Rows[0].Field<string>("Date").ToString();
                }
                else
                {
                    lbl_exp.Text = "Unlimited";
                }

            }

            lbl_version.Text = Includes.AppSettings.App_Version;
            this.Text = "App Version " + Includes.AppSettings.App_Version;
            lbl_cust_id.Text = Includes.AppSettings.Cust_ID;
            lbl_serial.Text = Includes.AppSettings.Serial;
            lbl_dev.Text = Includes.AppSettings.Developer;
            lbl_manufacturer.Text = Includes.AppSettings.Manufacturer;
            lbl_company.Text = Includes.AppSettings.Company;
            lbl_weblink.Text = Includes.AppSettings.Website;
            lbl_contact_info.Text = Includes.AppSettings.Contact;
            lbl_email.Text = Includes.AppSettings.Email;


        }

        private void lbl_weblink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lbl_weblink_DoubleClick(object sender, EventArgs e)
        {
            // Replace the URL below with the website you want to open
            string url = "https://codefilter.pythonanywhere.com";

            // Launch the default browser and navigate to the URL
            System.Diagnostics.Process.Start(url);
        }
    }
}
