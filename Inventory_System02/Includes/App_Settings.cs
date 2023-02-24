using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System02.Includes
{
    public static class AppSettings
    {
        public static string DateFormat { get; set; } = "yyyy-MM-dd";
        public static string Image_DIR { get; set; } = @"CommonSql\Pictures\Item\Image\";
        public static string Customer_DIR { get; set; } = @"CommonSql\Pictures\Customers\";
        public static string Supplier_DIR { get; set; } = @"CommonSql\Pictures\Suppliers\";
        public static string Employee_DIR { get; set; } = @"CommonSql\Pictures\Employee\";
        public static string Company_DIR { get; set; } = @"CommonSql\Pictures\Company\";
        public static string Item_RDLC_DIR { get; set; } = @"CommonSql\Reports Dir\";
        public static string Doc_DIR { get; set; } = @"CommonSql\Document Center Files\";
        public static string Supplier_RDLC_DIR { get; set; } = @"CommonSql\Reports Dir\Supplier_Report.rdlc";
        public static string Employee_RDLC_DIR { get; set; } = @"CommonSql\Reports Dir\Employee_Report.rdlc";
        public static string Customer_RDLC_DIR { get; set; } = @"CommonSql\Reports Dir\Customer_Report.rdlc";
        //about
        public static string App_Version { get; set; } = "2.0.0";
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
