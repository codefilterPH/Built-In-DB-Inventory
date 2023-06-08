using Inventory_System02.Includes;
using Inventory_System02.Reports_Dir;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_System02.Invoice_Silent
{
    class Invoice_Silent
    {
        public async Task Invoice(string out_return, string Trans_ref, string what_to_do)
        {
            try
            {
                SQLConfig config = new SQLConfig();

                DataSet ds = new DataSet();

                Report_Viewer frm = new Report_Viewer();
                ReportDataSource rs = new ReportDataSource();
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                usableFunction func = new usableFunction();
                string report_date = string.Empty, cust_name = string.Empty, address = string.Empty, FileName = string.Empty;
                string rdlc_path = Includes.AppSettings.Invoice_RDLC_Path + "\\";
                string sql = string.Empty;

                decimal total = 0, all_total = 0;
                int qty = 0, all_qty = 0;
                string new_qty = string.Empty, formattedtotal = string.Empty;

                if (out_return == "out")
                {
                    sql = "Select * from `Stock Out` where `Transaction Reference` = '" + Trans_ref + "' ORDER BY `Item Name` ASC";
                    await Task.Run(() => config.Load_Datasource(sql, ds));
                    await Task.Run(() => config.singleResult(sql));
                    if (config.dt.Rows.Count > 0)
                    {
                        report_date = config.dt.Rows[0].Field<string>("Entry Date");
                        cust_name = config.dt.Rows[0].Field<string>("Customer Name");
                        address = config.dt.Rows[0].Field<string>("Customer Address");

                    }
                }
                else if (out_return == "return")
                {
                    sql = "Select * from `Stock Returned` where `Transaction Reference` = '" + Trans_ref + "' ORDER BY `Item Name` ASC";
                    await Task.Run(() => config.Load_Datasource(sql, ds));
                    await Task.Run(() => config.singleResult(sql));
                    if (config.dt.Rows.Count > 0)
                    {
                        report_date = config.dt.Rows[0].Field<string>("Entry Date");
                        cust_name = config.dt.Rows[0].Field<string>("Customer Name");
                        address = config.dt.Rows[0].Field<string>("Customer Address");
                    }
                }
                else
                {
                    sql = "Select * from `Stocks` where `Transaction Reference` = '" + Trans_ref + "' ORDER BY `Item Name` ASC ";
                    await Task.Run(() => config.Load_Datasource(sql, ds));
                    await Task.Run(() => config.singleResult(sql));
                    if (config.dt.Rows.Count > 0)
                    {
                        report_date = config.dt.Rows[0].Field<string>("Entry Date");
                        cust_name = config.dt.Rows[0].Field<string>("Supplier ID");
                        address = config.dt.Rows[0].Field<string>("Supplier Name");
                    }

                }
                //await Task.Delay(0);
                List<Invoice_Code.Items_DataSet> list2 = new List<Invoice_Code.Items_DataSet>();
                if (ds != null)
                {
                    list2 = ds.Tables[0].AsEnumerable().Select(
                     dataRow => new Invoice_Code.Items_DataSet
                     {
                         Item_ID = dataRow.Field<string>("Stock ID").ToString(),
                         Item_Name = dataRow.Field<string>("Item Name").ToString(),
                         Brand = dataRow.Field<string>("Brand").ToString(),
                         Description = dataRow.Field<string>("Description").ToString(),
                         Quantity = dataRow["Quantity"].ToString(),
                         Price = dataRow["Price"].ToString(),
                         Amount = dataRow["Total"].ToString(),

                     }).ToList();
                    rs.Value = list2;

                }


                if (ds != null)
                {
                    all_total = 0;
                    all_qty = 0;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        qty = 0;
                        total = 0;
                        int.TryParse(ds.Tables[0].Rows[i]["Quantity"].ToString(), out qty);
                        decimal.TryParse(ds.Tables[0].Rows[i]["Total"].ToString(), out total);
                        all_qty += qty;
                        all_total += total;
                    }
                    new_qty = all_qty.ToString();
                    formattedtotal = all_total.ToString("#,##0.00");
                }

                rs.Name = "Out_DataSet";
                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.ProcessingMode = ProcessingMode.Local;

                if (out_return == "out")
                {
                    frm.reportViewer1.LocalReport.ReportPath = (rdlc_path + @"Invoice_out.rdlc");
                }
                else if (out_return == "return")
                {
                    frm.reportViewer1.LocalReport.ReportPath = (rdlc_path + @"Invoice_return.rdlc");
                }
                else
                {
                    frm.reportViewer1.LocalReport.ReportPath = (rdlc_path + @"Invoice_In.rdlc");
                }

                //Load Text to RDLC TextBox
                reportParameters.Add(new ReportParameter("ReportDate", DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve)));
                reportParameters.Add(new ReportParameter("TransRef", Trans_ref));
                reportParameters.Add(new ReportParameter("Customer_Name", cust_name));
                reportParameters.Add(new ReportParameter("Address", address));
                reportParameters.Add(new ReportParameter("Total_Items", config.dt.Rows.Count.ToString()));
                reportParameters.Add(new ReportParameter("Total_QTY", new_qty));
                reportParameters.Add(new ReportParameter("Total", formattedtotal));

                //Load out status and remarks
                RDLCSupportingClass supportingClass = new RDLCSupportingClass();
                if (out_return == "out")
                {
                    Invoice invoice = supportingClass.LoadStatusRemarks(Trans_ref);
                    if (invoice != null)
                    {
                        reportParameters.Add(new ReportParameter("PaymentStatus", invoice.Status));
                        reportParameters.Add(new ReportParameter("Remarks", invoice.Remarks));
                    }
                    else
                    {
                        reportParameters.Add(new ReportParameter("PaymentStatus", "none"));
                        reportParameters.Add(new ReportParameter("Remarks", "none"));
                    }
                }

                //load company info
                CompanyInfo companyinfo = supportingClass.LoadCompanyInfo();
                if (companyinfo != null)
                {
                    reportParameters.Add(new ReportParameter("Company", companyinfo.Name));

                }
                else
                {
                    reportParameters.Add(new ReportParameter("Company", ""));
                }

                frm.reportViewer1.LocalReport.SetParameters(reportParameters);
                frm.reportViewer1.RefreshReport();
                if (what_to_do == "preview")
                {
                    frm.ShowDialog();
                }
                if (what_to_do == "batch")
                {
                    if (out_return == "out")
                    {
                        FileName = "Outbound " + Trans_ref + " " + DateTime.Now.ToString("hhmmss") + ".pdf";
                    }
                    else if (out_return == "return")
                    {
                        FileName = "Return " + Trans_ref + " " + DateTime.Now.ToString("hhmmss") + ".pdf";
                    }
                    else if (out_return == "in")
                    {
                        FileName = "Inbound " + Trans_ref + " " + DateTime.Now.ToString("hhmmss") + ".pdf";
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
    }
}
