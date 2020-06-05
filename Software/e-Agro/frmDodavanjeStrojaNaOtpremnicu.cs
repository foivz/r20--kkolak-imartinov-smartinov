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
    public partial class frmDodavanjeStrojaNaOtpremnicu : Form
    {
        private otpremnica odabranaOtpremnica;
        StavkeNaOtpremnici stavkeNaOtpremnici;
        Strojevi strojevi;
        public frmDodavanjeStrojaNaOtpremnicu(otpremnica otpremnica)
        {
            odabranaOtpremnica = otpremnica;
            stavkeNaOtpremnici = new StavkeNaOtpremnici();
            strojevi = new Strojevi();
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            katalog_strojeva odabraniStroj = cmbStrojevi.SelectedItem as katalog_strojeva;
            int kolicina = int.Parse(txtKolicina.Text);
            stavkeNaOtpremnici.DodajStrojNaOtpremnicu(odabraniStroj, kolicina, odabranaOtpremnica);
        }

        private void frmDodavanjeStrojaNaOtpremnicu_Load(object sender, EventArgs e)
        {
            cmbStrojevi.DataSource = strojevi.DohvatiStrojeve();
        }
    }
}
