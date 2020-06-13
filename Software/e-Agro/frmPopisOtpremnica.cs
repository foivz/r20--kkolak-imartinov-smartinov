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
        }
        private void frmPopisOtpremnica_Load_1(object sender, EventArgs e)
        {
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            otpremnice.ObrisiOtpremnicu(DohvatiOdabranu());
            OsvjeziTablicu();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
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
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeOtpremnice(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();

        }
    }
}
