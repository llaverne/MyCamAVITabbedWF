namespace MyCamAVITabbedWF
{
    partial class frmSensorsEdit
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
            this.gpbInterface = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.gpbInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInterface
            // 
            this.gpbInterface.Controls.Add(this.txtName);
            this.gpbInterface.Controls.Add(this.txtID);
            this.gpbInterface.Controls.Add(this.txtStatus);
            this.gpbInterface.Location = new System.Drawing.Point(12, 12);
            this.gpbInterface.Name = "gpbInterface";
            this.gpbInterface.Size = new System.Drawing.Size(255, 91);
            this.gpbInterface.TabIndex = 5;
            this.gpbInterface.TabStop = false;
            this.gpbInterface.Text = "Interface";
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
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(6, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(29, 13);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "txtID";
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
            // frmInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 630);
            this.Controls.Add(this.gpbInterface);
            this.Name = "frmInterface";
            this.Text = "frmInterface";
            this.gpbInterface.ResumeLayout(false);
            this.gpbInterface.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInterface;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtStatus;
    }
}