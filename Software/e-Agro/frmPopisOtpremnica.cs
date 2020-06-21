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
    /// <summary>
    /// Prikaz popisa otpremnica te daljnji rad s otpremnicama iz baze
    /// </summary>
    public partial class frmPopisOtpremnica : Form
    {
        Otpremnice otpremnice; // Referenca na klasu Otpremnice koja upravlja otpremnicama iz baze
        StavkeNaOtpremnici stavkeNaOtpremnici; // Referenca na klasu StavkeNaOtpremnici koja upravlja stavkama na otpremnici iz baze

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public frmPopisOtpremnica()
        {
            otpremnice = new Otpremnice();
            stavkeNaOtpremnici = new StavkeNaOtpremnici();
            InitializeComponent();
        }

        /// <summary>
        /// Dohvaćanje odabrane otpremnice iz baze
        /// </summary>
        /// <returns>Vraća objekta otpremnica koji je instanca iz baze podataka</returns>
        private otpremnica DohvatiOdabranu()
        {
            return dgvOtpremnice.CurrentRow.DataBoundItem as otpremnica;
        }


        /// <summary>
        /// Prikaz popisa otpremnica u DataGridView
        /// </summary>
        private void OsvjeziTablicu() 
        {
            dgvOtpremnice.DataSource = otpremnice.DohvatiOtpremnice();
            dgvOtpremnice.Columns["stavke_na_otpremnici"].Visible = false;
            dgvOtpremnice.Columns["otpremnica_id"].Visible = false;
            dgvOtpremnice.Columns["korisnik_id"].Visible = false;
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Obriši
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            otpremnice.ObrisiOtpremnicu(DohvatiOdabranu());
            OsvjeziTablicu();
        }

        /// <summary>
        /// Rukuje događajem učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopisOtpremnica_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Mora se dodati kako bi radila F1 pomoć
            OsvjeziTablicu();
        }

        /// <summary>
        /// Rukuje događajem promjene izbora otpremnice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOtpremnice_SelectionChanged(object sender, EventArgs e)
        {
            dgvStavkeNaOtpremnici.DataSource = stavkeNaOtpremnici.DohvatiStavkeZaOtpremnicu(DohvatiOdabranu());
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Dodaj stroj na otpremnicu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Rukuje događajem klika na gumb Dodaj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Rukuje događajem klika na gumb Ažuriraj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Rukuje događajem klika na gumb Ispiši odabranu otpremnicu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIspisi_Click(object sender, EventArgs e)
        {
            Hide();
            using(var forma = new frmOtpremnicaIzvjestaj(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
        }

        /// <summary>
        /// Služi za prikaz pomoći pritiskom na tipku F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopisOtpremnica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#331-upravljanje-otpremnicama");
            }
        }
    }
}
