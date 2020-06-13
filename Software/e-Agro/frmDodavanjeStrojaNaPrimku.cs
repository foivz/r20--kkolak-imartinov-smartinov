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
    public partial class frmDodavanjeStrojaNaPrimku : Form
    {
        Strojevi strojevi;
        private primka odabranaPrimka;
        StavkeNaPrimci stavkeNaPrimci;
        public frmDodavanjeStrojaNaPrimku(primka primka)
        {
            odabranaPrimka = primka;
            stavkeNaPrimci = new StavkeNaPrimci();
            strojevi = new Strojevi();
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodavanjeStrojaNaPrimku_Load(object sender, EventArgs e)
        {
            cmbStrojevi.DataSource = strojevi.DohvatiStrojeve();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            katalog_strojeva odabraniStroj = cmbStrojevi.SelectedItem as katalog_strojeva;
            int kolicina = int.Parse(txtKolicina.Text);
            stavkeNaPrimci.DodajStrojNaPrimku(odabraniStroj, kolicina, odabranaPrimka);
            Close();
        }
    }
}
