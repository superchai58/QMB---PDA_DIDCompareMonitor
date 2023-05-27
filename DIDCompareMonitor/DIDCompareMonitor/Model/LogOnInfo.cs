using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDCompareMonitor.Model
{
    public class LogOnInfo
    {
        private string appName = string.Empty;
        public string AppName
        {
            get { return appName; }
            set { appName = value; }
        }

        private string line = string.Empty;
        public string Line
        {
            get { return line; }
            set { line = value; }
        }

        private string station = string.Empty;
        public string Station
        {
            get { return station; }
            set { station = value; }
        }

        private string conn = string.Empty;
        public string Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        private string userID = string.Empty;
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string rights = string.Empty;
        public string Rights
        {
            get { return rights; }
            set { rights = value; }
        }

        private string bu = string.Empty;
        public string BU
        {
            get { return bu; }
            set { bu = value; }
        }

        private string serverBU = string.Empty;
        public string ServerBU
        {
            get { return serverBU; }
            set { serverBU = value; }
        }

        private string factory = string.Empty;
        public string Factory
        {
            get { return factory; }
            set { factory = value; }
        }

        private string chkRouting = string.Empty;
        public string CHKRouting
        {
            get { return chkRouting; }
            set { chkRouting = value; }
        }

        private string updRouting = string.Empty;
        public string UPDRouting
        {
            get { return updRouting; }
            set { updRouting = value; }
        }
        /// CONN Data

        private string server = string.Empty;
        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        private string dataBase = string.Empty;
        public string DataBase
        {
            get { return dataBase; }
            set { dataBase = value; }
        }

        private string password = string.Empty;
        public string Password
        {
            get { return password; }
            set { dataBase = value; }
        }

        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string qsmsconn = string.Empty;
        public string QSMSConn
        {
            get { return qsmsconn; }
            set { qsmsconn = value; }
        }



        //private string userName = string.Empty;
        //public string UserName
        //{
        //    get { return userName; }
        //    set { userName = value; }
        //}

        //private string ip = string.Empty;
        //public string IP
        //{
        //    get { return ip; }
        //    set { ip = value; }
        //}


        //private StationInfo workStation = new StationInfo();
        //public StationInfo WorkStation
        //{
        //    get { return workStation; }
        //    set { workStation = value; }
        //}


    }
}