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
    public partial class frmOtpremnicaIzvjestaj : Form
    {
        private otpremnica odabranaOtpremnica;
        public frmOtpremnicaIzvjestaj(otpremnica otpremnica)
        {
            odabranaOtpremnica = otpremnica;
            InitializeComponent();
        }

        private void frmOtpremnicaIzvjestaj_Load(object sender, EventArgs e)
        {
            List<stavke_na_otpremnici> popisStavki = new List<stavke_na_otpremnici>();
            List<katalog_strojeva> popisStrojeva = new List<katalog_strojeva>();
            var korisnik = new korisnik();

            using (var context = new PI20_024_DBEntities())
            {
                var query = from s in context.stavke_na_otpremnici
                            where s.otpremnica_id == odabranaOtpremnica.otpremnica_id
                            select s;

                var queryKorisnik = from k in context.korisniks
                                    where k.korisnik_id == odabranaOtpremnica.korisnik_id
                                    select k;

                korisnik = queryKorisnik.First();
                popisStavki = query.ToList();

                foreach (var stavka in popisStavki)
                {
                    popisStrojeva.Add(stavka.katalog_strojeva);
                }
            }

            stavke_na_otpremniciBindingSource.DataSource = popisStavki;
            otpremnicaBindingSource.DataSource = odabranaOtpremnica;
            korisnikBindingSource.DataSource = korisnik;
            katalog_strojevaBindingSource.DataSource = popisStrojeva;
            this.rvOtpremnica.RefreshReport();
        }
    }
}
