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
            string naziv = txtNaziv.Text;
            string adresa = txtAdresa.Text;
            string tekuciRacun = txtTekuciRacun.Text;

            if (odabraniDobavljac != null)
            {
                dobavljaci.AzurirajDobavljaca(odabraniDobavljac, naziv, adresa, tekuciRacun);
            }
            else
            {
                dobavljaci.DodajDobavljaca(naziv, adresa, tekuciRacun);
            }
        }

        private void frmDodavanjeDobavljaca_Load(object sender, EventArgs e)
        {
            if (odabraniDobavljac != null)
            {
                txtNaziv.Text = odabraniDobavljac.naziv;
                txtAdresa.Text = odabraniDobavljac.adresa;
                txtTekuciRacun.Text = odabraniDobavljac.tekuci_racun;
                btnDodaj.Text = "Ažuriraj dobavljača";
                this.Text = "Ažuriranje dobavljača";
            }
        }
    }
}
