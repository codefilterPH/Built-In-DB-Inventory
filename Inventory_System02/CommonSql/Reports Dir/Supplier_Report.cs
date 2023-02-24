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
    public partial class Supplier_Report : Form
    {
        SQLConfig config = new SQLConfig();
        string sql;
        DataSet ds = new DataSet();

        Report_Viewer frm = new Report_Viewer();
        ReportDataSource rs = new ReportDataSource();
        ReportParameterCollection reportParameters = new ReportParameterCollection();
        usableFunction func = new usableFunction();

        string Global_ID, Fullname, JobRole, datef = string.Empty;

        private void chk_Supplier_ID_CheckedChanged(object sender, EventArgs e)
        {

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

        private void btn_Print_Click(object sender, EventArgs e)
        {

        }

        private void btn_Print_Preview_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("preview");
        }

        public Supplier_Report(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }


        private void Calculate_Filtering(string what_to_do)
        {
            DateAdjuster_local(cbo_date);
            rs = new ReportDataSource();
            reportParameters = new ReportParameterCollection();
            frm = new Report_Viewer();
            ds = new DataSet();
            Group_Filtering_MustNotEmpty();
            List<Class_Supplier_Var> list2 = new List<Class_Supplier_Var>();

            if (dtp_sup_rep_date.Text == "")
            {
                func.Error_Message1 = "Report date";
                func.Error_Message();
                dtp_sup_rep_date.Focus();
                return;
            }
            if (cbo_date.Text == "All Dates")
            {
                sql = " SELECT * from Supplier where count = '1'";
            }
            else if (cbo_date.Text == "Today")
            {
                sql = " SELECT * from Supplier where count = '1' and `Entry Date` = '" + DateTime.Now.ToString(Includes.AppSettings.DateFormat) + "' ";
            }
            else
            {
                sql = " SELECT * from Supplier where count = '1' and `Entry Date` between '" + datef + "' and '" + DateTime.Now.ToString(Includes.AppSettings.DateFormat) + "'  ";
            }
            config.Load_DTG(sql, dtg_PreviewPage);
            DTG_Properties();
            config.Load_Datasource(sql, ds);
            if (ds != null)
            {
                list2 = ds.Tables[0].AsEnumerable().Select(
              dataRow => new Class_Supplier_Var
              {
                  Entry_Date = dataRow.Field<string>("Entry Date").ToString(),
                  Supplier_Id = dataRow.Field<string>("Company ID").ToString(),
                  Supplier_Name = dataRow.Field<string>("Company Name").ToString(),
                  Email = dataRow.Field<string>("Email").ToString(),
                  Phone = dataRow.Field<string>("Phone").ToString(),
                  Street = dataRow.Field<string>("Street").ToString(),
                  City = dataRow.Field<string>("City").ToString(),
                  Province = dataRow.Field<string>("Province").ToString(),
                  Address = dataRow.Field<string>("Address").ToString(),

              }).ToList();
                rs.Value = list2;
            }

            rs.Name = "DataSet1";
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.ProcessingMode = ProcessingMode.Local;
            frm.reportViewer1.LocalReport.ReportPath = (Includes.AppSettings.Supplier_RDLC_DIR);

            //Load Text to RDLC TextBox
            reportParameters.Add(new ReportParameter("param_report_date", dtp_sup_rep_date.Text));

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
        private void Hiding_Columns()
        {
            if (chk_entry_date.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Date", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Date", "False"));
            }

            if (chk_Supplier_ID.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_ID", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_ID", "False"));
            }

            if (chk_Supplier_Name.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Name", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Name", "False"));
            }
            if (chk_Email.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Email", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Email", "False"));
            }

            if (chk_Phone.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Phone", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Phone", "False"));
            }

            if (chk_Street.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Street", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Street", "False"));
            }

            if (chk_City.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_City", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_City", "False"));
            }

            if (chk_Province.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Province", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Province", "False"));
            }


            if (chk_Address.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Address", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Address", "False"));
            }

         
        }
        int count = 0;

        private void btn_Batch_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("batch");

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
            using (FileStream fs = File.Create((Includes.AppSettings.Doc_DIR) + FileName))
            {
                fs.Write(mybytes, 0, mybytes.Length);

                MessageBox.Show("Batched!", "Send to Document Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void cbo_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate_Filtering("load");
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
                chk_Supplier_ID.Checked = true;
                chk_Supplier_Name.Checked = true;
                chk_Address.Checked = true;
                func.Error_Message();
                return;
            }
        }
        private void Supplier_Report_Load(object sender, EventArgs e)
        {
            this.Refresh();

            dtp_sup_rep_date.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormat);

            chk_Supplier_ID.Checked = true;
            chk_Supplier_Name.Checked = true;
            chk_Address.Checked = true;

            sql = " SELECT * from Supplier where count = '1' ";
            config.Load_DTG(sql, dtg_PreviewPage);
            DTG_Properties();

            cbo_date.DropDownStyle = ComboBoxStyle.DropDownList;
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
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Address { get; set; }
    }
}
