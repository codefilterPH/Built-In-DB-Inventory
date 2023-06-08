using Inventory_System02.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Inventory_System02
{
    public partial class Batch_Form : Form
    {
        SQLConfig config = new SQLConfig();
        string path = Includes.AppSettings.Doc_DIR + "\\"; // Replace with the actual path to your inbound directory
        string[] files = Directory.GetFiles(Includes.AppSettings.Doc_DIR + "\\");
        //string[] files = Directory.GetFiles(@"\\" + config.computerName + @"\DB\BATCH FILES");

        string Global_ID, Fullname, JobRole;
        public Batch_Form(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
        }

        public void PATH()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(PATH));
                return;
            }
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("File Name");
            //dt.Columns.Add("Type");

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                //dt.Rows.Add(file.CreationTime, file.Name, file.Extension);
                dt.Rows.Add(file.CreationTime, file.Name);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            lbl_current.Text = "All Documents";
        }
        string what_to_del = string.Empty;
        private void chk_Select_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Select_all.Checked)
            {
                foreach (DataGridViewRow rw in dtg_batch_form.Rows)
                {
                    rw.Selected = true;
                    what_to_del = "all";
                }
            }
            else
            {
                foreach (DataGridViewRow rw in dtg_batch_form.Rows)
                {
                    rw.Selected = false;
                    what_to_del = "specific";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            what_to_del = "specific";
            chk_Select_all.Checked = false;
            DTG_Properties();


        }
        private void Load_to_Adobe()
        {
            if (dtg_batch_form.Rows.Count >= 1)
            {
                if (dtg_batch_form.CurrentRow != null)
                {
                    string file = Includes.AppSettings.Doc_DIR + "\\" + dtg_batch_form.CurrentRow.Cells[1].Value.ToString();
                    axAcroPDF1.LoadFile(file);
                }
            }
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {

            if (JobRole != "Programmer/Developer" && JobRole != "Office Manager")
            {
                MessageBox.Show("No permission to delete a document!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                chk_Select_all.Checked = false;
                return;
            }

            if (dtg_batch_form.Rows.Count > 0)
            {
                if (what_to_del != "all")
                {
                    if (dtg_batch_form.SelectedRows.Count == 0 || dtg_batch_form.CurrentRow.Cells[0].Selected == true)
                    {
                        dtg_batch_form.CurrentRow.Cells[1].Selected = true;
                        dtg_batch_form.CurrentRow.Cells[0].Selected = false;
                        what_to_del = "specific";
                    }
                }
            }

            string dir = Includes.AppSettings.Doc_DIR;
            if (what_to_del == "all")
            {
                if (MessageBox.Show("Are you sure to delete all files?", "Deletion Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dtg_batch_form.Rows.Count == 0)
                    {
                        MessageBox.Show("No files to delete.", "Delete unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Get the filenames from the DataGridView control 
                    List<string> filenames = new List<string>();
                    foreach (DataGridViewRow row in dtg_batch_form.Rows)
                    {
                        string filename = row.Cells[1].Value.ToString(); // Assumes the filename is in the second cell (index 1)
                        filenames.Add(filename);
                    }

                    // Loop through each filename and delete the associated file
                    foreach (string filename in filenames)
                    {
                        string filepath = Path.Combine(dir, filename);

                        // Check if file exists with its full path    
                        if (File.Exists(filepath))
                        {
                            // If file found, delete it   
                            File.Delete(filepath);
                            PATH();
                        }
                        else
                        {
                            MessageBox.Show("File not found: " + filename, "Delete unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    MessageBox.Show("Files are deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Reset any other properties as needed

                    dtg_batch_form.Columns.Clear();
                    todayToolStripMenuItem_Click(sender, e);
                }

            }
            else if (what_to_del == "specific")
            {

                if (MessageBox.Show("Are you sure to delete file " + dtg_batch_form.CurrentRow.Cells[1].Value.ToString() + "?", "Deletion Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (dtg_batch_form.Rows.Count == 0)
                    {
                        MessageBox.Show("No file to delete.", "Delete unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // Delete specific files in a directory              
                    try
                    {
                        string filename1 = dtg_batch_form.CurrentRow.Cells[1].Value.ToString();
                        // Check if file exists with its full path    
                        if (File.Exists(Path.Combine(dir, filename1)))
                        {
                            // If file found, delete it   
                            if (MessageBox.Show("Delete this " + filename1 + "?", "Deletion Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                           DialogResult.Yes)
                            {
                                File.Delete(Path.Combine(dir, filename1));
                                MessageBox.Show(filename1 + " is deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                todayToolStripMenuItem_Click(sender, e);
                            }
                        }
                        else
                        {
                            MessageBox.Show("File not found!", "Delete unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (IOException ioExp)
                    {
                        MessageBox.Show(ioExp.Message);
                    }
                }
            }
            chk_Select_all.Checked = false;
            what_to_del = "";
            this.Refresh();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewColumn newColumn = dtg_batch_form.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dtg_batch_form.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dtg_batch_form.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            dtg_batch_form.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Put each of the columns into programmatic sort mode.
            foreach (DataGridViewColumn column in dtg_batch_form.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void inboundTransToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Inbound Transaction/s";
            string[] files = Directory.GetFiles(path, "Inbound TRANS*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void outboundTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Outbound Transaction/s";
            string path = Includes.AppSettings.Doc_DIR; // Replace with the actual path to your inbound directory
            string[] files = Directory.GetFiles(path, "Outbound TRANS*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void returnTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Returned Transaction/s";
            string[] files = Directory.GetFiles(path, "Return TRANS*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }
        private void supplierReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Supplier\'s Reports";
            string path = Includes.AppSettings.Doc_DIR; // Replace with the actual path to your inbound directory
            string[] files = Directory.GetFiles(path, "Supplier Report*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Customer\'s Reports";
            string path = Includes.AppSettings.Doc_DIR; // Replace with the actual path to your inbound directory
            string[] files = Directory.GetFiles(path, "Customer Report*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Employee\'s Reports";
            string path = Includes.AppSettings.Doc_DIR; // Replace with the actual path to your inbound directory
            string[] files = Directory.GetFiles(path, "Employee Report*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void inboundReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Inbound Date Range Reports";
            string path = Includes.AppSettings.Doc_DIR; // Replace with the actual path to your inbound directory
            string[] files = Directory.GetFiles(path, "Inbound Report*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void outboundReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Outbound Date Range Reports";
            string path = Includes.AppSettings.Doc_DIR; // Replace with the actual path to your inbound directory
            string[] files = Directory.GetFiles(path, "Outbound Report*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void returnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Returned Date Range Reports";
            string path = Includes.AppSettings.Doc_DIR; // Replace with the actual path to your inbound directory
            string[] files = Directory.GetFiles(path, "Return Report*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }
        private void DTG_Properties()
        {
            if (this.IsDisposed) // Check if form has been disposed of
            {
                return;
            }
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(DTG_Properties));
                return;
            }
            if (dtg_batch_form.Rows.Count >= 1)
            {
                dtg_batch_form.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtg_batch_form.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Load_to_Adobe();
            }
        }

        private void todayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Includes.AppSettings.Doc_DIR);
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("File Name");

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);

                if (file.CreationTime.Date == DateTime.Today)
                {
                    dt.Rows.Add(file.CreationTime, file.Name);
                }
            }

            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
            lbl_current.Text = "Today\'s Filter";

        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Monthly Filter";
            string[] files = Directory.GetFiles(Includes.AppSettings.Doc_DIR);
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("File Name");

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);

                if (file.CreationTime.Date >= DateTime.Today.AddMonths(-1))
                {
                    dt.Rows.Add(file.CreationTime, file.Name);
                }
            }

            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Yearly Filter";
            string[] files = Directory.GetFiles(Includes.AppSettings.Doc_DIR);
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("File Name");

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);

                if (file.CreationTime.Date >= DateTime.Today.AddYears(-1))
                {
                    dt.Rows.Add(file.CreationTime, file.Name);
                }
            }

            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void inboundSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Inbound Summary";
            string[] files = Directory.GetFiles(path, "Inbound Summary*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void outboundSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Outbound Summary";
            string[] files = Directory.GetFiles(path, "Outbound Summary*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void returnSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_current.Text = "Returned Summary";
            string[] files = Directory.GetFiles(path, "Return Summary*");

            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Name", typeof(string));

            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row["Date"] = File.GetCreationTime(file);
                row["Name"] = Path.GetFileName(file);
                dt.Rows.Add(row);
            }
            // Sort the DataTable by the "Date" column in descending order
            dt.DefaultView.Sort = "Date DESC";
            dt = dt.DefaultView.ToTable();

            // Bind the sorted DataTable to the DataGridView
            dtg_batch_form.DataSource = dt;
            DTG_Properties();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            files = Directory.GetFiles(Includes.AppSettings.Doc_DIR);
            int count = files.Length;

            if (count > 0)
            {
                if (!IsDisposed && IsHandleCreated)
                {
                    if (dtg_batch_form != null)
                    {
                        PATH();
                        DTG_Properties();
                    }
                }
            }
        }


        private void dtg_batch_form_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            chk_Select_all.Checked = false;
            if (dtg_batch_form.Rows.Count > 0)
            {
                string file = Includes.AppSettings.Doc_DIR + dtg_batch_form.CurrentRow.Cells[1].Value.ToString();
                System.Diagnostics.Process.Start(file);
            }
        }

        private void Batch_Form_Load(object sender, EventArgs e)
        {
            this.Refresh();
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
