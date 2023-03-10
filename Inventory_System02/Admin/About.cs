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
            string sql = "Select Status from Administration";
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
    }
}
