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
    public partial class frmPonudaIzvjestaj : Form
    {
        private ponuda odabranaPonuda;
        public frmPonudaIzvjestaj(ponuda ponuda)
        {
            odabranaPonuda = ponuda;
            InitializeComponent();
        }

        private void frmPonudaIzvjestaj_Load(object sender, EventArgs e)
        {
            List<stavke_na_ponudi> popisStavki = new List<stavke_na_ponudi>();
            List<katalog_strojeva> popisStrojeva = new List<katalog_strojeva>();
            var korisnik = new korisnik();

            using(var context = new PI20_024_DBEntities())
            {
                var query = from s in context.stavke_na_ponudi
                            where s.ponuda_id == odabranaPonuda.ponuda_id
                            select s;

                var queryKorisnik = from k in context.korisniks
                                    where k.korisnik_id == odabranaPonuda.korisnik_id
                                    select k;

                korisnik = queryKorisnik.First();
                popisStavki = query.ToList();

                foreach (var stavka in popisStavki)
                {
                    popisStrojeva.Add(stavka.katalog_strojeva);
                }
            }

            stavke_na_ponudiBindingSource.DataSource = popisStavki;
            ponudaBindingSource.DataSource = odabranaPonuda;
            korisnikBindingSource.DataSource = korisnik;
            katalog_strojevaBindingSource.DataSource = popisStrojeva;
            this.rvPonuda.RefreshReport();
        }
    }
}
