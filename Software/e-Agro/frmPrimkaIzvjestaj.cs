using System;
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
            this.KeyPreview = true;
            List<stavke_na_primci> popisStavki = new List<stavke_na_primci>();
            List<katalog_strojeva> popisStrojeva = new List<katalog_strojeva>();
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

        private void frmPrimkaIzvjestaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#332-upravljanje-primkama");
            }
        }
    }
}
