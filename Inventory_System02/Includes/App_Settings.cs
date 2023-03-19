using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
using System.Configuration;
using System.Deployment.Application;
using System.Reflection;

namespace Inventory_System02.Includes
{
    public static class AppSettings
    {
        //if installed in the program(x86)
        //public static string Database { get; set; } = @"Data Source = CommonSql\Database.db;Version=3;New=False;Read Only = False;Compress=True;Journal Mode=Off;providerName=System.Data.SQlite;";

        //public static string Database { get; set; } = $"Data Source={Path.Combine(Application.StartupPath, "CommonSql", "Tools", "tools.dll")};Version=3;New=False;Read Only=False;Compress=True;Journal Mode=Off;providerName=System.Data.SQLite;";

        ////using Clickonces      
        //public  static string path = ApplicationDeployment.CurrentDeployment.DataDirectory;
        //public static string databasePath = Path.Combine(path, "CommonSql", "Tools", "tools.dll");
        //public static string Database = $"Data Source={databasePath};Version=3;New=False;Read Only=False;Compress=True;Journal Mode=Off;providerName=System.Data.SQLite;";

        //Images
        public static string app_value { get; set; } = "74C50BEC-CBFD-4B91-A5E2-AD9F3AE66319";
        public static string DateFormatRetrieve { get; set; } = "yyyy-MM-dd";
        public static string DateFormatSave { get; set; } = "yyyy-MM-dd HH:mm:ss";
        //about
        //getting the app version 
        // Retrieve the version information for the current assembly
        static FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string App_Version { get; set; } = versionInfo.ProductVersion;
        public static string Cust_ID { get; set; } = "1";
        public static string Serial { get; set; } = "74C50BEC";
        public static string Developer { get; set; } = "Eugene Rey L Bulahan";
        public static string Manufacturer { get; set; } = "CodefilterPH";
        public static string Company { get; set; } = "CodefilterPH";
        public static string Website { get; set; } = "https://codefilter.pythonanywhere.com";
        public static string Contact { get; set; } = "(0945) 832-2316";
        public static string Email { get; set; } = "eugenereybulahan@gmail.com";

