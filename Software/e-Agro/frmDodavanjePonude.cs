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
                txtCijena.Text = odabranaPonuda.cijena.ToString();
                dtpDatumKreiranja.Value = odabranaPonuda.datum_kreiranja;
                cmbKlijent.SelectedItem = odabranaPonuda.klijent;
                btnDodaj.Text = "Ažuriraj ponudu";
                this.Text = "Ažuriranje ponude";
                lblNaslovPonuda.Text = "Ažuriraj ponudu";
            }
            UcitajCombo();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodavanjePonude_Load(object sender, EventArgs e)
        {
            UcitajGUI();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            korisnik korisnik = cmbKreirao.SelectedItem as korisnik;
            string naziv = txtNaziv.Text;
            double cijena = double.Parse(txtCijena.Text);
            DateTime datumKreiranja = dtpDatumKreiranja.Value;
            klijent klijent = cmbKlijent.SelectedItem as klijent;

            if(odabranaPonuda != null)
            {
                ponude.AzurirajPonudu(odabranaPonuda, korisnik, naziv, cijena, datumKreiranja, klijent);
            }
            else
            {
                ponude.DodajPonudu(korisnik, naziv, cijena, datumKreiranja, klijent);
            }
            Close();
        }
    }
}
