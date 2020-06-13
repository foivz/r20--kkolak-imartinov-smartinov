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
    public partial class frmDodavanjeSkladista : Form
    {
        Skladista skladista;

        private skladiste odabranoSkladiste;
        public frmDodavanjeSkladista()
        {
            skladista = new Skladista();
            InitializeComponent();
        }

        public frmDodavanjeSkladista(skladiste skladiste)
        {
            skladista = new Skladista();
            odabranoSkladiste = skladiste;
            InitializeComponent();
        }

        private void UcitajGUI()
        {
            radno_mjesto odabranoRadnoMjesto = new radno_mjesto();
            if(odabranoSkladiste != null)
            {
                using (var context = new PI20_024_DBEntities())
                {
                    var query = from r in context.radno_mjesto
                                where r.skladiste_id == odabranoSkladiste.skladiste_id
                                select r;

                    odabranoRadnoMjesto = query.First();
                }

                txtAdresa.Text = odabranoRadnoMjesto.adresa;
                txtNaziv.Text = odabranoSkladiste.naziv;
                this.Text = "Ažuriranje skladišta";
                btnDodaj.Text = "Ažuriraj skladište";
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmDodavanjeSkladista_Load(object sender, EventArgs e)
        {
            UcitajGUI();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            string adresa = txtAdresa.Text;
            if(odabranoSkladiste != null)
            {
                skladista.AzurirajSkladiste(odabranoSkladiste, naziv, adresa);
            }
            else
            {
                skladista.DodajSkladiste(naziv, adresa);
            }
            Close();
        }
    }
}
