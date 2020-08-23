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
    /// Dodavanje i ažuriranje otpremnice
    /// </summary>
    public partial class frmDodavanjeOtpremnice : Form
    {
        Otpremnice otpremnice; // Referenca na klasu Otpremnice koja upravlja otpremnicama iz baze podataka
        Korisnici korisnici; // Referenca na klasu Korisnici koja upravlja korisnicima iz baze podataka

        private otpremnica odabranaOtpremnica; // Referenca na postojeću otpremnicu ako se radi o ažuriranju

        /// <summary>
        /// Konstruktor forme koji služi za spremanje otpremnice koja se ažurira
        /// </summary>
        /// <param name="otpremnica">Odabrana otpremnica s popisa otpremnica koju želimo ažurirati</param>
        public frmDodavanjeOtpremnice(otpremnica otpremnica)
        {
            otpremnice = new Otpremnice();
            korisnici = new Korisnici();
            odabranaOtpremnica = otpremnica;
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public frmDodavanjeOtpremnice()
        {
            otpremnice = new Otpremnice();
            korisnici = new Korisnici();
            InitializeComponent();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Odustani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Metoda za učitavanje podataka u ComboBox
        /// </summary>
        private void UcitajCombo()
        {
            cmbKreirao.DataSource = korisnici.DohvatiKorisnike();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UcitajGUI()
        {
            if (odabranaOtpremnica != null)
            {
                cmbKreirao.SelectedItem = odabranaOtpremnica.korisnik;
                dtpDatumIsporuke.Value = odabranaOtpremnica.datum_isporuke;
                btnDodaj.Text = "Ažuriraj otpremnicu";
                this.Text = "Ažuriranje otpremnice";
                lblNaslov.Text = "Ažuriraj otpremnicu";
            }
            UcitajCombo();
        }

        /// <summary>
        /// Rukuje događajem učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodavanjeOtpremnice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Mora se dodati kako bi radila F1 pomoć
            UcitajGUI();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Dodaj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            korisnik korisnik = cmbKreirao.SelectedItem as korisnik;
            DateTime datumIsporuke = dtpDatumIsporuke.Value;

            if(string.IsNullOrEmpty(cmbKreirao.Text)) // Ako su uneseni prazni podaci ispiše se poruka
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }
            if (odabranaOtpremnica != null) // Ažuriranje postojeće otpremnice
            {
                otpremnice.AzurirajOtpremnicu(odabranaOtpremnica, korisnik, odabranaOtpremnica.cijena, datumIsporuke);
            }
            else // Dodavanje nove otpremnice
            {
                otpremnice.DodajOtpremnicu(korisnik, 0, datumIsporuke);
            }
            Close();
        }

        /// <summary>
        /// Služi za prikaz pomoći pritiskom na tipku F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodavanjeOtpremnice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#323-upravljanje-narud%C5%BEbama");
            }
        }
    }
}
