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
    public partial class frmPopisDobavljaca : Form
    {
        Dobavljaci dobavljaci;
        public frmPopisDobavljaca()
        {
            dobavljaci = new Dobavljaci();
            InitializeComponent();
        }

        private void OsvjeziTablicu()
        {
            dgvDobavljaci.DataSource = dobavljaci.DohvatiDobavljace();
            dgvDobavljaci.Columns["narudzbas"].Visible = false;
            dgvDobavljaci.Columns["katalog_strojeva"].Visible = false;
        }

        private dobavljac DohvatiOdabranog()
        {
            return dgvDobavljaci.CurrentRow.DataBoundItem as dobavljac;
        }

        private void frmPopisDobavljaca_Load_1(object sender, EventArgs e)
        {
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            dobavljaci.ObrisiDobavljaca(DohvatiOdabranog());
            OsvjeziTablicu();
        }
    }
}
