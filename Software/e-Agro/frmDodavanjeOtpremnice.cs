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
                txtCijena.Text = odabranaOtpremnica.cijena.ToString();
                dtpDatumIsporuke.Value = odabranaOtpremnica.datum_isporuke;
                btnDodaj.Text = "Ažuriraj otpremnicu";
                this.Text = "Ažuriranje otpremnice";
                lblNaslov.Text = "Ažuriranje otpremnice";
            }
            UcitajCombo();
        }
        private void frmDodavanjeOtpremnice_Load(object sender, EventArgs e)
        {
            UcitajGUI();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            korisnik korisnik = cmbKreirao.SelectedItem as korisnik;
            double cijena = double.Parse(txtCijena.Text);
            DateTime datumIsporuke = dtpDatumIsporuke.Value;
            if (odabranaOtpremnica != null)
            {
                otpremnice.AzurirajOtpremnicu(odabranaOtpremnica, korisnik, cijena, datumIsporuke);
            }
            else
            {
                otpremnice.DodajOtpremnicu(korisnik, cijena,datumIsporuke);
            }
            Close();
        }
    }
}
