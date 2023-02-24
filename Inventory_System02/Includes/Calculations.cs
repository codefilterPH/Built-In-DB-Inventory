using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System02.Includes;
using ZXing;
using System.IO;
namespace Inventory_System02.Includes
{
    class Calculations
    {
        SQLConfig config = new SQLConfig();
        string sql = string.Empty;

        double qty = 0, t_qty = 0, price = 0, sub_amt = 0, amt = 0;

        public void Calculate_Todays_Entry_StockIn(string Type_Of_Process )
        {

            sql = "Select * from "+ Type_Of_Process + " where `Entry Date` = '"+DateTime.Now.ToString(Includes.AppSettings.DateFormat) +"' ";
            config.singleResult(sql);

            if (config.dt.Rows.Count == 1)
            {
                double.TryParse(config.dt.Rows[0].Field<string>("Quantity"), out qty);
                double.TryParse(config.dt.Rows[0].Field<string>("Price"), out price);
                sub_amt = qty * price;
                amt += sub_amt;
                t_qty = qty;
            }
            else if ( config.dt.Rows.Count > 1)
            {

                for ( int i = 0; i < config.dt.Rows.Count; i++)
                {
                    double.TryParse(config.dt.Rows[i].Field<string>("Quantity"), out qty);
                    double.TryParse(config.dt.Rows[i].Field<string>("Price"), out price);
                    t_qty += qty;
                    sub_amt = qty * price;
                    amt += sub_amt;
                }
             
            }


            Save_To_DB(qty.ToString(), t_qty.ToString(), amt.ToString(), "`Total Quantity`" , "`Total Value`" );
           
        }
        public void Over_All()
        {
            sql = "Select * from Stocks";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                for ( int i = 0; i < config.dt.Rows.Count; i ++ )
                {
                    qty = Convert.ToDouble( config.dt.Rows[i].Field<string>("Quantity") );
                    price = Convert.ToDouble( config.dt.Rows[i].Field<string>("Price") );

                    t_qty += qty;
                    sub_amt = qty * price;
                    amt += sub_amt;
                }

                Save_To_DB(qty.ToString(), t_qty.ToString(), amt.ToString(), "`Overall_Qty`", "`Overall_Total`");


            }
        }
        private void Save_To_DB( string single_qty, string all_qty, string amount, string col1, string col2 )
        {
            sql = "Select * from Calculations";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                sql = "Update Calculations set "+ col1+ " = '" + all_qty + "', " + col2 + " = '" + amount + "' ";
                config.singleResult(sql);
            }
            else
            {
                sql = "Insert into Calculations ( "+ col1 +", " +col2 +" ) values ( '" + single_qty + "', '" + amount + "') ";
                config.singleResult(sql);
            }
            qty = 0; t_qty = 0; price = 0; sub_amt = 0; amt = 0;
        }
        public void ReturnReason(string trans_ref, string cust_id, string reason)
        {
            sql = "Select * from `Return Reasons` where `Transaction Ref` = '" + trans_ref + "' and `Customer ID` = '" + cust_id + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
               
                sql = " Update `Return Reasons` set Reason = '" + reason + "' where `Transaction Ref` = '" + trans_ref + "' and `Customer ID` = '" + cust_id + "' ";
                config.Execute_Query(sql);
            }
            else
            {
               
                sql = " Insert into `Return Reasons` ( `Transaction Ref`, `Customer ID`, `Reason` ) values ( '"+trans_ref+"', '"+cust_id+"', '" + reason + "' )  ";
                config.Execute_Query(sql); 
            }
        }
    }
}
