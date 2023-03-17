using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Inventory_System02.Includes;
using Inventory_System02.Reports_Dir;
using Microsoft.Reporting.WinForms;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace Inventory_System02.Includes
{
    internal class RDLCSupportingClass
    {
        public Invoice LoadStatusRemarks(string TransRef)
        {

            string sql = string.Empty;
            SQLConfig config = new SQLConfig();
            sql = "Select Status, Remarks from StockOutStatus where TransRef = '" + TransRef + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count >= 1)
            {
                string status = config.dt.Rows[0]["Status"].ToString();
                string remarks = config.dt.Rows[0]["Remarks"].ToString();
                return new Invoice { Remarks = remarks, Status = status };
            }
            return null;
        }
        public CompanyInfo LoadCompanyInfo()
        {

            //Load Company Name
            string sql = string.Empty;
            SQLConfig config = new SQLConfig();
            sql = "Select Company_Name from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count == 1)
            {
                string company = config.dt.Rows[0]["Company_Name"].ToString();
                return new CompanyInfo { Name = company };
            }
            return null;
        } 
    }
    public class Invoice
    {
        public string Remarks { get; set; }
        public string Status { get; set; }
    }
    public class CompanyInfo
    {
        public string Name { get; set; }    
    }

}
