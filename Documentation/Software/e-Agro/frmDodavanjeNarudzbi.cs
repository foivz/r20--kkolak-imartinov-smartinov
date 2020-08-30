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
    public partial class frmDodavanjeNarudzbi : Form
    {
        Narudzbe narudzbe;
        Dobavljaci dobavljaci;
        Korisnici korisnici;

        private narudzba odabranaNarudzba;

        public frmDodavanjeNarudzbi(narudzba narudzba)
        {
            narudzbe = new Narudzbe();
            dobavljaci = new Dobavljaci();
            korisnici = new Korisnici();
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }
        public frmDodavanjeNarudzbi()
        {
            InitializeComponent();
            dobavljaci = new Dobavljaci();
            narudzbe = new Narudzbe();
            korisnici = new Korisnici();
        }

        private void UcitajCombo()
        {
            cmbDobavljac.DataSource = dobavljaci.DohvatiDobavljace();
            cmbKorisnik.DataSource = korisnici.DohvatiKorisnike();
        }

        private void UcitajGUI()
        {
            if (odabranaNarudzba != null)
            {
                cmbDobavljac.SelectedItem = odabranaNarudzba.dobavljac;
                dtpDatum.Value = odabranaNarudzba.datum_izdavanja.Value;
                txtStatus.Text = odabranaNarudzba.status;
                txtNapomena.Text = odabranaNarudzba.napomena;
                cmbKorisnik.SelectedItem = odabranaNarudzba.korisnik;

                btnDodaj.Text = "Ažuriraj";
                this.Text = "Ažuriranje narudžbu";
                lblNaslov.Text = "Ažuriraj narudžbu";
            }
            UcitajCombo();
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodavanjeNarudzbi_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            UcitajGUI();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dobavljac dobavljac = cmbDobavljac.SelectedItem as dobavljac;
            korisnik korisnik = cmbKorisnik.SelectedItem as korisnik;
            DateTime datumIzdavanja = dtpDatum.Value;
            string status = txtStatus.Text;
            string napomena = txtNapomena.Text;
            


            if (string.IsNullOrEmpty(cmbDobavljac.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            if (odabranaNarudzba != null)
            {
                narudzbe.AzurirajNarudzbu(odabranaNarudzba, dobavljac, korisnik, odabranaNarudzba.cijena, datumIzdavanja, status, napomena);
            }
            else
            {
                narudzbe.DodajNarudzbu(dobavljac, 0, korisnik, datumIzdavanja, status, napomena);
            }
            Close();
        }

        private void frmDodavanjeNarudzbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#323-upravljanje-narud%C5%BEbama");
            }
        }
    }
}
