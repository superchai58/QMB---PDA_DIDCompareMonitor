using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using NSIniFile;
//using Encryption;
using System.Xml;
using System.IO;
using System.Data.SqlClient;
using Connect.BLL;

namespace PDA_DIDSlotLink
{
    public partial class frmSelect : Form
    {
        public string Station = string.Empty;
        public string UID = string.Empty;
        public string Right = string.Empty;
        public string message = string.Empty;

        string Factory = string.Empty;
        string Line = string.Empty;
        string Side = string.Empty;
        string Machine = string.Empty;
        string OldDID = string.Empty;
        string ScanDID = string.Empty;
        string CheckType = string.Empty;
        int QTY = 0;


        private DataTable Info = new DataTable();
        private DataTable ChkData = new DataTable();
        private DataTable CompareDID = new DataTable();
        ConnectDBQSMS oConQSMS = new ConnectDBQSMS();
        ConnectDBSMT oConSMT = new ConnectDBSMT();

        public frmSelect(string strUserName)
        {
            InitializeComponent();
            UID = strUserName;
            //readXML();
           
                
        }

        private void readXML()
        {
            //string appName = System.Reflection.Assembly.GetCallingAssembly().GetName().CodeBase;
            //string appPath = System.IO.Path.GetDirectoryName(appName);
           //---PDA--
           // myConfig.Load(appPath + "\\config.xml");
           // myConfig.Load("config.xml");
           // XmlNode xNode;
           //// XmlElement xSMT, xQSMS, xChkFeederLine, xChkFirst, xChkPolar, xChkDispatchOrder, xErrorReconfirm, xChkDIDTime, xTimeSpan, xChkDIDTimeSec, xTimeSpanSec, xDoubleChkOldDid,xChkVendorPN; //,xChkMachine;    //(0001)
           // XmlElement xSMT, xQSMS, xChkFeederLine, xChkFirst, xChkPolar, xChkDispatchOrder, xErrorReconfirm, xChkDIDTime, xTimeSpan, xChkDIDTimeSec, xTimeSpanSec, xDoubleChkOldDid, xChkVendorPN, xControlLight; //,xChkMachine;    //(0001)
           // xNode = myConfig.SelectSingleNode("config");
           // xSMT = (XmlElement)xNode.SelectSingleNode("SMT");
           // xQSMS = (XmlElement)xNode.SelectSingleNode("QSMS");
           // xChkFeederLine = (XmlElement)xNode.SelectSingleNode("ChkFeederLine");
           // xChkFirst = (XmlElement)xNode.SelectSingleNode("ChkFirst");
           // xChkPolar = (XmlElement)xNode.SelectSingleNode("ChkPolar"); //(0001)
           // xChkDispatchOrder = (XmlElement)xNode.SelectSingleNode("ChkDispatchOrder");
           // xErrorReconfirm = (XmlElement)xNode.SelectSingleNode("ErrorReconfirm"); //(0003)
           // xChkDIDTime = (XmlElement)xNode.SelectSingleNode("ChkDIDTime");
           // xTimeSpan = (XmlElement)xNode.SelectSingleNode("TimeSpan");
           // xChkDIDTimeSec = (XmlElement)xNode.SelectSingleNode("ChkDIDTimeSec");
           // xTimeSpanSec = (XmlElement)xNode.SelectSingleNode("TimeSpanSec");//(0005)
           // xDoubleChkOldDid = (XmlElement)xNode.SelectSingleNode("DoubleChkOldDid");
           // xChkVendorPN = (XmlElement)xNode.SelectSingleNode("ChkVendorPN");
           // xControlLight = (XmlElement)xNode.SelectSingleNode("ControlLight");
           // //xChkVendorPN = (XmlElement)xNode.SelectSingleNode("ChkVendorPN");
           // //xChkMachine = (XmlElement)xNode.SelectSingleNode("ChkMachine");

            //SQLHelper.strSMTDBCon = xSMT.InnerText + "password=is6<2g;Persist Security Info=True";
            //SQLHelper.strQSMSDBCon = xQSMS.InnerText + "password=is6<2g;Persist Security Info=True";
            //Parameter.strChkFeederLine = xChkFeederLine.InnerText.Trim().ToString();
            //Parameter.strChkFirst = xChkFirst.InnerText.Trim().ToString();
            //Parameter.strChkPolar = xChkPolar.InnerText.Trim().ToString(); //(0001)
            //Parameter.strChkDispatchOrder = xChkDispatchOrder.InnerText.Trim().ToString(); //(0002)
            //Parameter.strErrorReconfirm = xErrorReconfirm.InnerText.Trim().ToString();//(0003)
            //Parameter.strChkDIDTime = xChkDIDTime.InnerText.Trim().ToString();
            //Parameter.strTimeSpan = double.Parse(xTimeSpan.InnerText.Trim().ToString());
            //Parameter.strChkDIDTimeSec = xChkDIDTimeSec.InnerText.Trim().ToString();
            //Parameter.strTimeSpanSec = double.Parse(xTimeSpanSec.InnerText.Trim().ToString());//(0005)
            //Parameter.DoubleChkOldDid = xDoubleChkOldDid.InnerText.Trim().ToString();
            //Parameter.strServer = xSMT.InnerText.Trim().Substring(8, 11);
            //Parameter.strChkVendorPN = xChkVendorPN.InnerText.Trim().ToString();
            //Parameter.ControlLight = xControlLight.InnerText.Trim().ToString();
            ////Parameter.strChkVendorPN = xChkVendorPN.InnerText.Trim().ToString();
            ////Parameter.strChkMachine = xChkMachine.InnerText.Trim().ToString();

            //--Test computer--
            //SQLHelper.strSMTDBCon = "server = 10.94.1.11;database=SMT;user id = sa; password=pqmb#7sa;Persist Security Info=True";
            //SQLHelper.strQSMSDBCon = "server = 10.94.1.16;database=QSMS;user id = sa; password=pqmb#7sa;Persist Security Info=True";
            //SQLHelper.strQSMSDBCon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\PalisadeWorldDatabase.mdf;Integrated Security=True;User Instance=True";
            
            //Parameter.strChkFeederLine = "Y";
            //Parameter.strChkFirst = "N";
            //Parameter.strChkPolar = "N"; //(0001)
            //Parameter.strChkDispatchOrder = "Y"; //(0002)
            //Parameter.strErrorReconfirm = "N";//(0003)
            //Parameter.strChkDIDTime = "N";
            //Parameter.strTimeSpan = 60;
            //Parameter.strChkDIDTimeSec = "N";
            //Parameter.strTimeSpanSec = 60;//(0005)
            //Parameter.DoubleChkOldDid = "Y";
            //Parameter.strServer = "10.97.2.11";
            //Parameter.strChkVendorPN = "N";
            //Parameter.ControlLight = "Y";
            ////Parameter.strChkVendorPN = xChkVendorPN.InnerText.Trim().ToString();
            ////Parameter.strChkMachine = xChkMachine.InnerText.Trim().ToString();

            //try
            //{
            //    Parameter.strChkMachine = RegeditManager.Read("ChkMachine");
            //}
            //catch
            //{
            //}   
        }

