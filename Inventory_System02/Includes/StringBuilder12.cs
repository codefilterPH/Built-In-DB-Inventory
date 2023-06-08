namespace Inventory_System02.Includes
{
    class StringBuilder12
    {
        /*
private void StringBuilderSetup()
{
    // Check all the checkboxes and see which ones are selected. Concatenate them in the selection string.
    SBuilder = new StringBuilder();
    SelectionString = string.Empty;
    SelectionString = "";

    if (cbo_report_type.Text == "Stock In")
    {
        grp_filters.Controls.Remove(chk_Cust_ID);
        grp_filters.Controls.Remove(chk_Cust_Name);
        grp_filters.Controls.Remove(chk_Cust_Address);
        foreach (CheckBox CBox in grp_filters.Controls)
        {
            chk_Entry_Date.Text = "`Entry Date`";
            chk_Item_ID.Text = "`Stock ID`";
            chk_Item_Name.Text = "`Item Name`";
            chk_Brand.Text = "Brand";
            chk_Description.Text = "Description";
            chk_Quantity.Text = "Quantity";
            chk_Price.Text = "Price";
            chk_Sup_ID.Text = "`Supplier ID`";
            chk_Sup_Name.Text = "`Supplier Name`";
            chk_User_ID.Text = "`User ID`";
            chk_Staff_Name.Text = "`Warehouse Staff Name`";
            chk_Job.Text = "`Job Role`";
            chk_Trans_Ref.Text = "`Transaction Reference`";

            SBuilder.Append(CBox.Text + ", ");
        }
        grp_filters.Controls.Add(chk_Cust_ID);
        grp_filters.Controls.Add(chk_Cust_Name);
        grp_filters.Controls.Add(chk_Cust_Address);
    }
    else if (cbo_report_type.Text == "Stock Out" || cbo_report_type.Text == "Stock Return")
    {
        grp_filters.Controls.Remove(chk_Sup_ID);
        grp_filters.Controls.Remove(chk_Sup_Name);
        foreach (CheckBox CBox in grp_filters.Controls)
        {
            chk_Entry_Date.Text = "`Entry Date`";
            chk_Item_ID.Text = "`Stock ID`";
            chk_Item_Name.Text = "`Item Name`";
            chk_Brand.Text = "`Brand`";
            chk_Description.Text = "`Description`";
            chk_Quantity.Text = "`Quantity`";
            chk_Price.Text = "`Total`";
            chk_Cust_ID.Text = "`Customer ID`";
            chk_Cust_Name.Text = "`Customer Name`";
            chk_Cust_Address.Text = "`Customer Address`";
            chk_User_ID.Text = "`User ID`";
            chk_Staff_Name.Text = "`Warehouse Staff Name`";
            chk_Job.Text = "`Job Role`";
            chk_Trans_Ref.Text = "`Transaction Reference`";
            SBuilder.Append(CBox.Text + ", ");
        }
        grp_filters.Controls.Add(chk_Sup_ID);
        grp_filters.Controls.Add(chk_Sup_Name);
    }

    if (SBuilder.ToString().Length > 0)
    {
        // Eliminate the last comma if at all any checkbox is selected.
        SelectionString = SBuilder.ToString().Substring(0, SBuilder.ToString().Length - 2);
        // Separate by comma and Reverse the strings
        String Output = String.Join(",", SelectionString
        .Split(',')
        .Select(a => a)
        .Reverse());

        SelectionString = Output.ToString();
    }
    chk_Entry_Date.Text = "Entry Date";
    chk_Item_ID.Text = "Item ID";
    chk_Item_Name.Text = "Item Name";
    chk_Brand.Text = "Brand";
    chk_Description.Text = "Description";
    chk_Quantity.Text = "Quantity";
    chk_Price.Text = "Price";
    chk_Trans_Ref.Text = "Trans Reference";
    chk_Sup_ID.Text = "Supplier ID";
    chk_Sup_Name.Text = "Supplier Name";
    chk_Cust_ID.Text = "Customer ID";
    chk_Cust_Name.Text = "Customer Name";
    chk_Cust_Address.Text = "Customer Address";
    chk_User_ID.Text = "User ID";
    chk_Staff_Name.Text = "Staff Name";
    chk_Job.Text = "Job Role";
}
*/

    }

}

