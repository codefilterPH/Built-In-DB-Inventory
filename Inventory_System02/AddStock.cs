using Inventory_System02.Includes;
using Inventory_System02.Items;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;

namespace Inventory_System02
{
    public partial class AddStock : Form
    {
        Invoice_Code.Invoice_Code rdlc = new Invoice_Code.Invoice_Code();
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        Calculations cal = new Calculations();
        ID_Generator gen = new ID_Generator();
        string sql, Item_ID1, Global_ID, Fullname, JobRole, item_image_location = string.Empty, img_loc = string.Empty;
        public AddStock(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;

            item_image_location = @"CommonSql\Pictures\Item\Image\";

        }

        private void definitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings(Global_ID, Fullname, JobRole);
            frm.ShowDialog();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            sql = "Select Name from `Product Name`";
            config.fiil_CBO(sql, txt_ItemName);

            sql = "Select Name from Brand";
            config.fiil_CBO(sql, cbo_brand);

            sql = "Select * from Stocks order by `Entry Date` desc";
            config.Load_DTG(sql, dtg_Items);
            if (config.dt.Rows.Count > 0)
            {
                DTG_Property();
            }
            Calculator_Timer.Start();
            func.Reload_Images(Item_Image, txt_Barcode.Text, item_image_location);



        }
        double totalrows = 0;
        private void DTG_Property()
        {
            this.dtg_Items.Columns[6].DefaultCellStyle.Format = "0.00";

            //Format to date dtg cell
            dtg_Items.Columns["Entry Date"].DefaultCellStyle.Format = "dd-MM-yyyy";
            //sorting
            dtg_Items.Sort(dtg_Items.Columns["Entry Date"], ListSortDirection.Descending);


            dtg_Items.Columns[0].Visible = false;
            dtg_Items.Columns[8].Visible = false;

            config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));

            foreach (DataRow rw in config.dt.Rows)
            {
                if (File.Exists(rw[8].ToString()))
                {
                    rw["Image"] = File.ReadAllBytes(rw[8].ToString());
                }
                else
                {
                    rw["Image"] = File.ReadAllBytes(item_image_location + "DONOTDELETE_SUBIMAGE.PNG");
                }
            }

            dtg_Items.Columns["Image"].DisplayIndex = 0;

            for (int i = 0; i < dtg_Items.Columns.Count; i++)
            {
                if (dtg_Items.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dtg_Items.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }

            }
            for (int i = 0; i < dtg_Items.Rows.Count; i++)
            {
                totalrows = i;
            }
            totalrows += 1;
            lbl_numb_items.Text = "Rows Count: " + totalrows.ToString();


            dtg_Items.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Items.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Items.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Items.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtg_Items.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_Items.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Calculator_Timer.Start();
        }


        private void txt_Price_Leave(object sender, EventArgs e)
        {
            func.Two_Decimal_Places(sender, e, txt_Price);
        }

        private void btn_Gen_Click(object sender, EventArgs e)
        {
            gen.Generate_Transaction();
            sql = "Select `Transaction Reference` from `ID_Generated` where count = '1' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txt_TransRef.Text = config.dt.Rows[0].Field<string>("Transaction Reference");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Items.Rows.Count > 0)
            {
                txt_Barcode.Text = dtg_Items.CurrentRow.Cells[2].Value.ToString();
                txt_ItemName.Text = dtg_Items.CurrentRow.Cells[3].Value.ToString();
                cbo_brand.Text = dtg_Items.CurrentRow.Cells[4].Value.ToString();
                cbo_desc.Text = dtg_Items.CurrentRow.Cells[5].Value.ToString();
                txt_Qty.Text = dtg_Items.CurrentRow.Cells[6].Value.ToString();
                txt_Price.Text = dtg_Items.CurrentRow.Cells[7].Value.ToString();
                func.Reload_Images(Item_Image, txt_Barcode.Text, item_image_location);
                txt_SupID.Text = dtg_Items.CurrentRow.Cells[9].Value.ToString();
                txt_Sup_Name.Text = dtg_Items.CurrentRow.Cells[10].Value.ToString();
                txt_TransRef.Text = dtg_Items.CurrentRow.Cells[14].Value.ToString();

                double val = Convert.ToDouble(txt_Qty.Text) * Convert.ToDouble(txt_Price.Text);
                lbl_ProductValue.Text = val.ToString();

                func.Change_Font_DTG(sender, e, dtg_Items);
            }

            if (txt_Qty.Value <= Convert.ToDecimal(quantty))
            {
                lbl_stock_low.Text = "Stock Low Detected!";
            }
            else
            {
                lbl_stock_low.Text = "";
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_Barcode.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to update current item? \n\nContinue?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    img_loc = item_image_location + txt_Barcode.Text + ".PNG";


                    sql = "Update Stocks set " +
                        " `Item Name` = '" + txt_ItemName.Text + "' " +
                        ", `Brand` = '" + cbo_brand.Text + "' " +
                        ", `Description` = '" + cbo_desc.Text + "' " +
                        ", `Quantity` = '" + txt_Qty.Text + "' " +
                        ", `Price` = '" + txt_Price.Text + "' " +
                        ", `Image Path` = '" + img_loc + "' " +
                        ", `Supplier ID` = '" + txt_SupID.Text + "' " +
                        ", `Supplier Name` = '" + txt_Sup_Name.Text + "' " +
                        " where `Stock ID` = '" + txt_Barcode.Text + "' ";
                    config.Execute_CUD(sql, "Unsuccessful to update profile", "Profile successfully updated!");
                    AddStock_Load(sender, e);

                }
            }
            else
            {
                MessageBox.Show("Barcode is missing!", "Invalid Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btb_delete_Click(object sender, EventArgs e)
        {
            if (dtg_Items.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow rw in dtg_Items.SelectedRows)
                {
                    sql = "Delete from Stocks where `Stock ID`  = '" + rw.Cells[2].Value.ToString() + "' ";
                    config.Execute_Query(sql);
                }
                MessageBox.Show("Deleted from stocks!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AddStock_Load(sender, e);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStock_Load(sender, e);
        }

        private void btn_Clear_Text_Click(object sender, EventArgs e)
        {
            func.clearTxt(panel1);
            txt_Barcode.Focus();
            txt_Price.Text = "0.00";
        }

        private void txt_Barcode_TextChanged(object sender, EventArgs e)
        {
            if (txt_Barcode.Text != "")
            {
                BarcodeWriter writer = new BarcodeWriter()
                {
                    Format = BarcodeFormat.CODE_128
                };
                pic_BarCode.Image = writer.Write(txt_Barcode.Text);
            }


            /*
            //FOR DECODING
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)pic_BarCode.Image);
            if (result != null )
            {
                txt_Barcode.Text = result.Text;
            }
            */
        }

        private void Item_Image_DoubleClick(object sender, EventArgs e)
        {
            func.DoubleClick_Picture_Then_Replace_Existing(Item_Image, txt_Barcode.Text, item_image_location);
            func.Reload_Images(Item_Image, txt_Barcode.Text, item_image_location);
            btn_edit_Click(sender, e);
        }
        string search_for = string.Empty;
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (cbo_srch_type.Text == "Date")
            {
                search_for = "`Entry Date`";
            }
            else if (cbo_srch_type.Text == "Id")
            {
                search_for = "`Stock ID`";
            }
            else if (cbo_srch_type.Text == "Name")
            {
                search_for = "`Item Name`";
            }
            else if (cbo_srch_type.Text == "Brand")
            {
                search_for = "`Brand`";
            }
            else if (cbo_srch_type.Text == "Description")
            {
                search_for = "`Description`";
            }
            else if (cbo_srch_type.Text == "Quantity")
            {
                search_for = "`Quantity`";
            }
            else if (cbo_srch_type.Text == "Price")
            {
                search_for = "`Price`";
            }
            else if (cbo_srch_type.Text == "Supplier")
            {
                search_for = "`Supplier Name`";
            }
            else if (cbo_srch_type.Text == "Job")
            {
                search_for = "`Job Role`";
            }
            else if (cbo_srch_type.Text == "Trans Ref")
            {
                search_for = "`Transaction Reference`";
            }
            else
            {
                search_for = "`Transaction Reference`";
            }
            sql = "Select * from Stocks where " + search_for + " like '%" + txt_Search.Text + "%' ";
            config.Load_DTG(sql, dtg_Items);
            DTG_Property();

            if (txt_Search.Text == "")
            {
                refreshToolStripMenuItem_Click(sender, e);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void Calculations()
        {
            sql = "Select * from Calculations";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                lbl_Today_Qty.Text = "Qty " + config.dt.Rows[0].Field<string>("Total Quantity");
                lbl_Today_Amt.Text = "Php " + config.dt.Rows[0].Field<string>("Total Value");
                lbl_TotalQty.Text = "Qty " + config.dt.Rows[0].Field<string>("Overall_Qty");
                lbl_TotalAmt.Text = "Php " + config.dt.Rows[0].Field<string>("Overall_Total");
            }
        }
        double quantty = 0;
        private void Calculator_Timer_Tick(object sender, EventArgs e)
        {

            cal.Calculate_Todays_Entry_StockIn("Stocks");
            cal.Over_All();
            Calculations();
            Calculator_Timer.Stop();

            sql = "Select Low_Detection from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataGridViewRow rw in dtg_Items.Rows)
                {
                    quantty = Convert.ToDouble(config.dt.Rows[0].Field<string>("Low_Detection"));
                    if (Convert.ToDouble(rw.Cells[6].Value) <= quantty)
                    {
                        rw.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }

        }

        private void btn_searchSup_Click(object sender, EventArgs e)
        {
            supplierListToolStripMenuItem_Click(sender, e);
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            Item_Image_DoubleClick(sender, e);
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_TransRef.Text != "")
            {
                rdlc.Invoice("in", txt_TransRef.Text, "batch");
            }
            else
            {
                txt_TransRef.Text = "Empty Field!";
                txt_TransRef.Focus();
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_TransRef.Text != "")
            {
                rdlc.Invoice("in", txt_TransRef.Text, "preview");
            }
            else
            {
                txt_TransRef.Text = "Empty Field!";
                txt_TransRef.Focus();
            }
        }

        private void printTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_TransRef.Text != "")
            {
                rdlc.Invoice("in", txt_TransRef.Text, "print");
            }
            else
            {
                txt_TransRef.Text = "Empty Field!";
                txt_TransRef.Focus();
            }
        }

        private void dtg_Items_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Preview();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            Preview();
        }

        private void Preview()
        {
            if (dtg_Items.Rows.Count >= 1)
            {
                if (txt_Barcode.Text != "" || txt_Barcode.Text != null)
                {
                       Items.Item_Preview frm = new Items.Item_Preview(
                       dtg_Items.CurrentRow.Cells[1].Value.ToString(),
                       txt_Barcode.Text,
                       txt_TransRef.Text,
                       txt_ItemName.Text,
                       cbo_brand.Text,
                       cbo_desc.Text,
                       txt_Qty.Text,
                       txt_Price.Text,
                       lbl_ProductValue.Text,
                       txt_Sup_Name.Text);

                        frm.ShowDialog();
                }
            }
        }

        private void txt_Price_Click(object sender, EventArgs e)
        {
            txt_Price.SelectionStart = 0;
            txt_Price.SelectionLength = txt_Price.Text.Length;
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            func.Make_Numeric_Only(sender, e);
        }

        private void supplierListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustSupplier.CustSupp frm = new CustSupplier.CustSupp(Global_ID, Fullname, JobRole, "Sup");
            frm.ShowDialog();
        }

        private void txt_SupID_TextChanged(object sender, EventArgs e)
        {
            sql = "Select `Company Name` from Supplier where `Company ID` = '" + txt_SupID.Text + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txt_Sup_Name.Text = config.dt.Rows[0].Field<string>("Company Name");
                func.Reload_Images(Sup_Image, txt_SupID.Text, @"CommonSql\Pictures\Suppliers\");
            }
            if (txt_SupID.Text == "")
            {
                txt_Sup_Name.Text = "";
            }
        }

        private void btn_AddStock_Click(object sender, EventArgs e)
        {
            if (txt_Barcode.Text == "")
            {
                gen.Item_ID();
                sql = "Select `Item ID` from ID_Generated where count = '1'";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    Item_ID1 = config.dt.Rows[0].Field<string>("Item ID");
                }

            }
            else
            {
                sql = "Select `Stock ID` from Stocks where `Stock ID` = '" + txt_Barcode.Text + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    MessageBox.Show("Barcode needs to be unique, Already in used!", "Barcode Message Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Barcode.Focus();
                    return;
                }
                else
                {
                    Item_ID1 = txt_Barcode.Text;
                }
            }

            if (Item_ID1 == null || Item_ID1 == "")
            {
                func.Error_Message1 = "Item ID is not Generated!";
                txt_Barcode.Focus();
                func.Error_Message();
                Item_ID1 = "ERROR_ID";

            }
            else if (txt_ItemName.Text == "" || txt_ItemName.Text == null)
            {
                func.Error_Message1 = "Item Name";
                txt_ItemName.Focus();
                func.Error_Message();

            }
            else if (cbo_brand.Text == "" || cbo_brand.Text == null)
            {
                func.Error_Message1 = "Item Brand";
                cbo_brand.Focus();
                func.Error_Message();

            }
            else if (cbo_desc.Text == "" || cbo_desc.Text == null)
            {
                cbo_desc.Text = "None";

            }
            else if (txt_Qty.Value == 0 || txt_Qty.Text == null)
            {
                func.Error_Message1 = "Item Quantity";
                txt_Qty.Focus();
                func.Error_Message();

            }

            else if (txt_TransRef.Text == "" || txt_TransRef.Text == null)
            {
                func.Error_Message1 = "Transaction Reference";
                txt_TransRef.Focus();
                func.Error_Message();
                btn_Gen_Click(sender, e);
                txt_TransRef.Focus();
            }
            else
            {
                img_loc = item_image_location + Item_ID1 + ".PNG";

                sql = "Insert into Stocks ( " +
                    " `Entry Date` " +
                    ",`Stock ID` " +
                    ",`Item Name` " +
                    ",`Brand` " +
                    ",`Description` " +
                    ",`Quantity` " +
                    ",`Price` " +
                    ",`Image Path` " +
                    ",`Supplier ID` " +
                    ",`Supplier Name` " +
                    ",`User ID` " +
                    ",`Warehouse Staff Name`    " +
                    ",`Job Role` " +
                    ",`Transaction Reference` ) values (" +
                    " '" + DateTime.Now.ToString("dd-MM-yyyy") + "' " +
                    ",'" + Item_ID1 + "' " +
                    ",'" + txt_ItemName.Text + "' " +
                    ",'" + cbo_brand.Text + "' " +
                    ",'" + cbo_desc.Text + "' " +
                    ",'" + txt_Qty.Text + "' " +
                    ",'" + txt_Price.Text + "' " +
                    ",'" + img_loc + "' " +
                    ",'" + txt_SupID.Text + "' " +
                    ",'" + txt_Sup_Name.Text + "' " +
                    ",'" + Global_ID + "' " +
                    ",'" + Fullname + "' " +
                    ",'" + JobRole + "' " +
                    ",'" + txt_TransRef.Text + "'  )";
                config.Execute_CUD(sql, "Unable to Record Item!", "Item successfully added to database!");
                save_Ref = txt_TransRef.Text;
                txt_Price.Text = "0.00";
                txt_Qty.Text = "1";
                txt_ItemName.Focus();
                txt_Search_TextChanged(sender, e);
                Calculator_Timer.Start();
                txt_TransRef.Text = save_Ref;
            }

        }
        string save_Ref = string.Empty;
    }
}
