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
using System.Diagnostics;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Inventory_System02.Includes
{


    class Calculations
    {
        SQLConfig config = new SQLConfig();
        string sql = string.Empty;
        decimal total_amt;
        int total_qty;
        public void Calculate_Todays_Entry_StockIn(string Type_Of_Process )
        {

            sql = "Select * from "+ Type_Of_Process + " where `Entry Date` = '"+DateTime.Now.ToString(Includes.AppSettings.DateFormat) +"' ";
            config.singleResult(sql);

            if (config.dt.Rows.Count >= 1)
            {
                total_amt = 0;
                total_qty = 0;
                for (int i = 0; i < config.dt.Rows.Count; i++)
                {
                    int qty;
                    decimal price;
                    int.TryParse(Convert.ToString(config.dt.Rows[i]["Quantity"]), out qty);
                    decimal.TryParse(Convert.ToString(config.dt.Rows[i]["Price"]), out price);

                    decimal amount = qty * price;
      
                    total_qty += qty;
                    total_amt += amount;
                }

                sql = "Select * from Calculations";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    sql = "Update Calculations set `Total Quantity` = '" + total_qty + "', `Total Value` = '" + total_amt + "' ";
                    config.singleResult(sql);
                }
                else
                {
                    sql = "Insert into Calculations ( `Total Quantity`,  `Total Value` ) values ( '" + total_qty + "', '" + total_amt + "') ";
                    config.singleResult(sql);
                }
            }   
        }
        public void Over_All()
        {
            sql = "SELECT Quantity, Price FROM Stocks";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
               
                total_amt = 0;
                total_qty = 0;
                for (int i = 0; i < config.dt.Rows.Count; i++ )
                {
                    int qty = 0;
                    decimal price = 0;
                    int.TryParse(config.dt.Rows[i]["Quantity"].ToString(), out qty);
                    decimal.TryParse(config.dt.Rows[i]["Price"].ToString(), out price);
                    decimal amount = qty * price;
                    total_qty += qty;
                    total_amt += amount;
                }

                sql = "SELECT * FROM Calculations";
                config.singleResult(sql);

                if (config.dt.Rows.Count > 0)
                {
                    sql = "UPDATE Calculations SET Overall_Qty = '"+ total_qty+"', Overall_Total = '"+total_amt+"'";
                    config.Execute_Query(sql);

                }
                else
                {
                    sql = "INSERT INTO Calculations (Overall_Qty, Overall_Total) VALUES ('"+ total_qty+ "', '"+total_amt+"')";
                    config.Execute_Query(sql);
                }
            }
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