        // Update the paths for the other fields
        public static string Image_DIR { get; set; } 
        public static string Customer_DIR { get; set; }
        public static string Supplier_DIR { get; set; }
        public static string Employee_DIR { get; set; }
        public static string Company_DIR { get; set; }
        public static string Doc_DIR { get; set; }
        public static string Search_DTG { get; set; }
        public static string Invoice_RDLC_Path { get; set; }
        public static string Invoice_BY_SupDivi { get; set; }
        public static string Supplier_RDLC_DIR { get; set; }
        public static string Employee_RDLC_DIR { get; set; }
        public static string Customer_RDLC_DIR { get; set; }
        public static string Item_RDLC_DIR { get; set; }
        public static string Item_qty_RDLC_DIR { get; set; }
        
       
        public static void My_path()
        {

            // Check the configuration setting to determine which connection string to use
            bool useClickOnceConnection = ConfigurationManager.AppSettings["UseClickOnceConnection"] == "false";

            if (useClickOnceConnection)
            {
                // Update the paths for the other fields

                string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string clickOnceDataDir = Path.Combine(appDataDir, "Apps", "2.0", "Data");

                string[] clickOnceDirs = Directory.GetDirectories(clickOnceDataDir, "*.*/", SearchOption.TopDirectoryOnly);
                string randomStringDir = clickOnceDirs.FirstOrDefault(d => Directory.GetDirectories(d, "*", SearchOption.TopDirectoryOnly).Length > 0);

                if (randomStringDir != null)
                {
                    string commonSqlDir = Path.Combine(randomStringDir, "Data", "CommonSql");
                    Image_DIR = Path.Combine(commonSqlDir, "Pictures", "Item", "Image");
                    Customer_DIR =  Path.Combine(commonSqlDir, "Pictures", "Pictures", "Customers");
                    Supplier_DIR = Path.Combine(commonSqlDir, "Pictures", "Suppliers");
                    Employee_DIR = Path.Combine(commonSqlDir, "Pictures", "Employee");
                    Company_DIR = Path.Combine(commonSqlDir, "Pictures", "Company");
                    Doc_DIR = Path.Combine(commonSqlDir, "Document Center Files");
                    Search_DTG = Path.Combine(commonSqlDir, "Reports Dir", "Search DTG", "Search_DTG.rdlc");
                    Invoice_RDLC_Path = Path.Combine(commonSqlDir, "Invoice");
                    Invoice_BY_SupDivi = Path.Combine(commonSqlDir, "Reports Dir", "Item_Division", "Item_Divisup_Report.rdlc");
                    Supplier_RDLC_DIR = Path.Combine(commonSqlDir, "CommonSql", "Reports Dir", "Supplier_Report.rdlc");
                    Employee_RDLC_DIR = Path.Combine(commonSqlDir, "CommonSql", "Reports Dir", "Employee_Report.rdlc");
                    Customer_RDLC_DIR = Path.Combine(commonSqlDir, "CommonSql", "Reports Dir", "Customer_Report.rdlc");
                    Item_RDLC_DIR = Path.Combine(commonSqlDir, "CommonSql", "Reports Dir", "Item Report.rdlc");
                    Item_qty_RDLC_DIR = Path.Combine(commonSqlDir, "Reports Dir", "Item_Qty", "ItemQTY_Report.rdlc");
                }
                else
                {
                    throw new Exception("Unable to locate ClickOnce data directory.");
                }
            }
            else
            {
             
                Image_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Pictures", "Item", "Image");
                Customer_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Pictures", "Customers");
                Supplier_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Pictures", "Suppliers");
                Employee_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Pictures", "Employee");
                Company_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Pictures", "Company");
                Doc_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Document Center Files");
                Search_DTG = Path.Combine(Application.StartupPath, "CommonSql", "Reports Dir", "Search DTG", "Search_DTG.rdlc");
                Invoice_RDLC_Path = Path.Combine(Application.StartupPath, "CommonSql", "Invoice");
                Invoice_BY_SupDivi = Path.Combine(Application.StartupPath, "CommonSql", "Reports Dir", "Item_Division", "Item_Divisup_Report.rdlc");
                Supplier_RDLC_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Reports Dir", "Supplier_Report.rdlc");
                Employee_RDLC_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Reports Dir", "Employee_Report.rdlc");
                Customer_RDLC_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Reports Dir", "Customer_Report.rdlc");
                Item_RDLC_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Reports Dir", "Item Report.rdlc");
                Item_qty_RDLC_DIR = Path.Combine(Application.StartupPath, "CommonSql", "Reports Dir", "Item_Qty", "ItemQTY_Report.rdlc");
            }

        }

        public static string Database()
        {
            string connectionString = "";

            // Check the configuration setting to determine which connection string to use
            bool useClickOnceConnection = ConfigurationManager.AppSettings["UseClickOnceConnection"] == "false";

            if (useClickOnceConnection)
            {

                string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string clickOnceDataDir = Path.Combine(appDataDir, "Apps", "2.0");

                string[] clickOnceDirs = Directory.GetDirectories(clickOnceDataDir, "*.*/", SearchOption.TopDirectoryOnly);
                string randomStringDir = clickOnceDirs.FirstOrDefault(d => Directory.GetDirectories(d, "*", SearchOption.TopDirectoryOnly).Length > 0);

                if (randomStringDir != null)
                {
                    string commonSqlDir = Path.Combine(randomStringDir, "CommonSql");
                    string databasePath = Path.Combine(commonSqlDir, "Tools", "tools.db");
                    MessageBox.Show(databasePath);
                    connectionString = $"Data Source={databasePath};Version=3;New=False;Read Only=False;Compress=True;Journal Mode=Off;providerName=System.Data.SQLite;";
                }
                else
                {
                    throw new Exception("Unable to locate ClickOnce data directory.");
                }
                   
            }
            else
            {
                // Use the hard-coded connection string approach
                connectionString = $"Data Source={Path.Combine(Application.StartupPath, "CommonSql", "Tools", "tools.dll")};Version=3;New=False;Read Only=False;Compress=True;Journal Mode=Off;providerName=System.Data.SQLite;";          
            }

            return connectionString;
        }
    }
}