        ////private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Application.Exit();
        //}

        

        private void frmSelect_Load(object sender, EventArgs e)
        {
            txtOPID.Text = UID;
            barCodeDID.EnableScanner = true;
            //#region// Check if the Program has been opened.
            ////Process[] currentProcess = Process.GetProcesses();


            ////int currentProCount = 0;

            ////for (int i = 0; i < currentProcess.Length; i++)
            ////{
            ////    if (currentProcess[i].ProcessName.ToUpper() == Parameter.AppName.ToUpper() + ".EXE")
            ////    {
            ////        currentProcess[i].Kill();
            ////        currentProCount = currentProCount + 1;
            ////    }
            ////}
            ////if (currentProCount > 1)
            ////{
            ////    MessageBox.Show("程序已经运行,请检查！");
            ////    this.Close();
            ////}
            //#endregion    

            //strSQL = "select distinct line from Routingline where line<>'' union select distinct Line from Application_List order by line";
            //DataTable dtGetLine = sqlHelper.getDataTable(strSQL, SQLHelper.strSMTDBName);
            //if (dtGetLine.Rows.Count != 0)
            //{
            //    for (int intR = 0; intR < dtGetLine.Rows.Count; intR++)
            //    {
            //        cboLine.Items.Add(dtGetLine.Rows[intR]["Line"].ToString());
            //    }
            //}
            //获取相关设置
            //strSQL = "select * from QSMS_ProConfig where Station='DIDSlotLink' and line in ('" + Parameter.strLine + "','ALL') and [Session]='BASE'";
            //DataTable dtGetSetting = sqlHelper.getDataTable(strSQL, SQLHelper.strQSMSDBName);
            //DataRow dr = null;
            //try
            //{
            //    for (int i = 0; i < dtGetSetting.Rows.Count; i++)
            //    {
            //        dr = dtGetSetting.Rows[i];
            //        if (dr["Key"].ToString().ToUpper() == "CHECKSPLICEPN")
            //        {
            //            Parameter.strCheckSplicePN = dr["Value"].ToString();
            //        }
            //        if (dr["Key"].ToString().ToUpper() == "CHECKSPLICEREPLACEPN")
            //        {
            //            Parameter.strCheckSpliceReplacePN = dr["Value"].ToString();
            //        }                    
            //    }
            //}
            //catch (Exception)
            //{
            //    //MessageBox.Show("ข้อผิดพลาดของโปรแกรมกรุณาโทร QMS(Program Error , Please Call QMS)");
            //    MessageBox.Show("Program Error , Please Call QMS");
            //    return;
            //}

            try
            {              
                lblStatus.Text = "Query/CompareDID/ConfirmDID";
                btnCompareDID.Visible = true;
                txtScanDID.Visible = true;
                lblScanDID.Visible = true;


                //exec SP: DIDCompareM_GetInfo
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "EXEC DIDCompareM_GetInfo 'Factory', '', ''";
                cmd.CommandTimeout = 180;
                oConQSMS = new ConnectDBQSMS();
                Info = oConQSMS.Query(cmd);

                for (int i = 0; i < Info.Rows.Count; i++)
                {
                    cboFactory.Items.Add(Info.Rows[i][0].ToString().Trim());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLines.Items.Clear();
            cboSide.Items.Clear();
            cboMachine.Items.Clear();

            Factory = cboFactory.Text;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXEC DIDCompareM_GetInfo 'Line','"+Factory+"', ''";            
            cmd.CommandTimeout = 180;
            oConQSMS = new ConnectDBQSMS();
            Info = oConQSMS.Query(cmd);

            for (int i = 0; i < Info.Rows.Count; i++)
            {
                cboLines.Items.Add(Info.Rows[i][0].ToString().Trim());
            }
        }

        private void cboLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSide.Items.Clear();
            cboMachine.Items.Clear();
            Line = cboLines.Text;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXEC DIDCompareM_GetInfo 'Side','" + Line + "', ''";
            cmd.CommandTimeout = 180;
            oConQSMS = new ConnectDBQSMS();
            Info = oConQSMS.Query(cmd);

            for (int i = 0; i < Info.Rows.Count; i++)
            {
                cboSide.Items.Add(Info.Rows[i][0].ToString().Trim());
            }
        }

        private void cboSide_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMachine.Items.Clear();
            Line = cboLines.Text;
            Side = cboSide.Text;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXEC DIDCompareM_GetInfo 'Machine','" + Line + "', '" + Side + "'";
            cmd.CommandTimeout = 180;
            oConQSMS = new ConnectDBQSMS();
            Info = oConQSMS.Query(cmd);

            for (int i = 0; i < Info.Rows.Count; i++)
            {
                cboMachine.Items.Add(Info.Rows[i][0].ToString().Trim());
            }
        }

