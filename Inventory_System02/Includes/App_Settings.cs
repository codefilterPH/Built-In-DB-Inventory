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

    }
}
