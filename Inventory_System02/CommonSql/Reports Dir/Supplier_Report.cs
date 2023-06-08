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
    public partial class Supplier_Report : Form
    {
        SQLConfig config;
        string sql = string.Empty;
        int count = 0;
        DataSet ds;

        Report_Viewer frm;
        ReportDataSource rs;
        ReportParameterCollection reportParameters;
        usableFunction func;
        List<Class_Supplier_Var> list2;

        string Global_ID, Fullname, JobRole, datef = string.Empty;
        public Supplier_Report(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }
        bool isWorkerBusy = false;
        private void Supplier_Report_Load(object sender, EventArgs e)
        {
            chk_entry_date.Checked = true;
            chk_Supplier_ID.Checked = true;
            chk_Supplier_Name.Checked = true;
            chk_Phone.Checked = true;
            chk_Address.Checked = true;

            if (!isWorkerBusy)
            {
                isWorkerBusy = true;
                backgroundWorker1.RunWorkerAsync();
            }
            Calculate_Filtering("loadToday");
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
                    sql = " SELECT * from Supplier where DATE(`Entry Date`) >= '" + dtp_date_from.Text + "' and DATE(`Entry Date`) <= '" + dtp_date_to.Text + "' ORDER BY `Entry Date` DESC ";
                }
                else
                {
                    sql = " SELECT * from Supplier where DATE(`Entry Date`) >= '" + DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve) + "' ORDER BY `Entry Date` DESC ";
                }

                config.Load_DTG(sql, dtg_PreviewPage);
                DTG_Properties();

                if (what_to_do != "load")
                {
                    list2 = new List<Class_Supplier_Var>();
                    try
                    {
                        if (dtg_PreviewPage.DataSource != null)
                        {
                            list2 = ((DataTable)dtg_PreviewPage.DataSource).AsEnumerable().Select(
                              dataRow => new Class_Supplier_Var
                              {
                                  Entry_Date = dataRow["Entry Date"].ToString(),
                                  Supplier_Id = dataRow["Company ID"].ToString(),
                                  Supplier_Name = dataRow["Company Name"].ToString(),
                                  Email = dataRow["Email"].ToString(),
                                  Phone = dataRow["Phone"].ToString(),
                                  Address = dataRow["Address"].ToString(),

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
                    frm.reportViewer1.LocalReport.ReportPath = (Includes.AppSettings.Supplier_RDLC_DIR);

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
                    reportParameters.Add(new ReportParameter("Hide_Date", (!chk_entry_date.Checked).ToString()));
                    reportParameters.Add(new ReportParameter("Hide_ID", (!chk_Supplier_ID.Checked).ToString()));
                    reportParameters.Add(new ReportParameter("Hide_Name", (!chk_Supplier_Name.Checked).ToString()));
                    reportParameters.Add(new ReportParameter("Hide_Email", (!chk_Email.Checked).ToString()));
                    reportParameters.Add(new ReportParameter("Hide_Phone", (!chk_Phone.Checked).ToString()));
                    reportParameters.Add(new ReportParameter("Hide_Address", (!chk_Address.Checked).ToString()));


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
                        string FileName = "Supplier Report " + DateTime.Now.ToString("hhmmss") + ".pdf";
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
                MessageBox.Show(ex.Message);
            }
        }

        private void Group_Filtering_MustNotEmpty()
        {
            try
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
                    chk_Supplier_ID.Checked = true;
                    chk_Supplier_Name.Checked = true;
                    chk_Address.Checked = true;
                    func.Error_Message();
                    return;
                }
            }
            catch (Exception ex)
            {
                lbl_exception.Text = "Error: " + ex.Message;
            }
        }
        private void dtp_date_from_ValueChanged(object sender, EventArgs e)
        {
            Calculate_Filtering("load");
        }
        private void dtp_date_to_ValueChanged(object sender, EventArgs e)
        {
            Calculate_Filtering("load");
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("print");
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

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            isWorkerBusy = false;
        }

        private void btn_Print_Preview_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("preview");
        }
        private void btn_Batch_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("batch");
        }

        private void DTG_Properties()
        {
            dtg_PreviewPage.Columns[0].Visible = false;
            func.Count_person(dtg_PreviewPage, lbl_Personnel);

            dtg_PreviewPage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
    public class Class_Supplier_Var
    {
        public string Entry_Date { get; set; }
        public string Supplier_Id { get; set; }
        public string Supplier_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
