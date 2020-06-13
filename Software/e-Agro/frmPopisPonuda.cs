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
    public partial class frmPopisPonuda : Form
    {
        Ponude ponude;
        StavkeNaPonudi stavkeNaPonudi;
        public frmPopisPonuda()
        {
            ponude = new Ponude();
            stavkeNaPonudi = new StavkeNaPonudi();
            InitializeComponent();
        }
        private ponuda DohvatiOdabranu()
        {
            return dgvPonude.CurrentRow.DataBoundItem as ponuda;
        }
        private void OsvjeziTablicu()
        {
            dgvPonude.DataSource = ponude.DohvatiPonude();
            dgvPonude.Columns["stavke_na_ponudi"].Visible = false;
        }
        private void frmPopisPonuda_Load(object sender, EventArgs e)
        {
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ponude.ObrisiPonudu(DohvatiOdabranu());
            OsvjeziTablicu();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void dgvPonude_SelectionChanged(object sender, EventArgs e)
        {
            dgvStavkeNaPonudi.DataSource = stavkeNaPonudi.DohvatiStavkeZaPonudu(DohvatiOdabranu());
        }

        private void btnDodajStroj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeStrojaNaPonuda(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjePonude())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using(var forma = new frmDodavanjePonude(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }
    }
}
