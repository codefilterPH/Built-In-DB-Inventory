using Inventory_System02.Includes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;

namespace Inventory_System02.Reports_Dir
{
    public partial class Item_Report : Form
    {
        SQLConfig config = new SQLConfig();

        DataSet ds = new DataSet();

        Report_Viewer frm = new Report_Viewer();
        ReportDataSource rs = new ReportDataSource();
        ReportParameterCollection reportParameters = new ReportParameterCollection();
        usableFunction func = new usableFunction();

        string Global_ID, Fullname, JobRole;
        string sql, image_path = @"CommonSql\Reports Dir\";
        string company_name = string.Empty, company_address = string.Empty, company_image_path = string.Empty;
        string db_table = string.Empty, datef =string.Empty, datenow = DateTime.Now.ToString("dd-MM-yyyy"), dateformat = "dd-MM-yyyy";
        double price = 0, quantity = 0, sub_amt = 0, total_val = 0;

        int count = 0;

        public Item_Report(string userid, string name, string jobrole)
        {
            InitializeComponent();
            Global_ID = userid;
            Fullname = name;
            JobRole = jobrole;

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
                chk_Item_ID.Checked = true;
                chk_Item_Name.Checked = true;
                chk_Quantity.Checked = true;
                chk_Price.Checked = true;
                return;
            }
        }
        private void WhatTable_To_Select()
        {
            if (cbo_report_type.Text == "Stock In")
            {
                db_table = "`Stocks`";
            }
            else if (cbo_report_type.Text == "Stock Out")
            {
                db_table = "`Stock Out`";
            }
            else
            {
                db_table = "`Stock Returned`";
            }
        }

        private void Item_Report_Load_1(object sender, EventArgs e)
        {
            txt_rep_date.Text = datenow;

            sql = "Select * from `Stocks` order by `Entry Date` desc";
            config.Load_DTG(sql, dtg_PreviewPage);
            Dtg_Properties();
            config.Load_Datasource(sql, ds);
            calculate_Total();

            chk_Cust_ID.Visible = false;
            chk_Cust_Name.Visible = false;
            chk_Cust_Address.Visible = false;

        }
        private void calculate_Total()
        {
            lbl_total_items.Text = ds.Tables[0].Rows.Count.ToString();
            DataTable table = new DataTable();
            table = ds.Tables[0];

            ClearVariables();

            foreach (DataRow dr in table.Rows)
            {
                quantity = Convert.ToDouble(dr["Quantity"]);
                quantity1 += quantity;
                if (cbo_report_type.Text == "Stock In")
                {
                    price = Convert.ToDouble(dr["Price"]);

                    sub_amt = quantity * price;
                    total_val += sub_amt;
                }
                else
                {
                    price = Convert.ToDouble(dr["Total"]);
                    total_val += price;
                }

            }

            lbl_total_quantity.Text = quantity1.ToString();
            lbl_total_value.Text = total_val.ToString();
        }
        private void DateAdjuster_local(ComboBox bx)
        {
            DateTime datefrom1 = Convert.ToDateTime(datenow);
            if (bx.Text == "Today")
            {
                datef = datefrom1.ToString(dateformat);
            }
            else if (bx.Text == "1 Week")
            {
                datef = datefrom1.AddDays(-7).ToString(dateformat);
            }
            else if (bx.Text == "2 Weeks")
            {
                datef = datefrom1.AddDays(-14).ToString(dateformat);
            }
            else if (bx.Text == "1 Month")
            {
                datef = datefrom1.AddMonths(-1).ToString(dateformat);
            }
            else if (bx.Text == "6 Months")
            {
                datef = datefrom1.AddMonths(-6).ToString(dateformat);
            }
            else if (bx.Text == "1 Year")
            {
                datef = datefrom1.AddMonths(-12).ToString(dateformat);
            }
            else if (bx.Text == "2 Years")
            {
                datef = datefrom1.AddMonths(-24).ToString(dateformat);
            }
            else
            {
                datef = "01-02-2022";
            }


        }

