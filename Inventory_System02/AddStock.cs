using Inventory_System02.Includes;
using Inventory_System02.Items;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

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
        int quantity;
        public AddStock(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;

            item_image_location = Includes.AppSettings.Image_DIR;

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
            cbo_srch_type.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        double totalrows = 0;
        private void DTG_Property()
        {
         

            //Format to date dtg cell
            dtg_Items.Columns["Entry Date"].DefaultCellStyle.Format = Includes.AppSettings.DateFormatRetrieve;
            //sorting
            dtg_Items.Sort(dtg_Items.Columns["Entry Date"], ListSortDirection.Descending);
       

            config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));

            foreach (DataRow rw in config.dt.Rows)
            {
                if (File.Exists(rw[9].ToString()))
                {
                    rw["Image"] = File.ReadAllBytes(rw[9].ToString());
                }
                else
                {
                    try
                    {
                        rw["Image"] = File.ReadAllBytes(item_image_location + "DONOTDELETE_SUBIMAGE.JPG");
                    }
                    catch
                    {
                        rw["Image"] = File.ReadAllBytes(item_image_location + "DONOTDELETE_SUBIMAGE.PNG");

                    }
                   
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
            lbl_items_count.Text = totalrows.ToString();

            //Format to add comma separator and two decimal places in dtg
            dtg_Items.Columns[7].DefaultCellStyle.Format = "#,##0.00";
            dtg_Items.Columns[8].DefaultCellStyle.Format = "#,##0.00";
            //Hide some columns
            dtg_Items.Columns[0].Visible = false;
            dtg_Items.Columns[2].Visible = false;
            dtg_Items.Columns[9].Visible = false;

            dtg_Items.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Items.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Items.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Items.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtg_Items.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_Items.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtg_Items.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Calculator_Timer.Start();
        }
        private void Calculator_Timer_Tick(object sender, EventArgs e)
        {
            Calculations();
          
            //STOCK LOW DETECTION
            sql = "Select Low_Detection from Settings";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                
                foreach (DataGridViewRow rw in dtg_Items.Rows)
                {
                    int.TryParse ( Convert.ToString( config.dt.Rows[0]["Low_Detection"] ), out quantity);
                    if (Convert.ToInt32(rw.Cells[6].Value) <= quantity)
                    {
                        //STOCK LOW DETECT CHANGE FONT COLOR
                        rw.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            Calculator_Timer.Stop();
        }
        int my_qty;
        decimal my_total;
        public void Calculations()
        {
            if ( dtg_Items.Rows.Count > 0)
            {
                my_qty = 0;
                my_total = 0;

                foreach (DataGridViewRow rw in dtg_Items.Rows)
                {
                    if (Convert.ToDateTime(rw.Cells[1].Value.ToString()).ToString(Includes.AppSettings.DateFormatRetrieve) == DateTime.Now.ToString(Includes.AppSettings.DateFormatRetrieve))
                    {
                    
                        int qty = 0;
                        decimal total = 0;
                        int.TryParse(rw.Cells[6].Value.ToString(), out qty);
                        decimal.TryParse(rw.Cells[8].Value.ToString(), out total);
                        my_qty += qty;
                        my_total += total;
                    }
                    lbl_Today_Qty.Text = my_qty.ToString();
                    lbl_Today_Amt.Text = my_total.ToString();
                }

                my_qty = 0;
                my_total = 0;
                foreach ( DataGridViewRow rw in dtg_Items.Rows )
                {
                    int qty = 0;
                    decimal total = 0;
                    int.TryParse(rw.Cells[6].Value.ToString(), out qty);
                    decimal.TryParse(rw.Cells[8].Value.ToString(), out total);
                    my_qty += qty;
                    my_total += total;
                }
                lbl_TotalQty.Text = my_qty.ToString();
                lbl_TotalAmt.Text = my_total.ToString();
            }
        }

        private void txt_Price_Leave(object sender, EventArgs e)
        {
            txt_Qty_ValueChanged(sender,e);
            func.Two_Decimal_Places(sender, e, txt_Price);
        }

        private void btn_Gen_Click(object sender, EventArgs e)
        {
            gen.Generate_Transaction();
            sql = "Select `Transaction Reference` from `ID_Generated` where count = '1' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txt_TransRef.Text = Convert.ToString(config.dt.Rows[0]["Transaction Reference"]);
            }
            SupplierChangeDisabler();
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
                lbl_ProductValue.Text = dtg_Items.CurrentRow.Cells[8].Value.ToString();
                func.Reload_Images(Item_Image, txt_Barcode.Text, item_image_location);
                txt_SupID.Text = dtg_Items.CurrentRow.Cells[10].Value.ToString();
                txt_Sup_Name.Text = dtg_Items.CurrentRow.Cells[11].Value.ToString();
                txt_TransRef.Text = dtg_Items.CurrentRow.Cells[15].Value.ToString();

                func.Change_Font_DTG(sender, e, dtg_Items);
                txt_Qty_ValueChanged(sender, e);
            }


            if (txt_Qty.Value <= Convert.ToDecimal(quantity))
            {
                lbl_stock_low.Text = "Stock Low Detected!";
            }
            else
            {
                lbl_stock_low.Text = "";
            }

            SupplierChangeDisabler();
        }
        private void SupplierChangeDisabler()
        {
            if (!string.IsNullOrWhiteSpace(txt_TransRef.Text))
            {
                sql = "Select `Transaction Reference` from Stocks WHERE `Transaction Reference` = '" + txt_TransRef.Text + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    supplierListToolStripMenuItem.Enabled = false;
                    btn_searchSup.Enabled = false;
                    txt_SupID.Enabled = false;
                    txt_Sup_Name.Enabled = false;
                }
                else
                {
                    supplierListToolStripMenuItem.Enabled = true;
                    btn_searchSup.Enabled = true;
                    txt_SupID.Enabled = true;
                    txt_Sup_Name.Enabled = true;
                }
            }
            else
            {
                supplierListToolStripMenuItem.Enabled = true;
                btn_searchSup.Enabled = true;
                txt_SupID.Enabled = true;
                txt_Sup_Name.Enabled = true;

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
         
            if (txt_Barcode.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to update current item? \n\nContinue?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    txt_Qty_ValueChanged(sender, e);
                    img_loc = item_image_location + txt_Barcode.Text + ".PNG";

                    sql = "Update Stocks set " +
                        " `Item Name` = '" + txt_ItemName.Text + "' " +
                        ", `Brand` = '" + cbo_brand.Text + "' " +
                        ", `Description` = '" + cbo_desc.Text + "' " +
                        ", `Quantity` = '" + Convert.ToInt32(txt_Qty.Text) + "' " +
                        ", `Price` = '" + Convert.ToDecimal(txt_Price.Text) + "' " +
                        ", `Total` = '" + Convert.ToDecimal(lbl_ProductValue.Text) +"' "+    
                        ", `Image Path` = '" + img_loc + "' " +
                        ", `Supplier ID` = '" + txt_SupID.Text + "' " +
                        ", `Supplier Name` = '" + txt_Sup_Name.Text + "' " +
                        " where `Stock ID` = '" + txt_Barcode.Text + "' ";
                    config.Execute_CUD(sql, "Unsuccessful to update item information", "Item information successfully updated!");
                    refreshToolStripMenuItem_Click(sender, e);  

                }
            }
            else
            {
                MessageBox.Show("Barcode is missing!", "Invalid Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btb_delete_Click(object sender, EventArgs e)
        {
            if ( dtg_Items.Rows.Count > 0 )
            {
                if (dtg_Items.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("You are about to deleted selected item(s), Please confirm deletion.", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        foreach (DataGridViewRow rw in dtg_Items.SelectedRows)
                        {
                            sql = "Delete from Stocks where `Stock ID`  = '" + rw.Cells[2].Value.ToString() + "' ";
                            config.Execute_Query(sql);
                        }
                        MessageBox.Show("Deleted from inbound stocks!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddStock_Load(sender, e);
                    }
                }
                else
                {
                    dtg_Items.CurrentRow.Selected = true;
                }
               
            }       
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( dtg_Items.Columns.Count >=1 )
            {
                dtg_Items.Columns.Clear();
            }
            this.Refresh();
            AddStock_Load(sender, e);
            SupplierChangeDisabler();
            enable_them = true;
            SpecialFilterDisabler();
        }

        private void btn_Clear_Text_Click(object sender, EventArgs e)
        {
            txt_TransRef.Text = "";
            txt_ItemName.Text = "";
            txt_Barcode.Text = "";
            cbo_desc.Text = "";
            cbo_brand.Text = "";
            txt_Qty.Text = "0";
            txt_SupID.Text = "";
            txt_Sup_Name.Text = "";
            txt_Price.Text = "0.00";
            txt_Barcode.Focus();
            SupplierChangeDisabler();

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
            if (cbo_srch_type.Text == "DATE")
            {
                search_for = "`Entry Date`";
            }
            else if (cbo_srch_type.Text == "ID")
            {
                search_for = "`Stock ID`";
            }
            else if (cbo_srch_type.Text == "NAME")
            {
                search_for = "`Item Name`";
            }
            else if (cbo_srch_type.Text == "BRAND")
            {
                search_for = "`Brand`";
            }
            else if (cbo_srch_type.Text == "DESCRIPTION")
            {
                search_for = "`Description`";
            }
            else if (cbo_srch_type.Text == "QUANTITY")
            {
                search_for = "`QUANTITY`";
            }
            else if (cbo_srch_type.Text == "PRICE")
            {
                search_for = "`Price`";
            }
            else if (cbo_srch_type.Text == "SUPPLIER")
            {
                search_for = "`Supplier Name`";
            }
            else if (cbo_srch_type.Text == "JOB")
            {
                search_for = "`Job Role`";
            }
            else if (cbo_srch_type.Text == "TRANS REF")
            {
                search_for = "`Transaction Reference`";
            }
            else
            {
                search_for = "`Transaction Reference`";
            }
            sql = "Select * from Stocks where " + search_for + " like '%" + txt_Search.Text + "%' ORDER BY `Entry Date` DESC ";
            config.Load_DTG(sql, dtg_Items);
            Calculator_Timer.Start();
            DTG_Property();

            if (txt_Search.Text == "")
            {
                refreshToolStripMenuItem_Click(sender, e);
            }
        }

        private void btn_searchSup_Click(object sender, EventArgs e)
        {
            supplierListToolStripMenuItem_Click(sender, e);
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            Item_Image_DoubleClick(sender, e);
            refreshToolStripMenuItem_Click(sender, e);
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
                    dtg_Items.CurrentRow.Cells[13].Value.ToString());

                    frm.ShowDialog();
                }
            }
        }

        private void cbo_srch_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search_TextChanged(sender, e);
        }
        private ToolTip toolTip;
        private void btn_searchSup_MouseHover(object sender, EventArgs e)
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(btn_searchSup, "Click to search for an existing supplier.");
        }

        private void txt_Barcode_MouseHover(object sender, EventArgs e)
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(txt_Barcode, "If left empty system will auto create an item id.");
        }

        private void txt_SupID_MouseHover(object sender, EventArgs e)
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(txt_SupID, "Type any known ID, System will populate the names if exists.");
        }

        private void Item_Image_MouseHover(object sender, EventArgs e)
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(Item_Image, "Double click me to change picture.");
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            gen.Item_ID();
            sql = "Select `Item ID` from ID_Generated where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txt_Barcode.Text = config.dt.Rows[0].Field<string>("Item ID"); 
                cbo_brand.Text = "Replace me with existing brand or new one.";
                txt_ItemName.Text = "Replace me with new name.";
                txt_Price.Text = "0.00";
                txt_Qty.Text = "0";
                lbl_ProductValue.Text = "0.00";
                cbo_desc.Text = "None";
                txt_Barcode.Focus();

            }
        }

        private void txt_Qty_ValueChanged(object sender, EventArgs e)
        {
            decimal total_product = 0;
            decimal value1 = txt_Qty.Value;
            decimal value2 = Convert.ToDecimal(txt_Price.Text);

            total_product = value1 * value2;
            lbl_ProductValue.Text = total_product.ToString();
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            txt_Qty_ValueChanged(sender, e);
        }

        private void txt_Qty_Leave(object sender, EventArgs e)
        {
            txt_Qty_ValueChanged(sender, e);
        }

        private void view_trans_in_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txt_TransRef.Text) && txt_TransRef.Text != "Empty Field!")
            {
                rdlc.Invoice("in", txt_TransRef.Text, "preview");
            }
            else
            {
                txt_TransRef.Text = "Empty Field!";
                txt_TransRef.Focus();
            }
        }

        private void batch_trans_in_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_TransRef.Text) && txt_TransRef.Text != "Empty Field!")
            {
                rdlc.Invoice("in", txt_TransRef.Text, "batch");
            }
            else
            {
                txt_TransRef.Text = "Empty Field!";
                txt_TransRef.Focus();
            }
        }

        private void print_trans_in_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_TransRef.Text) && txt_TransRef.Text != "Empty Field!")
            {
                rdlc.Invoice("in", txt_TransRef.Text, "print");
            }
            else
            {
                txt_TransRef.Text = "Empty Field!";
                txt_TransRef.Focus();
            }
        }

        private void view_tbl_in_Click(object sender, EventArgs e)
        {
            Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
            frm.Search_Result("INBOUND SUMMARY", "preview", dtg_Items, lbl_items_count.Text, lbl_TotalQty.Text, lbl_TotalAmt.Text, cbo_srch_type.Text, txt_Search.Text);
        }

        private void batch_tbl_in_Click(object sender, EventArgs e)
        {
            Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
            frm.Search_Result("INBOUND SUMMARY", "batch", dtg_Items, lbl_items_count.Text, lbl_TotalQty.Text, lbl_TotalAmt.Text, cbo_srch_type.Text, txt_Search.Text);
            MessageBox.Show("Sent to My Documents!");
        }

        private void print_tbl_in_Click(object sender, EventArgs e)
        {
            Load_DTG_VBPrint frm = new Load_DTG_VBPrint();
            frm.Search_Result("INBOUND SUMMARY", "print", dtg_Items, lbl_items_count.Text, lbl_TotalQty.Text, lbl_TotalAmt.Text, cbo_srch_type.Text, txt_Search.Text);
        }

        private void lbl_ProductValue_TextChanged(object sender, EventArgs e)
        {
            func.Label_Two_Decimal_Places(sender, e, lbl_ProductValue);
        }

        private void lbl_Today_Amt_TextChanged(object sender, EventArgs e)
        {
            func.Label_Two_Decimal_Places(sender, e, lbl_Today_Amt);
        }

        private void lbl_TotalAmt_TextChanged(object sender, EventArgs e)
        {
            func.Label_Two_Decimal_Places(sender, e, lbl_TotalAmt);
        }
        bool enable_them = false;
        private void SpecialFilterDisabler()
        {      
            if (enable_them == false)
            {
                printTransactionToolStripMenuItem.Enabled = false;
                batchToolStripMenuItem.Enabled = false;
                viewToolStripMenuItem.Enabled = false;
                btn_AddStock.Enabled = false;
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
                btn_upload.Enabled = false;
                btn_preview.Enabled = false;
                dtg_Items.Enabled = false;
                txt_Search.Enabled = false;
                btn_Clear_Text.Enabled = false;


                if (dtg_Items.Columns.Count > 0)
                {
                    dtg_Items.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtg_Items.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtg_Items.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                
                lbl_items_count.Text = dtg_Items.Rows.Count.ToString();
                lbl_Today_Amt.Text = "0";
                lbl_Today_Qty.Text = "0";
                lbl_TotalAmt.Text = "0";
                lbl_TotalQty.Text = "0";
                txt_TransRef.Text = "";
                txt_ItemName.Text = "";
                txt_Barcode.Text = "";
                cbo_desc.Text = "";
                cbo_brand.Text = "";
                txt_Qty.Text = "0";
                txt_SupID.Text = "";
                txt_Sup_Name.Text = "";
                txt_Price.Text = "0.00";
            }
            else
            {
                printTransactionToolStripMenuItem.Enabled = true;
                batchToolStripMenuItem.Enabled = true;
                viewToolStripMenuItem.Enabled = true;
                btn_AddStock.Enabled = true;
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
                btn_upload.Enabled = true;
                btn_preview.Enabled = true;
                dtg_Items.Enabled = true;
                txt_Search.Enabled = true;
                btn_Clear_Text.Enabled = true;
            }
           
        }
        private void TableRefresher()
        {
            //Refresh and clear the columns this is important to remain the sorting
            if (dtg_Items.Columns.Count > 0)
            {
                dtg_Items.Columns.Clear();
            }
        }
        private void mostProductPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT Brand, COUNT(*) AS `Total Occurences` FROM `Stocks` GROUP BY Brand ORDER BY `Total Occurences` DESC";
            config.Load_DTG(sql, dtg_Items);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void leastProductPurchasedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT Brand, COUNT(*) AS `Total Occurences` FROM `Stocks` GROUP BY Brand ORDER BY `Total Occurences` ASC";
            config.Load_DTG(sql, dtg_Items);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void mostItemPurchasedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT `Item Name`, `Brand`, COUNT(*) AS `Total Occurences` FROM `Stocks` GROUP BY `Item Name` ORDER BY `Total Occurences` DESC";
            config.Load_DTG(sql, dtg_Items);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void mostItemPurchasedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT `Item Name`, `Brand`, COUNT(*) AS `Total Occurences` FROM `Stocks` GROUP BY `Item Name` ORDER BY `Total Occurences` ASC";
            config.Load_DTG(sql, dtg_Items);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void mosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT `Supplier Name`, COUNT(*) AS `Total Occurences` FROM `Stocks` GROUP BY `Supplier Name` ORDER BY `Total Occurences` DESC";
            config.Load_DTG(sql, dtg_Items);
            enable_them = false;
            SpecialFilterDisabler();
        }

        private void divisionWithTheLeastPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableRefresher();
            sql = "SELECT `Supplier Name`, COUNT(*) AS `Total Occurences` FROM `Stocks` GROUP BY `Supplier Name` ORDER BY `Total Occurences` ASC";
            config.Load_DTG(sql, dtg_Items);
            enable_them = false;
            SpecialFilterDisabler();
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
           
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_SupID.Text = frm.supID;
            }
        }

        private void txt_SupID_TextChanged(object sender, EventArgs e)
        {
            sql = "Select `Company Name` from Supplier where `Company ID` = '" + txt_SupID.Text + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txt_Sup_Name.Text = config.dt.Rows[0].Field<string>("Company Name");
                func.Reload_Images(Sup_Image, txt_SupID.Text, Includes.AppSettings.Supplier_DIR);
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
            else if (string.IsNullOrWhiteSpace(txt_ItemName.Text))
            {
                func.Error_Message1 = "Item Name";
                txt_ItemName.Focus();
                func.Error_Message();

            }
            else if (string.IsNullOrWhiteSpace(cbo_brand.Text))
            {
                func.Error_Message1 = "Item Brand";
                cbo_brand.Focus();
                func.Error_Message();

            }
            else if (string.IsNullOrWhiteSpace(cbo_desc.Text))
            {
                cbo_desc.Text = "None";

            }
            else if (txt_Qty.Value == 0 || txt_Qty.Text == null)
            {
                func.Error_Message1 = "Item Quantity";
                txt_Qty.Focus();
                func.Error_Message();

            }
            else if (string.IsNullOrWhiteSpace(txt_SupID.Text))
            {
                func.Error_Message1 = "Supplier";
                txt_SupID.Focus();
                func.Error_Message();
            }
            else if (string.IsNullOrWhiteSpace(txt_TransRef.Text))
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
                    ",`Total` " +
                    ",`Image Path` " +
                    ",`Supplier ID` " +
                    ",`Supplier Name` " +
                    ",`User ID` " +
                    ",`Warehouse Staff Name`    " +
                    ",`Job Role` " +
                    ",`Transaction Reference` ) values (" +
                    " '" + DateTime.Now.ToString(Includes.AppSettings.DateFormatSave) + "' " +
                    ",'" + Item_ID1 + "' " +
                    ",'" + txt_ItemName.Text + "' " +
                    ",'" + cbo_brand.Text + "' " +
                    ",'" + cbo_desc.Text + "' " +
                    ",'" + Convert.ToInt32(txt_Qty.Text) + "' " +
                    ",'" + Convert.ToDecimal(txt_Price.Text) + "' " +
                    ",'" + Convert.ToDecimal(lbl_ProductValue.Text) +"' " +
                    ",'" + img_loc + "' " +
                    ",'" + txt_SupID.Text + "' " +
                    ",'" + txt_Sup_Name.Text + "' " +
                    ",'" + Global_ID + "' " +
                    ",'" + Fullname + "' " +
                    ",'" + JobRole + "' " +
                    ",'" + txt_TransRef.Text + "'  )";
                config.Execute_CUD(sql, "Unable to Record Item!", "Item successfully added to database!");
                save_Ref = txt_TransRef.Text;
                newItemToolStripMenuItem_Click(sender, e);
                txt_ItemName.Focus();
                txt_Search_TextChanged(sender, e);
                Calculator_Timer.Start();
                txt_TransRef.Text = save_Ref;
                if ( dtg_Items.Rows.Count > 0)
                {
                    dtg_Items.Rows[0].Selected = true;
                }
            }
        }
        string save_Ref = string.Empty;
    }
}
