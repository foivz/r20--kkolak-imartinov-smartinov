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
    public partial class frmNarudzbaIzvjestaj : Form
    {
        private narudzba odabranaNarudzba;
        public frmNarudzbaIzvjestaj(narudzba narudzba)
        {
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }

        private void frmNarudzbaIzvjestaj_Load(object sender, EventArgs e)
        {
            List<stavke_na_narudzbi> popisStavki = new List<stavke_na_narudzbi>();
            List<katalog_strojeva> popisStrojeva = new List<katalog_strojeva>();

            using (var context = new PI20_024_DBEntities())
            {
                var query = from s in context.stavke_na_narudzbi
                            where s.narudzba_id == odabranaNarudzba.narudzba_id
                            select s;

                popisStavki = query.ToList();

                foreach (var stavka in popisStavki)
                {
                    popisStrojeva.Add(stavka.katalog_strojeva);
                }
            }
            narudzbaBindingSource.DataSource = odabranaNarudzba;
            katalog_strojevaBindingSource.DataSource = popisStrojeva;

            this.reportViewer1.RefreshReport();
        }
    }
}