        public void Calculate_Filtering(string preview_or_print)
        {
            rs = new ReportDataSource();
            reportParameters = new ReportParameterCollection();
            frm = new Report_Viewer();
            ds = new DataSet();

            List<Class_Item_Var> list2 = new List<Class_Item_Var>();

            if (txt_rep_date.Text == "")
            {
                func.Error_Message1 = "Report date";
                func.Error_Message();
                txt_rep_date.Focus();
                return;
            }
            Group_Filtering_MustNotEmpty();
            WhatTable_To_Select();
            DateAdjuster_local(cbo_Date);
                
            if (cbo_Date.Text == "All Dates")
            {
                sql = " SELECT * from " + db_table + " where count = '1' ";
            }
            else if ( cbo_Date.Text == "Today")
            {
                sql = " SELECT * from " + db_table + " where count = '1' and `Entry Date` = '"+datenow+"' ";
            }
            else
            {
                sql = " SELECT * from " + db_table + " where count = '1' and `Entry Date` between '" + Convert.ToDateTime(datef)+"' and '"+ datenow +"' ";
            }
           
            config.Load_Datasource(sql, ds);
            config.Load_DTG(sql, dtg_PreviewPage);
            Dtg_Properties();

            if (cbo_report_type.Text == "Stock In")
            {
                if (ds != null)
                { 
                    list2 = ds.Tables[0].AsEnumerable().Select(
                     dataRow => new Class_Item_Var
                     {
                         Entry_Date = dataRow.Field<string>("Entry Date").ToString(),
                         Item_ID = dataRow.Field<string>("Stock ID").ToString(),
                         Item_Name = dataRow.Field<string>("Item Name").ToString(),
                         Category = dataRow.Field<string>("Category").ToString(),
                         Description = dataRow.Field<string>("Description").ToString(),
                         Quantity = dataRow.Field<string>("Quantity").ToString(),
                         Price = dataRow.Field<string>("Price").ToString(),
                         Supplier_ID = dataRow.Field<string>("Supplier ID").ToString(),
                         Supplier_Name = dataRow.Field<string>("Supplier Name").ToString(),
                         Use_ID = dataRow.Field<string>("User ID").ToString(),
                         Staff_Name = dataRow.Field<string>("Warehouse Staff Name").ToString(),
                         Job_Role = dataRow.Field<string>("Job Role").ToString(),
                         Trans_Ref = dataRow.Field<string>("Transaction Reference").ToString(),

                     }).ToList();
                    rs.Value = list2;
                }
            }
            else
            {
                if (ds != null)
                {
                    list2 = ds.Tables[0].AsEnumerable().Select(
                  dataRow => new Class_Item_Var
                  {
                      Entry_Date = dataRow.Field<string>("Entry Date"),
                      Item_ID = dataRow.Field<string>("Stock ID"),
                      Item_Name = dataRow.Field<string>("Item Name"),
                      Category = dataRow.Field<string>("Category"),
                      Description = dataRow.Field<string>("Description"),
                      Quantity = dataRow.Field<string>("Quantity"),
                      Price = dataRow.Field<string>("Total"),
                      Customer_ID = dataRow.Field<string>("Customer ID"),
                      Customer_Name = dataRow.Field<string>("Customer Name"),
                      Customer_Address = dataRow.Field<string>("Customer Address"),
                      Use_ID = dataRow.Field<string>("User ID"),
                      Staff_Name = dataRow.Field<string>("Warehouse Staff Name"),
                      Job_Role = dataRow.Field<string>("Job Role"),
                      Trans_Ref = dataRow.Field<string>("Transaction Reference"),

                  }).ToList();
                    rs.Value = list2;
                }
            }

            rs.Name = "DataSet1";
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.ProcessingMode = ProcessingMode.Local;

            if (cbo_report_type.Text == "Stock In")
            {
                frm.reportViewer1.LocalReport.ReportPath = (image_path + @"Item Report.rdlc");
            }
            else
            {
                frm.reportViewer1.LocalReport.ReportPath = (image_path + @"Item ReportStocksOutIn.rdlc");
            }

            //Load Text to RDLC TextBox
            reportParameters.Add(new ReportParameter("param_report_date", txt_rep_date.Text));
            reportParameters.Add(new ReportParameter("DateStart", datef));
            reportParameters.Add(new ReportParameter("DateEnd", datenow));

            //Get Company Info
            sql = "Select * from Settings ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                company_name = config.dt.Rows[0].Field<string>("Company_Name");
                company_address = config.dt.Rows[0].Field<string>("Company Address");
               // company_image_path = config.dt.Rows[0].Field<string>("Company_Image");
            }
            if (company_name == "" || company_name == null)
            {
                company_name = "No Company Name";
            }
            if (company_address == "" || company_address == null)
            {
                company_address = "No Company Address";
            }
          
