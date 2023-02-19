using Inventory_System02.Includes;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;



namespace Inventory_System02
{
    public partial class Batch_Form : Form
    {
        SQLConfig config = new SQLConfig();
        string Global_ID, Fullname, JobRole;
        public Batch_Form(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;

         
        }

        public void PATH()
        {

            string[] files = Directory.GetFiles(@"CommonSql\Document Center Files");
            //string[] files = Directory.GetFiles(@"\\" + config.computerName + @"\DB\BATCH FILES");
            //if (File.Exists(@"CommonSql\Document Center Files\"))
            //{

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
            dataGridView1.DataSource = dt;
            // }  
        }
        string what_to_del = string.Empty;
        private void chk_Select_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Select_all.Checked)
            {
                foreach (DataGridViewRow rw in dataGridView1.Rows)
                {
                    rw.Selected = true;
                    what_to_del = "all";
                }
            }
            else
            {
                foreach (DataGridViewRow rw in dataGridView1.Rows)
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

            if (dataGridView1.Rows.Count > 0)
            {
                Load_to_Adobe();
            }

        }
        private void Load_to_Adobe()
        {
            string file = @"CommonSql\Document Center Files\" + dataGridView1.CurrentRow.Cells[1].Value.ToString();
            axAcroPDF1.LoadFile(file);
        }
        private void btn_Delete_Click_1(object sender, EventArgs e)
        {

            string dir = @"CommonSql\Document Center Files";
            if (what_to_del == "all")
            {
                if (MessageBox.Show("Are you sure to delete all files?", "Deletion Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                      DialogResult.Yes)
                {
                    string[] files = Directory.GetFiles(@"CommonSql\Document Center Files");
                    foreach (string file in files)
                    {
                        File.Delete(file);
                        PATH();
                    }
                    MessageBox.Show("Files are deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else if (what_to_del == "specific")
            {
                // Delete specific files in a directory              
                try
                {
                    string filename1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    // Check if file exists with its full path    
                    if (File.Exists(Path.Combine(dir, filename1)))
                    {
                        // If file found, delete it   
                        if (MessageBox.Show("Delete this " + filename1 + "?", "Deletion Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                       DialogResult.Yes)
                        {
                            File.Delete(Path.Combine(dir, filename1));
                            PATH();
                            MessageBox.Show(filename1 + " is deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            what_to_del = "";
        }
     
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewColumn newColumn = dataGridView1.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dataGridView1.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dataGridView1.SortOrder == SortOrder.Ascending)
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
            dataGridView1.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Put each of the columns into programmatic sort mode.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void Batch_Form_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"CommonSql\Document Center Files");
            int count = files.Length;

            if (count > 0)
            {
                PATH();

                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
             //  dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                if (dataGridView1.Rows.Count > 0)
                {
                    Load_to_Adobe();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            chk_Select_all.Checked = false;
            if (dataGridView1.Rows.Count > 0)
            {
                string file = @"CommonSql\Document Center Files\" + dataGridView1.CurrentRow.Cells[1].Value.ToString();
                System.Diagnostics.Process.Start(file);
            }

        }
    }
}