        private void cboMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            Factory = cboFactory.Text;
            Line = cboLines.Text;
            Side = cboSide.Text;
            Machine = cboMachine.Text;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXEC DIDCompareM_ChkInfo '" + Factory + "', '" + Line + "', '" + Side + "', '" + Machine + "', 'Query'";
            cmd.CommandTimeout = 180;
            oConQSMS = new ConnectDBQSMS();
            ChkData = oConQSMS.Query(cmd);
            
            dgvDID.DataSource = ChkData;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            CheckType = "";
            Factory = cboFactory.Text;
            Line = cboLines.Text;
            Side = cboSide.Text;
            Machine = cboMachine.Text;
            lblStatus.Text = "Query";
            CheckType = lblStatus.Text;

            txtMachine.Text = "";
            txtSlot.Text = "";
            txtLR.Text = "";
            txtOldDID.Text = "";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXEC DIDCompareM_ChkInfo '" + Factory + "', '" + Line + "', '" + Side + "', '" + Machine + "', '" + CheckType + "'";
            cmd.CommandTimeout = 180;
            oConQSMS = new ConnectDBQSMS();
            ChkData = oConQSMS.Query(cmd);

            QTY = ChkData.Rows.Count;
            //lblQTY.Text = "TotalQTY:" + QTY;
            dgvDID.DataSource = ChkData;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboFactory.Items.Clear();
            cboLines.Items.Clear();
            cboSide.Items.Clear();
            cboMachine.Items.Clear();
            txtMachine.Text = "";
            txtSlot.Text = "";
            txtLR.Text = "";
            txtOldDID.Text = "";
            lblStatus.Text = "Clear";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXEC DIDCompareM_GetInfo 'Factory','', ''";
            cmd.CommandTimeout = 180;
            oConQSMS = new ConnectDBQSMS();
            Info = oConQSMS.Query(cmd);

