namespace MyCamAVITabbedWF
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.gpbInterface = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboLowFontSize = new System.Windows.Forms.ComboBox();
            this.cboLowFontColor = new System.Windows.Forms.ComboBox();
            this.gpbHi = new System.Windows.Forms.GroupBox();
            this.cboHiFontColor = new System.Windows.Forms.ComboBox();
            this.cboHiFontSize = new System.Windows.Forms.ComboBox();
            this.txtHi = new System.Windows.Forms.TextBox();
            this.cboFontSize = new System.Windows.Forms.ComboBox();
            this.cboHorizontalDivision = new System.Windows.Forms.ComboBox();
            this.cboVerticalDivision = new System.Windows.Forms.ComboBox();
            this.cboFontColor = new System.Windows.Forms.ComboBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.cboInput = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstOverlays = new System.Windows.Forms.ListView();
            this.chkShowBar = new System.Windows.Forms.CheckBox();
            this.gpbInterface.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbHi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 761);
            this.tabControl1.TabIndex = 0;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(6, 62);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(48, 13);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "txtStatus";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(6, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(29, 13);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "txtID";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(6, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(46, 13);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "txtName";
            // 
            // gpbInterface
            // 
            this.gpbInterface.Controls.Add(this.txtName);
            this.gpbInterface.Controls.Add(this.txtID);
            this.gpbInterface.Controls.Add(this.txtStatus);
            this.gpbInterface.Location = new System.Drawing.Point(658, 16);
            this.gpbInterface.Name = "gpbInterface";
            this.gpbInterface.Size = new System.Drawing.Size(255, 91);
            this.gpbInterface.TabIndex = 4;
            this.gpbInterface.TabStop = false;
            this.gpbInterface.Text = "Interface";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gpbHi);
            this.groupBox1.Controls.Add(this.cboFontSize);
            this.groupBox1.Controls.Add(this.cboHorizontalDivision);
            this.groupBox1.Controls.Add(this.cboVerticalDivision);
            this.groupBox1.Controls.Add(this.cboFontColor);
            this.groupBox1.Controls.Add(this.cboFont);
            this.groupBox1.Controls.Add(this.txtText);
            this.groupBox1.Controls.Add(this.cboInput);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(658, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 251);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Overlay";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Low Value";
            // 
            // cboLowFontSize
            // 
            this.cboLowFontSize.FormattingEnabled = true;
            this.cboLowFontSize.Items.AddRange(new object[] {
            "6",
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "24",
            "30",
            "36",
            "48"});
            this.cboLowFontSize.Location = new System.Drawing.Point(132, 19);
            this.cboLowFontSize.Name = "cboLowFontSize";
            this.cboLowFontSize.Size = new System.Drawing.Size(40, 21);
            this.cboLowFontSize.TabIndex = 15;
            this.cboLowFontSize.Text = "Size";
            // 
            // cboLowFontColor
            // 
            this.cboLowFontColor.FormattingEnabled = true;
            this.cboLowFontColor.Location = new System.Drawing.Point(176, 19);
            this.cboLowFontColor.Name = "cboLowFontColor";
            this.cboLowFontColor.Size = new System.Drawing.Size(92, 21);
            this.cboLowFontColor.TabIndex = 14;
            this.cboLowFontColor.Text = "Color";
            // 
            // gpbHi
            // 
            this.gpbHi.Controls.Add(this.chkShowBar);
            this.gpbHi.Controls.Add(this.cboLowFontSize);
            this.gpbHi.Controls.Add(this.cboLowFontColor);
            this.gpbHi.Controls.Add(this.textBox1);
            this.gpbHi.Controls.Add(this.cboHiFontColor);
            this.gpbHi.Controls.Add(this.cboHiFontSize);
            this.gpbHi.Controls.Add(this.txtHi);
            this.gpbHi.Location = new System.Drawing.Point(7, 112);
            this.gpbHi.Name = "gpbHi";
            this.gpbHi.Size = new System.Drawing.Size(273, 96);
            this.gpbHi.TabIndex = 20;
            this.gpbHi.TabStop = false;
            this.gpbHi.Text = "High && Low Indication";
            // 
            // cboHiFontColor
            // 
            this.cboHiFontColor.FormattingEnabled = true;
            this.cboHiFontColor.Location = new System.Drawing.Point(176, 44);
            this.cboHiFontColor.Name = "cboHiFontColor";
            this.cboHiFontColor.Size = new System.Drawing.Size(92, 21);
            this.cboHiFontColor.TabIndex = 11;
            this.cboHiFontColor.Text = "Color";
            // 
            // cboHiFontSize
            // 
            this.cboHiFontSize.FormattingEnabled = true;
            this.cboHiFontSize.Items.AddRange(new object[] {
            "6",
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "24",
            "30",
            "36",
            "48"});
            this.cboHiFontSize.Location = new System.Drawing.Point(132, 45);
            this.cboHiFontSize.Name = "cboHiFontSize";
            this.cboHiFontSize.Size = new System.Drawing.Size(40, 21);
            this.cboHiFontSize.TabIndex = 12;
            this.cboHiFontSize.Text = "Size";
            // 
            // txtHi
            // 
            this.txtHi.Location = new System.Drawing.Point(6, 19);
            this.txtHi.Name = "txtHi";
            this.txtHi.Size = new System.Drawing.Size(123, 20);
            this.txtHi.TabIndex = 16;
            this.txtHi.Text = "Hi Value";
            // 
            // cboFontSize
            // 
            this.cboFontSize.FormattingEnabled = true;
            this.cboFontSize.Items.AddRange(new object[] {
            "6",
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "24",
            "30",
            "36",
            "48"});
            this.cboFontSize.Location = new System.Drawing.Point(134, 51);
            this.cboFontSize.Name = "cboFontSize";
            this.cboFontSize.Size = new System.Drawing.Size(40, 21);
            this.cboFontSize.TabIndex = 8;
            this.cboFontSize.Text = "Size";
            // 
            // cboHorizontalDivision
            // 
            this.cboHorizontalDivision.FormattingEnabled = true;
            this.cboHorizontalDivision.Location = new System.Drawing.Point(7, 78);
            this.cboHorizontalDivision.Name = "cboHorizontalDivision";
            this.cboHorizontalDivision.Size = new System.Drawing.Size(56, 21);
            this.cboHorizontalDivision.TabIndex = 7;
            this.cboHorizontalDivision.Text = "Pos X";
            // 
            // cboVerticalDivision
            // 
            this.cboVerticalDivision.FormattingEnabled = true;
            this.cboVerticalDivision.Location = new System.Drawing.Point(76, 78);
            this.cboVerticalDivision.Name = "cboVerticalDivision";
            this.cboVerticalDivision.Size = new System.Drawing.Size(54, 21);
            this.cboVerticalDivision.TabIndex = 6;
            this.cboVerticalDivision.Text = "Pos Y";
            // 
            // cboFontColor
            // 
            this.cboFontColor.FormattingEnabled = true;
            this.cboFontColor.Location = new System.Drawing.Point(177, 51);
            this.cboFontColor.Name = "cboFontColor";
            this.cboFontColor.Size = new System.Drawing.Size(97, 21);
            this.cboFontColor.TabIndex = 5;
            this.cboFontColor.Text = "Color";
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(7, 51);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(123, 21);
            this.cboFont.TabIndex = 4;
            this.cboFont.Text = "Font";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(134, 24);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(140, 20);
            this.txtText.TabIndex = 3;
            this.txtText.Text = "Name/Text";
            // 
            // cboInput
            // 
            this.cboInput.FormattingEnabled = true;
            this.cboInput.Location = new System.Drawing.Point(7, 24);
            this.cboInput.Name = "cboInput";
            this.cboInput.Size = new System.Drawing.Size(123, 21);
            this.cboInput.TabIndex = 2;
            this.cboInput.Text = "Data Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstOverlays
            // 
            this.lstOverlays.GridLines = true;
            this.lstOverlays.Location = new System.Drawing.Point(660, 378);
            this.lstOverlays.Name = "lstOverlays";
            this.lstOverlays.Size = new System.Drawing.Size(285, 185);
            this.lstOverlays.TabIndex = 6;
            this.lstOverlays.UseCompatibleStateImageBehavior = false;
            // 
            // chkShowBar
            // 
            this.chkShowBar.AutoSize = true;
            this.chkShowBar.Location = new System.Drawing.Point(6, 71);
            this.chkShowBar.Name = "chkShowBar";
            this.chkShowBar.Size = new System.Drawing.Size(99, 17);
            this.chkShowBar.TabIndex = 22;
            this.chkShowBar.Text = "Show Bargraph";
            this.chkShowBar.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 762);
            this.Controls.Add(this.lstOverlays);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbInterface);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Time Lapse and Video";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gpbInterface.ResumeLayout(false);
            this.gpbInterface.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbHi.ResumeLayout(false);
            this.gpbHi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.GroupBox gpbInterface;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboHorizontalDivision;
        private System.Windows.Forms.ComboBox cboVerticalDivision;
        private System.Windows.Forms.ComboBox cboFontColor;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ComboBox cboInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboFontSize;
        private System.Windows.Forms.ComboBox cboLowFontSize;
        private System.Windows.Forms.ComboBox cboLowFontColor;
        private System.Windows.Forms.ComboBox cboHiFontSize;
        private System.Windows.Forms.ComboBox cboHiFontColor;
        private System.Windows.Forms.TextBox txtHi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gpbHi;
        private System.Windows.Forms.ListView lstOverlays;
        private System.Windows.Forms.CheckBox chkShowBar;
    }
}

