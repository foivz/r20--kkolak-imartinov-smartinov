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
    /// Prikaz popisa korisnika te daljnji rad s korisnicima iz baze
    /// </summary>
    public partial class frmPopisKorisnika : Form
    {
        Korisnici korisnici; //Referenca na klasu Korisnici koja upravlja korisnicima iz baze podataka

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public frmPopisKorisnika()
        {
            korisnici = new Korisnici();
            InitializeComponent();  
        }

        /// <summary>
        /// Dohvaćanje odabranog korisnika iz tablice
        /// </summary>
        /// <returns>Vraća objekta korisnik koji je instanca iz baze podataka</returns>
        private korisnik DohvatiOdabranog()
        {
            return dgvKorisnici.CurrentRow.DataBoundItem as korisnik;
        }

        /// <summary>
        /// Prikaz popisa korisnika u DataGridView
        /// </summary>
        private void OsvjeziTablicu()
        {
            dgvKorisnici.DataSource = korisnici.DohvatiKorisnike();
            dgvKorisnici.Columns["otpremnicas"].Visible = false;
            dgvKorisnici.Columns["ponudas"].Visible = false;
            dgvKorisnici.Columns["primkas"].Visible = false;
            dgvKorisnici.Columns["korisnik_id"].Visible = false;
            dgvKorisnici.Columns["tip_id"].Visible = false;
            dgvKorisnici.Columns["radno_mjesto_id"].Visible = false;
        }

        /// <summary>
        /// Rukuje događajem učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopisKorisnika_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Mora se dodati kako bi radila F1 pomoć
            OsvjeziTablicu();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Dodaj te otvara formu za dodavanje korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeKorisnika())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Obriši
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            korisnici.ObrisiKorisnika(DohvatiOdabranog());
            OsvjeziTablicu();
        }

        /// <summary>
        /// Rukue događajem klika na gumb Ažuriraj te otvara formu za dodavanje korisnika gdje predaje kao parametar formi odabranog korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeKorisnika(DohvatiOdabranog()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        /// <summary>
        /// Služi za prikaz pomoći pritiskom na tipku F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopisKorisnika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#313-upravljanje-korisnicima");
            }
        }
    }
}
