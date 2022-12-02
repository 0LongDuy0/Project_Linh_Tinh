using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class U_Utility
    {
        public static Random rand = new Random();

        public static DateTime? Get_Null_Date()
        {
            return Convert_String_To_Datetime("01/01/1900", "dd/MM/yyyy");
        }

        public static int Convert_To_Int32(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (U_Utility.Convert_To_String(p_objData) != ""))
                return Convert.ToInt32(p_objData);
            else
                return U_Const.INT_VALUE_NULL;
        }

        public static long Convert_To_Int64(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (U_Utility.Convert_To_String(p_objData) != ""))
                return Convert.ToInt64(p_objData);
            else
                return U_Const.INT_VALUE_NULL;
        }

        public static double Convert_To_Double(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (U_Utility.Convert_To_String(p_objData) != ""))
                return Convert.ToDouble(p_objData);
            else
                return U_Const.FLT_VALUE_NULL;
        }

        public static bool Convert_To_Bool(object p_objData)
        {
            if (p_objData != System.DBNull.Value)
                return Convert.ToBoolean(p_objData);
            else
                return U_Const.BL_VALUE_NULL;
        }

        public static DateTime? Convert_To_DateTime(object p_objData)
        {
            if (p_objData != System.DBNull.Value && p_objData != null)
                return Convert.ToDateTime(p_objData);
            else
                return U_Const.DTM_VALUE_NULL;
        }

        public static DateTime? Convert_String_To_Datetime(string p_strDate)
        {
            if (p_strDate == "")
                return U_Const.DTM_VALUE_NULL;

            CultureInfo provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(p_strDate, U_Config.Date_Format_String, provider);
        }

        public static DateTime? Convert_String_To_Datetime(string p_strDate, string p_strFormat)
        {
            if (p_strDate == "")
                return U_Const.DTM_VALUE_NULL;

            CultureInfo provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(p_strDate, p_strFormat, provider);
        }

        public static string? Convert_To_String(object p_objData)
        {
            if (p_objData != null)
                return Convert.ToString(p_objData);
            else
                return U_Const.STR_VALUE_NULL;
        }

        public static T Map_Row_To_Entity<T>(DataRow p_Row) where T : new()
        {
            // create a new object
            T v_objItem = new T();

            foreach (DataColumn v_colValue in p_Row.Table.Columns)
            {
                // find the property for the column
                PropertyInfo? v_objItem_Info = v_objItem.GetType().GetProperty(v_colValue.ColumnName);

                // if exists, set the value
                if (v_objItem_Info != null && p_Row[v_colValue] != DBNull.Value)
                {
                    string v_strTypedata = v_colValue.DataType.Name;
                    switch (v_strTypedata)
                    {
                        case "String": v_objItem_Info.SetValue(v_objItem, U_Utility.Convert_To_String(p_Row[v_colValue])); break;
                        case "Int16": v_objItem_Info.SetValue(v_objItem, U_Utility.Convert_To_Int32(p_Row[v_colValue])); break;
                        case "Int32": v_objItem_Info.SetValue(v_objItem, U_Utility.Convert_To_Int32(p_Row[v_colValue])); break;
                        case "Int64": v_objItem_Info.SetValue(v_objItem, U_Utility.Convert_To_Int64(p_Row[v_colValue])); break;
                        case "DateTime": v_objItem_Info.SetValue(v_objItem, U_Utility.Convert_To_DateTime(p_Row[v_colValue])); break;
                        case "DateTime?": v_objItem_Info.SetValue(v_objItem, U_Utility.Convert_To_DateTime(p_Row[v_colValue])); break;
                        case "Double": v_objItem_Info.SetValue(v_objItem, U_Utility.Convert_To_Double(p_Row[v_colValue]), null); break;
                        case "Decimal": v_objItem_Info.SetValue(v_objItem, U_Utility.Convert_To_Double(p_Row[v_colValue]), null); break;
                        case "Boolean": v_objItem_Info.SetValue(v_objItem, U_Utility.Convert_To_Bool(p_Row[v_colValue]), null); break;
                    }
                }
            }

            // return 
            return v_objItem;
        }

    }
}
