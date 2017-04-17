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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.grbStageConnectStatus = new System.Windows.Forms.GroupBox();
            this.btnConnectA = new System.Windows.Forms.Button();
            this.btnConnectB = new System.Windows.Forms.Button();
            this.btnConnectC = new System.Windows.Forms.Button();
            this.btnConnectD = new System.Windows.Forms.Button();
            this.btnConnectE = new System.Windows.Forms.Button();
            this.btnConnectF = new System.Windows.Forms.Button();
            this.btnConnectG = new System.Windows.Forms.Button();
            this.btnConnectH = new System.Windows.Forms.Button();
            this.grbFICTSingle = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnSingleD = new System.Windows.Forms.Button();
            this.btnSingleC = new System.Windows.Forms.Button();
            this.btnSingleB = new System.Windows.Forms.Button();
            this.btnSingeA = new System.Windows.Forms.Button();
            this.grbDuplexProgramStatus = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.btnSingleOpenAll = new System.Windows.Forms.Button();
            this.btnSingleCLoseAll = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.grbMessage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbStageConnectStatus.SuspendLayout();
            this.grbFICTSingle.SuspendLayout();
            this.grbDuplexProgramStatus.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIP);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.grbDuplexProgramStatus);
            this.groupBox2.Controls.Add(this.grbFICTSingle);
            this.groupBox2.Controls.Add(this.grbStageConnectStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            // grbFICTSingle
            // 
            this.grbFICTSingle.Controls.Add(this.btnSingleCLoseAll);
            this.grbFICTSingle.Controls.Add(this.btnSingleOpenAll);
            this.grbFICTSingle.Controls.Add(this.button9);
            this.grbFICTSingle.Controls.Add(this.button10);
            this.grbFICTSingle.Controls.Add(this.button11);
            this.grbFICTSingle.Controls.Add(this.button12);
            this.grbFICTSingle.Controls.Add(this.btnSingleD);
            this.grbFICTSingle.Controls.Add(this.btnSingleC);
            this.grbFICTSingle.Controls.Add(this.btnSingleB);
            this.grbFICTSingle.Controls.Add(this.btnSingeA);
            this.grbFICTSingle.Location = new System.Drawing.Point(222, 27);
            this.grbFICTSingle.Name = "grbFICTSingle";
            this.grbFICTSingle.Size = new System.Drawing.Size(202, 180);
            this.grbFICTSingle.TabIndex = 11;
            this.grbFICTSingle.TabStop = false;
            this.grbFICTSingle.Text = "FICT Single Program Status";
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(101, 117);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 26);
            this.button9.TabIndex = 10;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(101, 85);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 26);
            this.button10.TabIndex = 9;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(101, 53);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 26);
            this.button11.TabIndex = 8;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(101, 21);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 26);
            this.button12.TabIndex = 7;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
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
            // btnSingeA
            // 
            this.btnSingeA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingeA.Location = new System.Drawing.Point(6, 21);
            this.btnSingeA.Name = "btnSingeA";
            this.btnSingeA.Size = new System.Drawing.Size(89, 26);
            this.btnSingeA.TabIndex = 3;
            this.btnSingeA.Text = "A Close";
            this.btnSingeA.UseVisualStyleBackColor = true;
            // 
            // grbDuplexProgramStatus
            // 
            this.grbDuplexProgramStatus.Controls.Add(this.button27);
            this.grbDuplexProgramStatus.Controls.Add(this.button28);
            this.grbDuplexProgramStatus.Controls.Add(this.button17);
            this.grbDuplexProgramStatus.Controls.Add(this.button18);
            this.grbDuplexProgramStatus.Controls.Add(this.button19);
            this.grbDuplexProgramStatus.Controls.Add(this.button20);
            this.grbDuplexProgramStatus.Controls.Add(this.button21);
            this.grbDuplexProgramStatus.Controls.Add(this.button22);
            this.grbDuplexProgramStatus.Controls.Add(this.button23);
            this.grbDuplexProgramStatus.Controls.Add(this.button24);
            this.grbDuplexProgramStatus.Location = new System.Drawing.Point(435, 27);
            this.grbDuplexProgramStatus.Name = "grbDuplexProgramStatus";
            this.grbDuplexProgramStatus.Size = new System.Drawing.Size(203, 180);
            this.grbDuplexProgramStatus.TabIndex = 12;
            this.grbDuplexProgramStatus.TabStop = false;
            this.grbDuplexProgramStatus.Text = "FICT Duplex Program Status";
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Location = new System.Drawing.Point(106, 117);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(89, 26);
            this.button17.TabIndex = 10;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Location = new System.Drawing.Point(106, 85);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(89, 26);
            this.button18.TabIndex = 9;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Location = new System.Drawing.Point(106, 53);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(89, 26);
            this.button19.TabIndex = 8;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Location = new System.Drawing.Point(106, 21);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(89, 26);
            this.button20.TabIndex = 7;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Location = new System.Drawing.Point(6, 117);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(89, 26);
            this.button21.TabIndex = 6;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Location = new System.Drawing.Point(6, 85);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(89, 26);
            this.button22.TabIndex = 5;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Location = new System.Drawing.Point(6, 53);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(89, 26);
            this.button23.TabIndex = 4;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Location = new System.Drawing.Point(6, 21);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(89, 26);
            this.button24.TabIndex = 3;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
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
            // btnSingleCLoseAll
            // 
            this.btnSingleCLoseAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleCLoseAll.Location = new System.Drawing.Point(101, 149);
            this.btnSingleCLoseAll.Name = "btnSingleCLoseAll";
            this.btnSingleCLoseAll.Size = new System.Drawing.Size(89, 26);
            this.btnSingleCLoseAll.TabIndex = 12;
            this.btnSingleCLoseAll.Text = "Close All";
            this.btnSingleCLoseAll.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button27.Location = new System.Drawing.Point(106, 149);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(89, 26);
            this.button27.TabIndex = 12;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button28.Location = new System.Drawing.Point(6, 149);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(89, 26);
            this.button28.TabIndex = 11;
            this.button28.Text = "button28";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 13;
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
            this.grbMessage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbStageConnectStatus.ResumeLayout(false);
            this.grbFICTSingle.ResumeLayout(false);
            this.grbDuplexProgramStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMessage;
        private System.Windows.Forms.ListBox lstMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbStageConnectStatus;
        private System.Windows.Forms.GroupBox grbDuplexProgramStatus;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.GroupBox grbFICTSingle;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnSingleD;
        private System.Windows.Forms.Button btnSingleC;
        private System.Windows.Forms.Button btnSingleB;
        private System.Windows.Forms.Button btnSingeA;
        private System.Windows.Forms.Button btnConnectH;
        private System.Windows.Forms.Button btnConnectG;
        private System.Windows.Forms.Button btnConnectF;
        private System.Windows.Forms.Button btnConnectE;
        private System.Windows.Forms.Button btnConnectD;
        private System.Windows.Forms.Button btnConnectC;
        private System.Windows.Forms.Button btnConnectB;
        private System.Windows.Forms.Button btnConnectA;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button btnSingleCLoseAll;
        private System.Windows.Forms.Button btnSingleOpenAll;
    }
}