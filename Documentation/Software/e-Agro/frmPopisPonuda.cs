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
            dgvPonude.Columns["ponuda_id"].Visible = false;
            dgvPonude.Columns["klijent_id"].Visible = false;
            dgvPonude.Columns["korisnik_id"].Visible = false;
        }
        private void frmPopisPonuda_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ponude.ObrisiPonudu(DohvatiOdabranu());
            OsvjeziTablicu();
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

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            Hide();
            using(var forma = new frmSlanjeEmaila("Ponuda"))
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            Hide();
            using(var forma = new frmPonudaIzvjestaj(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void frmPopisPonuda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#322-upravljanje-ponudama");
            }
        }
    }
}
