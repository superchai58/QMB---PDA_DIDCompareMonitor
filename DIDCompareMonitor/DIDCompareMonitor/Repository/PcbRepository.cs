using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;


namespace DIDCompareMonitor.Repository
{
    public class PcbRepository : QMSSDK.Db.Specific
    {
        private SqlConnection conn = null;
        private SqlConnection qsmsconn = null;

        public PcbRepository(string connectionString, string QSMSConn)
        {
            this.conn = new SqlConnection(connectionString);
            this.qsmsconn = new SqlConnection(QSMSConn);
        }


        public DataTable GetInfo(string Type, string Item, string Side)
        {
            this.SPName = "DIDCompareM_GetInfo";

            SqlParameter[] paras = new SqlParameter[3];
            paras[0] = new SqlParameter("@Type", SqlDbType.VarChar, 50) { Value = Type };
            paras[1] = new SqlParameter("@Item", SqlDbType.VarChar, 50) { Value = Item };
            paras[2] = new SqlParameter("@Side", SqlDbType.VarChar, 50) { Value = Side };
            return this.Execute(paras, qsmsconn).Tables[0];
        }

        public DataTable ChkData(string Type,string Factory, string Line, string Side,string Machine)
        {
            this.SPName = "DIDCompareM_ChkInfo";

            SqlParameter[] paras = new SqlParameter[5];
            paras[0] = new SqlParameter("@Factory", SqlDbType.VarChar, 50) { Value = Factory };
            paras[1] = new SqlParameter("@Line", SqlDbType.VarChar, 50) { Value = Line };
            paras[2] = new SqlParameter("@Side", SqlDbType.VarChar, 50) { Value = Side };
            paras[3] = new SqlParameter("@Machine", SqlDbType.VarChar, 50) { Value = Machine };
            paras[4] = new SqlParameter("@Type", SqlDbType.VarChar, 50) { Value = Type };

            return this.Execute(paras, qsmsconn).Tables[0];
        }

        public DataTable CompareDID(string CheckType,string OldDID, string ScanDID, string UID)
        {
            this.SPName = "DIDCompareM_ChkDID";

            SqlParameter[] paras = new SqlParameter[4];
            paras[0] = new SqlParameter("@CheckType", SqlDbType.VarChar, 50) { Value = CheckType };
            paras[1] = new SqlParameter("@OldDID", SqlDbType.VarChar, 50) { Value = OldDID };
            paras[2] = new SqlParameter("@ScanDID", SqlDbType.VarChar, 50) { Value = ScanDID };
            paras[3] = new SqlParameter("@UID", SqlDbType.VarChar, 50) { Value = UID };

            return this.Execute(paras, qsmsconn).Tables[0];
        }

    }
}
