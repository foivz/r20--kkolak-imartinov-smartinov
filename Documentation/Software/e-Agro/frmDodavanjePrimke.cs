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
                txtMjesto.Text = odabranaPrimka.mjesto;
                txtTecaj.Text = odabranaPrimka.tecaj.ToString();
                dtpDatum.Value = odabranaPrimka.datum.Value;
                btnDodaj.Text = "Ažuriraj primku";
                this.Text = "Ažuriranje primke";
                lblNaslov.Text = "Ažuriraj primku";
            }
            UcitajCombo();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodavanjePrimke_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            UcitajGUI();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            korisnik korisnik = cmbKreirao.SelectedItem as korisnik;
            string mjesto = txtMjesto.Text;
            double tecaj = double.Parse(txtTecaj.Text);
            DateTime datum = dtpDatum.Value;

            if (string.IsNullOrEmpty(cmbKreirao.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }
            if (odabranaPrimka != null)
            {
                primke.AzurirajPrimku(odabranaPrimka, korisnik, odabranaPrimka.cijena, datum, mjesto, tecaj);
            }
            else
            {
                primke.DodajPrimku(korisnik, 0, datum,mjesto,tecaj);
            }
            Close();
        }

        private void frmDodavanjePrimke_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#332-upravljanje-primkama");
            }
        }
    }
}
