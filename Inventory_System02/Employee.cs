using Inventory_System02.Includes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Inventory_System02.Profiles
{
    public partial class Employees : Form
    {
        SQLConfig config = new SQLConfig();
        ID_Generator gen = new ID_Generator();
        usableFunction func = new usableFunction();
        string sql, Global_ID, Fullname, JobRole;

        string emp_image_location = string.Empty;
        public Employees(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;

            emp_image_location = @"CommonSql\Pictures\Employee\";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "" || txt_ID.Text == null)
            {
                func.Error_Message1 = "ID";
                func.Error_Message();
                btn_GenID.Focus();
            }
            else if (txt_FN.Text == "" || txt_FN.Text == null)
            {
                func.Error_Message1 = "Password";
                func.Error_Message();
                txt_Pass.Focus();
            }
            else if (txt_FN.Text == "" || txt_FN.Text == null)
            {
                func.Error_Message1 = "First Name";
                func.Error_Message();
                txt_FN.Focus();
            }
            else
            {
                sql = "Select * from Employee where `Employee ID` = '" + txt_ID.Text + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count < 1)
                {
                    sql = "Insert into Employee (" +
                   " `Hired Date` " +
                   ",  `Employee ID`" +
                   ", `Password`" +
                   ", `First Name` " +
                   ", `Last Name` " +
                   ", `Email` " +
                   ", `Phone Number` " +
                   ", `Address` " +
                   ", `Job Role` ) values  ( " +
                   " '" + dtp_Hired_date.Text + "' " +
                   ", '" + txt_ID.Text + "' " +
                   ", sha1('" + txt_Pass.Text + "') " +
                   ", '" + txt_FN.Text + "' " +
                   ", '" + txt_LN.Text + "' " +
                   ", '" + txt_Email.Text + "' " +
                   ", '" + txt_Phone.Text + "' " +
                   ", '" + txt_Address.Text + "' " +
                   ", '" + txt_Job_role.Text + "' ) ";
                    config.Execute_CUD(sql, "Unsuccessful to Record " + txt_Job_role.Text, "Successfully recorded " + txt_Job_role.Text);
                }
                else
                {
                    MessageBox.Show("This user is already added to the Database!", "Unable to add duplicate user", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            reloadTableToolStripMenuItem_Click(sender, e);
        }


        private void btn_GenID_Click(object sender, EventArgs e)
        {
            gen.Employee_ID();
            sql = "Select `User ID` from ID_Generated where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txt_ID.Text = config.dt.Rows[0].Field<string>("User ID");
            }

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            func.Reload_Images(pictureBox1, "DONOTDELETE_SUBIMAGE", @"CommonSql\Pictures\Employee\");
            reloadTableToolStripMenuItem_Click(sender, e);
            timer1.Start();
        }
        double count1 = 0;
        private void reloadTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "Select * from Employee";
            config.Load_DTG(sql, dtg_User);

            if (dtg_User.Columns.Count > 0)
            {
                dtg_User.Columns[0].Visible = false;
                if (Global_ID != "admin")
                {
                    dtg_User.Rows.RemoveAt(0);
                }

                config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));


                foreach (DataRow rw in config.dt.Rows)
                {
                    try
                    {
                        if (File.Exists(emp_image_location + rw[2].ToString() + ".JPG"))
                        {
                            rw["Image"] = File.ReadAllBytes(emp_image_location + rw[2].ToString() + ".JPG");
                        }
                        else
                        {
                            rw["Image"] = File.ReadAllBytes(emp_image_location + "DONOTDELETE_SUBIMAGE.JPG");
                        }
                    }
                    catch
                    {
                        for (int i = 0; i < dtg_User.Rows.Count; i++)
                        {
                            if (File.Exists(emp_image_location + dtg_User.Rows[i].Cells[2].ToString() + ".JPG"))
                            {
                                rw["Image"] = File.ReadAllBytes(emp_image_location + dtg_User.Rows[i].Cells[2].ToString() + ".JPG");
                            }
                            else
                            {
                                if (0 == dtg_User.Rows.Count)
                                {
                                    rw["Image"] = File.ReadAllBytes(emp_image_location + "DONOTDELETE_SUBIMAGE.JPG");
                                }
                            }
                        }
                    }

                }

                dtg_User.Columns["Image"].DisplayIndex = 0;

                for (int i = 0; i < dtg_User.Columns.Count; i++)
                {
                    if (dtg_User.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dtg_User.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                        break;
                    }
                }
                for (int i = 0; i < dtg_User.Rows.Count; i++)
                {
                    count1 = i;
                }
                count1 += 1;
                lbl_total_emp.Text = count1.ToString();
            }
            dtg_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtp_Hired_date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            timer1.Start();
        }

        private void txt_Phone_MouseLeave(object sender, EventArgs e)
        {
            func.Philippine_Mobile(sender, e);
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            func.email_validation(txt_Email.Text);
        }

        private void btn_Clear_Text_Click(object sender, EventArgs e)
        {
            func.clearTxt(panel2);
        }
        private void Error_DeletingSuper_User()
        {
            MessageBox.Show("You cannot change the Creator of this Application!", "Warning Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "" || txt_ID.Text == null)
            {
                usableFunction func = new usableFunction();
                func.Error_Message1 = "ID";
                func.Error_Message();
                txt_ID.Focus();
            }
            else if (txt_ID.Text == "admin")
            {
                Error_DeletingSuper_User();
            }
            else
            {
                if ( MessageBox.Show("Are you sure you want to delete "+ txt_FN.Text +"?", "Warning Deletion Prompt",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql = "Delete from Employee where `Employee ID` = '" + txt_ID.Text + "' ";
                    config.Execute_CUD(sql, "Unsuccessful deletion of profile!", "Profile successfully deleted!");
                }     
            }
            reloadTableToolStripMenuItem_Click(sender, e);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {     
            if (txt_ID.Text == "admin")
            {
                if ( Global_ID != "admin")
                {
                    Error_DeletingSuper_User();
                }
            }
            else
            { 

                if (MessageBox.Show("Are you sure to update this user? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
                {
                    if (txt_ID.Text == "" || txt_ID.Text == null)
                    {
                        func.Error_Message1 = "ID";
                        func.Error_Message();
                        txt_ID.Focus();
                        return;
                    }
                    else if (txt_FN.Text == "" || txt_FN.Text == null)
                    {
                        func.Error_Message1 = "Last Name";
                        func.Error_Message();
                        txt_FN.Focus();
                        return;
                    }
                    else
                    {
                        sql = "Update Employee set " +
                        " `Hired Date` = '" + dtp_Hired_date.Text + "' " +
                        ", `First Name` = '" + txt_FN.Text + "'" +
                        ", `Last Name` = '" + txt_LN.Text + "' " +
                        ", `Email` = '" + txt_Email.Text + "' " +
                        ", `Phone Number` = '" + txt_Phone.Text + "' " +
                        ", `Address` = '" + txt_Address.Text + "' " +
                        ", `Job Role` = '" + txt_Job_role.Text + "' " +
                        " where `Employee ID` = '" + txt_ID.Text + "' ";
                        config.Execute_CUD(sql, "Unable to update profile", "Profile successfully updated!");

                    }
                }
                reloadTableToolStripMenuItem_Click(sender, e);
            }
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func.clearTxt(panel2);
            btn_GenID_Click(sender, e);
            txt_ID.Focus();
            txt_ID.SelectionLength = txt_ID.Text.Length;

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            pictureBox1_DoubleClick(sender, e);
        }

        private void btn_Change_pass_Click(object sender, EventArgs e)
        {
            if (Global_ID != "admin")
            {
                Error_DeletingSuper_User();
            }
            else
            {

                if (MessageBox.Show("Are you sure to update your password? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
                {
                    if (txt_Pass.Text == "" || txt_Pass.Text == null)
                    {
                        func.Error_Message1 = "First Name";
                        func.Error_Message();
                        txt_FN.Focus();
                        return;
                    }
                    sql = "Update Employee set " +
                        " `Password` = sha1('" + txt_Pass.Text + "') " +
                        " where `Employee ID` = '" + txt_ID.Text + "' ";
                    config.Execute_CUD(sql, "Unable to update password! Please Contact your Administrator.", "Password successfully updated!");
                }
                reloadTableToolStripMenuItem_Click(sender, e);
            }
        }

        private void dtg_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_User.Rows.Count > 0)
            {
                dtp_Hired_date.Text = dtg_User.CurrentRow.Cells[1].Value.ToString();
                txt_ID.Text = dtg_User.CurrentRow.Cells[2].Value.ToString();
                txt_Pass.Text = dtg_User.CurrentRow.Cells[3].Value.ToString();
                txt_FN.Text = dtg_User.CurrentRow.Cells[4].Value.ToString();
                txt_LN.Text = dtg_User.CurrentRow.Cells[5].Value.ToString();
                txt_Email.Text = dtg_User.CurrentRow.Cells[6].Value.ToString();
                txt_Phone.Text = dtg_User.CurrentRow.Cells[7].Value.ToString();
                txt_Address.Text = dtg_User.CurrentRow.Cells[8].Value.ToString();
                txt_Job_role.Text = dtg_User.CurrentRow.Cells[9].Value.ToString();

                func.Reload_Images(pictureBox1, txt_ID.Text, @"CommonSql\Pictures\Employee\");
                func.Change_Font_DTG(sender, e, dtg_User);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sql = "Select Type from `Employee Role`";
            config.fiil_CBO(sql, txt_Job_role);
            timer1.Stop();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            func.DoubleClick_Picture_Then_Replace_Existing_FOR_JPEG(pictureBox1, txt_ID.Text, @"CommonSql\Pictures\Employee\");
            reloadTableToolStripMenuItem_Click(sender, e);
            reloadTableToolStripMenuItem_Click(sender, e);
            timer1.Start();

        }
    }
}
