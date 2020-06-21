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
    /// Dodavanje i ažuriranje korisnika
    /// </summary>
    public partial class frmDodavanjeKorisnika : Form
    {
        RadnaMjesta radnoMjesto; // Referenca na klasu RadnaMjesta koja upravlja radnim mjestima iz baze podataka
        TipoviKorisnika tipKorisnika; // Referenca na klasu TipoviKorisnika koja upravlja tipovima korisnika iz baze podataka
        Korisnici korisnici; // Referenca na klasu Korisnici koja upravlja korisnicima iz baze podataka

        private korisnik odabraniKorisnik; // Referenca na postojećeg korisnika ako se radi o ažuriranju

        /// <summary>
        /// Konstruktor forme koji služi za spremanje korisnika koji se ažurira
        /// </summary>
        /// <param name="korisnik"></param>
        public frmDodavanjeKorisnika(korisnik korisnik)
        {
            radnoMjesto = new RadnaMjesta();
            tipKorisnika = new TipoviKorisnika();
            korisnici = new Korisnici();
            odabraniKorisnik = korisnik;
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public frmDodavanjeKorisnika()
        {
            radnoMjesto = new RadnaMjesta();
            tipKorisnika = new TipoviKorisnika();
            korisnici = new Korisnici();
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja služi za učitavanje podataka u ComboBox-ove
        /// </summary>
        private void UcitajCombo()
        {
            cmbRadnoMjesto.DataSource = radnoMjesto.DohvatiRadnaMjesta();
            cmbTipKorisnika.DataSource = tipKorisnika.DohvatiTipoveKorisnika();
        }

        /// <summary>
        /// Metoda koja služi za promjenu teksta koji piše na formi ako se radi o ažuriranju
        /// i za prikaz podataka za odabranog korisnika
        /// </summary>
        private void UcitajGUI()
        {
            if(odabraniKorisnik != null)
            {
                lblNaslov.Text = "Ažuriraj korisnika";
                btnDodaj.Text = "Ažuriraj korisnika";
                this.Text = "Ažuriranje korisnika";
                lblNaslov.Text = "Ažuriraj korisnika";
                txtEmail.Text = odabraniKorisnik.email;
                txtKorisnickoIme.Text = odabraniKorisnik.korisnicko_ime;
                txtLozinka.Text = odabraniKorisnik.lozinka;
                cmbTipKorisnika.SelectedItem = odabraniKorisnik.tip_korisnika;
                txtIme.Text = odabraniKorisnik.ime;
                txtPrezime.Text = odabraniKorisnik.prezime;
                txtTekuciRacun.Text = odabraniKorisnik.tekuci_racun;
                txtAdresa.Text = odabraniKorisnik.adresa;
                cmbRadnoMjesto.SelectedItem = odabraniKorisnik.radno_mjesto;
            }
            UcitajCombo();
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
        /// Rukuje događajem učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodavanjeKorisnika_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            UcitajGUI();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Dodaj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            bool vecPostojiKorisnickoIme = false;
            bool vecPostojiEmail = false;
            string email = txtEmail.Text;
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            tip_korisnika tipKorisnika = cmbTipKorisnika.SelectedItem as tip_korisnika;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string tekuciRacun = txtTekuciRacun.Text;
            string adresa = txtAdresa.Text;
            radno_mjesto radnoMjesto = cmbRadnoMjesto.SelectedItem as radno_mjesto;

            // Ako su uneseni prazni podaci ispiše se poruka
            if(email == "" || korisnickoIme == "" || lozinka == "" || string.IsNullOrEmpty(cmbTipKorisnika.Text) || ime == "" || prezime == "" || tekuciRacun == "" || adresa == "" || string.IsNullOrEmpty(cmbRadnoMjesto.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            if (odabraniKorisnik != null) // Ažuriranje postojećeg korisnika
            {
                korisnici.AzurirajKorisnika(odabraniKorisnik, email, korisnickoIme, lozinka, tipKorisnika, ime, prezime, tekuciRacun, adresa, radnoMjesto);
            }
            else // Dodavanje novog korisnika
            {
                List<korisnik> postojeciKorisnici = korisnici.DohvatiKorisnike();
                foreach (var korisnik in postojeciKorisnici) // Provjera postoji li korisnik s unesenim korisničkim imenom ili e-mailom
                {
                    if(korisnik.korisnicko_ime == korisnickoIme)
                        vecPostojiKorisnickoIme = true;
                    if (korisnik.email == email)
                        vecPostojiEmail = true;
                }
                if(vecPostojiEmail && vecPostojiKorisnickoIme)
                    MessageBox.Show("Korisničko ime " + korisnickoIme + " je već zauzeto i e-mail adresa " + email + " je već zauzeta!");
                else if(vecPostojiEmail && !vecPostojiKorisnickoIme)
                    MessageBox.Show("E-mail " + email + " je već zauzet!");
                else if(!vecPostojiEmail && vecPostojiKorisnickoIme)
                    MessageBox.Show("Korisničko ime " + korisnickoIme + " je već zauzeto!");
                else
                    korisnici.DodajKorisnika(email, korisnickoIme, lozinka, tipKorisnika, ime, prezime, tekuciRacun, adresa, radnoMjesto);
            }
            Close();
        }

        /// <summary>
        /// Služi za prikaz pomoći pritiskom na tipku F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodavanjeKorisnika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#313-upravljanje-korisnicima");
            }
        }
    }
}
