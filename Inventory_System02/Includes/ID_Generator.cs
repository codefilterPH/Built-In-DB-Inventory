using System;

namespace Inventory_System02.Includes
{

    class ID_Generator
    {

        SQLConfig config = new SQLConfig();
        string Id, sql;
        public void Employee_ID()
        {
            char[] letters = "0001902873678945600000".ToCharArray();
            Random R = new Random();
            string randomString = string.Empty;

            for (int z = 0; z < 2; z++)
            {
                randomString += letters[R.Next(0, 9)].ToString();
            }

            Id = "EMP" + randomString;

            sql = "Select * from `ID_Generated` where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                sql = "update `ID_Generated` set `User ID` = '" + Id + "' where count = '1'";
                config.Execute_Query(sql);
            }

        }
        public void Supplier_ID()
        {
            char[] letters = "0001902873678945600000".ToCharArray();
            Random R = new Random();
            string randomString = string.Empty;

            for (int z = 0; z < 6; z++)
            {
                randomString += letters[R.Next(0, 9)].ToString();
            }

            Id = "SUP" + randomString;

            sql = "Select * from `ID_Generated` where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                sql = "update `ID_Generated` set `Supplier ID` = '" + Id + "' where count = '1'";
                config.Execute_Query(sql);
            }

        }
        public void Item_ID()
        {
            char[] letters = "0C0D01BL9M0N2O8Q7P3ARF6S7TG8U9VEW4Z5602J00H010".ToCharArray();
            Random R = new Random();
            string randomString = string.Empty;

            for (int z = 0; z < 8; z++)
            {
                randomString += letters[R.Next(0, 9)].ToString();
            }

            Id = randomString;

            sql = "Select * from `ID_Generated` where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                sql = "update `ID_Generated` set `Item ID` = '" + Id + "' where count = '1'";
                config.Execute_Query(sql);
            }

        }
        public void Customer_ID()
        {
            char[] letters = "0001902873678945600000".ToCharArray();
            Random R = new Random();
            string randomString = string.Empty;

            for (int z = 0; z < 5; z++)
            {
                randomString += letters[R.Next(0, 9)].ToString();
            }

            Id = "DIV" + randomString;

            sql = "Select * from `ID_Generated` where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                sql = "update `ID_Generated` set `Customer ID` = '" + Id + "' where count = '1'";
                config.Execute_Query(sql);
            }

        }
        public void Generate_Transaction()
        {
            char[] letters = "0C0D01BL9M0N2O8Q7P3ARF6S7TG8U9VEW4Z5602J00H010".ToCharArray();
            Random R = new Random();
            string randomString = string.Empty;

            for (int z = 0; z < 7; z++)
            {
                randomString += letters[R.Next(0, 9)].ToString();
            }

            Id = "TRANS" + randomString;

            sql = "Select * from `ID_Generated` where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                sql = "update `ID_Generated` set `Transaction Reference` = '" + Id + "' where count = '1'";
                config.Execute_Query(sql);
            }

        }
    }
}
