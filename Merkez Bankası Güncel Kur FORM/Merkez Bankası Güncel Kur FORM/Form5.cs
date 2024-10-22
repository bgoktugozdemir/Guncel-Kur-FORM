﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merkez_Bankası_Güncel_Kur_FORM
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Form1.username.ToUpper();
            txtLicenseKey.Text = Properties.Settings.Default.LicenseKey;
            txtLicenseStartingDate.Text = Form1.licenseStartingDate.ToString();
            txtLicenseExpirationDate.Text = Form1.licenseExpirationDate.ToString();
        }

        private void txtLicenseKey_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(txtLicenseKey.Text);
            txtLicenseKey.ForeColor = Color.Black;
        }

        private void txtLicenseKey_MouseLeave(object sender, EventArgs e)
        {
            txtLicenseKey.ForeColor = Color.White;
        }

        private void txtLicenseKey_MouseHover(object sender, EventArgs e)
        {
            txtLicenseKey.ForeColor = Color.Yellow;
        }
    }
}
