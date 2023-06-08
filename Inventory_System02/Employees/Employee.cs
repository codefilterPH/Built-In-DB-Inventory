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

        public Employees(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;


        }
        private void Error_PermissionDenied()
        {
            MessageBox.Show("You do not have permission to perform this action.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "" || txt_ID.Text == null)
            {
                func.Error_Message1 = "ID";
                func.Error_Message();
                btn_GenID.Focus();
            }
            else if (txt_Pass.Text == "" || txt_Pass.Text == null)
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
            else if (JobRole == "Programmer/Developer" || JobRole == "Office Manager")
            {
                if (JobRole == "Programmer/Developer" && txt_Job_role.Text == "Programmer/Developer")
                {
                    Error_PermissionDenied();
                    return;
                }
                else if (JobRole == "Office Manager" && txt_Job_role.Text == "Programmer/Developer")
                {
                    Error_PermissionDenied();
                    return;
                }

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
                    ", SHA512('" + txt_Pass.Text + "') " +
                    ", '" + txt_FN.Text + "' " +
                    ", '" + txt_LN.Text + "' " +
                    ", '" + txt_Email.Text + "' " +
                    ", '" + txt_Phone.Text + "' " +
                    ", '" + txt_Address.Text + "' " +
                    ", '" + txt_Job_role.Text + "' ) ";
                    config.Execute_CUD(sql, "Unsuccessful to Record " + txt_Job_role.Text, "Successfully recorded " + txt_Job_role.Text);
                    return;
                }
                else
                {
                    MessageBox.Show("This user is already added to the Database!", "Unable to add duplicate user", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            else
            {
                Error_PermissionDenied();
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
            func.Reload_Images(pictureBox1, "DONOTDELETE_SUBIMAGE", Includes.AppSettings.Employee_DIR);
            reloadTableToolStripMenuItem_Click(sender, e);
            txt_Job_role.DropDownStyle = ComboBoxStyle.DropDownList;
            timer1.Start();
        }
        private void reloadTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (JobRole == "Office Manager" || JobRole == "Programmer/Developer")
            {
                sql = "Select * from Employee WHERE `Employee ID` <> 'admin' ORDER BY `Hired Date` DESC";
            }
            else
            {
                sql = "Select * from Employee WHERE `Employee ID` == '" + Global_ID + "' and `Job Role` = '" + JobRole + "'";
            }

            config.Load_DTG(sql, dtg_User);
            Hideadmin_and_LoadImage();
        }
        private void Hideadmin_and_LoadImage()
        {
            if (dtg_User.Columns.Count > 0)
            {
                dtg_User.Columns[0].Visible = false;
                if (!config.dt.Columns.Contains("Image"))
                {
                    config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
                }
                int visibleRowCount = 0;
                foreach (DataGridViewRow row in dtg_User.Rows)
                {
                    if (row.Cells[2].Value != null && row.Cells[2].Value.ToString().Equals("admin"))
                    {
                        if (Global_ID != "admin")
                        {
                            row.Visible = false;
                        }
                    }
                    if (row.Visible)
                    {
                        visibleRowCount++;
                    }
                }
                lbl_total_emp.Text = visibleRowCount.ToString();

                string image_path = Includes.AppSettings.Employee_DIR + "\\";
                byte[] defaultImage = File.ReadAllBytes(image_path + "DONOTDELETE_SUBIMAGE.JPG");

                foreach (DataRow rw in config.dt.Rows)
                {
                    string imagePath = image_path + rw[2].ToString() + ".JPG";
                    byte[] imageBytes;

                    if (File.Exists(imagePath))
                    {
                        imageBytes = File.ReadAllBytes(imagePath);
                    }
                    else
                    {
                        imageBytes = defaultImage;
                    }

                    rw["Image"] = imageBytes;
                }


                dtg_User.Columns["Image"].DisplayIndex = 0;

                for (int i = 0; i < dtg_User.Columns.Count; i++)
                {
                    if (dtg_User.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dtg_User.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;

                        break;
                    }
                }
                dtg_User.Columns["Password"].Visible = false;
            }
            dtg_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtp_Hired_date.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve);
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
            MessageBox.Show("You cannot change or delete the Creator of this Application!", "Warning Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (dtg_User.Rows.Count >= 1)
            {
                if (dtg_User.SelectedRows.Count == 1)
                {
                    string userRole = dtg_User.CurrentRow.Cells[9].Value.ToString();
                    string userId = dtg_User.CurrentRow.Cells[2].Value.ToString();

                    if (JobRole == "Programmer/Developer")
                    {
                        if (userId == Global_ID || userRole == JobRole)
                        {
                            MessageBox.Show("You cannot delete your own account. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        else if (JobRole != userRole && userId != Global_ID)
                        {
                            if (MessageBox.Show("Are you sure you want to delete " + txt_FN.Text + "?", "Warning Deletion Prompt",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                sql = "Delete from Employee where `Employee ID` = '" + userId + "' ";
                                config.Execute_CUD(sql, "Unable to delete employee " + dtg_User.CurrentRow.Cells[4].Value.ToString() + "!", "Successfully deleted employee " + dtg_User.CurrentRow.Cells[4].Value.ToString() + "!");
                                reloadTableToolStripMenuItem_Click(sender, e);
                            }
                        }
                        else
                        {
                            MessageBox.Show("You don't have permission to delete this account. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    else if (JobRole == "Office Manager")
                    {
                        if (userId == Global_ID && userRole == JobRole)
                        {
                            MessageBox.Show("You cannot delete your own account. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        else if (userId != Global_ID && userRole != "Programmer/Developer")
                        {
                            if (MessageBox.Show("Are you sure you want to delete " + txt_FN.Text + "?", "Warning Deletion Prompt",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                sql = "Delete from Employee where `Employee ID` = '" + userId + "' ";
                                config.Execute_CUD(sql, "Unable to delete employee " + dtg_User.CurrentRow.Cells[4].Value.ToString() + "!", "Successfully deleted employee " + dtg_User.CurrentRow.Cells[4].Value.ToString() + "!");
                                reloadTableToolStripMenuItem_Click(sender, e);
                            }
                        }
                        else
                        {
                            MessageBox.Show("You don't have permission to delete this account. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    else // job role is not admin or manager
                    {
                        if (JobRole != "Office Manager" || JobRole != "Programmer/Developer")
                        {
                            MessageBox.Show("You don't have permission to delete this account. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                }
                else if (dtg_User.SelectedRows.Count > 1)
                {
                    MessageBox.Show("You cannot delete multiple accounts. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else if (dtg_User.SelectedRows.Count <= 0)
                {
                    dtg_User.CurrentRow.Selected = true;
                }
            }

        }

        private void PersonExistsVerifier(object sender, EventArgs e)
        {
            //When user clicks the update button and if the user not exists it will create the person instead
            sql = "Select * from Employee where `Employee ID` = '" + txt_ID.Text + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count < 1)
            {
                btn_Add_Click(sender, e);
                return;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_ID.Text))
            {
                if (txt_ID.Text == "admin")
                {
                    if (Global_ID != "admin")
                    {
                        Error_DeletingSuper_User();
                    }
                }
                else if (txt_Job_role.Text == JobRole && txt_ID.Text == Global_ID)
                {
                    PersonExistsVerifier(sender, e);
                    // Allow the user to update their own account
                    if (MessageBox.Show("Are you sure to update your profile? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        // Perform the update
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
                        reloadTableToolStripMenuItem_Click(sender, e);
                    }
                }
                else if (JobRole == "Programmer/Developer" || JobRole == "Office Manager")
                {
                    PersonExistsVerifier(sender, e);
                    // Allow managers and admin to update other employees' accounts
                    if (MessageBox.Show("Are you sure to update this user? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        // Perform the update
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
                        reloadTableToolStripMenuItem_Click(sender, e);
                    }
                }
                else
                {
                    // Don't allow other employees to update accounts
                    MessageBox.Show("You do not have permission to update this account.", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (JobRole == "Office Manager" || JobRole == "Programmer/Developer")
            {
                func.clearTxt(panel2);
                btn_GenID_Click(sender, e);
                txt_ID.Focus();
                txt_ID.SelectionLength = txt_ID.Text.Length;
            }
            else
            {
                // Don't allow other employees to update accounts
                MessageBox.Show("You do not have permission to add new profile.", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }


        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_ID.Text))
            {
                if (JobRole == "Programmer/Developer")
                {
                    // Allow admin to change the picture of anyone, including themselves
                    pictureBox1_DoubleClick(sender, e);
                }
                else if (JobRole == "Office Manager")
                {
                    // Allow manager to change the picture of anyone except admin
                    if (txt_Job_role.Text != "Programmer/Developer")
                    {
                        pictureBox1_DoubleClick(sender, e);
                    }
                    else
                    {
                        Error_PermissionDenied();
                    }
                }
                else
                {
                    // Others can only change their own picture
                    if (txt_ID.Text == Global_ID && txt_Job_role.Text == JobRole)
                    {
                        pictureBox1_DoubleClick(sender, e);
                    }
                    else
                    {
                        Error_PermissionDenied();
                    }
                }
            }

        }

        private void btn_Change_pass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Pass.Text))
            {
                MessageBox.Show("Password is empty", "Nothing to Change", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Global_ID == "admin")
            {
                // Admin can change password for any employee
                if (txt_ID.Text == Global_ID || JobRole == "Programmer/Developer")
                {
                    if (MessageBox.Show("Are you sure you want to update your password? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (string.IsNullOrWhiteSpace(txt_Pass.Text))
                        {
                            func.Error_Message1 = "Password";
                            func.Error_Message();
                            txt_Pass.Focus();
                            return;
                        }
                        string sql = "UPDATE Employee SET Password = SHA512('" + txt_Pass.Text + "') WHERE `Employee ID` = '" + txt_ID.Text + "' ";
                        config.Execute_CUD(sql, "Unable to update password! Please contact your administrator.", "Password successfully updated!");
                    }
                    reloadTableToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Only administrators and programmers/developers can update passwords for their own accounts. Thank you!", "No permission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (JobRole == "Office Manager")
            {
                // Office Manager can change password for all employees except admin
                if (txt_ID.Text == "admin")
                {
                    MessageBox.Show("You don't have permission to change the password of the admin account. Thank you!", "No permission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update your password? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txt_Pass.Text))
                    {
                        func.Error_Message1 = "Password";
                        func.Error_Message();
                        txt_Pass.Focus();
                        return;
                    }
                    string sql = "UPDATE Employee SET Password = SHA512('" + txt_Pass.Text + "') WHERE `Employee ID` = '" + txt_ID.Text + "' ";
                    config.Execute_CUD(sql, "Unable to update password! Please contact your administrator.", "Password successfully updated!");
                }
                reloadTableToolStripMenuItem_Click(sender, e);
            }
            else if (JobRole == "Programmer/Developer")
            {
                // Programmer/Developer can change their own password
                if (txt_ID.Text == Global_ID)
                {
                    if (MessageBox.Show("Are you sure you want to update your password? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (string.IsNullOrWhiteSpace(txt_Pass.Text))
                        {
                            func.Error_Message1 = "Password";
                            func.Error_Message();
                            txt_Pass.Focus();
                            return;
                        }
                        string sql = "UPDATE Employee SET Password = SHA512('" + txt_Pass.Text + "') WHERE `Employee ID` = '" + txt_ID.Text + "' ";
                        config.Execute_CUD(sql, "Unable to update password! Please Contact your Administrator.", "Password successfully updated!");
                    }
                    reloadTableToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("You don't have permission to change password of other employees. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from Employee WHERE ( `Employee ID` LIKE '%" + txt_Search.Text + "%' OR `First Name` LIKE '%" + txt_Search.Text + "%' OR `Last Name` LIKE '%" + txt_Search.Text + "%' OR `Job Role` LIKE '%" + txt_Search.Text + "%' ) AND `Employee ID` != 'admin' AND `Job Role` != 'Programmer/Developer' ORDER BY `Hired Date` DESC";
            config.Load_DTG(sql, dtg_User);
            Hideadmin_and_LoadImage();
        }

        private void dtg_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_User.Rows.Count > 0)
            {
                dtp_Hired_date.Text = dtg_User.CurrentRow.Cells[1].Value.ToString();
                txt_ID.Text = dtg_User.CurrentRow.Cells[2].Value.ToString();
                txt_FN.Text = dtg_User.CurrentRow.Cells[4].Value.ToString();
                txt_LN.Text = dtg_User.CurrentRow.Cells[5].Value.ToString();
                txt_Email.Text = dtg_User.CurrentRow.Cells[6].Value.ToString();
                txt_Phone.Text = dtg_User.CurrentRow.Cells[7].Value.ToString();
                txt_Address.Text = dtg_User.CurrentRow.Cells[8].Value.ToString();
                txt_Job_role.Text = dtg_User.CurrentRow.Cells[9].Value.ToString();

                func.Reload_Images(pictureBox1, txt_ID.Text, Includes.AppSettings.Employee_DIR);
                func.Change_Font_DTG(sender, e, dtg_User);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sql = "Select Type from `Employee Role` WHERE Type <> 'Programmer/Developer'";
            dtp_Hired_date.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve);
            config.fiil_CBO(sql, txt_Job_role);
            timer1.Stop();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            func.DoubleClick_Picture_Then_Replace_Existing(pictureBox1, txt_ID.Text, Includes.AppSettings.Employee_DIR);
            reloadTableToolStripMenuItem_Click(sender, e);
            reloadTableToolStripMenuItem_Click(sender, e);
            timer1.Start();

        }
    }
}
