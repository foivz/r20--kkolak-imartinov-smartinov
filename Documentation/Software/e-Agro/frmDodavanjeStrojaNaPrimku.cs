﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            this.KeyPreview = true;
            cmbStrojevi.DataSource = strojevi.DohvatiStrojeve();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            katalog_strojeva odabraniStroj = cmbStrojevi.SelectedItem as katalog_strojeva;
            int kolicina = int.Parse(txtKolicina.Text);

            if(txtKolicina.Text == "" || string.IsNullOrEmpty(cmbStrojevi.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            stavkeNaPrimci.DodajStrojNaPrimku(odabraniStroj, kolicina, odabranaPrimka);

            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabranaPrimka).State = EntityState.Modified;
                odabranaPrimka.cijena += (odabraniStroj.cijena * kolicina);
                context.SaveChanges();
            }
            Close();
        }

        private void frmDodavanjeStrojaNaPrimku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#332-upravljanje-primkama");
            }
        }
    }
}
