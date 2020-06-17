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
    public partial class frmDodavanjeKorisnika : Form
    {
        RadnaMjesta radnoMjesto;
        TipoviKorisnika tipKorisnika;
        Korisnici korisnici;

        private korisnik odabraniKorisnik;
        public frmDodavanjeKorisnika(korisnik korisnik)
        {
            radnoMjesto = new RadnaMjesta();
            tipKorisnika = new TipoviKorisnika();
            korisnici = new Korisnici();
            odabraniKorisnik = korisnik;
            InitializeComponent();
        }
        public frmDodavanjeKorisnika()
        {
            radnoMjesto = new RadnaMjesta();
            tipKorisnika = new TipoviKorisnika();
            korisnici = new Korisnici();
            InitializeComponent();
        }

        private void UcitajCombo()
        {
            cmbRadnoMjesto.DataSource = radnoMjesto.DohvatiRadnaMjesta();
            cmbTipKorisnika.DataSource = tipKorisnika.DohvatiTipoveKorisnika();
        }

        private void UcitajGUI()
        {
            if(odabraniKorisnik != null)
            {
                lblNaslov.Text = "Ažuriraj korisnika";
                btnDodaj.Text = "Ažuriraj korisnika";
                this.Text = "Ažuriranje korisnika";
                lblNaslov.Text = "Ažuriranje korisnika";
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
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodavanjeKorisnika_Load(object sender, EventArgs e)
        {
            UcitajGUI();
        }

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

            if(email == "" || korisnickoIme == "" || lozinka == "" || string.IsNullOrEmpty(cmbTipKorisnika.Text) || ime == "" || prezime == "" || tekuciRacun == "" || adresa == "" || string.IsNullOrEmpty(cmbRadnoMjesto.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            if (odabraniKorisnik != null)
            {
                korisnici.AzurirajKorisnika(odabraniKorisnik, email, korisnickoIme, lozinka, tipKorisnika, ime, prezime, tekuciRacun, adresa, radnoMjesto);
            }
            else
            {
                List<korisnik> postojeciKorisnici = korisnici.DohvatiKorisnike();
                foreach (var korisnik in postojeciKorisnici)
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
    }
}
