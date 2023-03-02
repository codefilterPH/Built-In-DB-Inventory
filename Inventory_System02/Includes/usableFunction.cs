using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Inventory_System02.Includes;
using Microsoft.Reporting.WinForms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using Inventory_System02.Reports_Dir;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Inventory_System02.Includes
{
    class usableFunction
    {

        

        //initialize the validating method
        static Regex Valid_Name = StringOnly();
        static Regex Valid_Contact = NumbersOnly();
        static Regex Valid_Password = ValidPassword();
        static Regex Valid_Email = Email_Address();



        //Method for validating email address
        private static Regex Email_Address()
        {
            string Email_Pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(Email_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for string validation only
        private static Regex StringOnly()
        {
            string StringAndNumber_Pattern = "^[a-zA-Z]";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for numbers validation only
        private static Regex NumbersOnly()
        {
            string StringAndNumber_Pattern = "^[0-9]*$";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        private void FormatPhoneNumber(MaskedTextBox maskedTextBox)
        {
            string phoneNumber = maskedTextBox.Text.Replace(" ", "").Replace("-", "");

            if (phoneNumber.Length == 11 && phoneNumber.StartsWith("63"))
            {
                phoneNumber = phoneNumber.Substring(1);
                maskedTextBox.Text = string.Format("{0:0000-###-####}", Convert.ToInt64(phoneNumber));
            }
        }

        //Method for password validation only
        private static Regex ValidPassword()
        {
            string Password_Pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(Password_Pattern, RegexOptions.IgnoreCase);
        }

        //my func
        public void clearTxt(Control container)
        {
            try
            {
                //'for each txt as control in this(object).control
                foreach (Control txt in container.Controls)
                {
                    //conditioning the txt as control by getting it's type.
                    //the type of txt as control must be textbox.
                    if (txt is TextBox)
                    {
                        //if the object(textbox) is present. The result is, the textbox will be cleared.
                        txt.Text = "";
                    }
                    if (txt is RichTextBox)
                    {
                        txt.Text = "";
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ResponsiveDtg(DataGridView dtg)
        {
            dtg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        //textboxes
        public void TextBox_Readonly(object sender, EventArgs e, TextBox txt)
        {
            txt.ReadOnly = true;
        }
        public void KeyPress_Textbox_Numberonly(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public void KeyPress_Textbox_NumbersOnlyNoDot(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' || e.KeyChar == ' ')
            {
                e.Handled = true; // prevent the dot or space from being entered
            }
        }
        public void Make_Numeric_Only(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public void Make_Alphanumeric_TextBox(object sender, KeyPressEventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z ]", "");
            textboxSender.SelectionStart = cursorPosition;
        }
        public void Numbers_and_Hyphen_Only(object sender, KeyPressEventArgs e)
        {

            Regex reg = new Regex(@"^[0-9-]*$");
            bool textChangedByKey;
            string lastText;

            TextBox senderTB = sender as TextBox;
            if (char.IsControl(e.KeyChar)) return;
            if (!reg.IsMatch(senderTB.Text.Insert(senderTB.SelectionStart, e.KeyChar.ToString()) + "1"))
            {
                e.Handled = true;
                return;
            }
            textChangedByKey = true;


            if (!textChangedByKey)
            {
                if (!reg.IsMatch(senderTB.Text))
                {
                    return;
                }
            }
            else
            {
                textChangedByKey = false;
                lastText = senderTB.Text;
            }

        }
        public void Philippine_Mobile(object sender, EventArgs e)
        {
            /*
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, @"^(09 |\+639)\d{ 9}$", "");
            textboxSender.SelectionStart = cursorPosition;
            */


        }
        public void Two_Decimal_Places(object sender, EventArgs e, TextBox txt)
        {
            if (txt.Text == "" || txt.Text == null)
            {
                txt.Text = "0.00";
            }
            else
            {
                txt.Text = String.Format("{0:N2}", double.Parse(txt.Text));
            }

        }
        public void Label_Two_Decimal_Places(object sender, EventArgs e, Label lbl)
        {
            if (lbl.Text == "" || lbl.Text == null)
            {
                lbl.Text = "0.00";
            }
            else
            {
                lbl.Text = String.Format("{0:N2}", double.Parse(lbl.Text));
            }

        }
        //dtg
        public void Datagrid_Setup(DataGridView dtg)
        {
            if (dtg.Rows.Count > 0)
            {
                if (dtg.Columns.Count >= 5)
                {
                    dtg.AutoGenerateColumns = false;
                    dtg.AutoSize = false;
                    dtg.EnableHeadersVisualStyles = false;
                    dtg.ScrollBars = ScrollBars.Both;
                }
                else if (dtg.Columns.Count < 5)
                {
                    ResponsiveDtg(dtg);
                    dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }
        }
        public void Font_size_change(Form frm)
        {
            if (frm.Width > 1400 || frm.Height > 1000)
            {

            }

        }
       
        public string Error_Message1;
        public void Error_Message()
        {
            MessageBox.Show(Error_Message1 + " must not empty", "Empty Field Message",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;

        }
        string ext;
        public void Reload_Images(PictureBox pictureBox1, string ID, string Brand)
        {
            //Brand is either Employee, Company, Staff, Cust FOLDER PATH
            try
            {
                try
                {
                    ext = Path.GetExtension(Brand + ID);
                }
                catch
                {
                    if (ext == "")
                    {
                        ext = ".PNG";
                    }
                }

                try
                {
                    FileStream fs = new System.IO.FileStream(Brand + ID + ext, FileMode.Open, FileAccess.Read);
                    pictureBox1.Image = Image.FromStream(fs);
                    fs.Close();
                }
                catch
                {
                    try
                    {
                        FileStream fs = new System.IO.FileStream(Brand + ID + ".PNG", FileMode.Open, FileAccess.Read);
                        pictureBox1.Image = Image.FromStream(fs);
                        fs.Close();
                    }
                    catch
                    {
                        FileStream fs = new System.IO.FileStream(Brand + ID + ".JPG", FileMode.Open, FileAccess.Read);
                        pictureBox1.Image = Image.FromStream(fs);
                        fs.Close();
                    }
            
                }

            }
            catch
            {
                try
                {
                    FileStream fs = new System.IO.FileStream(Brand + @"DONOTDELETE_SUBIMAGE" + ext, FileMode.Open, FileAccess.Read);
                    pictureBox1.Image = Image.FromStream(fs);
                    fs.Close();
                }
                catch
                {
                    try
                    {
                        FileStream fs = new System.IO.FileStream(Brand + @"DONOTDELETE_SUBIMAGE.PNG", FileMode.Open, FileAccess.Read);
                        pictureBox1.Image = Image.FromStream(fs);
                        fs.Close();
                    }
                    catch
                    {
                        FileStream fs = new System.IO.FileStream(Brand + @"DONOTDELETE_SUBIMAGE.JPG", FileMode.Open, FileAccess.Read);
                        pictureBox1.Image = Image.FromStream(fs);
                        fs.Close();
                    }
      
                }

            }
        }
       string dateText, table11;
        public void Limit_to_Oldest_Item_date(object sender, EventArgs e, string txt, string report_table)
        {
            if (report_table == "Stock In")
            {
                table11 = "`Stocks`";
            }
            else if (report_table == "Stock Out")
            {
                table11 = "`Stock Out`";
            }
            else if (report_table == "Stock Returned")
            {
                table11 = "`Stock Returned`";

            }

            SQLConfig config = new SQLConfig();
            string sql;
            sql = "Select `Entry Date` from " + table11 + " Desc limit 1";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                dateText = config.dt.Rows[0].Field<string>("Entry Date");


                DateTime dtTarget = default(DateTime); // (or) DateTime.MinValue , use this for comparision
                if (DateTime.TryParseExact(txt, Includes.AppSettings.DateFormatRetrieve, CultureInfo.CurrentCulture, DateTimeStyles.None, out dtTarget))
                {
                    if (DateTime.ParseExact(txt, Includes.AppSettings.DateFormatRetrieve, null) < DateTime.ParseExact(dateText, Includes.AppSettings.DateFormatRetrieve, null))
                    {
                        MessageBox.Show("Time must be exact or greater than " + dateText, "First Item Date is " + dateText, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Date is not valid! It must be Includes.AppSettings.DateFormat", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else
            {
                txt = DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve);
            }
        }
        string appPath, filepath;
        public void DoubleClick_Picture_Then_Replace_Existing(PictureBox pic, string ID, string Brand)
        {

            if (ID == null || ID == "")
            {
                Error_Message1 = "ID";
                Error_Message();
                return;

            }
            try
            {
                ext = Path.GetExtension(Brand + ID);

            }
            catch
            {
                ext = Path.GetExtension(Brand + ID + ".PNG");
            }


            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = " All Files (*.*)|*.*|PNG files (*.PNG)|*.PNG|JPEG files (*.JPG)|*.JPG ";


            if (opFile.ShowDialog() == DialogResult.OK)
            {
                if (ext == "PNG files (*.PNG)|*.PNG" || ext == "JPEG files (*.JPG)|*.JPG" || ext == "")
                {
                    appPath = Brand;
                    if (Directory.Exists(appPath) == false)
                    {
                        Directory.CreateDirectory(appPath);
                    }
                    else
                    {
                        if (ID + ".PNG" != "DONOTDELETE_SUBIMAGE.PNG" || ID + ".JPG" != "DONOTDELETE_SUBIMAGE.PNG" || ID != "DONOTDELETE_SUBIMAGE")
                        {
                            if (MessageBox.Show("Are you sure to delete current picture and replace with new image?", "Deleting an existing image", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    System.IO.File.Delete(Brand + ID + ext);
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                    return;
                                }

                            }
                            else
                            {
                                return;
                            }
                        }



                    }
                }
                else
                {
                    MessageBox.Show("Invalid File! \n\n Select only .JPG or .PNG files", "Cannot Load Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    opFile.Dispose();
                    return;
                }


                try
                {

                    Bitmap bmp1 = new Bitmap(pic.Image);

                    if (System.IO.File.Exists(appPath + ID + ".PNG"))
                    {
                        System.IO.File.Delete(appPath + ID + ".PNG");


                    }
                    filepath = opFile.FileName;
                    File.Copy(filepath, appPath + ID + ".PNG"); // <---
                    pic.Image = new Bitmap(opFile.OpenFile());

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                    opFile.Dispose();
                    return;
                }
            }
            else
            {
                opFile.Dispose();
            }

        }
        public void DoubleClick_Picture_Then_Replace_Existing_FOR_JPEG(PictureBox pic, string ID, string Brand)
        {

            if (ID == null || ID == "")
            {
                Error_Message1 = "ID";
                Error_Message();
                return;

            }
            try
            {
                ext = Path.GetExtension(Brand + ID);

            }
            catch
            {
                ext = Path.GetExtension(Brand + ID + ".JPG");
            }


            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = " All Files (*.*)|*.*|PNG files (*.PNG)|*.PNG|JPEG files (*.JPG)|*.JPG ";


            if (opFile.ShowDialog() == DialogResult.OK)
            {
                if (ext == "PNG files (*.PNG)|*.PNG" || ext == "JPEG files (*.JPG)|*.JPG" || ext == "")
                {
                    appPath = Brand;
                    if (Directory.Exists(appPath) == false)
                    {
                        Directory.CreateDirectory(appPath);
                    }
                    else
                    {
                        if (ID + ".PNG" != "DONOTDELETE_SUBIMAGE.PNG" || ID + ".JPG" != "DONOTDELETE_SUBIMAGE.PNG" || ID != "DONOTDELETE_SUBIMAGE")
                        {
                            if (MessageBox.Show("Are you sure to delete current picture and replace with new image?", "Deleting an existing image", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    System.IO.File.Delete(Brand + ID + ext);
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                    return;
                                }

                            }
                            else
                            {
                                return;
                            }
                        }



                    }
                }
                else
                {
                    MessageBox.Show("Invalid File! \n\n Select only .JPG or .PNG files", "Cannot Load Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    opFile.Dispose();
                    return;
                }


                try
                {

                    Bitmap bmp1 = new Bitmap(pic.Image);

                    if (System.IO.File.Exists(appPath + ID + ".JPG"))
                    {
                        System.IO.File.Delete(appPath + ID + ".JPG");


                    }
                    filepath = opFile.FileName;
                    File.Copy(filepath, appPath + ID + ".JPG"); // <---
                    pic.Image = new Bitmap(opFile.OpenFile());

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                    opFile.Dispose();
                    return;
                }
            }
            else
            {
                opFile.Dispose();
            }

        }
        public void email_validation(string txt)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Match m = Regex.Match(txt, pattern, RegexOptions.IgnoreCase);
            if (m.Success == false)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        int Due1 = 0; string Due;
        public void Due_Date_Warranty (string TransRef)
        {

            SQLConfig config = new SQLConfig();
            string sql;

            sql = "Select Warranty from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                Due1 = Convert.ToInt32(config.dt.Rows[0]["Warranty"]);

            }         
            Due = DateTime.Now.AddDays(Due1).ToString(Includes.AppSettings.DateFormatRetrieve);     
            
            sql = "Select * from `Stock Out` where `Transaction Reference` = '" + TransRef + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                sql = "Update `Stock Out` set `Warranty Due Date` = '" + Due + "' where `Transaction Reference` = '" + TransRef + "' ";
                config.singleResult(sql);
            }

        }
        public void NumbersOnlyDTG_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void Change_Font_DTG(object sender, DataGridViewCellEventArgs e, DataGridView dtg)
        {
            foreach (DataGridViewRow c in dtg.Rows)
            {
                if (c.Selected)
                {
                    c.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                }
                else 
                {
                    c.DefaultCellStyle.Font = new Font("Segoe UI", (float)9.75, FontStyle.Regular);
                }

            }

        }
        double count1 = 0;
        public void Count_person(DataGridView dtg, Label tx)
        {
            for (int i = 0; i < dtg.Rows.Count; i++)
            {
                count1 = i;
            }
            count1 += 1;
            tx.Text = count1.ToString();
        }

        public void Select_All_Dtg( DataGridView dtg, CheckBox bx)
        {
            if (dtg.RowCount > 0)
            {
                if (bx.Checked == true)
                {
                    dtg.SelectAll();
                }
                else
                {
                    bx.Checked = false;
                    dtg.ClearSelection();
                }
            }
        }
   


    }
}
