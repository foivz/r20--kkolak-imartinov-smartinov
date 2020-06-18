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
    public partial class frmProdajniReferentGraf : Form
    {
        private korisnik prijavljeniKorisnik;
        StavkeNaPonudi stavkeNaPonudi;
        public frmProdajniReferentGraf(korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
            stavkeNaPonudi = new StavkeNaPonudi();
        }

        private void frmProdajniReferentGraf_Load(object sender, EventArgs e)
        {

            chartProdaja.Titles.Add("Prodaja po vrsti strojeva");

            var popisPonuda = new List<ponuda>();
            var popisStavki = new List<stavke_na_ponudi>();


            using (var context = new PI20_024_DBEntities())
            {
                var query = from p in context.ponudas
                            where p.korisnik_id == prijavljeniKorisnik.korisnik_id
                            select p;

                popisPonuda = query.ToList();
                foreach (var ponuda in popisPonuda)
                {
                    popisStavki.AddRange(ponuda.stavke_na_ponudi);
                }

                foreach (var stavka in popisStavki)
                {
                    chartProdaja.Series[0].Points.AddXY(stavka.katalog_strojeva.vrsta, stavka.katalog_strojeva.cijena);
                }
            }
        }
    }
}