           // reportParameters.Add(new ReportParameter("Image_Path", @"C:\Users\eugen\Desktop\Inventory_System02\Inventory_System02\bin\Debug\CommonSql\Pictures\Company\Company_Logo1.PNG"));
            reportParameters.Add(new ReportParameter("CompanyName", company_name));
            reportParameters.Add(new ReportParameter("CompanyAddress", company_address));
            if (ds.Tables[0].Rows.Count >= 1)
            {
                reportParameters.Add(new ReportParameter("Total_Items", ds.Tables[0].Rows.Count.ToString()));
                calculate_Total();
                reportParameters.Add(new ReportParameter("Total_Quantity", quantity1.ToString()));
                reportParameters.Add(new ReportParameter("Total_Value", total_val.ToString()));   

            }
            else if (ds.Tables[0].Rows.Count <= 0)
            {
                reportParameters.Add(new ReportParameter("Total_Items", 0.ToString()));
                reportParameters.Add(new ReportParameter("Total_Quantity", 0.ToString()));
                reportParameters.Add(new ReportParameter("Total_Value", 0.ToString()));
            }
            foreach (CheckBox chk2 in grp_filters.Controls)
            {
                if (chk2.Checked == false)
                {
                    reportParameters.Add(new ReportParameter("Total_Items", 0.ToString()));
                }
            }


            Hiding_Columns();
         //   frm.reportViewer1.LocalReport.EnableExternalImages = true;
            frm.reportViewer1.LocalReport.SetParameters(reportParameters);
            frm.reportViewer1.RefreshReport();

