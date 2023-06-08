using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace Inventory_System02.Includes
{
    public static class AppSettings
    {
        //if installed in the program(x86)
        //public static string Database { get; set; } = @"Data Source = CommonSql\Database.db;Version=3;New=False;Read Only = False;Compress=True;Journal Mode=Off;providerName=System.Data.SQlite;";

        //public static string Database { get; set; } = $"Data Source={Path.Combine(Application.StartupPath, "CommonSql", "Tools", "tools.dll")};Version=3;New=False;Read Only=False;Compress=True;Journal Mode=Off;providerName=System.Data.SQLite;";
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

            // Get the value of the registry key
            string ServerRegistryKey = @"SOFTWARE\codefilterPH\InventoryMS\";
            string ServerRegistryValue = null;
            try
            {
                ServerRegistryValue = (string)Registry.CurrentUser.OpenSubKey(ServerRegistryKey).GetValue("ServerName");
            }
            catch (Exception ex)
            {
                // handle the exception
                Console.WriteLine("Error retrieving ServerName registry value: " + ex.Message);
            }

            // Get the value of the registry key
            string RegistryKey = @"SOFTWARE\codefilterPH\InventoryMS\";
            string ImageRegistryValue = null;
            string DocumentRegValue = null;
            string InvoiceRegValue = null;
            string ReportsRegValue = null;
            try
            {
                ImageRegistryValue = (string)Registry.CurrentUser.OpenSubKey(RegistryKey).GetValue("ImageDir");
                DocumentRegValue = (string)Registry.CurrentUser.OpenSubKey(RegistryKey).GetValue("DocumentsDir");
                InvoiceRegValue = (string)Registry.CurrentUser.OpenSubKey(RegistryKey).GetValue("InvoiceDir");
                ReportsRegValue = (string)Registry.CurrentUser.OpenSubKey(RegistryKey).GetValue("ReportsDir");
            }
            catch (Exception ex)
            {
                // handle the exception
                Console.WriteLine("Error retrieving registry value: " + ex.Message);
            }


            // Combine the registry value with the subfolders
            //for pictures
            string item_pic = null;
            string customer_pic = null;
            string supplier_pic = null;
            string employee_pic = null;
            string company_pic = null;
            if (!string.IsNullOrEmpty(ServerRegistryValue) && !string.IsNullOrEmpty(ImageRegistryValue))
            {
                item_pic = $@"\\{ServerRegistryValue}{ImageRegistryValue}\Item\Image\";
                customer_pic = $@"\\{ServerRegistryValue}{ImageRegistryValue}\Customers\";
                supplier_pic = $@"\\{ServerRegistryValue}{ImageRegistryValue}\Suppliers\";
                company_pic = $@"\\{ServerRegistryValue}{ImageRegistryValue}\Company\";
                employee_pic = $@"\\{ServerRegistryValue}{ImageRegistryValue}\Employee\";
            }
            else
            {
                // handle the case where either value is null or empty
                Console.WriteLine("One or both registry values are null or empty.");
            }
            //Doc Center
            string doc_center = null;
            if (!string.IsNullOrEmpty(ServerRegistryValue) && !string.IsNullOrEmpty(DocumentRegValue))
            {
                doc_center = $@"\\{ServerRegistryValue}{DocumentRegValue}\";
            }
            else
            {
                // handle the case where either value is null or empty
                Console.WriteLine("One or both document center registry values are null or empty.");
            }

            //Invoice
            string invoice_dir = null;
            if (!string.IsNullOrEmpty(ServerRegistryValue) && !string.IsNullOrEmpty(InvoiceRegValue))
            {
                invoice_dir = $@"\\{ServerRegistryValue}{InvoiceRegValue}\";
            }
            else
            {
                // handle the case where either value is null or empty
                Console.WriteLine("One or both invoice dir registry values are null or empty.");
            }
            //Reports
            string search_dtg_rdlc = null;
            string supplier_rdlc = null;
            string employee_rdlc = null;
            string customer_rdlc = null;
            string item_rdlc = null;
            string item_qty_rdlc = null;
            string item_supdivi_rdlc = null;
            if (!string.IsNullOrEmpty(ServerRegistryValue) && !string.IsNullOrEmpty(ReportsRegValue))
            {
                search_dtg_rdlc = $@"\\{ServerRegistryValue}{ReportsRegValue}\Search DTG\Search_DTG.rdlc";
                supplier_rdlc = $@"\\{ServerRegistryValue}{ReportsRegValue}\Supplier_Report.rdlc";
                employee_rdlc = $@"\\{ServerRegistryValue}{ReportsRegValue}\Employee_Report.rdlc";
                customer_rdlc = $@"\\{ServerRegistryValue}{ReportsRegValue}\Customer_Report.rdlc";
                item_rdlc = $@"\\{ServerRegistryValue}{ReportsRegValue}\Item Report.rdlc";
                item_qty_rdlc = $@"\\{ServerRegistryValue}{ReportsRegValue}\Item_Qty\ItemQTY_Report.rdlc";
                item_supdivi_rdlc = $@"\\{ServerRegistryValue}{ReportsRegValue}\Item_Division\Item_Divisup_Report.rdlc";

            }
            else
            {
                // handle the case where either value is null or empty
                Console.WriteLine("One or both reports dir registry values are null or empty.");
            }

            //transfer to string
            if (!string.IsNullOrEmpty(item_pic))
            {
                Image_DIR = item_pic;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("item_pic is null or empty.");
            }
            if (!string.IsNullOrEmpty(customer_pic))
            {
                Customer_DIR = customer_pic;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("customerDir is null or empty.");
            }

            if (!string.IsNullOrEmpty(supplier_pic))
            {
                Supplier_DIR = supplier_pic;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("supplier_pic is null or empty.");
            }
            if (!string.IsNullOrEmpty(company_pic))
            {
                Company_DIR = company_pic;

            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("company_pic is null or empty.");
            }
            if (!string.IsNullOrEmpty(employee_pic))
            {
                Employee_DIR = employee_pic;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("employee_pic is null or empty.");
            }
            //DOCUMENT CENTER
            if (!string.IsNullOrEmpty(doc_center))
            {
                Doc_DIR = doc_center;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("doc_center is null or empty.");
            }
            //Invoice Path
            if (!string.IsNullOrEmpty(invoice_dir))
            {
                Invoice_RDLC_Path = invoice_dir;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("invoice_dir is null or empty.");
            }

            //reports Path
            if (!string.IsNullOrEmpty(search_dtg_rdlc))
            {
                Search_DTG = search_dtg_rdlc;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("search_dtg_rdlc is null or empty.");
            }
            if (!string.IsNullOrEmpty(supplier_rdlc))
            {
                Supplier_RDLC_DIR = supplier_rdlc;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("supplier_rdlc is null or empty.");
            }
            if (!string.IsNullOrEmpty(employee_rdlc))
            {
                Employee_RDLC_DIR = employee_rdlc;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("employee_rdlc is null or empty.");
            }
            if (!string.IsNullOrEmpty(customer_rdlc))
            {
                Customer_RDLC_DIR = customer_rdlc;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("customer_rdlc is null or empty.");
            }
            if (!string.IsNullOrEmpty(item_rdlc))
            {
                Item_RDLC_DIR = item_rdlc;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("item_rdlc is null or empty.");
            }
            if (!string.IsNullOrEmpty(item_qty_rdlc))
            {
                Item_qty_RDLC_DIR = item_qty_rdlc;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("item_qty_rdlc is null or empty.");
            }
            if (!string.IsNullOrEmpty(item_supdivi_rdlc))
            {
                Invoice_BY_SupDivi = item_supdivi_rdlc;
            }
            else
            {
                // handle the case where imageDir is null or empty
                Console.WriteLine("item_supdivi_rdlc is null or empty.");
            }
        }

        public static string Database()
        {

            string serverRegistryKey = @"SOFTWARE\codefilterPH\InventoryMS\";
            string serverRegistryValue = null;
            try
            {
                serverRegistryValue = (string)Registry.CurrentUser.OpenSubKey(serverRegistryKey).GetValue("ServerName");
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving ServerName registry value", ex);
            }

            string registryKey = @"SOFTWARE\codefilterPH\InventoryMS\";
            string toolsRegistryValue = null;
            try
            {
                toolsRegistryValue = (string)Registry.CurrentUser.OpenSubKey(registryKey).GetValue("ToolsDir");
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving ToolsDir registry value", ex);
            }

            string toolsPath = null;
            if (!string.IsNullOrEmpty(serverRegistryValue) && !string.IsNullOrEmpty(toolsRegistryValue))
            {
                toolsPath = $@"\\{serverRegistryValue}{toolsRegistryValue}";
            }
            else
            {
                throw new Exception("One or both registry values are null or empty");
            }

            string connectionString = $"Data Source={toolsPath};Version=3;New=False;Read Only=False;Compress=True;Journal Mode=Off;providerName=System.Data.SQLite;";
            return connectionString;

        }
    }
}
