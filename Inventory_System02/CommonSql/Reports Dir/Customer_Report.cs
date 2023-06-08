using Inventory_System02.Includes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_System02.Reports_Dir
{
    public partial class Customer_Report : Form
    {
        SQLConfig config;
        DataSet ds;
        Report_Viewer frm;
        ReportDataSource rs;
        ReportParameterCollection reportParameters;
        usableFunction func;
        List<Class_Customer_Var> list2;

        int count = 0;
        string sql = string.Empty;
        string Global_ID, Fullname, JobRole;
        public Customer_Report(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }
        bool isWorkerBusy = false;
        private void Customer_Report_Load(object sender, EventArgs e)
        {
            chk_Cust_ID.Checked = true;
            chk_Name.Checked = true;
            chk_Address.Checked = true;
            chk_Hire_Date.Checked = true;

            if (!isWorkerBusy)
            {
                isWorkerBusy = true;
                backgroundWorker1.RunWorkerAsync();
            }

            Calculate_Filtering("loadToday");
            if (dtg_PreviewPage.Rows.Count == 0)
            {
                lbl_Personnel.Text = "0";
            }
        }

        private void chk_Select_All_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Select_All.Checked == true)
            {
                foreach (CheckBox ch in grp_filters.Controls)
                {
                    if (ch is CheckBox)
                    {
                        ch.Checked = true;
                        chk_Unselect.Checked = false;
                    }
                }
            }
            else
            {
                chk_Unselect.Checked = true;
                chk_Unselect.Checked = false;
            }
        }

        private void chk_Unselect_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Unselect.Checked == true)
            {
                foreach (CheckBox ch in grp_filters.Controls)
                {
                    if (ch is CheckBox)
                    {
                        ch.Checked = false;
                        chk_Select_All.Checked = false;

                    }
                }
            }
        }
        private void Group_Filtering_MustNotEmpty()
        {
            foreach (Control c in grp_filters.Controls)
            {
                CheckBox chkbox = c as CheckBox;
                if (chkbox != null && chkbox.Checked)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                func.Error_Message1 = "Have atleast one column selected, Filters";
                chk_Cust_ID.Checked = true;
                chk_Hire_Date.Checked = true;
                chk_Name.Checked = true;
                chk_Address.Checked = true;
                func.Error_Message();
                return;
            }
        }

        private void Calculate_Filtering(string what_to_do)
        {
            try
            {
                rs = new ReportDataSource();
                reportParameters = new ReportParameterCollection();
                frm = new Report_Viewer();
                ds = new DataSet();
                config = new SQLConfig();
                func = new usableFunction();
                Group_Filtering_MustNotEmpty();

                if (string.IsNullOrWhiteSpace(dtp_date_to.Text))
                {
                    func.Error_Message1 = "Report \'Date To\'";
                    func.Error_Message();
                    dtp_date_to.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(dtp_date_from.Text))
                {
                    func.Error_Message1 = "Report \'Date From\'";
                    func.Error_Message();
                    dtp_date_from.Focus();
                    return;
                }
                sql = string.Empty;
                if (what_to_do != "loadToday")
                {
                    sql = " SELECT * from Customer WHERE DATE(`Entry Date`) >= '" + dtp_date_from.Text + "' AND DATE(`Entry Date`) <= '" + dtp_date_to.Text + "' ORDER BY `Entry Date` DESC";
                }
                else
                {
                    sql = " SELECT * from Customer WHERE DATE(`Entry Date`) >= '" + DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve) + "' ORDER BY `Entry Date` DESC";
                }
                config.Load_DTG(sql, dtg_PreviewPage);
                DTG_Properties();
                list2 = new List<Class_Customer_Var>();
                if (what_to_do != "load")
                {
                    try
                    {
                        if (dtg_PreviewPage.DataSource != null)
                        {
                            list2 = ((DataTable)dtg_PreviewPage.DataSource).AsEnumerable().Select(
                            dataRow => new Class_Customer_Var
                            {
                                Cust_ID = dataRow["Customer ID"].ToString(),
                                Name = dataRow["Name"].ToString(),
                                Type = dataRow["Type"].ToString(),
                                Phone = dataRow["Phone Number"].ToString(),
                                Address = dataRow["Address"].ToString(),
                                Entry_Date = dataRow["Entry Date"].ToString()
                            }).ToList();
                            rs.Value = list2;
                        }
                        else
                        {
                            lbl_exception.Text = "Error: The data source is empty";
                        }
                    }
                    catch (NullReferenceException ex)
                    {
                        lbl_exception.Text = "Error: " + ex.Message;
                    }

                    rs.Name = "DataSet1";
                    frm.reportViewer1.LocalReport.DataSources.Clear();
                    frm.reportViewer1.LocalReport.DataSources.Add(rs);
                    frm.reportViewer1.ProcessingMode = ProcessingMode.Local;
                    frm.reportViewer1.LocalReport.ReportPath = (Includes.AppSettings.Customer_RDLC_DIR);

                    //Load Text to RDLC TextBox
                    reportParameters.Add(new ReportParameter("Report_Date", DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve)));
                    reportParameters.Add(new ReportParameter("From_Date", dtp_date_from.Text));
                    reportParameters.Add(new ReportParameter("To_Date", dtp_date_to.Text));

                    if (dtg_PreviewPage.Rows.Count >= 1)
                    {
                        reportParameters.Add(new ReportParameter("Total_Person", lbl_Personnel.Text));
                    }
                    else
                    {
                        reportParameters.Add(new ReportParameter("Total_Person", "0"));
                    }
                    foreach (CheckBox chk2 in grp_filters.Controls)
                    {
                        if (chk2.Checked == false)
                        {
                            reportParameters.Add(new ReportParameter("Total_Person", 0.ToString()));
                        }
                    }
                    //HIDING COLUMNS
                    reportParameters.Add(new ReportParameter("Hide_Hired_Date", (!chk_Hire_Date.Checked).ToString()));
                    reportParameters.Add(new ReportParameter("Hide_Name", (!chk_Name.Checked).ToString()));
                    reportParameters.Add(new ReportParameter("Hide_Phone", (!chk_Phone.Checked).ToString()));
                    reportParameters.Add(new ReportParameter("Hide_Type", (!chk_Type.Checked).ToString()));
                    reportParameters.Add(new ReportParameter("Hide_Address", (!chk_Address.Checked).ToString()));
                    reportParameters.Add(new ReportParameter("Hide_Cust_ID", (!chk_Cust_ID.Checked).ToString()));


                    frm.reportViewer1.LocalReport.SetParameters(reportParameters);
                    frm.reportViewer1.RefreshReport();

                    if (what_to_do == "preview")
                    {
                        frm.ShowDialog();

                    }
                    else if (what_to_do == "print")
                    {
                        Print_To_The_Printer prt = new Print_To_The_Printer();
                        prt.PrintToPrinter(frm.reportViewer1.LocalReport);
                    }
                    else if (what_to_do == "batch")
                    {

                        string FileName = "Customer Report " + DateTime.Now.ToString("hhmmss") + ".pdf";
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

                            MessageBox.Show("Batched!", "Send to Document Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_exception.Text = "Error: " + ex.Message;
            }
        }
        private void DTG_Properties()
        {
            dtg_PreviewPage.Columns[0].Visible = false;
            func.Count_person(dtg_PreviewPage, lbl_Personnel);
            dtg_PreviewPage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btn_Print_Preview_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("preview");
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("print");
        }

        private void btn_Batch_Click(object sender, EventArgs e)
        {

            Calculate_Filtering("batch");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            isWorkerBusy = false;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Set the date range in the background worker
            dtp_date_to.Invoke(new Action(() =>
            {
                dtp_date_to.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve);
            }));

            dtp_date_from.Invoke(new Action(() =>
            {
                dtp_date_from.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve);
            }));
        }

        private void dtp_date_from_ValueChanged(object sender, EventArgs e)
        {
            Calculate_Filtering("load");
        }

        private void dtp_date_to_ValueChanged(object sender, EventArgs e)
        {
            Calculate_Filtering("load");
        }
    }
    public class Class_Customer_Var
    {

        public string Cust_ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Entry_Date { get; set; }
    }
}

