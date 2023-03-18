using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;


namespace Inventory_System02.Includes
{
    public static class AppSettings
    {
        //public static string Database { get; set; } = @"Data Source = CommonSql\Database.db;Version=3;New=False;Read Only = False;Compress=True;Journal Mode=Off;providerName=System.Data.SQlite;";

        public static string Database { get; set; } = $"Data Source={Path.Combine(Application.StartupPath, "CommonSql", "Tools", "tools.dll")};Version=3;New=False;Read Only=False;Compress=True;Journal Mode=Off;providerName=System.Data.SQLite;";

        public static string app_value { get; set; } = "74C50BEC-CBFD-4B91-A5E2-AD9F3AE66319";
        public static string DateFormatRetrieve { get; set; } = "yyyy-MM-dd";
        public static string DateFormatSave { get; set; } = "yyyy-MM-dd HH:mm:ss";
        //Images
        public static string Image_DIR { get; set; } = @"CommonSql\Pictures\Item\Image\";
        public static string Customer_DIR { get; set; } = @"CommonSql\Pictures\Customers\";
        public static string Supplier_DIR { get; set; } = @"CommonSql\Pictures\Suppliers\";
        public static string Employee_DIR { get; set; } = @"CommonSql\Pictures\Employee\";
        public static string Company_DIR { get; set; } = @"CommonSql\Pictures\Company\";
       
        //doc files
        public static string Doc_DIR { get; set; } = @"CommonSql\Document Center Files\";
        //rdlc
        public static string Search_DTG { get; set; } = @"CommonSql\Reports Dir\Search DTG\Search_DTG.rdlc";
        public static string Invoice_RDLC_Path { get; set; } = @"CommonSql\Invoice\";
        public static string Invoice_BY_SupDivi { get; set; } = @"CommonSql\Reports Dir\Item_Division\Item_Divisup_Report.rdlc";
        public static string Supplier_RDLC_DIR { get; set; } = @"CommonSql\Reports Dir\Supplier_Report.rdlc";
        public static string Employee_RDLC_DIR { get; set; } = @"CommonSql\Reports Dir\Employee_Report.rdlc";
        public static string Customer_RDLC_DIR { get; set; } = @"CommonSql\Reports Dir\Customer_Report.rdlc";
        public static string Item_RDLC_DIR { get; set; } = @"CommonSql\Reports Dir\";
        public static string Item_qty_RDLC_DIR { get; set; } = @"CommonSql\Reports Dir\Item_Qty\";

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





    }
}