            for (int i = 0; i < Info.Rows.Count; i++)
            {
                cboFactory.Items.Add(Info.Rows[i][0].ToString().Trim());
            }
        }

        private void btnCompareDID_Click(object sender, EventArgs e)
        {
            //chbCompare.Checked = true;
            //chbConfirm.Checked = false;
            CheckType = "";
            Factory = cboFactory.Text;
            Line = cboLines.Text;
            Side = cboSide.Text;
            Machine = cboMachine.Text;
            lblStatus.Text = "CompareDID";
            CheckType = lblStatus.Text;

            txtMachine.Text = "";
            txtSlot.Text = "";
            txtLR.Text = "";
            txtOldDID.Text = "";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXEC DIDCompareM_ChkInfo '" + Factory + "', '" + Line + "', '" + Side + "', '" + Machine + "', '" + CheckType + "'";
            cmd.CommandTimeout = 180;
            oConQSMS = new ConnectDBQSMS();
            ChkData = oConQSMS.Query(cmd);

            QTY = ChkData.Rows.Count;
            //lblQTY.Text = "TotalQTY:" + QTY;
            dgvDID.DataSource = ChkData;
        }

        private void btnConfirmDID_Click(object sender, EventArgs e)
        {
            //chbConfirm.Checked = true;
            //chbCompare.Checked = false;
            CheckType = "";
            Factory = cboFactory.Text;
            Line = cboLines.Text;
            Side = cboSide.Text;
            Machine = cboMachine.Text;
            lblStatus.Text = "ConfirmDID";
            CheckType = lblStatus.Text;

            txtMachine.Text = "";
            txtSlot.Text = "";
            txtLR.Text = "";
            txtOldDID.Text = "";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXEC DIDCompareM_ChkInfo '" + Factory + "', '" + Line + "', '" + Side + "', '" + Machine + "', '" + CheckType + "'";
            cmd.CommandTimeout = 180;
            oConQSMS = new ConnectDBQSMS();
            ChkData = oConQSMS.Query(cmd);

            QTY = ChkData.Rows.Count;
            //lblQTY.Text = "TotalQTY:" + QTY;
            dgvDID.DataSource = ChkData;
        }

        private void dgvDID_Click(object sender, EventArgs e)
        {
            txtScanDID.Text = "";
            int rowNumber = 0;
            //--Click then access to text box--
            rowNumber = dgvDID.CurrentCell.RowNumber;

            //--set rows from textbox--
            Factory = cboFactory.Text;
            Line = cboLines.Text;
            Side = cboSide.Text;
            Machine = cboMachine.Text;

            if (ChkData.Rows.Count > 0)
            {
                for (int i = 0; i < ChkData.Rows.Count; i++)
                {
                    if (i == rowNumber)
                    {
                        txtMachine.Text = ChkData.Rows[i]["Machine"].ToString().Trim();
                        txtSlot.Text = ChkData.Rows[i]["Slot"].ToString().Trim();
                        txtLR.Text = ChkData.Rows[i]["LR"].ToString().Trim();
                        txtOldDID.Text = ChkData.Rows[i]["DID"].ToString().Trim();
                        txtScanDID.Focus();
                    }
                }
            }
            txtScanDID.Focus();
        }

