﻿namespace MyCamAVITabbedWF
{
    partial class frmEventBox
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
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorCountLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(10, 11);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(484, 234);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(403, 270);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Error Count:";
            // 
            // errorCountLbl
            // 
            this.errorCountLbl.AutoSize = true;
            this.errorCountLbl.Location = new System.Drawing.Point(80, 269);
            this.errorCountLbl.Name = "errorCountLbl";
            this.errorCountLbl.Size = new System.Drawing.Size(13, 13);
            this.errorCountLbl.TabIndex = 3;
            this.errorCountLbl.Text = "0";
            // 
            // ErrorEventBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 310);
            this.Controls.Add(this.errorCountLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.logBox);
            this.Name = "ErrorEventBox";
            this.Text = "ErrorEventBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorCountLbl;
    }
}