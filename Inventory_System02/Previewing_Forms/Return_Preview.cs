using Inventory_System02.Includes;
using System;
using System.Windows.Forms;

namespace Inventory_System02.Items
{

    public partial class Return_Preview : Form
    {
        usableFunction func = new usableFunction();
        string id = string.Empty;
        string item_image_location = string.Empty;
        string entry_date = string.Empty;
        string trans_ref = string.Empty;
        string divi_name = string.Empty;
        string divi_address = string.Empty;
        string name = string.Empty;
        string description = string.Empty;
        string brand = string.Empty;
        string quantity = string.Empty;
        string price = string.Empty;
        string total_amt = string.Empty;
        string person_name = string.Empty;

        public Return_Preview(
            string rec_entry_date,
            string barcode,
            string rec_trans_ref,
            string division_name,
            string division_address,
            string rec_name,
            string rec_brand,
            string rec_desc,
            string rec_qty,
            string rec_price,
            string rec_value,
            string rec_person_name
            )
        {
            InitializeComponent();

            entry_date = rec_entry_date;
            id = barcode;
            trans_ref = rec_trans_ref;
            divi_name = division_name;
            divi_address = division_address;
            name = rec_name;
            brand = rec_brand;
            description = rec_desc;
            quantity = rec_qty;
            price = rec_price;
            total_amt = rec_value;
            person_name = rec_person_name;
        }

        private void Return_Preview_Load(object sender, EventArgs e)
        {
            if (id != string.Empty)
            {
                txt_id.Text = id;
                txt_date.Text = entry_date;
                item_image_location = Includes.AppSettings.Image_DIR;
                func.Reload_Images(Item_Image, id, item_image_location);

                txt_name.Text = name;
                txt_trans_ref.Text = trans_ref;
                txt_divi_name.Text = divi_name;
                txt_divi_address.Text = divi_address;
                txt_brand.Text = brand;
                txt_desc.Text = description;
                txt_qty.Text = quantity;
                txt_price.Text = price;
                txt_amt.Text = total_amt;
                txt_person_name.Text = person_name;

                txt_name.Focus();

                SQLConfig config = new SQLConfig();
                string sql = "SELECT Status FROM `Stock Returned` WHERE `Stock ID` = '" + id + "' and `Transaction Reference` = '" + trans_ref + "' ";
                config.singleResult(sql);
                if (config.dt.Rows.Count >= 1)
                {
                    txt_Status.Text = config.dt.Rows[0]["Status"].ToString();
                }
            }
        }
    }
}
