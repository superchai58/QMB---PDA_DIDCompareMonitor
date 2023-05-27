namespace PDA_DIDSlotLink
{
    partial class frmSelect
    {
        /// <summary>
        /// 必需的设计器变量。

        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// 清理所有正在使用的资源。

        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。

        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompareDID = new System.Windows.Forms.Button();
            this.btnConfirmDID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFactory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboLines = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSide = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMachine = new System.Windows.Forms.ComboBox();
            this.Machie = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.LR = new System.Windows.Forms.Label();
            this.txtLR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOldDID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailInfo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblScanDID = new System.Windows.Forms.Label();
            this.txtScanDID = new System.Windows.Forms.TextBox();
            this.dgvDID = new System.Windows.Forms.DataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtOPID = new System.Windows.Forms.TextBox();
            this.barCodeDID = new Barcode.Barcode();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnQuery.Location = new System.Drawing.Point(3, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(60, 22);
            this.btnQuery.TabIndex = 24;
            this.btnQuery.Text = "Query";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(81, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 22);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCompareDID
            // 
            this.btnCompareDID.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCompareDID.Location = new System.Drawing.Point(159, 3);
            this.btnCompareDID.Name = "btnCompareDID";
            this.btnCompareDID.Size = new System.Drawing.Size(71, 22);
            this.btnCompareDID.TabIndex = 30;
            this.btnCompareDID.Text = "CompareDID";
            this.btnCompareDID.Click += new System.EventHandler(this.btnCompareDID_Click);
            // 
            // btnConfirmDID
            // 
            this.btnConfirmDID.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmDID.Location = new System.Drawing.Point(251, 3);
            this.btnConfirmDID.Name = "btnConfirmDID";
            this.btnConfirmDID.Size = new System.Drawing.Size(71, 22);
            this.btnConfirmDID.TabIndex = 31;
            this.btnConfirmDID.Text = "ConfirmDID";
            this.btnConfirmDID.Click += new System.EventHandler(this.btnConfirmDID_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.Text = "Fac";
            // 
            // cboFactory
            // 
            this.cboFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.cboFactory.Location = new System.Drawing.Point(24, 31);
            this.cboFactory.Name = "cboFactory";
            this.cboFactory.Size = new System.Drawing.Size(45, 19);
            this.cboFactory.TabIndex = 34;
            this.cboFactory.SelectedIndexChanged += new System.EventHandler(this.cboFactory_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(67, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.Text = "Line";
            // 
            // cboLines
            // 
            this.cboLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.cboLines.Location = new System.Drawing.Point(89, 31);
            this.cboLines.Name = "cboLines";
            this.cboLines.Size = new System.Drawing.Size(45, 19);
            this.cboLines.TabIndex = 37;
            this.cboLines.SelectedIndexChanged += new System.EventHandler(this.cboLines_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(132, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.Text = "Side";
            // 
            // cboSide
            // 
            this.cboSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.cboSide.Location = new System.Drawing.Point(157, 31);
            this.cboSide.Name = "cboSide";
            this.cboSide.Size = new System.Drawing.Size(45, 19);
            this.cboSide.TabIndex = 40;
            this.cboSide.SelectedIndexChanged += new System.EventHandler(this.cboSide_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(200, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.Text = "Mach";
            // 
            // cboMachine
            // 
            this.cboMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.cboMachine.Location = new System.Drawing.Point(230, 31);
            this.cboMachine.Name = "cboMachine";
            this.cboMachine.Size = new System.Drawing.Size(92, 19);
            this.cboMachine.TabIndex = 43;
            this.cboMachine.SelectedIndexChanged += new System.EventHandler(this.cboMachine_SelectedIndexChanged);
            // 
            // Machie
            // 
            this.Machie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.Machie.Location = new System.Drawing.Point(3, 62);
            this.Machie.Name = "Machie";
            this.Machie.Size = new System.Drawing.Size(34, 13);
            this.Machie.Text = "Mach";
            // 
            // txtMachine
            // 
            this.txtMachine.BackColor = System.Drawing.SystemColors.Control;
            this.txtMachine.Enabled = false;
            this.txtMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.txtMachine.Location = new System.Drawing.Point(33, 57);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.ReadOnly = true;
            this.txtMachine.Size = new System.Drawing.Size(98, 19);
            this.txtMachine.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(130, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.Text = "Slot";
            // 
            // txtSlot
            // 
            this.txtSlot.BackColor = System.Drawing.SystemColors.Control;
            this.txtSlot.Enabled = false;
            this.txtSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.txtSlot.Location = new System.Drawing.Point(152, 57);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.ReadOnly = true;
            this.txtSlot.Size = new System.Drawing.Size(35, 19);
            this.txtSlot.TabIndex = 49;
            // 
            // LR
            // 
            this.LR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.LR.Location = new System.Drawing.Point(185, 62);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(21, 13);
            this.LR.Text = "LR";
            // 
            // txtLR
            // 
            this.txtLR.BackColor = System.Drawing.SystemColors.Control;
            this.txtLR.Enabled = false;
            this.txtLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.txtLR.Location = new System.Drawing.Point(202, 57);
            this.txtLR.Name = "txtLR";
            this.txtLR.ReadOnly = true;
            this.txtLR.Size = new System.Drawing.Size(35, 19);
            this.txtLR.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.label8.Location = new System.Drawing.Point(235, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.Text = "OldDID";
            // 
            // txtOldDID
            // 
            this.txtOldDID.BackColor = System.Drawing.SystemColors.Control;
            this.txtOldDID.Enabled = false;
            this.txtOldDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.txtOldDID.Location = new System.Drawing.Point(274, 57);
            this.txtOldDID.Name = "txtOldDID";
            this.txtOldDID.ReadOnly = true;
            this.txtOldDID.Size = new System.Drawing.Size(48, 19);
            this.txtOldDID.TabIndex = 55;
            this.txtOldDID.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(245, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.Text = "OPID";
            // 
            // DetailInfo
            // 
            this.DetailInfo.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold);
            this.DetailInfo.Location = new System.Drawing.Point(3, 90);
            this.DetailInfo.Name = "DetailInfo";
            this.DetailInfo.Size = new System.Drawing.Size(40, 11);
            this.DetailInfo.Text = "DetIF";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStatus.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblStatus.Location = new System.Drawing.Point(36, 90);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(33, 11);
            this.lblStatus.Text = "Mode";
            // 
            // lblScanDID
            // 
            this.lblScanDID.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblScanDID.Location = new System.Drawing.Point(3, 114);
            this.lblScanDID.Name = "lblScanDID";
            this.lblScanDID.Size = new System.Drawing.Size(54, 11);
            this.lblScanDID.Text = "ScanDID";
            this.lblScanDID.Visible = false;
            // 
            // txtScanDID
            // 
            this.txtScanDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.txtScanDID.Location = new System.Drawing.Point(48, 107);
            this.txtScanDID.Name = "txtScanDID";
            this.txtScanDID.Size = new System.Drawing.Size(274, 19);
            this.txtScanDID.TabIndex = 65;
            this.txtScanDID.Visible = false;
            this.txtScanDID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanDID_KeyPress);
            // 
            // dgvDID
            // 
            this.dgvDID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvDID.Location = new System.Drawing.Point(3, 131);
            this.dgvDID.Name = "dgvDID";
            this.dgvDID.Size = new System.Drawing.Size(319, 100);
            this.dgvDID.TabIndex = 66;
            this.dgvDID.Click += new System.EventHandler(this.dgvDID_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 11);
            this.label3.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMessage.Location = new System.Drawing.Point(3, 248);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(319, 41);
            this.txtMessage.TabIndex = 69;
            // 
            // txtOPID
            // 
            this.txtOPID.BackColor = System.Drawing.SystemColors.Control;
            this.txtOPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
            this.txtOPID.Location = new System.Drawing.Point(274, 82);
            this.txtOPID.Name = "txtOPID";
            this.txtOPID.ReadOnly = true;
            this.txtOPID.Size = new System.Drawing.Size(48, 19);
            this.txtOPID.TabIndex = 56;
            // 
            // barCodeDID
            // 
            this.barCodeDID.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barCodeDID_OnRead);
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(325, 295);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDID);
            this.Controls.Add(this.txtScanDID);
            this.Controls.Add(this.lblScanDID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.DetailInfo);
            this.Controls.Add(this.txtOPID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOldDID);
            this.Controls.Add(this.txtLR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSlot);
            this.Controls.Add(this.LR);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Machie);
            this.Controls.Add(this.cboSide);
            this.Controls.Add(this.cboLines);
            this.Controls.Add(this.cboFactory);
            this.Controls.Add(this.cboMachine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmDID);
            this.Controls.Add(this.btnCompareDID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelect";
            this.Text = "DIDCompareMonitor";
            this.Load += new System.EventHandler(this.frmSelect_Load);
            this.Closed += new System.EventHandler(this.frmSelect_Closed);
            this.Activated += new System.EventHandler(this.frmSelect_Activated);
            this.ResumeLayout(false);
            //// 
            //// barCodeDID
            //// 
            this.barCodeDID.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.barCodeDID.DecoderParameters.CODABARParams.NotisEditing = false;
            this.barCodeDID.DecoderParameters.CODABARParams.Redundancy = true;
            this.barCodeDID.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.CODE128Params.EAN128 = true;
            this.barCodeDID.DecoderParameters.CODE128Params.ISBT128 = true;
            this.barCodeDID.DecoderParameters.CODE128Params.Other128 = true;
            this.barCodeDID.DecoderParameters.CODE128Params.Redundancy = false;
            this.barCodeDID.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.barCodeDID.DecoderParameters.CODE39Params.Concatenation = false;
            this.barCodeDID.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.barCodeDID.DecoderParameters.CODE39Params.FullAscii = false;
            this.barCodeDID.DecoderParameters.CODE39Params.Redundancy = false;
            this.barCodeDID.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.barCodeDID.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.barCodeDID.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.DecoderParameters.CODE93Params.Redundancy = false;
            this.barCodeDID.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            this.barCodeDID.DecoderParameters.D2OF5Params.Redundancy = true;
            this.barCodeDID.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.barCodeDID.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            this.barCodeDID.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.barCodeDID.DecoderParameters.I2OF5Params.Redundancy = true;
            this.barCodeDID.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.barCodeDID.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            this.barCodeDID.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            this.barCodeDID.DecoderParameters.MSIParams.Redundancy = true;
            this.barCodeDID.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.barCodeDID.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            this.barCodeDID.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.barCodeDID.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            this.barCodeDID.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.barCodeDID.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            this.barCodeDID.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.barCodeDID.DeviceName = null;
            this.barCodeDID.EnableScanner = true;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            this.barCodeDID.ScanParameters.BeepFrequency = 2670;
            this.barCodeDID.ScanParameters.BeepTime = 200;
            this.barCodeDID.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            this.barCodeDID.ScanParameters.LedTime = 3000;
            this.barCodeDID.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            this.barCodeDID.ScanParameters.WaveFile = "";
            this.barCodeDID.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barCodeDID_OnRead);

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCompareDID;
        private System.Windows.Forms.Button btnConfirmDID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFactory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboLines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMachine;
        private System.Windows.Forms.Label Machie;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.Label LR;
        private System.Windows.Forms.TextBox txtLR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOldDID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DetailInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblScanDID;
        private System.Windows.Forms.TextBox txtScanDID;
        private System.Windows.Forms.DataGrid dgvDID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtOPID;
        private Barcode.Barcode barCodeDID;

        //private System.Windows.Forms.ComboBox cboLine;
        //private System.Windows.Forms.Label lblLine;
        //private System.Windows.Forms.ComboBox cboLR;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.ComboBox cboLR1;
    }
}

