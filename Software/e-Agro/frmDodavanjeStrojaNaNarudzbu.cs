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
    public partial class frmDodavanjeStrojaNaNarudzbu : Form
    {
        private narudzba odabranaNarudzba;
        StavkeNaNarudzbi stavkeNaNarudzbi;
        Strojevi strojevi;
        public frmDodavanjeStrojaNaNarudzbu(narudzba narudzba)
        {
            odabranaNarudzba = narudzba;
            stavkeNaNarudzbi = new StavkeNaNarudzbi();
            strojevi = new Strojevi();
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodavanjeStrojaNaNarudzbu_Load(object sender, EventArgs e)
        {
            cmbStrojevi.DataSource = strojevi.DohvatiStrojeve();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            katalog_strojeva odabraniStroj = cmbStrojevi.SelectedItem as katalog_strojeva;
            int kolicina = int.Parse(txtKolicina.Text);
            stavkeNaNarudzbi.DodajStrojNaNarudzbu(odabraniStroj, kolicina, odabranaNarudzba);
        }
    }
}
