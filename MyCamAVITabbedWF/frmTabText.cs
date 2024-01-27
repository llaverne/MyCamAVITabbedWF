﻿#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace MyCamAVIControl {
    partial class frmTabText : Form {

        private string strTabText = "";
        public string TabText
        {
            get { return strTabText; }
        }



        public frmTabText() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            strTabText = txtTabName.Text;
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