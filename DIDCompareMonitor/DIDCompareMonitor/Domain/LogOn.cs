using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIDCompareMonitor.Model;

namespace DIDCompareMonitor.Domain
{
   public class LogOn
    {
        public static LogOnInfo CollectData(string command)
        {
            LogOnInfo info = new LogOnInfo();
            info.Conn = GetValueByKey(command, "CONN").Replace("PROVIDER=SQLOLEDB;", "");
            info.AppName = GetValueByKey(command, "APPNAME");
            info.Line = GetValueByKey(command, "LINE");
            info.Station = GetValueByKey(command, "STATION");
            info.UserID = GetValueByKey(command, "USERID");
            info.Rights = GetValueByKey(command, "RIGHT");
            info.BU = GetValueByKey(command, "BU");
            info.ServerBU = GetValueByKey(command, "SERVERBU");
            info.Factory = GetValueByKey(command, "FACTORY");
            info.CHKRouting = GetValueByKey(command, "CHKROUTING");
            info.UPDRouting= GetValueByKey(command, "UPDROUTING");

            /// CONN Data
            info.Server = GetValueByKey(info.Conn, "SERVER", ";");
            info.Name = GetValueByKey(info.Conn, "Application Name", ";");
            info.DataBase = GetValueByKey(info.Conn, "DATABASE", ";");
            info.Password = GetValueByKey(info.Conn, "Password", ";");
          
            string qsmsConnectionString = string.Empty;
            string qsmsIP = Utility.Extensions.GetQSMSIP(info.Conn);
            qsmsConnectionString = info.Conn;
            qsmsConnectionString = qsmsConnectionString.Replace(info.Server, qsmsIP).Replace("SMT", "QSMS");
            info.QSMSConn = qsmsConnectionString;


            //info.WorkStation = new StationInfo
            //{
            //    Name = GetValueByKey(command, "STATION"),
            //    Line = GetValueByKey(command, "LINE"),
            //    ChkRouting = GetValueByKey(command, "CHKROUTING").ToBoolean(),
            //    UpdateRouting = GetValueByKey(command, "UPDROUTING").ToBoolean()
            //};

            //info.IP = GetValueByKey(command, "DATA SOURCE");

            return info;
        }

        private static string GetValueByKey(string command, string key, string endChar = ">")
        {
            key += "=";

            if (command.IndexOf(key) == -1)
                return "";

            string strTemp = command.Substring(command.IndexOf(key), command.Length - command.IndexOf(key));

            int endPosition = strTemp.IndexOf(endChar);

            if (endPosition != -1)
            {
                return strTemp.Substring(key.Length, endPosition - key.Length);
            }

            return "";
        }
    }
}

