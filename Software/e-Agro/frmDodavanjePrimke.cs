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
    public partial class frmDodavanjePrimke : Form
    {
        Primke primke;
        Korisnici korisnici;

        private primka odabranaPrimka;

        public frmDodavanjePrimke(primka primka)
        {
            primke = new Primke();
            korisnici = new Korisnici();
            odabranaPrimka = primka;
            InitializeComponent();
        }

        public frmDodavanjePrimke()
        {
            korisnici = new Korisnici();
            primke = new Primke();
            InitializeComponent();
        }

        private void UcitajCombo()
        {
            cmbKreirao.DataSource = korisnici.DohvatiKorisnike();
        }

        private void UcitajGUI()
        {
            if (odabranaPrimka != null)
            {
                cmbKreirao.SelectedItem = odabranaPrimka.korisnik;
                txtCijena.Text = odabranaPrimka.cijena.ToString();
                btnDodaj.Text = "Ažuriraj korisnika";
                this.Text = "Ažuriranje korisnika";
            }
            UcitajCombo();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodavanjePrimke_Load(object sender, EventArgs e)
        {
            UcitajGUI();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            korisnik korisnik = cmbKreirao.SelectedItem as korisnik;
            int cijena =int.Parse(txtCijena.Text);
            if (odabranaPrimka != null)
            {
                primke.AzurirajPrimku(odabranaPrimka, korisnik, cijena);
            }
            else
            {
                primke.DodajPrimku(korisnik, cijena);
            }
            Close();

        }
    }
}