            if (preview_or_print == "preview")
            {
                frm.ShowDialog();
            }
            else if ( preview_or_print == "print")
            {
                Print_To_The_Printer prt = new Print_To_The_Printer();
                prt.PrintToPrinter(frm.reportViewer1.LocalReport);
            }
        }
        private void Hiding_Columns()
        {

            if (chk_Entry_Date.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Entry_Date", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Entry_Date", "False"));
            }
            if (chk_Item_ID.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Item_ID", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Item_ID", "False"));
            }

            if (chk_Item_Name.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Item_Name", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Item_Name", "False"));
            }

            if (chk_Category.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Category", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Category", "False"));
            }

            if (chk_Description.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Description", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Description", "False"));
            }

            if (chk_Quantity.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Quantity", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Quantity", "False"));
            }
            if (chk_Price.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Price", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Price", "False"));
            }
            if (chk_Sup_ID.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Supplier_ID", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Supplier_ID", "False"));
            }
            if (chk_Sup_Name.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Supplier_Name", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Supplier_Name", "False"));
            }
            if (chk_Cust_ID.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Customer_ID", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Customer_ID", "False"));
            }
            if (chk_Cust_Name.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Customer_Name", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Customer_Name", "False"));
            }
            if (chk_Cust_Address.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Customer_Address", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Customer_Address", "False"));
            }
            if (chk_User_ID.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_User_ID", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_User_ID", "False"));
            }
            if (chk_Staff_Name.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Staff_Name", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Staff_Name", "False"));
            }
            if (chk_Job.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Job_Role", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Job_Role", "False"));
            }

            if (chk_Trans_Ref.Checked == false)
            {
                reportParameters.Add(new ReportParameter("Hide_Trans_Ref", "True"));
            }
            else
            {
                reportParameters.Add(new ReportParameter("Hide_Trans_Ref", "False"));
            }


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                db_table = string.Empty;
                dtg_PreviewPage.Columns.Clear();
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

        private void cbo_report_type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ( cbo_report_type.Text == "Stock In")
            {
                chk_Cust_ID.Visible = false;
                chk_Cust_Name.Visible = false;
                chk_Cust_Address.Visible = false;

                chk_Sup_ID.Visible = true;
                chk_Sup_Name.Visible = true;         
            }
            else
            {
                chk_Cust_ID.Visible = true;
                chk_Cust_Name.Visible = true;
                chk_Cust_Address.Visible = true;

                chk_Sup_ID.Visible = false;
                chk_Sup_Name.Visible = false;
            }
            Calculate_Filtering("load_todtg");

        }

        private void Dtg_Properties()
        {
            dtg_PreviewPage.Columns["Entry Date"].DisplayIndex = 0;
            dtg_PreviewPage.Columns["Stock ID"].DisplayIndex = 1;
            dtg_PreviewPage.Columns["Item Name"].DisplayIndex = 2;
            dtg_PreviewPage.Columns["Category"].DisplayIndex = 3;
            dtg_PreviewPage.Columns["Description"].DisplayIndex = 4;
            dtg_PreviewPage.Columns["Quantity"].DisplayIndex = 5;
            dtg_PreviewPage.Columns["Price"].DisplayIndex = 6;

            if ( cbo_report_type.Text == "Stock In")
            {
                dtg_PreviewPage.Columns["Supplier ID"].DisplayIndex = 7;
                dtg_PreviewPage.Columns["Supplier Name"].DisplayIndex = 8;
                dtg_PreviewPage.Columns["Image Path"].Visible = false;
            }

            dtg_PreviewPage.Columns["count"].Visible = false;

            dtg_PreviewPage.Columns["User ID"].DisplayIndex = 9;
            dtg_PreviewPage.Columns["Warehouse Staff Name"].DisplayIndex = 10;
            dtg_PreviewPage.Columns["Job Role"].DisplayIndex = 11;
            dtg_PreviewPage.Columns["Transaction Reference"].DisplayIndex = 12;

            


        }

        private void cbo_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate_Filtering("load_todtg");
        }

        private void chk_Select_All_CheckedChanged_1(object sender, EventArgs e)
        {

            if (chk_Select_All.Checked == true)
            {
                foreach (CheckBox ch in grp_filters.Controls)
                {
                    if (ch is CheckBox)
                    {
                        ch.Checked = true;
                        chk_Unselect.Checked = false;
                        if (cbo_report_type.Text == "Stock In")
                        {
                            chk_Cust_ID.Checked = false;
                            chk_Cust_Name.Checked = false;
                            chk_Cust_Address.Checked = false;
                        }
                        else
                        {
                            chk_Sup_ID.Checked = false;
                            chk_Sup_Name.Checked = false;
                        }
                    }
                }
            }
            else
            {
                chk_Unselect.Checked = true;
                chk_Unselect.Checked = false;
            }
        }

        private void btn_Print_Click_1(object sender, EventArgs e)
        {
            Calculate_Filtering("print");
        }

        private void btn_Batch_Click_1(object sender, EventArgs e)
        {
            Calculate_Filtering("batch");

            string FileName = "Item Report " + DateTime.Now.ToString("hhmmss") + ".pdf";
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

        private void btn_Print_Preview_Click_1(object sender, EventArgs e)
        {
            Calculate_Filtering("preview");
        }

        private void ClearVariables()
        {
            quantity = 0;
            quantity1 = 0;
            price = 0;
            total_val = 0;
            sub_amt = 0;
        }
        double quantity1 = 0;

        private void cbo_report_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enabled or Hide
            if (cbo_report_type.Text == "Stock In")
            {
                chk_Cust_ID.Visible = false;
                chk_Cust_Name.Visible = false;
                chk_Cust_Address.Visible = false;
                chk_Sup_ID.Visible = true;
                chk_Sup_Name.Visible = true;
                chk_Price.Text = "Price";
            }
            else
            {
                chk_Sup_ID.Visible = false;
                chk_Sup_Name.Visible = false;
                chk_Cust_ID.Visible = true;
                chk_Cust_Name.Visible = true;
                chk_Cust_Address.Visible = true;
                chk_Price.Text = "Total";
            }
            //Check if selected
            if (cbo_report_type.Text == "Stock In")
            {
                chk_Cust_ID.Checked = false;
                chk_Cust_Name.Checked = false;
                chk_Cust_Address.Checked = false;
                chk_Sup_ID.Checked = true;
                chk_Sup_Name.Checked = true;
                chk_Item_Name.Checked = true;
            }
            else
            {
                chk_Sup_ID.Checked = false;
                chk_Sup_Name.Checked = false;
                chk_Cust_ID.Checked = true;
                chk_Cust_Name.Checked = true;
                chk_Cust_Address.Checked = true;

            }
            chk_Item_Name.Checked = true;
            chk_Quantity.Checked = true;
            chk_Price.Checked = true;
        }

        private void Item_Report_Load(object sender, EventArgs e)
        {
            this.Refresh();
            txt_rep_date.Text = datenow;
            cbo_report_type_SelectedIndexChanged(sender, e);

            chk_Sup_ID.Checked = false;
            chk_Sup_Name.Checked = false;
            chk_Cust_Name.Visible = false;
            chk_Cust_ID.Visible = false;
            chk_Cust_Address.Visible = false;
        }
    }
    public class Class_Item_Var
    {
        public string Entry_Date { get; set; }
        public string Item_ID { get; set; }
        public string Item_Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
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

    }


}


