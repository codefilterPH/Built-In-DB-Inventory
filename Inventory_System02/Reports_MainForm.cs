using Inventory_System02.CommonSql.Reports_Dir.Item_Qty;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_System02
{
    public partial class Reports_MainForm : Form
    {
        public Reports_MainForm(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }
        string Global_ID, Fullname, JobRole;

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_content_remove();
            Reports_Dir.Employee_Report frm = new Reports_Dir.Employee_Report(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(report_panel, frm);
        }

        private void Reports_MainForm_Load(object sender, EventArgs e)
        {
            itemListToolStripMenuItem_Click(sender, e);
        }
        public static void ShowFormInContainerControl(Control ctl, Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            ctl.Controls.Add(frm);


        }

        private void customerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_content_remove();
            Reports_Dir.Customer_Report frm = new Reports_Dir.Customer_Report(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(report_panel, frm);
        }

        private void supplierReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_content_remove();
            Reports_Dir.Supplier_Report frm = new Reports_Dir.Supplier_Report(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(report_panel, frm);
        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_content_remove();
            Reports_Dir.Item_Report frm = new Reports_Dir.Item_Report(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(report_panel, frm);
        }

        private void itemBySupplierDivisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_content_remove();
            CommonSql.Reports_Dir.Item_Division.ItemByDivision_Form frm = new CommonSql.Reports_Dir.Item_Division.ItemByDivision_Form();
            ShowFormInContainerControl(report_panel, frm);
        }

        private void itemByQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Edit_QTY frm = new Edit_QTY();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                int from_Qty = 0;
                int to_Qty = 0;
                // Get the data entered by the user from the MyData property of the form
                from_Qty = frm.from_qty;
                to_Qty = frm.to_qty;

                Panel_content_remove();
                Item_by_Quantity new_frm = new Item_by_Quantity(from_Qty, to_Qty);
                ShowFormInContainerControl(report_panel, new_frm);
            }

        }

        public void Panel_content_remove()
        {
            foreach (Control item in report_panel.Controls.OfType<Form>())
            {
                item.Dispose();
                report_panel.Controls.Remove(item);
            }
        }
    }
}
