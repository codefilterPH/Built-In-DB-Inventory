using Inventory_System02.Includes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Inventory_System02.Reports_Dir
{
    public partial class Customer_Report : Form
    {
        SQLConfig config = new SQLConfig();
        string sql;
        DataSet ds = new DataSet();
        Report_Viewer frm = new Report_Viewer();
        ReportDataSource rs = new ReportDataSource();
        ReportParameterCollection reportParameters = new ReportParameterCollection();
        usableFunction func = new usableFunction();

        string Global_ID, Fullname, JobRole;

        private void btn_Print_Preview_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("preview");
        }

        public Customer_Report(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }

        private void Customer_Report_Load(object sender, EventArgs e)
        {
          
            chk_Cust_ID.Checked = true;
            chk_FN.Checked = true;
            chk_LN.Checked = true;
       
            dtp_date_from.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormat);
            dtp_date_to.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormat);

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

        int count = 0;
        string datef = string.Empty;

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("print");
        }

        private void btn_Batch_Click(object sender, EventArgs e)
        {

            Calculate_Filtering("batch");

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
            using (FileStream fs = File.Create((Includes.AppSettings.Doc_DIR) + FileName))
            {
                fs.Write(mybytes, 0, mybytes.Length);

                MessageBox.Show("Batched!", "Send to Document Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
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
                func.Error_Message();
                return;
            }
        }
        private void DTG_Properties()
        {
            dtg_PreviewPage.Columns[0].Visible = false;
            func.Count_person(dtg_PreviewPage, lbl_Personnel);
            dtg_PreviewPage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbo_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate_Filtering("dtg_preview");
        }
        private void DateAdjuster_local(ComboBox bx)
        {
            DateTime datefrom1 = Convert.ToDateTime(DateTime.Now.ToString(Includes.AppSettings.DateFormat));
            if (bx.Text == "Today")
            {
                datef = datefrom1.ToString(Includes.AppSettings.DateFormat);
            }
            else if (bx.Text == "1 Week")
            {
                datef = datefrom1.AddDays(-7).ToString(Includes.AppSettings.DateFormat);
            }
            else if (bx.Text == "2 Weeks")
            {
                datef = datefrom1.AddDays(-14).ToString(Includes.AppSettings.DateFormat);
            }
            else
            {
                datef = "2023-01-01";
            }


        }
        private void Calculate_Filtering(string what_to_do)
        {
            DateAdjuster_local(cbo_date);
            rs = new ReportDataSource();
            reportParameters = new ReportParameterCollection();
            frm = new Report_Viewer();
            ds = new DataSet();
            Group_Filtering_MustNotEmpty();
            List<Class_Customer_Var> list2 = new List<Class_Customer_Var>();
 
            if (txt_rep_date.Text == "")
            {
                func.Error_Message1 = "Report date";
                func.Error_Message();
                txt_rep_date.Focus();
                return;
            }
            if (cbo_date.Text == "Today")
            {
                sql = " SELECT * from Customer where count = '1' and `Entry Date` = '" + DateTime.Now.ToString(Includes.AppSettings.DateFormat) + "' ";
            }
            else if ( cbo_date.Text == "1 Week")
            {
                sql = " SELECT * from Customer WHERE `Entry Date` >= '"+ datef + "' AND `Entry Date` <= '" + DateTime.Now.ToString(Includes.AppSettings.DateFormat) + "' ";
            }
            else if (cbo_date.Text == "2 Weeks")
            { 
                sql = " SELECT * from Customer WHERE `Entry Date` >= '" + datef + "' AND `Entry Date` <= '" + DateTime.Now.ToString(Includes.AppSettings.DateFormat) + "' ";
            }
            else
            {
                sql = " SELECT * from Customer";
            }
            config.Load_DTG(sql, dtg_PreviewPage);
            DTG_Properties();
            config.Load_Datasource(sql, ds);
            if (ds != null)
            {
                list2 = ds.Tables[0].AsEnumerable().Select(
              dataRow => new Class_Customer_Var
              {
                  Cust_ID = dataRow.Field<string>("Customer ID").ToString(),
                  FN = dataRow.Field<string>("First Name").ToString(),
                  LN = dataRow.Field<string>("Last Name").ToString(),
                  Phone = dataRow.Field<string>("Phone Number").ToString(),
                  Address = dataRow.Field<string>("Address").ToString(),
                  Entry_Date = dataRow.Field<string>("Entry Date").ToString()
              }).ToList();
                rs.Value = list2;
            }

            rs.Name = "DataSet1";
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.ProcessingMode = ProcessingMode.Local;
            frm.reportViewer1.LocalReport.ReportPath = (@"CommonSql\Reports Dir\Customer_Report.rdlc");

            //Load Text to RDLC TextBox
            reportParameters.Add(new ReportParameter("param_report_date", txt_rep_date.Text));

            if (ds.Tables[0].Rows.Count >= 1)
            {
                reportParameters.Add(new ReportParameter("Total_Person", ds.Tables[0].Rows.Count.ToString()));
            }
            foreach (CheckBox chk2 in grp_filters.Controls)
            {
                if (chk2.Checked == false)
                {
                    reportParameters.Add(new ReportParameter("Total_Person", 0.ToString()));
                }
            }
            Hiding_Columns();
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


        }
        private void Hiding_Columns()
        {

            if (chk_Cust_ID.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Cust_ID", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Cust_ID", "False"));
            }

            if (chk_FN.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_FN", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_FN", "False"));
            }

            if (chk_LN.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_LN", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_LN", "False"));
            }

            if (chk_Phone.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Phone", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Phone", "False"));
            }

            if (chk_Address.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Address", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Address", "False"));
            }

            if (chk_Hire_Date.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Entry_Date", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Entry_Date", "False"));
            }
        }
    }
    public class Class_Customer_Var
    {
        public string Cust_ID { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Entry_Date { get; set; }
    }
}

