using Inventory_System02.Includes;
using Inventory_System02.Reports_Dir;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace Inventory_System02.Invoice_Code
{
    class Invoice_Code
    {
        SQLConfig config = new SQLConfig();

        DataSet ds = new DataSet();

        Report_Viewer frm = new Report_Viewer();
        ReportDataSource rs = new ReportDataSource();
        ReportParameterCollection reportParameters = new ReportParameterCollection();
        usableFunction func = new usableFunction();

        string sql = string.Empty;
        string report_date = string.Empty, cust_name = string.Empty, address = string.Empty, FileName = string.Empty;
        double total = 0;

        string rdlc_path = @"CommonSql\Invoice\";
        public void Invoice(string out_return, string Trans_ref, string what_to_do)
        {
            if (out_return == "out")
            {
                sql = "Select * from `Stock Out` where `Transaction Reference` = '" + Trans_ref + "' ";
                config.Load_Datasource(sql, ds);

                sql = "Select * from `Stock Out` where `Transaction Reference` = '" + Trans_ref + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    report_date = config.dt.Rows[0].Field<string>("Entry Date");
                    cust_name = config.dt.Rows[0].Field<string>("Customer Name");
                    address = config.dt.Rows[0].Field<string>("Customer Address");

                }
            }
            else if ( out_return == "return")
            {
                sql = "Select * from `Stock Returned` where `Transaction Reference` = '" + Trans_ref + "' ";
                config.Load_Datasource(sql, ds);

                sql = "Select * from `Stock Returned` where `Transaction Reference` = '" + Trans_ref + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    report_date = config.dt.Rows[0].Field<string>("Entry Date");
                    cust_name = config.dt.Rows[0].Field<string>("Customer Name");
                    address = config.dt.Rows[0].Field<string>("Customer Address");
                }
            }
            else
            {
                sql = "Select * from `Stocks` where `Transaction Reference` = '" + Trans_ref + "' ";
                config.Load_Datasource(sql, ds);

                sql = "Select * from `Stocks` where `Transaction Reference` = '" + Trans_ref + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    report_date = config.dt.Rows[0].Field<string>("Entry Date");
                    cust_name = config.dt.Rows[0].Field<string>("Supplier ID");
                    address = config.dt.Rows[0].Field<string>("Supplier Name");
                }

            }

            List<Items_DataSet> list2 = new List<Items_DataSet>();
            if (ds != null)
            {
                list2 = ds.Tables[0].AsEnumerable().Select(
                 dataRow => new Items_DataSet
                 {
                     Item_ID = dataRow.Field<string>("Stock ID").ToString(),
                     Item_Name = dataRow.Field<string>("Item Name").ToString(),
                     Category = dataRow.Field<string>("Category").ToString(),
                     Description = dataRow.Field<string>("Description").ToString(),
                     Quantity = dataRow.Field<string>("Quantity").ToString(),
                     Price = dataRow.Field<string>("Price").ToString(),
                     Amount = Convert.ToString(Convert.ToDouble(dataRow.Field<string>("Price"))
                     * Convert.ToDouble(dataRow.Field<string>("Quantity"))),

                 }).ToList();
                rs.Value = list2;

            }
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                total += Convert.ToDouble(ds.Tables[0].Rows[i].Field<string>("Quantity")) *
                    Convert.ToDouble(ds.Tables[0].Rows[i].Field<string>("Price"));
            }

            rs.Name = "Out_DataSet";
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.ProcessingMode = ProcessingMode.Local;

            if ( out_return == "out")
            {
                frm.reportViewer1.LocalReport.ReportPath = (rdlc_path + @"Invoice_out.rdlc");
            }
            else if (out_return == "return")
            {
                frm.reportViewer1.LocalReport.ReportPath = (rdlc_path + @"Invoice_return.rdlc");
            }
            else if ( out_return == "in")
            {
                frm.reportViewer1.LocalReport.ReportPath = (rdlc_path + @"Invoice_In.rdlc");
            }


            //Load Text to RDLC TextBox
            reportParameters.Add(new ReportParameter("ReportDate", report_date));
            reportParameters.Add(new ReportParameter("TransRef", Trans_ref));
            reportParameters.Add(new ReportParameter("Customer_Name", cust_name));
            reportParameters.Add(new ReportParameter("Address", address));
            reportParameters.Add(new ReportParameter("Total", total.ToString()));

            frm.reportViewer1.LocalReport.SetParameters(reportParameters);
            frm.reportViewer1.RefreshReport();

            if (what_to_do == "preview")
            {
                frm.ShowDialog();
            }
            else if ( what_to_do == "print")
            {
                Print_To_The_Printer prt = new Print_To_The_Printer();
                prt.PrintToPrinter(frm.reportViewer1.LocalReport);
            }
            else
            {
                if ( out_return == "out")
                {
                    FileName = "Outbound Invoice " + Trans_ref + " " + DateTime.Now.ToString("hhmmss") + ".pdf";
                }
                else if ( out_return == "return")
                {
                    FileName = "Return Invoice " + Trans_ref + " " + DateTime.Now.ToString("hhmmss") + ".pdf";
                }
                else
                {
                    FileName = "Inbound Invoice " + Trans_ref + " " + DateTime.Now.ToString("hhmmss") + ".pdf";
                }
                if (FileName != null )
                {
                    string extension;
                    string encoding;
                    string mimeType;
                    string[] streams;
                    Warning[] warnings;

                    string contentType = "application/pdf";

                    Byte[] mybytes = frm.reportViewer1.LocalReport.Render("PDF", null,
                                    out extension, out encoding,
                                    out mimeType, out streams, out warnings); //for exporting to PDF  
                                                                              //using (FileStream fs = File.Create(Server.MapPath("~/Report/") + FileName))
                    using (FileStream fs = File.Create((@"CommonSql\Document Center Files\") + FileName))
                    {
                        fs.Write(mybytes, 0, mybytes.Length);

                        MessageBox.Show("Batched!", "Send to Document Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }   
            }

        }

    }
    public class Items_DataSet
    {
        public string Entry_Date { get; set; }
        public string Item_ID { get; set; }
        public string Item_Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Supplier_ID { get; set; }
        public string Supplier_Name { get; set; }
        public string Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public string Use_ID { get; set; }
        public string Staff_Name { get; set; }
        public string Job_Role { get; set; }
        public string Trans_Ref { get; set; }
        public string Amount { get; set; }
        public string Price { get; set; }

    }
}
