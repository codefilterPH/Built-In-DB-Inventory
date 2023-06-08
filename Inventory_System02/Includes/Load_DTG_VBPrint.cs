using Inventory_System02.Reports_Dir;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Warning = Microsoft.Reporting.WinForms.Warning;

namespace Inventory_System02.Includes
{
    internal class Load_DTG_VBPrint
    {
        public void Search_Result(string trans_process, string what_to_do, DataGridView dtg, string number_of_items, string total_qty, string total_amount, string search_by, string search_txt)
        {
            try
            {
                SQLConfig config = new SQLConfig();
                usableFunction func = new usableFunction();
                DataSet ds = new DataSet();
                Report_Viewer frm = new Report_Viewer();
                ReportDataSource rs = new ReportDataSource();
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                // Create a new DataTable object
                List<SearchBy_Data> list2 = new List<SearchBy_Data>();
                if (dtg.DataSource != null)
                {
                    if (trans_process == "INBOUND SUMMARY")
                    {
                        list2 = ((DataTable)dtg.DataSource).AsEnumerable().Select(
                         dataRow => new SearchBy_Data
                         {
                             Entry_Date = dataRow.Field<string>("Entry Date"),
                             Customer_Name = dataRow.Field<string>("Supplier Name"),
                             Item_Name = dataRow.Field<string>("Item Name"),
                             Brand = dataRow.Field<string>("Brand").ToString(),
                             Quantity = dataRow["Quantity"].ToString(),
                             Price = dataRow["Price"].ToString(),
                             Total = dataRow["Total"].ToString(),

                         }).ToList();
                        rs.Value = list2;
                    }
                    else
                    {
                        list2 = ((DataTable)dtg.DataSource).AsEnumerable().Select(
                         dataRow => new SearchBy_Data
                         {
                             Entry_Date = dataRow.Field<string>("Entry Date"),
                             Customer_Name = dataRow.Field<string>("Customer Name"),
                             Item_Name = dataRow.Field<string>("Item Name"),
                             Brand = dataRow.Field<string>("Brand").ToString(),
                             Quantity = dataRow["Quantity"].ToString(),
                             Price = dataRow["Price"].ToString(),
                             Total = dataRow["Total"].ToString(),

                         }).ToList();
                        rs.Value = list2;
                    }


                }

                // Create a new ReportDataSource object and set its Value property to the DataTable
                rs.Name = "DataSetFromDTG";
                // rs.Value = ds.Tables[0];
                //rs.DataMember = "DataSetFromDTG";


                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.ProcessingMode = ProcessingMode.Local;

                string rdlc_path = Includes.AppSettings.Search_DTG;
                frm.reportViewer1.LocalReport.ReportPath = rdlc_path;

                //Load Text to RDLC TextBox
                reportParameters.Add(new ReportParameter("ReportDate", DateTime.Now.ToString(Includes.AppSettings.DateFormatSave)));
                reportParameters.Add(new ReportParameter("TransPro", trans_process));
                if (!string.IsNullOrWhiteSpace(search_txt))
                {
                    search_by = "BY " + search_by;
                }
                else
                {
                    search_by = "";
                }
                reportParameters.Add(new ReportParameter("SearchBy", search_by));
                reportParameters.Add(new ReportParameter("NumberOfItems", number_of_items.ToString()));
                reportParameters.Add(new ReportParameter("TotalQty", total_qty));
                reportParameters.Add(new ReportParameter("TotalAmount", total_amount));

                frm.reportViewer1.LocalReport.SetParameters(reportParameters);
                frm.reportViewer1.RefreshReport();

                string FileName = string.Empty;

                if (what_to_do == "preview")
                {
                    frm.ShowDialog();
                }
                else if (what_to_do == "print")
                {
                    Print_To_The_Printer prt = new Print_To_The_Printer();
                    prt.PrintToPrinter(frm.reportViewer1.LocalReport);
                }
                else
                {
                    if (trans_process == "OUTBOUND SUMMARY")
                    {
                        if (string.IsNullOrWhiteSpace(search_by))
                        {
                            FileName = "Outbound Summary " + DateTime.Now.ToString("hhmmss") + ".pdf";
                        }
                        else
                        {
                            FileName = "Outbound Summary " + search_by + " " + DateTime.Now.ToString("hhmmss") + ".pdf";
                        }

                    }
                    else if (trans_process == "RETURN SUMMARY")
                    {
                        if (string.IsNullOrWhiteSpace(search_by))
                        {
                            FileName = "Return Summary.pdf " + DateTime.Now.ToString("hhmmss") + ".pdf";
                        }
                        else
                        {
                            FileName = "Return Summary " + search_by + " " + DateTime.Now.ToString("hhmmss") + ".pdf";
                        }

                    }
                    else
                    {

                        if (string.IsNullOrWhiteSpace(search_by))
                        {
                            FileName = "Inbound Summary " + DateTime.Now.ToString("hhmmss") + ".pdf";
                        }
                        else
                        {
                            FileName = "Inbound Summary " + search_by + " " + DateTime.Now.ToString("hhmmss") + ".pdf";
                        }

                    }
                    if (FileName != null)
                    {
                        string extension;
                        string encoding;
                        string mimeType;
                        string[] streams;
                        Warning[] warnings;

                        Byte[] mybytes = frm.reportViewer1.LocalReport.Render("PDF", null,
                                        out extension, out encoding,
                                        out mimeType, out streams, out warnings); //for exporting to PDF  
                                                                                  //using (FileStream fs = File.Create(Server.MapPath("~/Report/") + FileName))
                        using (FileStream fs = File.Create((Includes.AppSettings.Doc_DIR + "\\") + FileName))
                        {
                            fs.Write(mybytes, 0, mybytes.Length);
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public class SearchBy_Data


        {
            public string Entry_Date { get; set; }
            public string Item_ID { get; set; }
            public string Item_Name { get; set; }
            public string Brand { get; set; }
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
            public string Total { get; set; }

        }
    }
}
