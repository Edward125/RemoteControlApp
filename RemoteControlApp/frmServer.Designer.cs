namespace RemoteControlApp
{
    partial class frmServer
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
            this.grbMessage = new System.Windows.Forms.GroupBox();
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.grbDuplexProgramStatus = new System.Windows.Forms.GroupBox();
            this.btnDuplexCloseAll = new System.Windows.Forms.Button();
            this.btnDuplexOpenAll = new System.Windows.Forms.Button();
            this.btnDuplexH = new System.Windows.Forms.Button();
            this.btnDuplexG = new System.Windows.Forms.Button();
            this.btnDuplexF = new System.Windows.Forms.Button();
            this.btnDuplexE = new System.Windows.Forms.Button();
            this.btnDuplexD = new System.Windows.Forms.Button();
            this.btnDuplexC = new System.Windows.Forms.Button();
            this.btnDuplexB = new System.Windows.Forms.Button();
            this.btnDuplexA = new System.Windows.Forms.Button();
            this.grbFICTSingle = new System.Windows.Forms.GroupBox();
            this.btnSingleCloseAll = new System.Windows.Forms.Button();
            this.btnSingleOpenAll = new System.Windows.Forms.Button();
            this.btnSingleH = new System.Windows.Forms.Button();
            this.btnSingleG = new System.Windows.Forms.Button();
            this.btnSingleF = new System.Windows.Forms.Button();
            this.btnSingleE = new System.Windows.Forms.Button();
            this.btnSingleD = new System.Windows.Forms.Button();
            this.btnSingleC = new System.Windows.Forms.Button();
            this.btnSingleB = new System.Windows.Forms.Button();
            this.btnSingleA = new System.Windows.Forms.Button();
            this.grbStageConnectStatus = new System.Windows.Forms.GroupBox();
            this.btnConnectH = new System.Windows.Forms.Button();
            this.btnConnectG = new System.Windows.Forms.Button();
            this.btnConnectF = new System.Windows.Forms.Button();
            this.btnConnectE = new System.Windows.Forms.Button();
            this.btnConnectD = new System.Windows.Forms.Button();
            this.btnConnectC = new System.Windows.Forms.Button();
            this.btnConnectB = new System.Windows.Forms.Button();
            this.btnConnectA = new System.Windows.Forms.Button();
            this.grbMessage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbDuplexProgramStatus.SuspendLayout();
            this.grbFICTSingle.SuspendLayout();
            this.grbStageConnectStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMessage
            // 
            this.grbMessage.Controls.Add(this.lstMessage);
            this.grbMessage.Location = new System.Drawing.Point(12, 233);
            this.grbMessage.Name = "grbMessage";
            this.grbMessage.Size = new System.Drawing.Size(644, 252);
            this.grbMessage.TabIndex = 0;
            this.grbMessage.TabStop = false;
            this.grbMessage.Text = "History Message";
            // 
            // lstMessage
            // 
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.ItemHeight = 14;
            this.lstMessage.Location = new System.Drawing.Point(6, 21);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(626, 214);
            this.lstMessage.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIP);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Controls.Add(this.grbDuplexProgramStatus);
            this.groupBox2.Controls.Add(this.grbFICTSingle);
            this.groupBox2.Controls.Add(this.grbStageConnectStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Status";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(13, 33);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 14);
            this.lblIP.TabIndex = 14;
            this.lblIP.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(39, 30);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(172, 22);
            this.txtIP.TabIndex = 13;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbDuplexProgramStatus
            // 
            this.grbDuplexProgramStatus.Controls.Add(this.btnDuplexCloseAll);
            this.grbDuplexProgramStatus.Controls.Add(this.btnDuplexOpenAll);
            this.grbDuplexProgramStatus.Controls.Add(this.btnDuplexH);
            this.grbDuplexProgramStatus.Controls.Add(this.btnDuplexG);
            this.grbDuplexProgramStatus.Controls.Add(this.btnDuplexF);
            this.grbDuplexProgramStatus.Controls.Add(this.btnDuplexE);
            this.grbDuplexProgramStatus.Controls.Add(this.btnDuplexD);
            this.grbDuplexProgramStatus.Controls.Add(this.btnDuplexC);
            this.grbDuplexProgramStatus.Controls.Add(this.btnDuplexB);
            this.grbDuplexProgramStatus.Controls.Add(this.btnDuplexA);
            this.grbDuplexProgramStatus.Location = new System.Drawing.Point(435, 27);
            this.grbDuplexProgramStatus.Name = "grbDuplexProgramStatus";
            this.grbDuplexProgramStatus.Size = new System.Drawing.Size(203, 180);
            this.grbDuplexProgramStatus.TabIndex = 12;
            this.grbDuplexProgramStatus.TabStop = false;
            this.grbDuplexProgramStatus.Text = "FICT Duplex Program Status";
            // 
            // btnDuplexCloseAll
            // 
            this.btnDuplexCloseAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplexCloseAll.Location = new System.Drawing.Point(106, 149);
            this.btnDuplexCloseAll.Name = "btnDuplexCloseAll";
            this.btnDuplexCloseAll.Size = new System.Drawing.Size(89, 26);
            this.btnDuplexCloseAll.TabIndex = 12;
            this.btnDuplexCloseAll.Text = "Close All";
            this.btnDuplexCloseAll.UseVisualStyleBackColor = true;
            // 
            // btnDuplexOpenAll
            // 
            this.btnDuplexOpenAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplexOpenAll.Location = new System.Drawing.Point(6, 149);
            this.btnDuplexOpenAll.Name = "btnDuplexOpenAll";
            this.btnDuplexOpenAll.Size = new System.Drawing.Size(89, 26);
            this.btnDuplexOpenAll.TabIndex = 11;
            this.btnDuplexOpenAll.Text = "Open All";
            this.btnDuplexOpenAll.UseVisualStyleBackColor = true;
            // 
            // btnDuplexH
            // 
            this.btnDuplexH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplexH.Location = new System.Drawing.Point(106, 117);
            this.btnDuplexH.Name = "btnDuplexH";
            this.btnDuplexH.Size = new System.Drawing.Size(89, 26);
            this.btnDuplexH.TabIndex = 10;
            this.btnDuplexH.Text = "H Close";
            this.btnDuplexH.UseVisualStyleBackColor = true;
            // 
            // btnDuplexG
            // 
            this.btnDuplexG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplexG.Location = new System.Drawing.Point(106, 85);
            this.btnDuplexG.Name = "btnDuplexG";
            this.btnDuplexG.Size = new System.Drawing.Size(89, 26);
            this.btnDuplexG.TabIndex = 9;
            this.btnDuplexG.Text = "G Close";
            this.btnDuplexG.UseVisualStyleBackColor = true;
            // 
            // btnDuplexF
            // 
            this.btnDuplexF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplexF.Location = new System.Drawing.Point(106, 53);
            this.btnDuplexF.Name = "btnDuplexF";
            this.btnDuplexF.Size = new System.Drawing.Size(89, 26);
            this.btnDuplexF.TabIndex = 8;
            this.btnDuplexF.Text = "F Close";
            this.btnDuplexF.UseVisualStyleBackColor = true;
            // 
            // btnDuplexE
            // 
            this.btnDuplexE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplexE.Location = new System.Drawing.Point(106, 21);
            this.btnDuplexE.Name = "btnDuplexE";
            this.btnDuplexE.Size = new System.Drawing.Size(89, 26);
            this.btnDuplexE.TabIndex = 7;
            this.btnDuplexE.Text = "E Close";
            this.btnDuplexE.UseVisualStyleBackColor = true;
            // 
            // btnDuplexD
            // 
            this.btnDuplexD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplexD.Location = new System.Drawing.Point(6, 117);
            this.btnDuplexD.Name = "btnDuplexD";
            this.btnDuplexD.Size = new System.Drawing.Size(89, 26);
            this.btnDuplexD.TabIndex = 6;
            this.btnDuplexD.Text = "D Close";
            this.btnDuplexD.UseVisualStyleBackColor = true;
            // 
            // btnDuplexC
            // 
            this.btnDuplexC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplexC.Location = new System.Drawing.Point(6, 85);
            this.btnDuplexC.Name = "btnDuplexC";
            this.btnDuplexC.Size = new System.Drawing.Size(89, 26);
            this.btnDuplexC.TabIndex = 5;
            this.btnDuplexC.Text = "C Close";
            this.btnDuplexC.UseVisualStyleBackColor = true;
            // 
            // btnDuplexB
            // 
            this.btnDuplexB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplexB.Location = new System.Drawing.Point(6, 53);
            this.btnDuplexB.Name = "btnDuplexB";
            this.btnDuplexB.Size = new System.Drawing.Size(89, 26);
            this.btnDuplexB.TabIndex = 4;
            this.btnDuplexB.Text = "B Close";
            this.btnDuplexB.UseVisualStyleBackColor = true;
            // 
            // btnDuplexA
            // 
            this.btnDuplexA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuplexA.Location = new System.Drawing.Point(6, 21);
            this.btnDuplexA.Name = "btnDuplexA";
            this.btnDuplexA.Size = new System.Drawing.Size(89, 26);
            this.btnDuplexA.TabIndex = 3;
            this.btnDuplexA.Text = "A Close";
            this.btnDuplexA.UseVisualStyleBackColor = true;
            // 
            // grbFICTSingle
            // 
            this.grbFICTSingle.Controls.Add(this.btnSingleCloseAll);
            this.grbFICTSingle.Controls.Add(this.btnSingleOpenAll);
            this.grbFICTSingle.Controls.Add(this.btnSingleH);
            this.grbFICTSingle.Controls.Add(this.btnSingleG);
            this.grbFICTSingle.Controls.Add(this.btnSingleF);
            this.grbFICTSingle.Controls.Add(this.btnSingleE);
            this.grbFICTSingle.Controls.Add(this.btnSingleD);
            this.grbFICTSingle.Controls.Add(this.btnSingleC);
            this.grbFICTSingle.Controls.Add(this.btnSingleB);
            this.grbFICTSingle.Controls.Add(this.btnSingleA);
            this.grbFICTSingle.Location = new System.Drawing.Point(222, 27);
            this.grbFICTSingle.Name = "grbFICTSingle";
            this.grbFICTSingle.Size = new System.Drawing.Size(202, 180);
            this.grbFICTSingle.TabIndex = 11;
            this.grbFICTSingle.TabStop = false;
            this.grbFICTSingle.Text = "FICT Single Program Status";
            // 
            // btnSingleCloseAll
            // 
            this.btnSingleCloseAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleCloseAll.Location = new System.Drawing.Point(101, 149);
            this.btnSingleCloseAll.Name = "btnSingleCloseAll";
            this.btnSingleCloseAll.Size = new System.Drawing.Size(89, 26);
            this.btnSingleCloseAll.TabIndex = 12;
            this.btnSingleCloseAll.Text = "Close All";
            this.btnSingleCloseAll.UseVisualStyleBackColor = true;
            // 
            // btnSingleOpenAll
            // 
            this.btnSingleOpenAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleOpenAll.Location = new System.Drawing.Point(6, 149);
            this.btnSingleOpenAll.Name = "btnSingleOpenAll";
            this.btnSingleOpenAll.Size = new System.Drawing.Size(89, 26);
            this.btnSingleOpenAll.TabIndex = 11;
            this.btnSingleOpenAll.Text = "Open All";
            this.btnSingleOpenAll.UseVisualStyleBackColor = true;
            // 
            // btnSingleH
            // 
            this.btnSingleH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleH.Location = new System.Drawing.Point(101, 117);
            this.btnSingleH.Name = "btnSingleH";
            this.btnSingleH.Size = new System.Drawing.Size(89, 26);
            this.btnSingleH.TabIndex = 10;
            this.btnSingleH.Text = "H Close";
            this.btnSingleH.UseVisualStyleBackColor = true;
            // 
            // btnSingleG
            // 
            this.btnSingleG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleG.Location = new System.Drawing.Point(101, 85);
            this.btnSingleG.Name = "btnSingleG";
            this.btnSingleG.Size = new System.Drawing.Size(89, 26);
            this.btnSingleG.TabIndex = 9;
            this.btnSingleG.Text = "G Close";
            this.btnSingleG.UseVisualStyleBackColor = true;
            // 
            // btnSingleF
            // 
            this.btnSingleF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleF.Location = new System.Drawing.Point(101, 53);
            this.btnSingleF.Name = "btnSingleF";
            this.btnSingleF.Size = new System.Drawing.Size(89, 26);
            this.btnSingleF.TabIndex = 8;
            this.btnSingleF.Text = "F Close";
            this.btnSingleF.UseVisualStyleBackColor = true;
            // 
            // btnSingleE
            // 
            this.btnSingleE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleE.Location = new System.Drawing.Point(101, 21);
            this.btnSingleE.Name = "btnSingleE";
            this.btnSingleE.Size = new System.Drawing.Size(89, 26);
            this.btnSingleE.TabIndex = 7;
            this.btnSingleE.Text = "E Close";
            this.btnSingleE.UseVisualStyleBackColor = true;
            // 
            // btnSingleD
            // 
            this.btnSingleD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleD.Location = new System.Drawing.Point(6, 117);
            this.btnSingleD.Name = "btnSingleD";
            this.btnSingleD.Size = new System.Drawing.Size(89, 26);
            this.btnSingleD.TabIndex = 6;
            this.btnSingleD.Text = "D Close";
            this.btnSingleD.UseVisualStyleBackColor = true;
            // 
            // btnSingleC
            // 
            this.btnSingleC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleC.Location = new System.Drawing.Point(6, 85);
            this.btnSingleC.Name = "btnSingleC";
            this.btnSingleC.Size = new System.Drawing.Size(89, 26);
            this.btnSingleC.TabIndex = 5;
            this.btnSingleC.Text = "C Close";
            this.btnSingleC.UseVisualStyleBackColor = true;
            // 
            // btnSingleB
            // 
            this.btnSingleB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleB.Location = new System.Drawing.Point(6, 53);
            this.btnSingleB.Name = "btnSingleB";
            this.btnSingleB.Size = new System.Drawing.Size(89, 26);
            this.btnSingleB.TabIndex = 4;
            this.btnSingleB.Text = "B Close";
            this.btnSingleB.UseVisualStyleBackColor = true;
            // 
            // btnSingleA
            // 
            this.btnSingleA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleA.Location = new System.Drawing.Point(6, 21);
            this.btnSingleA.Name = "btnSingleA";
            this.btnSingleA.Size = new System.Drawing.Size(89, 26);
            this.btnSingleA.TabIndex = 3;
            this.btnSingleA.Text = "A Close";
            this.btnSingleA.UseVisualStyleBackColor = true;
            // 
            // grbStageConnectStatus
            // 
            this.grbStageConnectStatus.Controls.Add(this.btnConnectH);
            this.grbStageConnectStatus.Controls.Add(this.btnConnectG);
            this.grbStageConnectStatus.Controls.Add(this.btnConnectF);
            this.grbStageConnectStatus.Controls.Add(this.btnConnectE);
            this.grbStageConnectStatus.Controls.Add(this.btnConnectD);
            this.grbStageConnectStatus.Controls.Add(this.btnConnectC);
            this.grbStageConnectStatus.Controls.Add(this.btnConnectB);
            this.grbStageConnectStatus.Controls.Add(this.btnConnectA);
            this.grbStageConnectStatus.Location = new System.Drawing.Point(11, 58);
            this.grbStageConnectStatus.Name = "grbStageConnectStatus";
            this.grbStageConnectStatus.Size = new System.Drawing.Size(200, 151);
            this.grbStageConnectStatus.TabIndex = 2;
            this.grbStageConnectStatus.TabStop = false;
            this.grbStageConnectStatus.Text = "FICT Stage Connect Status";
            // 
            // btnConnectH
            // 
            this.btnConnectH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectH.Location = new System.Drawing.Point(101, 117);
            this.btnConnectH.Name = "btnConnectH";
            this.btnConnectH.Size = new System.Drawing.Size(89, 26);
            this.btnConnectH.TabIndex = 10;
            this.btnConnectH.Text = "H Disconnect";
            this.btnConnectH.UseVisualStyleBackColor = true;
            // 
            // btnConnectG
            // 
            this.btnConnectG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectG.Location = new System.Drawing.Point(101, 85);
            this.btnConnectG.Name = "btnConnectG";
            this.btnConnectG.Size = new System.Drawing.Size(89, 26);
            this.btnConnectG.TabIndex = 9;
            this.btnConnectG.Text = "G Disconnect";
            this.btnConnectG.UseVisualStyleBackColor = true;
            // 
            // btnConnectF
            // 
            this.btnConnectF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectF.Location = new System.Drawing.Point(101, 53);
            this.btnConnectF.Name = "btnConnectF";
            this.btnConnectF.Size = new System.Drawing.Size(89, 26);
            this.btnConnectF.TabIndex = 8;
            this.btnConnectF.Text = "F Disconnect";
            this.btnConnectF.UseVisualStyleBackColor = true;
            // 
            // btnConnectE
            // 
            this.btnConnectE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectE.Location = new System.Drawing.Point(101, 21);
            this.btnConnectE.Name = "btnConnectE";
            this.btnConnectE.Size = new System.Drawing.Size(89, 26);
            this.btnConnectE.TabIndex = 7;
            this.btnConnectE.Text = "E Disconnect";
            this.btnConnectE.UseVisualStyleBackColor = true;
            // 
            // btnConnectD
            // 
            this.btnConnectD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectD.Location = new System.Drawing.Point(6, 117);
            this.btnConnectD.Name = "btnConnectD";
            this.btnConnectD.Size = new System.Drawing.Size(89, 26);
            this.btnConnectD.TabIndex = 6;
            this.btnConnectD.Text = "D Disconnct";
            this.btnConnectD.UseVisualStyleBackColor = true;
            // 
            // btnConnectC
            // 
            this.btnConnectC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectC.Location = new System.Drawing.Point(6, 85);
            this.btnConnectC.Name = "btnConnectC";
            this.btnConnectC.Size = new System.Drawing.Size(89, 26);
            this.btnConnectC.TabIndex = 5;
            this.btnConnectC.Text = "C Disconnect";
            this.btnConnectC.UseVisualStyleBackColor = true;
            // 
            // btnConnectB
            // 
            this.btnConnectB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectB.Location = new System.Drawing.Point(6, 53);
            this.btnConnectB.Name = "btnConnectB";
            this.btnConnectB.Size = new System.Drawing.Size(89, 26);
            this.btnConnectB.TabIndex = 4;
            this.btnConnectB.Text = "B Disconnect";
            this.btnConnectB.UseVisualStyleBackColor = true;
            // 
            // btnConnectA
            // 
            this.btnConnectA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectA.Location = new System.Drawing.Point(6, 21);
            this.btnConnectA.Name = "btnConnectA";
            this.btnConnectA.Size = new System.Drawing.Size(89, 26);
            this.btnConnectA.TabIndex = 3;
            this.btnConnectA.Text = "A Disconnect";
            this.btnConnectA.UseVisualStyleBackColor = true;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbMessage);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmServer";
            this.Text = "frmServer";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.grbMessage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbDuplexProgramStatus.ResumeLayout(false);
            this.grbFICTSingle.ResumeLayout(false);
            this.grbStageConnectStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMessage;
        private System.Windows.Forms.ListBox lstMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbStageConnectStatus;
        private System.Windows.Forms.GroupBox grbDuplexProgramStatus;
        private System.Windows.Forms.Button btnDuplexH;
        private System.Windows.Forms.Button btnDuplexG;
        private System.Windows.Forms.Button btnDuplexF;
        private System.Windows.Forms.Button btnDuplexE;
        private System.Windows.Forms.Button btnDuplexD;
        private System.Windows.Forms.Button btnDuplexC;
        private System.Windows.Forms.Button btnDuplexB;
        private System.Windows.Forms.Button btnDuplexA;
        private System.Windows.Forms.GroupBox grbFICTSingle;
        private System.Windows.Forms.Button btnSingleH;
        private System.Windows.Forms.Button btnSingleG;
        private System.Windows.Forms.Button btnSingleF;
        private System.Windows.Forms.Button btnSingleE;
        private System.Windows.Forms.Button btnSingleD;
        private System.Windows.Forms.Button btnSingleC;
        private System.Windows.Forms.Button btnSingleB;
        private System.Windows.Forms.Button btnSingleA;
        private System.Windows.Forms.Button btnConnectH;
        private System.Windows.Forms.Button btnConnectG;
        private System.Windows.Forms.Button btnConnectF;
        private System.Windows.Forms.Button btnConnectE;
        private System.Windows.Forms.Button btnConnectD;
        private System.Windows.Forms.Button btnConnectC;
        private System.Windows.Forms.Button btnConnectB;
        private System.Windows.Forms.Button btnConnectA;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnDuplexCloseAll;
        private System.Windows.Forms.Button btnDuplexOpenAll;
        private System.Windows.Forms.Button btnSingleCloseAll;
        private System.Windows.Forms.Button btnSingleOpenAll;
    }
}