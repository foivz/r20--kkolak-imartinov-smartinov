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
    public partial class frmNarudzbaGraf : Form
    {
        private narudzba odabranaNarudzba;
        public frmNarudzbaGraf(narudzba narudzba)
        {
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }

        private void frmNarudzbaGraf_Load(object sender, EventArgs e)
        {

            var popisStrojeva = new List<katalog_strojeva>();

            List<stavke_na_narudzbi> popisStavkiNaNarudzbi = new List<stavke_na_narudzbi>();
            List<katalog_strojeva> popisStrojevaNaNarudzbi = new List<katalog_strojeva>();


            using (var context = new PI20_024_DBEntities())
            {
                var query = from p in context.katalog_strojeva
                            select p;
                popisStrojeva = query.ToList();

                    foreach (var stroj in popisStrojeva)
                    {
                    chartDobavljac.Series["Stroj"].Points.AddXY(stroj.vrsta, stroj.cijena);
                    }

                var queryNarudzba = from s in context.stavke_na_narudzbi
                            where s.narudzba_id == odabranaNarudzba.narudzba_id
                            select s;

                popisStavkiNaNarudzbi = queryNarudzba.ToList();

                foreach (var stavka in popisStavkiNaNarudzbi)
                {
                    chartStrojNarudzbe.Series["StrojNarudzbe"].Points.AddXY(stavka.katalog_strojeva.naziv, stavka.katalog_strojeva.cijena);

                }

            }
            }

        
    }
    }

