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
    public partial class frmDodavanjeOtpremnice : Form
    {
        Otpremnice otpremnice;
        Korisnici korisnici;

        private otpremnica odabranaOtpremnica;

        public frmDodavanjeOtpremnice(otpremnica otpremnica)
        {
            otpremnice = new Otpremnice();
            korisnici = new Korisnici();
            odabranaOtpremnica = otpremnica;
            InitializeComponent();
        }
        public frmDodavanjeOtpremnice()
        {
            otpremnice = new Otpremnice();
            korisnici = new Korisnici();
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UcitajCombo()
        {
            cmbKreirao.DataSource = korisnici.DohvatiKorisnike();
        }

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
        private void frmDodavanjeOtpremnice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            UcitajGUI();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            korisnik korisnik = cmbKreirao.SelectedItem as korisnik;
            DateTime datumIsporuke = dtpDatumIsporuke.Value;

            if(string.IsNullOrEmpty(cmbKreirao.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }
            if (odabranaOtpremnica != null)
            {
                otpremnice.AzurirajOtpremnicu(odabranaOtpremnica, korisnik, odabranaOtpremnica.cijena, datumIsporuke);
            }
            else
            {
                otpremnice.DodajOtpremnicu(korisnik, 0, datumIsporuke);
            }
            Close();
        }

        private void frmDodavanjeOtpremnice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#323-upravljanje-narud%C5%BEbama");
            }
        }
    }
}
