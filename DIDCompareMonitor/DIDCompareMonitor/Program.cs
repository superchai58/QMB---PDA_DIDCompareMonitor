using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIDCompareMonitor.Model;
using DIDCompareMonitor.Domain;

namespace DIDCompareMonitor
{
    static class Program
    {
        public static LogOnInfo LogOnData = new LogOnInfo();
        public static bool IsDesignMode = false;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            string strCommand = string.Empty;
            if (args.Length == 0)
            {
                if (IsDesignMode)
                {
                    strCommand = "<APPNAME=DIDCOMPAREMONITOR><LINE=A16><STATION=DIDCOMPAREMONITOR><CONN=PROVIDER=SQLOLEDB;UID=sa;SERVER=10.94.1.11;DATABASE=SMT;Password =pqmb#7sa;Network Library=DBMSSOCN;Application Name=DIDCompareMonitor;connect timeout=30><USERID=04090053><RIGHT=Login,CompareDID,ConfirmDID><BU=><SERVERBU=NB6><FACTORY=F5><CHKROUTING=Y><UPDROUTING=Y><CHKDOMAIN=Y><APPCHECK=><IsRunOnSecondary=N>";
                }
                else
                {
                    //MessageBox.Show ("Please open by Mainmenu...", "Run error");
                    //Environment.Exit(0);
                    //return;
                    strCommand = "<APPNAME=DIDCOMPAREMONITOR><LINE=A16><STATION=DIDCOMPAREMONITOR><CONN=PROVIDER=SQLOLEDB;UID=sa;SERVER=10.94.1.11;DATABASE=SMT;Password =pqmb#7sa;Network Library=DBMSSOCN;Application Name=DIDCompareMonitor;connect timeout=30><USERID=04090053><RIGHT=Login,CompareDID,ConfirmDID><BU=><SERVERBU=NB6><FACTORY=F5><CHKROUTING=Y><UPDROUTING=Y><CHKDOMAIN=Y><APPCHECK=><IsRunOnSecondary=N>";
                }
            }
            for (int i = 0; i < args.Length; i++)
            { 

                strCommand+=args[i];
            }
            LogOnData = LogOn.CollectData(strCommand);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
