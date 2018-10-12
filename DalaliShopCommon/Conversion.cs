using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalaliShopCommon
{
    public class Conversion
    {
        public static int GetDataRowsNullableIntValue(DataRow dr, string ColumnName)
        {
            int value = 0;

            if (dr[ColumnName] != DBNull.Value)
                //value = (int)dr[ColumnName];
                value = Convert.ToInt32(dr[ColumnName]);

            return value;
        }
        public static string GetDataRowsStringValue(DataRow dr, string ColumnName)
        {
            string value = null;

            if (dr[ColumnName] != DBNull.Value)
                value = dr[ColumnName].ToString();

            return value;
        }
        public static DateTime GetDataRowsDateTimeValue(DataRow dr, string columnName)
        {
            DateTime value = Convert.ToDateTime(null);
            if (dr[columnName] != DBNull.Value)
                value = Convert.ToDateTime(dr[columnName]);
            return value;
        }
    }
}
