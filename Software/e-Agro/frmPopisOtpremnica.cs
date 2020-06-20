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
    public partial class frmPopisOtpremnica : Form
    {
        Otpremnice otpremnice;
        StavkeNaOtpremnici stavkeNaOtpremnici;
        public frmPopisOtpremnica()
        {
            otpremnice = new Otpremnice();
            stavkeNaOtpremnici = new StavkeNaOtpremnici();
            InitializeComponent();
        }
        private otpremnica DohvatiOdabranu()
        {
            return dgvOtpremnice.CurrentRow.DataBoundItem as otpremnica;
        }
        private void OsvjeziTablicu() 
        {
            dgvOtpremnice.DataSource = otpremnice.DohvatiOtpremnice();
            dgvOtpremnice.Columns["stavke_na_otpremnici"].Visible = false;
            dgvOtpremnice.Columns["otpremnica_id"].Visible = false;
            dgvOtpremnice.Columns["korisnik_id"].Visible = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            otpremnice.ObrisiOtpremnicu(DohvatiOdabranu());
            OsvjeziTablicu();
        }

        private void frmPopisOtpremnica_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            OsvjeziTablicu();
        }

        private void dgvOtpremnice_SelectionChanged(object sender, EventArgs e)
        {
            dgvStavkeNaOtpremnici.DataSource = stavkeNaOtpremnici.DohvatiStavkeZaOtpremnicu(DohvatiOdabranu());
        }

        private void btnDodajStroj_Click(object sender, EventArgs e)
        {
            Hide();
            using(var forma = new frmDodavanjeStrojaNaOtpremnicu(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma= new frmDodavanjeOtpremnice())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeOtpremnice(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            Hide();
            using(var forma = new frmOtpremnicaIzvjestaj(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void frmPopisOtpremnica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#331-upravljanje-otpremnicama");
            }
        }
    }
}
