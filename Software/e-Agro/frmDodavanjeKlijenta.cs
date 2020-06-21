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
    /// Dodavanje i ažuriranje klijenta
    /// </summary>
    public partial class frmDodavanjeKlijenta : Form
    {
        Klijenti klijenti; // Referenca na klasu Klijenti koja upravlja klijentima iz baze podataka
        private klijent odabraniKlijent; // Referenca na postojećeg klijenta ako se radi o ažuriranju

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public frmDodavanjeKlijenta()
        {
            klijenti = new Klijenti();
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor forme koji služi za spremanje klijenta koji se ažurira
        /// </summary>
        /// <param name="klijent"></param>
        public frmDodavanjeKlijenta(klijent klijent)
        {
            klijenti = new Klijenti();
            odabraniKlijent = klijent;
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
        /// Rukuje događajem klika na gumb Dodaj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            bool vecPostoji = false;
            string email = txtEmail.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string adresa = txtAdresa.Text;
            string tekuciRacun = txtTekuciRacun.Text;

            if (ime =="" || prezime=="" || adresa=="" || email=="" || tekuciRacun== "") // Ako su uneseni prazni podaci ispiše se poruka
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            if (odabraniKlijent != null) //Ažuriranje postojećeg klijenta
            {
                klijenti.AzurirajKlijenta(odabraniKlijent, ime, prezime, email, adresa, tekuciRacun);
            }
            else //Dodavanje novog klijenta
            {
                List<klijent> postojeciKlijenti = klijenti.DohvatiKlijente();
                foreach (var klijent in postojeciKlijenti) //Provjera postoji li već klijent s unesenim e-mailom
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

        /// <summary>
        /// Rukuje događajem učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodavanjeKlijenta_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Mora se dodati kako bi radila F1 pomoć
            if (odabraniKlijent != null) //Ako se radi o ažuriranju prikažu se podaci za odabranog dobavljača
            {
                txtEmail.Text = odabraniKlijent.email;
                txtIme.Text = odabraniKlijent.ime;
                txtPrezime.Text = odabraniKlijent.prezime;
                txtAdresa.Text = odabraniKlijent.adresa;
                txtTekuciRacun.Text = odabraniKlijent.tekuci_racun;
                btnDodaj.Text = "Ažuriraj klijenta";
                this.Text = "Ažuriranje klijenta";
                lblNaslov.Text = "Ažuriraj klijenta";
            }
        }

        /// <summary>
        /// Služi za prikaz pomoći pritiskom na tipku F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodavanjeKlijenta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#324-upravljanje-klijentima");
            }
        }
    }
}
