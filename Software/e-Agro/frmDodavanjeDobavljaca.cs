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
    /// Dodavanje i ažuriranje dobavljača
    /// </summary>
    public partial class frmDodavanjeDobavljaca : Form
    {
        Dobavljaci dobavljaci; // Referenca na klasu Dobavljaci koja upravlja dobavljačima iz baze podataka
        private dobavljac odabraniDobavljac; // Referenca na postojećeg dobavljača ako se radi o ažuriranju

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public frmDodavanjeDobavljaca()
        {
            dobavljaci = new Dobavljaci();
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor forme koji služi za spremanje dobavljača koji se ažurira
        /// </summary>
        /// <param name="dobavljac">Odabrani dobavljač s popisa dobavljača kojega želimo ažurirati</param>
        public frmDodavanjeDobavljaca(dobavljac dobavljac) 
        {
            dobavljaci = new Dobavljaci();
            odabraniDobavljac = dobavljac;
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
            string naziv = txtNaziv.Text;
            string adresa = txtAdresa.Text;
            string tekuciRacun = txtTekuciRacun.Text;

            if(naziv == "" || adresa == "" || tekuciRacun == "") // Ako su uneseni prazni podaci ispiše se poruka
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            if (odabraniDobavljac != null) // Ažuriranje postojećeg dobavljača
            {
                dobavljaci.AzurirajDobavljaca(odabraniDobavljac, naziv, adresa, tekuciRacun);
            }
            else // Dodavanje novog dobavljača
            {
                List<dobavljac> postojeciDobavljaci = dobavljaci.DohvatiDobavljace();
                foreach (var dobavljac in postojeciDobavljaci) // Provjera postoji li već dobavljač s unesenim nazivom
                {
                    if (dobavljac.naziv == naziv)
                    {
                        vecPostoji = true;
                        break;
                    }
                }
                if(vecPostoji)
                    MessageBox.Show("Dobavljač s nazivom " + naziv + " već postoji!");
                else
                    dobavljaci.DodajDobavljaca(naziv, adresa, tekuciRacun);
            }
            Close();
        }

        /// <summary>
        /// Rukuje događajem učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodavanjeDobavljaca_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Mora se dodati kako bi radila F1 pomoć
            if (odabraniDobavljac != null) //Ako se radi o ažuriranju prikažu se podaci za odabranog dobavljača
            {
                txtNaziv.Text = odabraniDobavljac.naziv;
                txtAdresa.Text = odabraniDobavljac.adresa;
                txtTekuciRacun.Text = odabraniDobavljac.tekuci_racun;
                btnDodaj.Text = "Ažuriraj dobavljača";
                this.Text = "Ažuriranje dobavljača";
                lblNaslov.Text = "Ažuriraj dobavljača";
            }
        }

        /// <summary>
        /// Služi za prikaz pomoći pritiskom na tipku F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodavanjeDobavljaca_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#325-upravljanje-dobavlja%C4%8Dima");
            }
        }
    }
}
