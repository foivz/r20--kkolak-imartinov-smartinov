﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agro
{
    public partial class frmPrimkaIzvjestaj : Form
    {
        private primka odabranaPrimka;

        public frmPrimkaIzvjestaj(primka primka)
        {
            odabranaPrimka = primka;
            InitializeComponent();
        }

        private void frmPrimkaIzvjestaj_Load(object sender, EventArgs e)
        {
            List<katalog_strojeva> popisStrojeva = new List<katalog_strojeva>();
            List<stavke_na_primci> popisStavki = new List<stavke_na_primci>();
            var korisnik = new korisnik();
            using (var context = new PI20_024_DBEntities())
            {
                var query = from p in context.stavke_na_primci
                            where p.primka_id == odabranaPrimka.primka_id
                            select p;

                var queryKorisnik = from k in context.korisniks
                                    where k.korisnik_id == odabranaPrimka.korisnik_id
                                    select k;

                korisnik = queryKorisnik.First();
                popisStavki = query.ToList();

                foreach (var stavka in popisStavki)
                {
                    popisStrojeva.Add(stavka.katalog_strojeva);
                }
            }
            stavke_na_primciBindingSource.DataSource = popisStavki;
            primkaBindingSource.DataSource = odabranaPrimka;
            korisnikBindingSource.DataSource = korisnik;
            katalog_strojevaBindingSource.DataSource = popisStrojeva;
            this.rvPrimka.RefreshReport();
        }
    }
}
