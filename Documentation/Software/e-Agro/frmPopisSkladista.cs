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
    public partial class frmPopisSkladista : Form
    {
        Skladista skladista;
        public frmPopisSkladista()
        {
            skladista = new Skladista();
            InitializeComponent();
        }
        private skladiste DohvatiOdabrano()
        {
            return dgvSkladista.CurrentRow.DataBoundItem as skladiste;
        }
        private void OsvjeziTablicu()
        {
            dgvSkladista.DataSource = skladista.DohvatiSkladista();
            dgvSkladista.Columns["radno_mjesto"].Visible = false;
            dgvSkladista.Columns["stroj_na_skladistu"].Visible = false;
            dgvSkladista.Columns["skladiste_id"].Visible = false;

        }

        private void frmPopisSkladista_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            skladista.ObrisiSkladiste(DohvatiOdabrano());
            OsvjeziTablicu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeSkladista())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeSkladista(DohvatiOdabrano()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void frmPopisSkladista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#311-upravljanje-skladi%C5%A1tem");
            }
        }
    }
}