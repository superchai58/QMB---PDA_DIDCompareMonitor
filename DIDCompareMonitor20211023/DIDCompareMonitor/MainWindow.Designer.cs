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
            this.cboLines.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboLines.FormattingEnabled = true;
            this.cboLines.Location = new System.Drawing.Point(275, 68);
            this.cboLines.Name = "cboLines";
            this.cboLines.Size = new System.Drawing.Size(90, 24);
            this.cboLines.TabIndex = 0;
            this.cboLines.SelectedIndexChanged += new System.EventHandler(this.cboLines_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Factory：";
            // 
            // cboFactory
            // 
            this.cboFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactory.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboFactory.FormattingEnabled = true;
            this.cboFactory.IntegralHeight = false;
            this.cboFactory.Location = new System.Drawing.Point(110, 68);
            this.cboFactory.Name = "cboFactory";
            this.cboFactory.Size = new System.Drawing.Size(90, 24);
            this.cboFactory.TabIndex = 3;
            this.cboFactory.SelectedIndexChanged += new System.EventHandler(this.cboFactory_SelectedIndexChanged);
            // 
            // dgvDID
            // 
            this.dgvDID.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDID.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDID.Location = new System.Drawing.Point(31, 196);
            this.dgvDID.Name = "dgvDID";
            this.dgvDID.ReadOnly = true;
            this.dgvDID.RowTemplate.Height = 23;
            this.dgvDID.Size = new System.Drawing.Size(936, 318);
            this.dgvDID.TabIndex = 4;
            this.dgvDID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDID_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(31, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message：";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMessage.Location = new System.Drawing.Point(31, 536);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(936, 46);
            this.txtMessage.TabIndex = 6;
            // 
            // cboMachine
            // 
            this.cboMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMachine.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboMachine.FormattingEnabled = true;
            this.cboMachine.Location = new System.Drawing.Point(632, 68);
            this.cboMachine.Name = "cboMachine";
            this.cboMachine.Size = new System.Drawing.Size(170, 24);
            this.cboMachine.TabIndex = 7;
            this.cboMachine.SelectedIndexChanged += new System.EventHandler(this.cboMachine_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(560, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Machine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(381, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Side:";
            // 
            // cboSide
            // 
            this.cboSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSide.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSide.FormattingEnabled = true;
            this.cboSide.Location = new System.Drawing.Point(447, 68);
            this.cboSide.Name = "cboSide";
            this.cboSide.Size = new System.Drawing.Size(90, 24);
            this.cboSide.TabIndex = 10;
            this.cboSide.SelectedIndexChanged += new System.EventHandler(this.cboSide_SelectedIndexChanged);
            // 
            // Machie
            // 
            this.Machie.AutoSize = true;
            this.Machie.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Machie.Location = new System.Drawing.Point(33, 128);
            this.Machie.Name = "Machie";
            this.Machie.Size = new System.Drawing.Size(72, 16);
            this.Machie.TabIndex = 11;
            this.Machie.Text = "Machine:";
            // 
            // txtMachine
            // 
            this.txtMachine.BackColor = System.Drawing.SystemColors.Control;
            this.txtMachine.Enabled = false;
            this.txtMachine.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMachine.Location = new System.Drawing.Point(110, 125);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.ReadOnly = true;
            this.txtMachine.Size = new System.Drawing.Size(90, 26);
            this.txtMachine.TabIndex = 12;
            // 
            // txtSlot
            // 
            this.txtSlot.Enabled = false;
            this.txtSlot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSlot.Location = new System.Drawing.Point(276, 125);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.ReadOnly = true;
            this.txtSlot.Size = new System.Drawing.Size(90, 26);
            this.txtSlot.TabIndex = 13;
            // 
            // txtLR
            // 
            this.txtLR.Enabled = false;
            this.txtLR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLR.Location = new System.Drawing.Point(449, 125);
            this.txtLR.Name = "txtLR";
            this.txtLR.ReadOnly = true;
            this.txtLR.Size = new System.Drawing.Size(90, 26);
            this.txtLR.TabIndex = 14;
            // 
            // txtScanDID
            // 
            this.txtScanDID.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtScanDID.Location = new System.Drawing.Point(646, 164);
            this.txtScanDID.Name = "txtScanDID";
            this.txtScanDID.Size = new System.Drawing.Size(310, 29);
            this.txtScanDID.TabIndex = 15;
            this.txtScanDID.Visible = false;
            this.txtScanDID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanDID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(217, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Slot:";
            // 
            // LR
            // 
            this.LR.AutoSize = true;
            this.LR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LR.Location = new System.Drawing.Point(386, 128);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(32, 16);
            this.LR.TabIndex = 17;
            this.LR.Text = "LR:";
            // 
            // lblScanDID
            // 
            this.lblScanDID.AutoSize = true;
            this.lblScanDID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScanDID.Location = new System.Drawing.Point(560, 177);
            this.lblScanDID.Name = "lblScanDID";
            this.lblScanDID.Size = new System.Drawing.Size(80, 16);
            this.lblScanDID.TabIndex = 18;
            this.lblScanDID.Text = "ScanDID:";
            this.lblScanDID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(562, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "OldDID:";
            // 
            // txtOldDID
            // 
            this.txtOldDID.Enabled = false;
            this.txtOldDID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOldDID.Location = new System.Drawing.Point(632, 125);
            this.txtOldDID.Name = "txtOldDID";
            this.txtOldDID.ReadOnly = true;
            this.txtOldDID.Size = new System.Drawing.Size(187, 26);
            this.txtOldDID.TabIndex = 20;
            this.txtOldDID.WordWrap = false;
            // 
            // btnCompareDID
            // 
            this.btnCompareDID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompareDID.Location = new System.Drawing.Point(275, 18);
            this.btnCompareDID.Name = "btnCompareDID";
            this.btnCompareDID.Size = new System.Drawing.Size(110, 30);
            this.btnCompareDID.TabIndex = 21;
            this.btnCompareDID.Text = "CompareDID";
            this.btnCompareDID.UseVisualStyleBackColor = true;
            this.btnCompareDID.Visible = false;
            this.btnCompareDID.Click += new System.EventHandler(this.btnCompareDID_Click);
            // 
            // btnConfirmDID
            // 
            this.btnConfirmDID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirmDID.Location = new System.Drawing.Point(396, 18);
            this.btnConfirmDID.Name = "btnConfirmDID";
            this.btnConfirmDID.Size = new System.Drawing.Size(110, 30);
            this.btnConfirmDID.TabIndex = 22;
            this.btnConfirmDID.Text = "ConfirmDID";
            this.btnConfirmDID.UseVisualStyleBackColor = true;
            this.btnConfirmDID.Visible = false;
            this.btnConfirmDID.Click += new System.EventHandler(this.btnConfirmDID_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(34, 18);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(110, 30);
            this.btnQuery.TabIndex = 23;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // DetailInfo
            // 
            this.DetailInfo.AutoSize = true;
            this.DetailInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DetailInfo.Location = new System.Drawing.Point(35, 177);
            this.DetailInfo.Name = "DetailInfo";
            this.DetailInfo.Size = new System.Drawing.Size(107, 16);
            this.DetailInfo.TabIndex = 24;
            this.DetailInfo.Text = "DetailInfo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(216, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Line:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(154, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 30);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblStatus.Location = new System.Drawing.Point(143, 175);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(187, 16);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Please select mode：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(827, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "OPID:";
            // 
            // txtOPID
            // 
            this.txtOPID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOPID.Location = new System.Drawing.Point(879, 125);
            this.txtOPID.Name = "txtOPID";
            this.txtOPID.Size = new System.Drawing.Size(77, 26);
            this.txtOPID.TabIndex = 31;
            // 
            // lblQTY
            // 
            this.lblQTY.AutoSize = true;
            this.lblQTY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQTY.ForeColor = System.Drawing.Color.Yellow;
            this.lblQTY.Location = new System.Drawing.Point(386, 177);
            this.lblQTY.Name = "lblQTY";
            this.lblQTY.Size = new System.Drawing.Size(0, 16);
            this.lblQTY.TabIndex = 32;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(994, 594);
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
            this.Controls.Add(this.txtScanDID);
            this.Controls.Add(this.txtLR);
            this.Controls.Add(this.txtSlot);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.Machie);
            this.Controls.Add(this.cboSide);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMachine);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDID);
            this.Controls.Add(this.cboFactory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLines);
            this.Name = "MainWindow";
            this.Text = "DIDCompareMonitor 20171102";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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