using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIDCompareMonitor.Domain;
using DIDCompareMonitor.Utility;
using System.Collections;

namespace DIDCompareMonitor
{
    public partial class MainWindow : Form
    {
        private PCB pcb = null;

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


        private DataTable Info = null;
        private DataTable ChkData = null;
        private DataTable CompareDID = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                //pcb = new PCB(ShareInfo.LogOnData.Conn);
                pcb = new PCB(Program.LogOnData.Conn, Program.LogOnData.QSMSConn);
                //pcb = new PCB(ShareInfo.LogOnData.Conn, Program.LogOnData.QSMSConn);

                Station = Program.LogOnData.Name;
                UID = Program.LogOnData.UserID;
                txtOPID.Text = UID;
                //A_Line = Program.LogOnData.Line;
                //A_Factory = Program.LogOnData.Factory;
                //Right = Program.LogOnData.Rights;
                lblStatus.Text = "Query/CompareDID/ConfirmDID";
                if (Program.LogOnData.Rights.Split(',').Contains("CompareDID") == true)
                {
                    btnCompareDID.Visible = true;
                    txtScanDID.Visible = true;
                    lblScanDID.Visible = true;
                
                }


                if (Program.LogOnData.Rights.Split(',').Contains("ConfirmDID") == true)
                {
                    btnConfirmDID.Visible = true;
                    txtScanDID.Visible = true;
                    lblScanDID.Visible = true;

                }


                Info = pcb.GetInfo("Factory","","");
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

            Info = pcb.GetInfo("Line", Factory, "");
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

            Info = pcb.GetInfo("Side", Line, "");
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

            Info = pcb.GetInfo("Machine", Line, Side);
            for (int i = 0; i < Info.Rows.Count; i++)
            {
                cboMachine.Items.Add(Info.Rows[i][0].ToString().Trim());
            }

        }


        private void cboMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Factory=cboFactory.Text;
            Line = cboLines.Text;
            Side = cboSide.Text;
            Machine = cboMachine.Text;

            ChkData = pcb.ChkData("Query",Factory, Line, Side, Machine);
            dgvDID.DataSource = ChkData;

        }


        //private void dgvDID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        private void dgvDID_MouseClick(object sender, MouseEventArgs e)//点击dataView内空白处也可以取数据

        {
            txtScanDID.Text = "";
            txtMachine.Text = dgvDID.CurrentRow.Cells["Machine"].Value.ToString();
            txtSlot.Text = dgvDID.CurrentRow.Cells["Slot"].Value.ToString();
            txtLR.Text = dgvDID.CurrentRow.Cells["LR"].Value.ToString();
            txtOldDID.Text= dgvDID.CurrentRow.Cells["DID"].Value.ToString();
            txtScanDID.Focus();

        }

        //private void barCodeDID_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        //{
        //    txtScanDID.Text = readerData.Text.trim();
        //}

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

                CompareDID = pcb.CompareDID(CheckType,OldDID, ScanDID, UID);
                if (CompareDID.Rows[0]["Result"].ToString() == "Fail")
                {   
                    message = CompareDID.Rows[0]["Des"].ToString();
                    ShowMessage(MessageLevel.Error, message);
                    txtScanDID.Text = "";
                    txtScanDID.Focus();
                }
                else
                {
                    message = CompareDID.Rows[0]["Des"].ToString();
                    ShowMessage(MessageLevel.Pass, message);
                    txtScanDID.Text = "";
                    txtScanDID.Focus();
                }

                if (CheckType == "CompareDID")
                {
                    btnCompareDID.PerformClick();
                }
                if (CheckType == "ConfirmDID")
                {
                    btnConfirmDID.PerformClick();
                }

                QTY = ChkData.Rows.Count;
                if (QTY > 0)
                    {

                        txtMachine.Text = dgvDID.Rows[0].Cells["Machine"].Value.ToString();
                        txtSlot.Text = dgvDID.Rows[0].Cells["Slot"].Value.ToString();
                        txtLR.Text = dgvDID.Rows[0].Cells["LR"].Value.ToString();
                        txtOldDID.Text = dgvDID.Rows[0].Cells["DID"].Value.ToString();
                    }
                txtScanDID.Focus();
            }
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


            ChkData = pcb.ChkData(CheckType,Factory, Line, Side, Machine);
            QTY = ChkData.Rows.Count;
            lblQTY.Text ="TotalQTY:" + QTY;
            dgvDID.DataSource = ChkData;


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


            ChkData = pcb.ChkData(CheckType, Factory, Line, Side, Machine);
            QTY = ChkData.Rows.Count;
            lblQTY.Text = "TotalQTY:" + QTY;
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

            ChkData = pcb.ChkData(CheckType, Factory, Line, Side, Machine);
            QTY = ChkData.Rows.Count;
            lblQTY.Text = "TotalQTY:" + QTY;
            dgvDID.DataSource = ChkData;

        }


        private void ShowMessage(MessageLevel level, string message)
        {
            SoundUtility.Sound(level);
            if (level == MessageLevel.Error)
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

            Info = pcb.GetInfo("Factory", "", "");
            for (int i = 0; i < Info.Rows.Count; i++)
            {
                cboFactory.Items.Add(Info.Rows[i][0].ToString().Trim());
            }

        }

        private void Machie_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LR_Click(object sender, EventArgs e)
        {

        }
    }
}
