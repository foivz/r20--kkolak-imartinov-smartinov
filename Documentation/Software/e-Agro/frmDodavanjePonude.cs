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
    public partial class frmDodavanjePonude : Form
    {
        Ponude ponude;
        Korisnici korisnici;
        Klijenti klijenti;

        private ponuda odabranaPonuda;
        public frmDodavanjePonude()
        {
            ponude = new Ponude();
            korisnici = new Korisnici();
            klijenti = new Klijenti();
            InitializeComponent();
        }

        public frmDodavanjePonude(ponuda ponuda)
        {
            ponude = new Ponude();
            korisnici = new Korisnici();
            klijenti = new Klijenti();
            odabranaPonuda = ponuda;
            InitializeComponent();
        }

        private void UcitajCombo()
        {
            cmbKlijent.DataSource = klijenti.DohvatiKlijente();
            cmbKreirao.DataSource = korisnici.DohvatiKorisnike();
        }

        private void UcitajGUI()
        {
            if(odabranaPonuda != null)
            {
                cmbKreirao.SelectedItem = odabranaPonuda.korisnik;
                txtNaziv.Text = odabranaPonuda.naziv;
                dtpDatumKreiranja.Value = odabranaPonuda.datum_kreiranja;
                cmbKlijent.SelectedItem = odabranaPonuda.klijent;
                btnDodaj.Text = "Ažuriraj ponudu";
                this.Text = "Ažuriranje ponude";
                lblNaslov.Text = "Ažuriraj ponudu";
            }
            UcitajCombo();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodavanjePonude_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            UcitajGUI();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            korisnik korisnik = cmbKreirao.SelectedItem as korisnik;
            string naziv = txtNaziv.Text;
            DateTime datumKreiranja = dtpDatumKreiranja.Value;
            klijent klijent = cmbKlijent.SelectedItem as klijent;

            if (string.IsNullOrEmpty(cmbKreirao.Text) || naziv=="" || string.IsNullOrEmpty(cmbKlijent.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            if(odabranaPonuda != null)
            {
                ponude.AzurirajPonudu(odabranaPonuda, korisnik, naziv, odabranaPonuda.cijena, datumKreiranja, klijent);
            }
            else
            {
                ponude.DodajPonudu(korisnik, naziv, 0, datumKreiranja, klijent);
            }
            Close();
        }

        private void frmDodavanjePonude_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#322-upravljanje-ponudama");
            }
        }
    }
}
