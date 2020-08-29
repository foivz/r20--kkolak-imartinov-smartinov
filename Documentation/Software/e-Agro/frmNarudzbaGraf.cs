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
        public frmNarudzbaGraf()
        {
            InitializeComponent();
        }

        private void frmNarudzbaGraf_Load(object sender, EventArgs e)
        {

            var popisNarudzbi = new List<narudzba>();
            var popisStavki = new List<stavke_na_narudzbi>();

            using (var context = new PI20_024_DBEntities())
            {

                var query = from p in context.narudzbas
                            select p;

                popisNarudzbi = query.ToList();

                foreach (var narudzba in popisNarudzbi)
                {
                    popisStavki.AddRange(narudzba.stavke_na_narudzbi);
                }

                foreach (var stavka in popisStavki)
                {
                    chartDobavljac.Series[0].Points.AddXY(stavka.narudzba.dobavljac_id, stavka.narudzba.cijena);
                }

            }


        }
    }
}
