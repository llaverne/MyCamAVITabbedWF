#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace MyIPCamAVIControl {
    partial class IPFrameRateForm : Form {

        private double rate=0;

        public double Rate {
            get { return rate; }
        }

        public IPFrameRateForm() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            rate = (double)numRate.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}