        private void txtScanDID_KeyPress(object sender, KeyPressEventArgs e)
        {
            OldDID = txtOldDID.Text;
            ScanDID = txtScanDID.Text;
            CheckType = "";

            if (e.KeyChar == (char)Keys.Enter && txtScanDID.Text.Trim() != "")
            {
                if (ScanDID == "")
                {
                    MessageBox.Show("please enter DID that need to compare.");
                    txtScanDID.Text = "";
                    txtScanDID.Focus();
                    return;
                }

                CheckType = lblStatus.Text;

                //CompareDID = pcb.CompareDID(CheckType, OldDID, ScanDID, UID);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "EXEC DIDCompareM_ChkDID '" + CheckType + "', '" + OldDID + "', '" + ScanDID + "', '" + UID + "'";
                cmd.CommandTimeout = 180;
                oConQSMS = new ConnectDBQSMS();
                CompareDID = oConQSMS.Query(cmd);

                if (CompareDID.Rows[0]["Result"].ToString() == "Fail")
                {
                    message = CompareDID.Rows[0]["Des"].ToString();
                    ShowMessage("Error", message);
                    txtScanDID.Text = "";
                    txtScanDID.Focus();
                }
                else
                {
                    message = CompareDID.Rows[0]["Des"].ToString();
                    ShowMessage("Pass", message);
                    txtScanDID.Text = "";
                    txtScanDID.Focus();
                }

                if (CheckType == "CompareDID")
                {
                    btnCompareDID_Click(null, null);                    
                }
                if (CheckType == "ConfirmDID")
                {
                    btnConfirmDID_Click(null, null);                   
                }

                QTY = ChkData.Rows.Count;
                if (QTY > 0)
                {
                    txtMachine.Text = ChkData.Rows[0]["Machine"].ToString().Trim();
                    txtSlot.Text = ChkData.Rows[0]["Slot"].ToString().Trim();
                    txtLR.Text = ChkData.Rows[0]["LR"].ToString().Trim();
                    txtOldDID.Text = ChkData.Rows[0]["DID"].ToString().Trim();
                    //--Set text box in datagrid--
                    //txtMachine.Text = dgvDID.Rows[0].Cells["Machine"].Value.ToString();
                    //txtSlot.Text = dgvDID.Rows[0].Cells["Slot"].Value.ToString();
                    //txtLR.Text = dgvDID.Rows[0].Cells["LR"].Value.ToString();
                    //txtOldDID.Text = dgvDID.Rows[0].Cells["DID"].Value.ToString();
                }
                txtScanDID.Focus();
            }
        }

        private void ShowMessage(string level, string message)
        {
            PlaySound playSound = new PlaySound();

            if (level == "Error")
            {
                playSound.Play("\\Voice\\ERROR.WAV");
            }
            else
            {
                playSound.Play("\\Voice\\OK.WAV");
            }
            
            if (level == "Error")
            {
                txtMessage.ForeColor = Color.Red;
            }
            else
            {
                txtMessage.ForeColor = Color.Green;
            }

            txtMessage.Text = message;
            //txtScanSN.SelectAll();
        }

        private void frmSelect_Closed(object sender, EventArgs e)
        {
            this.Hide();

            barCodeDID.EnableScanner = false;

            frmLogin oFrmLogin = new frmLogin();
            oFrmLogin.Show();
        }

        private void barCodeDID_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (readerData.Text == "")
            {
                return;
            }
            else
            {
                txtScanDID.Text = readerData.Text;
            }
        }

        private void frmSelect_Activated(object sender, EventArgs e)
        {
            barCodeDID.EnableScanner = true;
        }
    }
}