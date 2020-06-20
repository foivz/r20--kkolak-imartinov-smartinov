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
    public partial class frmDodavanjeDobavljaca : Form
    {
        Dobavljaci dobavljaci;
        private dobavljac odabraniDobavljac;
        public frmDodavanjeDobavljaca()
        {
            dobavljaci = new Dobavljaci();
            InitializeComponent();
        }

        public frmDodavanjeDobavljaca(dobavljac dobavljac) 
        {
            dobavljaci = new Dobavljaci();
            odabraniDobavljac = dobavljac;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            bool vecPostoji = false;
            string naziv = txtNaziv.Text;
            string adresa = txtAdresa.Text;
            string tekuciRacun = txtTekuciRacun.Text;

            if(naziv == "" || adresa == "" || tekuciRacun == "")
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            if (odabraniDobavljac != null)
            {
                dobavljaci.AzurirajDobavljaca(odabraniDobavljac, naziv, adresa, tekuciRacun);
            }
            else
            {
                List<dobavljac> postojeciDobavljaci = dobavljaci.DohvatiDobavljace();
                foreach (var dobavljac in postojeciDobavljaci)
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

        private void frmDodavanjeDobavljaca_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            if (odabraniDobavljac != null)
            {
                txtNaziv.Text = odabraniDobavljac.naziv;
                txtAdresa.Text = odabraniDobavljac.adresa;
                txtTekuciRacun.Text = odabraniDobavljac.tekuci_racun;
                btnDodaj.Text = "Ažuriraj dobavljača";
                this.Text = "Ažuriranje dobavljača";
                lblNaslov.Text = "Ažuriranje dobavljača";
            }
        }

        private void frmDodavanjeDobavljaca_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#325-upravljanje-dobavlja%C4%8Dima");
            }
        }
    }
}
