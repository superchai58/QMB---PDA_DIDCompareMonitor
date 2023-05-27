namespace DIDCompareMonitor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboLines = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFactory = new System.Windows.Forms.ComboBox();
            this.dgvDID = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.cboMachine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSide = new System.Windows.Forms.ComboBox();
            this.Machie = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.txtLR = new System.Windows.Forms.TextBox();
            this.txtScanDID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LR = new System.Windows.Forms.Label();
            this.lblScanDID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOldDID = new System.Windows.Forms.TextBox();
            this.btnCompareDID = new System.Windows.Forms.Button();
            this.btnConfirmDID = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.DetailInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOPID = new System.Windows.Forms.TextBox();
            this.lblQTY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDID)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLines
            // 
            this.cboLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLines.FormattingEnabled = true;
            this.cboLines.Location = new System.Drawing.Point(83, 31);
            this.cboLines.Name = "cboLines";
            this.cboLines.Size = new System.Drawing.Size(41, 21);
            this.cboLines.TabIndex = 0;
            this.cboLines.SelectedIndexChanged += new System.EventHandler(this.cboLines_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fac";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboFactory
            // 
            this.cboFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFactory.FormattingEnabled = true;
            this.cboFactory.IntegralHeight = false;
            this.cboFactory.Location = new System.Drawing.Point(21, 31);
            this.cboFactory.Name = "cboFactory";
            this.cboFactory.Size = new System.Drawing.Size(41, 21);
            this.cboFactory.TabIndex = 3;
            this.cboFactory.SelectedIndexChanged += new System.EventHandler(this.cboFactory_SelectedIndexChanged);
            // 
            // dgvDID
            // 
            this.dgvDID.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDID.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDID.Location = new System.Drawing.Point(2, 132);
            this.dgvDID.Name = "dgvDID";
            this.dgvDID.ReadOnly = true;
            this.dgvDID.RowTemplate.Height = 23;
            this.dgvDID.Size = new System.Drawing.Size(305, 77);
            this.dgvDID.TabIndex = 4;
            this.dgvDID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDID_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(0, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 11);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMessage.Location = new System.Drawing.Point(2, 225);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(305, 50);
            this.txtMessage.TabIndex = 6;
            // 
            // cboMachine
            // 
            this.cboMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMachine.FormattingEnabled = true;
            this.cboMachine.Location = new System.Drawing.Point(215, 31);
            this.cboMachine.Name = "cboMachine";
            this.cboMachine.Size = new System.Drawing.Size(92, 21);
            this.cboMachine.TabIndex = 7;
            this.cboMachine.SelectedIndexChanged += new System.EventHandler(this.cboMachine_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mach";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Side";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboSide
            // 
            this.cboSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSide.FormattingEnabled = true;
            this.cboSide.Location = new System.Drawing.Point(146, 31);
            this.cboSide.Name = "cboSide";
            this.cboSide.Size = new System.Drawing.Size(41, 21);
            this.cboSide.TabIndex = 10;
            this.cboSide.SelectedIndexChanged += new System.EventHandler(this.cboSide_SelectedIndexChanged);
            // 
            // Machie
            // 
            this.Machie.AutoSize = true;
            this.Machie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Machie.Location = new System.Drawing.Point(-1, 60);
            this.Machie.Name = "Machie";
            this.Machie.Size = new System.Drawing.Size(34, 13);
            this.Machie.TabIndex = 11;
            this.Machie.Text = "Mach";
            this.Machie.Click += new System.EventHandler(this.Machie_Click);
            // 
            // txtMachine
            // 
            this.txtMachine.BackColor = System.Drawing.SystemColors.Control;
            this.txtMachine.Enabled = false;
            this.txtMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachine.Location = new System.Drawing.Point(29, 57);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.ReadOnly = true;
            this.txtMachine.Size = new System.Drawing.Size(92, 20);
            this.txtMachine.TabIndex = 12;
            // 
            // txtSlot
            // 
            this.txtSlot.Enabled = false;
            this.txtSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot.Location = new System.Drawing.Point(139, 57);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.ReadOnly = true;
            this.txtSlot.Size = new System.Drawing.Size(35, 20);
            this.txtSlot.TabIndex = 13;
            // 
            // txtLR
            // 
            this.txtLR.Enabled = false;
            this.txtLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLR.Location = new System.Drawing.Point(188, 57);
            this.txtLR.Name = "txtLR";
            this.txtLR.ReadOnly = true;
            this.txtLR.Size = new System.Drawing.Size(35, 20);
            this.txtLR.TabIndex = 14;
            // 
            // txtScanDID
            // 
            this.txtScanDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanDID.Location = new System.Drawing.Point(53, 107);
            this.txtScanDID.Name = "txtScanDID";
            this.txtScanDID.Size = new System.Drawing.Size(254, 20);
            this.txtScanDID.TabIndex = 15;
            this.txtScanDID.Visible = false;
            this.txtScanDID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanDID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Slot";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LR
            // 
            this.LR.AutoSize = true;
            this.LR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LR.Location = new System.Drawing.Point(171, 60);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(21, 13);
            this.LR.TabIndex = 17;
            this.LR.Text = "LR";
            this.LR.Click += new System.EventHandler(this.LR_Click);
            // 
            // lblScanDID
            // 
            this.lblScanDID.AutoSize = true;
            this.lblScanDID.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScanDID.Location = new System.Drawing.Point(0, 112);
            this.lblScanDID.Name = "lblScanDID";
            this.lblScanDID.Size = new System.Drawing.Size(54, 11);
            this.lblScanDID.TabIndex = 18;
            this.lblScanDID.Text = "ScanDID";
            this.lblScanDID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "OldDID";
            // 
            // txtOldDID
            // 
            this.txtOldDID.Enabled = false;
            this.txtOldDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldDID.Location = new System.Drawing.Point(259, 57);
            this.txtOldDID.Name = "txtOldDID";
            this.txtOldDID.ReadOnly = true;
            this.txtOldDID.Size = new System.Drawing.Size(48, 20);
            this.txtOldDID.TabIndex = 20;
            this.txtOldDID.WordWrap = false;
            // 
            // btnCompareDID
            // 
            this.btnCompareDID.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompareDID.Location = new System.Drawing.Point(154, 7);
            this.btnCompareDID.Name = "btnCompareDID";
            this.btnCompareDID.Size = new System.Drawing.Size(76, 22);
            this.btnCompareDID.TabIndex = 21;
            this.btnCompareDID.Text = "CPDID";
            this.btnCompareDID.UseVisualStyleBackColor = true;
            this.btnCompareDID.Visible = false;
            this.btnCompareDID.Click += new System.EventHandler(this.btnCompareDID_Click);
            // 
            // btnConfirmDID
            // 
            this.btnConfirmDID.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirmDID.Location = new System.Drawing.Point(231, 7);
            this.btnConfirmDID.Name = "btnConfirmDID";
            this.btnConfirmDID.Size = new System.Drawing.Size(76, 22);
            this.btnConfirmDID.TabIndex = 22;
            this.btnConfirmDID.Text = "CFDID";
            this.btnConfirmDID.UseVisualStyleBackColor = true;
            this.btnConfirmDID.Visible = false;
            this.btnConfirmDID.Click += new System.EventHandler(this.btnConfirmDID_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(0, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(76, 22);
            this.btnQuery.TabIndex = 23;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // DetailInfo
            // 
            this.DetailInfo.AutoSize = true;
            this.DetailInfo.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DetailInfo.Location = new System.Drawing.Point(0, 87);
            this.DetailInfo.Name = "DetailInfo";
            this.DetailInfo.Size = new System.Drawing.Size(40, 11);
            this.DetailInfo.TabIndex = 24;
            this.DetailInfo.Text = "DetIF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Line";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(77, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 22);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStatus.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblStatus.Location = new System.Drawing.Point(37, 87);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(33, 11);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "OPID";
            // 
            // txtOPID
            // 
            this.txtOPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPID.Location = new System.Drawing.Point(259, 82);
            this.txtOPID.Name = "txtOPID";
            this.txtOPID.Size = new System.Drawing.Size(48, 20);
            this.txtOPID.TabIndex = 31;
            // 
            // lblQTY
            // 
            this.lblQTY.AutoSize = true;
            this.lblQTY.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQTY.ForeColor = System.Drawing.Color.Yellow;
            this.lblQTY.Location = new System.Drawing.Point(386, 192);
            this.lblQTY.Name = "lblQTY";
            this.lblQTY.Size = new System.Drawing.Size(0, 16);
            this.lblQTY.TabIndex = 32;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(311, 281);
            this.Controls.Add(this.txtScanDID);
            this.Controls.Add(this.txtLR);
            this.Controls.Add(this.txtSlot);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.cboFactory);
            this.Controls.Add(this.cboMachine);
            this.Controls.Add(this.cboLines);
            this.Controls.Add(this.lblQTY);
            this.Controls.Add(this.txtOPID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DetailInfo);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnConfirmDID);
            this.Controls.Add(this.btnCompareDID);
            this.Controls.Add(this.txtOldDID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblScanDID);
            this.Controls.Add(this.LR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Machie);
            this.Controls.Add(this.cboSide);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "PDA_DIDCompareMonitor20211023";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            //////// 
            //////// barCodeDID
            //////// 
            ////this.barCodeDID.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled;
            ////this.barCodeDID.DecoderParameters.CODABARParams.ClsiEditing = false;
            ////this.barCodeDID.DecoderParameters.CODABARParams.NotisEditing = false;
            ////this.barCodeDID.DecoderParameters.CODABARParams.Redundancy = true;
            ////this.barCodeDID.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled;
            ////this.barCodeDID.DecoderParameters.CODE128Params.EAN128 = true;
            ////this.barCodeDID.DecoderParameters.CODE128Params.ISBT128 = true;
            ////this.barCodeDID.DecoderParameters.CODE128Params.Other128 = true;
            ////this.barCodeDID.DecoderParameters.CODE128Params.Redundancy = false;
            ////this.barCodeDID.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled;
            ////this.barCodeDID.DecoderParameters.CODE39Params.Code32Prefix = false;
            ////this.barCodeDID.DecoderParameters.CODE39Params.Concatenation = false;
            ////this.barCodeDID.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            ////this.barCodeDID.DecoderParameters.CODE39Params.FullAscii = false;
            ////this.barCodeDID.DecoderParameters.CODE39Params.Redundancy = false;
            ////this.barCodeDID.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            ////this.barCodeDID.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            ////this.barCodeDID.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined;
            ////this.barCodeDID.DecoderParameters.CODE93Params.Redundancy = false;
            ////this.barCodeDID.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled;
            ////this.barCodeDID.DecoderParameters.D2OF5Params.Redundancy = true;
            ////this.barCodeDID.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled;
            ////this.barCodeDID.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled;
            ////this.barCodeDID.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            ////this.barCodeDID.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled;
            ////this.barCodeDID.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None;
            ////this.barCodeDID.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            ////this.barCodeDID.DecoderParameters.I2OF5Params.Redundancy = true;
            ////this.barCodeDID.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            ////this.barCodeDID.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled;
            ////this.barCodeDID.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled;
            ////this.barCodeDID.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One;
            ////this.barCodeDID.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10;
            ////this.barCodeDID.DecoderParameters.MSIParams.Redundancy = true;
            ////this.barCodeDID.DecoderParameters.MSIParams.ReportCheckDigit = false;
            ////this.barCodeDID.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled;
            ////this.barCodeDID.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System;
            ////this.barCodeDID.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            ////this.barCodeDID.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled;
            ////this.barCodeDID.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            ////this.barCodeDID.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None;
            ////this.barCodeDID.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            ////this.barCodeDID.DeviceName = null;
            ////this.barCodeDID.EnableScanner = true;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED;
            ////this.barCodeDID.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined;
            ////this.barCodeDID.ScanParameters.BeepFrequency = 2670;
            ////this.barCodeDID.ScanParameters.BeepTime = 200;
            ////this.barCodeDID.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None;
            ////this.barCodeDID.ScanParameters.LedTime = 3000;
            ////this.barCodeDID.ScanParameters.ScanType = Barcode.ScanTypes.Foreground;
            ////this.barCodeDID.ScanParameters.WaveFile = "";
            ////this.barCodeDID.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.barCodeDID_OnRead);
        }

        #endregion

        private System.Windows.Forms.ComboBox cboLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFactory;
        private System.Windows.Forms.DataGridView dgvDID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ComboBox cboMachine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSide;
        private System.Windows.Forms.Label Machie;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.TextBox txtLR;
        private System.Windows.Forms.TextBox txtScanDID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LR;
        private System.Windows.Forms.Label lblScanDID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOldDID;
        private System.Windows.Forms.Button btnCompareDID;
        private System.Windows.Forms.Button btnConfirmDID;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label DetailInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOPID;
        private System.Windows.Forms.Label lblQTY;
    }
}