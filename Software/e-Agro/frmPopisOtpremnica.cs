﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agro
{
    public partial class frmPopisOtpremnica : Form
    {
        Otpremnice otpremnice;
        public frmPopisOtpremnica()
        {
            otpremnice = new Otpremnice();
            InitializeComponent();
        }
        private otpremnica DohvatiOdabranu()
        {
            return dgvOtpremnice.CurrentRow.DataBoundItem as otpremnica;
        }
        private void OsvjeziTablicu() 
        {
            dgvOtpremnice.DataSource = otpremnice.DohvatiOtpremnice();
            dgvOtpremnice.Columns["stavke_na_otpremnici"].Visible = false;
        }
        private void frmPopisOtpremnica_Load_1(object sender, EventArgs e)
        {
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            otpremnice.ObrisiOtpremnicu(DohvatiOdabranu());
            OsvjeziTablicu();
        }
    }
}
