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
    public partial class frmProdajniReferent : Form
    {
        private korisnik prijavljeniKorisnik;
        public frmProdajniReferent(korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void btnStrojevi_Click(object sender, EventArgs e)
        {
            var katalogStrojeva = new frmKatalogStrojeva();
            katalogStrojeva.ShowDialog();
        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            var popisNarudzbi = new frmPopisNarudzbi();
            popisNarudzbi.ShowDialog();
        }

        private void btnPonuda_Click(object sender, EventArgs e)
        {
            var popisPonuda = new frmPopisPonuda();
            popisPonuda.ShowDialog();
        }

        private void btnDobavljac_Click(object sender, EventArgs e)
        {
            var popisDobavljaca = new frmPopisDobavljaca();
            popisDobavljaca.ShowDialog();
        }

        private void btnKlijent_Click(object sender, EventArgs e)
        {
            var popisKlijenata = new frmPopisKlijenata();
            popisKlijenata.ShowDialog();
        }

        private void btnGraf_Click(object sender, EventArgs e)
        {
            var graf = new frmProdajniReferentGraf();
            graf.ShowDialog();
        }
    }
}
