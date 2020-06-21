using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

            if(txtKolicina.Text == "" || string.IsNullOrEmpty(cmbStrojevi.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke");
                return;
            }

            stavkeNaOtpremnici.DodajStrojNaOtpremnicu(odabraniStroj, kolicina, odabranaOtpremnica);

            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabranaOtpremnica).State = EntityState.Modified;
                odabranaOtpremnica.cijena += (odabraniStroj.cijena * kolicina);
                context.SaveChanges();
            }
            Close();
        }

        private void frmDodavanjeStrojaNaOtpremnicu_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            cmbStrojevi.DataSource = strojevi.DohvatiStrojeve();
        }

        private void frmDodavanjeStrojaNaOtpremnicu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#331-upravljanje-otpremnicama");
            }
        }
    }
}
