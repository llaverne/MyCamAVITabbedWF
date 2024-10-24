namespace MyIPCamAVIControl
{
    partial class MyIPCamManager
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
            Disconnect();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMakeAVI = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkAddDateTime = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkEnableAutoCapture = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNextSnapshot = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkDateTime = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtResetFrameCounter = new System.Windows.Forms.MaskedTextBox();
            this.chkAddFrameCount = new System.Windows.Forms.CheckBox();
            this.cboFormat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.lnkPath = new System.Windows.Forms.LinkLabel();
            this.txtPeriod = new System.Windows.Forms.MaskedTextBox();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamePrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AForgeVideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.cboVideoResolution = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkInvertImage = new System.Windows.Forms.CheckBox();
            this.cboCameras = new System.Windows.Forms.ComboBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "format. (AVIs cannot use GIF)";
            // 
            // btnMakeAVI
            // 
            this.btnMakeAVI.Location = new System.Drawing.Point(275, 166);
            this.btnMakeAVI.Name = "btnMakeAVI";
            this.btnMakeAVI.Size = new System.Drawing.Size(83, 23);
            this.btnMakeAVI.TabIndex = 16;
            this.btnMakeAVI.Text = "Make AVI";
            this.btnMakeAVI.UseVisualStyleBackColor = true;
            this.btnMakeAVI.Click += new System.EventHandler(this.btnMakeAVI_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "date && time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "frame #";
            // 
            // chkAddDateTime
            // 
            this.chkAddDateTime.AutoSize = true;
            this.chkAddDateTime.Location = new System.Drawing.Point(265, 93);
            this.chkAddDateTime.Name = "chkAddDateTime";
            this.chkAddDateTime.Size = new System.Drawing.Size(28, 27);
            this.chkAddDateTime.TabIndex = 12;
            this.chkAddDateTime.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "3. Save it in";
            // 
            // chkEnableAutoCapture
            // 
            this.chkEnableAutoCapture.AutoSize = true;
            this.chkEnableAutoCapture.Enabled = false;
            this.chkEnableAutoCapture.Location = new System.Drawing.Point(11, 23);
            this.chkEnableAutoCapture.Name = "chkEnableAutoCapture";
            this.chkEnableAutoCapture.Size = new System.Drawing.Size(72, 27);
            this.chkEnableAutoCapture.TabIndex = 6;
            this.chkEnableAutoCapture.Text = "Enable";
            this.chkEnableAutoCapture.UseVisualStyleBackColor = true;
            this.chkEnableAutoCapture.CheckedChanged += new System.EventHandler(this.chkEnableAutoCapture_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEnableAutoCapture);
            this.groupBox1.Controls.Add(this.lblNextSnapshot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.chkDateTime);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtResetFrameCounter);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnMakeAVI);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chkAddDateTime);
            this.groupBox1.Controls.Add(this.chkAddFrameCount);
            this.groupBox1.Controls.Add(this.cboFormat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnChangePath);
            this.groupBox1.Controls.Add(this.lnkPath);
            this.groupBox1.Controls.Add(this.txtPeriod);
            this.groupBox1.Controls.Add(this.cboPeriod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNamePrefix);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(246, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 204);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto-capture";
            // 
            // lblNextSnapshot
            // 
            this.lblNextSnapshot.AutoSize = true;
            this.lblNextSnapshot.Location = new System.Drawing.Point(143, 24);
            this.lblNextSnapshot.Name = "lblNextSnapshot";
            this.lblNextSnapshot.Size = new System.Drawing.Size(53, 13);
            this.lblNextSnapshot.TabIndex = 26;
            this.lblNextSnapshot.Text = "1/1/2011";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "(Next snapshot: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "and";
            // 
            // chkDateTime
            // 
            this.chkDateTime.AutoSize = true;
            this.chkDateTime.Location = new System.Drawing.Point(265, 47);
            this.chkDateTime.Name = "chkDateTime";
            this.chkDateTime.Size = new System.Drawing.Size(129, 27);
            this.chkDateTime.TabIndex = 9;
            this.chkDateTime.Text = "Overlay Date/Time";
            this.chkDateTime.UseVisualStyleBackColor = true;
            this.chkDateTime.CheckedChanged += new System.EventHandler(this.chkDateTime_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "name are overwritten.";
            // 
            // txtResetFrameCounter
            // 
            this.txtResetFrameCounter.Location = new System.Drawing.Point(321, 73);
            this.txtResetFrameCounter.Name = "txtResetFrameCounter";
            this.txtResetFrameCounter.PromptChar = ' ';
            this.txtResetFrameCounter.Size = new System.Drawing.Size(45, 20);
            this.txtResetFrameCounter.TabIndex = 11;
            this.txtResetFrameCounter.Text = "1";
            this.txtResetFrameCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResetFrameCounter.Leave += new System.EventHandler(this.txtResetFrameCounter_Leave);
            this.txtResetFrameCounter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtResetFrameCounter_MouseDoubleClick);
            // 
            // chkAddFrameCount
            // 
            this.chkAddFrameCount.AutoSize = true;
            this.chkAddFrameCount.Location = new System.Drawing.Point(265, 76);
            this.chkAddFrameCount.Name = "chkAddFrameCount";
            this.chkAddFrameCount.Size = new System.Drawing.Size(28, 27);
            this.chkAddFrameCount.TabIndex = 10;
            this.chkAddFrameCount.UseVisualStyleBackColor = true;
            // 
            // cboFormat
            // 
            this.cboFormat.FormattingEnabled = true;
            this.cboFormat.Items.AddRange(new object[] {
            "JPG",
            "GIF",
            "PNG",
            "BMP",
            "WMF",
            "ICO"});
            this.cboFormat.Location = new System.Drawing.Point(69, 109);
            this.cboFormat.Name = "cboFormat";
            this.cboFormat.Size = new System.Drawing.Size(48, 21);
            this.cboFormat.TabIndex = 13;
            this.cboFormat.SelectedIndexChanged += new System.EventHandler(this.cboFormat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Existing images with same";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "&& add:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "1. Snap a picture every";
            // 
            // btnChangePath
            // 
            this.btnChangePath.Location = new System.Drawing.Point(20, 166);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.Size = new System.Drawing.Size(83, 23);
            this.btnChangePath.TabIndex = 15;
            this.btnChangePath.Text = "Change Path";
            this.btnChangePath.UseVisualStyleBackColor = true;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // lnkPath
            // 
            this.lnkPath.AutoSize = true;
            this.lnkPath.Location = new System.Drawing.Point(70, 141);
            this.lnkPath.Name = "lnkPath";
            this.lnkPath.Size = new System.Drawing.Size(22, 13);
            this.lnkPath.TabIndex = 14;
            this.lnkPath.TabStop = true;
            this.lnkPath.Text = "C:\\";
            this.lnkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPath_LinkClicked);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(125, 45);
            this.txtPeriod.Mask = "000";
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.PromptChar = ' ';
            this.txtPeriod.Size = new System.Drawing.Size(25, 20);
            this.txtPeriod.TabIndex = 7;
            this.txtPeriod.Text = "1";
            this.txtPeriod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPeriod_KeyUp);
            // 
            // cboPeriod
            // 
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Items.AddRange(new object[] {
            "Second(s)",
            "Minute(s)",
            "Hour(s)"});
            this.cboPeriod.Location = new System.Drawing.Point(155, 44);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(75, 21);
            this.cboPeriod.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "4. Store it at";
            // 
            // txtNamePrefix
            // 
            this.txtNamePrefix.Location = new System.Drawing.Point(126, 79);
            this.txtNamePrefix.Name = "txtNamePrefix";
            this.txtNamePrefix.Size = new System.Drawing.Size(97, 20);
            this.txtNamePrefix.TabIndex = 9;
            this.txtNamePrefix.Text = "Camera 1";
            this.txtNamePrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNamePrefix.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "2. Name it, starting with";
            // 
            // AForgeVideoSourcePlayer
            // 
            this.AForgeVideoSourcePlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AForgeVideoSourcePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AForgeVideoSourcePlayer.BorderColor = System.Drawing.Color.Gainsboro;
            this.AForgeVideoSourcePlayer.Location = new System.Drawing.Point(2, 14);
            this.AForgeVideoSourcePlayer.Name = "AForgeVideoSourcePlayer";
            this.AForgeVideoSourcePlayer.Size = new System.Drawing.Size(640, 469);
            this.AForgeVideoSourcePlayer.TabIndex = 37;
            this.AForgeVideoSourcePlayer.TabStop = false;
            this.AForgeVideoSourcePlayer.VideoSource = null;
            // 
            // cboVideoResolution
            // 
            this.cboVideoResolution.FormattingEnabled = true;
            this.cboVideoResolution.Location = new System.Drawing.Point(114, 79);
            this.cboVideoResolution.Name = "cboVideoResolution";
            this.cboVideoResolution.Size = new System.Drawing.Size(84, 21);
            this.cboVideoResolution.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkInvertImage);
            this.groupBox2.Controls.Add(this.cboCameras);
            this.groupBox2.Controls.Add(this.cboVideoResolution);
            this.groupBox2.Controls.Add(this.btnConfig);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Location = new System.Drawing.Point(12, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 202);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USB Camera Options";
            // 
            // chkInvertImage
            // 
            this.chkInvertImage.AutoSize = true;
            this.chkInvertImage.Location = new System.Drawing.Point(20, 107);
            this.chkInvertImage.Name = "chkInvertImage";
            this.chkInvertImage.Size = new System.Drawing.Size(98, 27);
            this.chkInvertImage.TabIndex = 32;
            this.chkInvertImage.Text = "Invert Image";
            this.chkInvertImage.UseVisualStyleBackColor = true;
            // 
            // cboCameras
            // 
            this.cboCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCameras.FormattingEnabled = true;
            this.cboCameras.Location = new System.Drawing.Point(15, 19);
            this.cboCameras.Name = "cboCameras";
            this.cboCameras.Size = new System.Drawing.Size(183, 21);
            this.cboCameras.TabIndex = 0;
            this.cboCameras.SelectedIndexChanged += new System.EventHandler(this.cboCameras_SelectedIndexChanged);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(15, 50);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(183, 23);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "USB Camera Configuration";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Capture Resolution";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Camera";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Snap a Photo Now";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(114, 135);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop Camera";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ToolTip1
            // 
            this.ToolTip1.IsBalloon = true;
            // 
            // MyIPCamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AForgeVideoSourcePlayer);
            this.Controls.Add(this.groupBox2);
            this.Name = "MyIPCamManager";
            this.Size = new System.Drawing.Size(644, 696);
            this.Load += new System.EventHandler(this.ManageCamera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnMakeAVI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkAddDateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkEnableAutoCapture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAddFrameCount;
        private System.Windows.Forms.ComboBox cboFormat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNextSnapshot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.LinkLabel lnkPath;
        private System.Windows.Forms.MaskedTextBox txtPeriod;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamePrefix;
        private System.Windows.Forms.Label label3;
        private AForge.Controls.VideoSourcePlayer AForgeVideoSourcePlayer;
        private System.Windows.Forms.ComboBox cboVideoResolution;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboCameras;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.MaskedTextBox txtResetFrameCounter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkDateTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkInvertImage;
    }
}
