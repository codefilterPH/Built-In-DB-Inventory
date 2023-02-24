using Inventory_System02.Includes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Inventory_System02.Reports_Dir
{

    public partial class Employee_Report : Form
    {
        SQLConfig config;
        string sql;
        DataSet ds;

        Report_Viewer frm;
        ReportDataSource rs;
        ReportParameterCollection reportParameters;
        usableFunction func;

        string Global_ID, Fullname, JobRole, datef = string.Empty;
        public Employee_Report(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;

        }

        private void Employee_Report_Load(object sender, EventArgs e)
        {
            config = new SQLConfig();
            func = new usableFunction();
            txt_rep_date.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormat);
       
            chk_Emp_ID.Checked = false;
            chk_FN.Checked = false;
            chk_LN.Checked = false;

            sql = " SELECT * from Employee where count = '1' ";
            config.Load_DTG(sql, dtg_PreviewPage);
            //DTG Properties
            dtg_PreviewPage.Columns[0].Visible = false;
            dtg_PreviewPage.Columns["Password"].Visible = false;
            func.Count_person(dtg_PreviewPage, lbl_Personnel);
            dtg_PreviewPage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            chk_FN.Checked = true;
            chk_LN.Checked = true;
            chk_Emp_ID.Checked = true;
            cbo_date.DropDownStyle = ComboBoxStyle.DropDownList;
        }
      
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                config = new SQLConfig();
                dtg_PreviewPage.Columns.Clear();
                Group_Filtering_MustNotEmpty();

                sql = " SELECT * from `Employee` ";
                config.Load_DTG(sql, dtg_PreviewPage);

            }
        }

        private void btn_Print_Preview_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("preview");
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

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("print");
        }

        private void cbo_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate_Filtering("load");
        }

        private void Group_Filtering_MustNotEmpty()
        {
            func = new usableFunction();
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
                chk_Emp_ID.Checked = true;
                chk_FN.Checked = true;
                chk_LN.Checked = true;
                func.Error_Message();
                return;
            }
        }

        private void cbo_report_type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Calculate_Filtering("loadtodtg");
        }

        private void btn_Batch_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("batch");

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
            else if (bx.Text == "1 Month")
            {
                datef = datefrom1.AddMonths(-1).ToString(Includes.AppSettings.DateFormat);
            }
            else if (bx.Text == "3 Months")
            {
                datef = datefrom1.AddMonths(-2).ToString(Includes.AppSettings.DateFormat);
            }
            else if (bx.Text == "6 Months")
            {
                datef = datefrom1.AddMonths(-6).ToString(Includes.AppSettings.DateFormat);
            }
            else if (bx.Text == "1 Year")
            {
                datef = datefrom1.AddYears(-1).ToString(Includes.AppSettings.DateFormat);
            }
            else
            {
                datef = "2023-01-01";
            }


        }

        private void Calculate_Filtering(string what_to_do)
        {
            rs = new ReportDataSource();
            reportParameters = new ReportParameterCollection();
            frm = new Report_Viewer();
            ds = new DataSet();
            config = new SQLConfig();
            func = new usableFunction();

            List<Class_Employee_Var> list2 = new List<Class_Employee_Var>();
          
            if (txt_rep_date.Text == "")
            {
                func.Error_Message1 = "Report date";
                func.Error_Message();
                txt_rep_date.Focus();
                return;
            }
        
            Group_Filtering_MustNotEmpty();
            DateAdjuster_local(cbo_date);
            if ( cbo_date.Text == "All Dates")
            {

                sql = " SELECT * from Employee where count = '1' ";

            }
            else
            {
                sql = " SELECT * from Employee where count = '1' and `Hired Date` between '" + datef + "' and '" + DateTime.Now.ToString(Includes.AppSettings.DateFormat)+ "' ";

            }
            config.Load_DTG(sql, dtg_PreviewPage);
            config.Load_Datasource(sql, ds);
            if (ds != null)
            {
                list2 = ds.Tables[0].AsEnumerable().Select(
              dataRow => new Class_Employee_Var
              {
                  Emp_ID = dataRow.Field<string>("Employee ID").ToString(),
                  FN = dataRow.Field<string>("First Name").ToString(),
                  LN = dataRow.Field<string>("Last Name").ToString(),
                  Email = dataRow.Field<string>("Email").ToString(),
                  Phone = dataRow.Field<string>("Phone Number").ToString(),
                  Address = dataRow.Field<string>("Address").ToString(),
                  JobRole = dataRow.Field<string>("Job Role").ToString(),
                  HiredDate = dataRow.Field<string>("Hired Date").ToString()
              }).ToList();
                rs.Value = list2;
            }


            rs.Name = "DataSet1";
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.ProcessingMode = ProcessingMode.Local;
            frm.reportViewer1.LocalReport.ReportPath = (Includes.AppSettings.Employee_RDLC_DIR);

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
            //HIDING COLUMNS
            reportParameters.Add(new ReportParameter("Hide_HiredDate", (!chk_HiredDate.Checked).ToString()));
            reportParameters.Add(new ReportParameter("Hide_EMP_ID", (!chk_Emp_ID.Checked).ToString()));
            reportParameters.Add(new ReportParameter("Hide_LN", (!chk_LN.Checked).ToString()));
            reportParameters.Add(new ReportParameter("Hide_FN", (!chk_FN.Checked).ToString()));
            reportParameters.Add(new ReportParameter("Hide_Email", (!chk_Email.Checked).ToString()));
            reportParameters.Add(new ReportParameter("Hide_Phone", (!chk_Phone.Checked).ToString()));
            reportParameters.Add(new ReportParameter("Hide_Address", (!chk_Address.Checked).ToString()));
            reportParameters.Add(new ReportParameter("Hide_JobRole", (!chk_JobRole.Checked).ToString()));

            frm.reportViewer1.LocalReport.SetParameters(reportParameters);
            frm.reportViewer1.RefreshReport();

            if ( what_to_do == "preview")
            {
                frm.ShowDialog();

            }
            else if (what_to_do == "print")
            {
                Print_To_The_Printer prt = new Print_To_The_Printer();
                prt.PrintToPrinter(frm.reportViewer1.LocalReport);
            }
            else if ( what_to_do == "batch")
            {

                string FileName = "Employee Report " + DateTime.Now.ToString("hhmmss") + ".pdf";
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

        }
    
    }
    public class Class_Employee_Var
    {
        public string Emp_ID { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string JobRole { get; set; }
        public string HiredDate { get; set; }
    }
}
