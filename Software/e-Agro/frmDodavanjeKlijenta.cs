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
    public partial class frmDodavanjeKlijenta : Form
    {
        Klijenti klijenti;
        private klijent odabraniKlijent;
        public frmDodavanjeKlijenta()
        {
            klijenti = new Klijenti();
            InitializeComponent();
        }

        public frmDodavanjeKlijenta(klijent klijent)
        {
            klijenti = new Klijenti();
            odabraniKlijent = klijent;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            bool vecPostoji = false;
            string email = txtEmail.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string adresa = txtAdresa.Text;
            string tekuciRacun = txtTekuciRacun.Text;

            if (ime =="" || prezime=="" || adresa=="" || email=="" || tekuciRacun== "")
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            if (odabraniKlijent != null)
            {
                klijenti.AzurirajKlijenta(odabraniKlijent, ime, prezime, email, adresa, tekuciRacun);
            }
            else
            {
                List<klijent> postojeciKlijenti = klijenti.DohvatiKlijente();
                foreach (var klijent in postojeciKlijenti)
                {
                    if (klijent.email == email)
                    {
                        vecPostoji = true;
                        break;
                    }
                }
                if(vecPostoji)
                    MessageBox.Show("Klijent s email-om " + email + " već postoji!");
                else
                    klijenti.DodajKlijenta(ime, prezime, email, adresa, tekuciRacun);
            }
            Close();
        }

        private void frmDodavanjeKlijenta_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            if(odabraniKlijent != null)
            {
                txtEmail.Text = odabraniKlijent.email;
                txtIme.Text = odabraniKlijent.ime;
                txtPrezime.Text = odabraniKlijent.prezime;
                txtAdresa.Text = odabraniKlijent.adresa;
                txtTekuciRacun.Text = odabraniKlijent.tekuci_racun;
                btnDodaj.Text = "Ažuriraj klijenta";
                this.Text = "Ažuriranje klijenta";
                lblNaslov.Text = "Ažuriranje klijenta";
            }
        }

        private void frmDodavanjeKlijenta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#324-upravljanje-klijentima");
            }
        }
    }
}
