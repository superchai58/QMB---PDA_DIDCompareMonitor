using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SQLHelper = QuantaSDK.DB.SQLHelper;


namespace DIDCompareMonitor.Utility
{
    public static class Extensions
    {
        public static bool ToBoolean(this string target)
        {
            if (target.ToLower() == "y" || target == "1")
                return true;

            return false;
        }

        public static bool IsChangedValue(this string oldValue, string newValue)
        {
            if (oldValue == "Default")
                return false;

            if (oldValue.ToUpper() != newValue.ToUpper())
                return true;

            return false;
        }


        public static string GetQSMSIP(string connStr)
        {
            string strSql = "select QSMS_Server,SMT_Server from QSMS_SMT_DB where BU in(select Site from Site)";

            DataTable dt = SQLHelper.ExecuteQuery(strSql, connStr).Tables[0];

            return dt.Rows[0]["QSMS_Server"].ToString();
        }
    }
}
