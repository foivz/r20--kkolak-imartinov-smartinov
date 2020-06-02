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
            string email = txtEmail.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string adresa = txtAdresa.Text;
            string tekuciRacun = txtTekuciRacun.Text;

            if (odabraniKlijent != null)
            {
                klijenti.AzurirajKlijenta(odabraniKlijent, ime, prezime, email, adresa, tekuciRacun);
            }
            else
            {
                klijenti.DodajKlijenta(ime, prezime, email, adresa, tekuciRacun);
            }
        }

        private void frmDodavanjeKlijenta_Load(object sender, EventArgs e)
        {
            if(odabraniKlijent != null)
            {
                txtEmail.Text = odabraniKlijent.email;
                txtIme.Text = odabraniKlijent.ime;
                txtPrezime.Text = odabraniKlijent.prezime;
                txtAdresa.Text = odabraniKlijent.adresa;
                txtTekuciRacun.Text = odabraniKlijent.tekuci_racun;
                btnDodaj.Text = "Ažuriraj klijenta";
                this.Text = "Ažuriranje klijenta";
            }
        }
    }
}
