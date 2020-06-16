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

        private narudzba odabranaNarudzba;

        public frmDodavanjeNarudzbi(narudzba narudzba)
        {
            narudzbe = new Narudzbe();
            dobavljaci = new Dobavljaci();
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }
        public frmDodavanjeNarudzbi()
        {
            InitializeComponent();
            dobavljaci = new Dobavljaci();
            narudzbe = new Narudzbe();
        }

        private void UcitajCombo()
        {
            cmbDobavljac.DataSource = dobavljaci.DohvatiDobavljace();
        }

        private void UcitajGUI()
        {
            if (odabranaNarudzba != null)
            {
                cmbDobavljac.SelectedItem = odabranaNarudzba.dobavljac;
                txtCijena.Text = odabranaNarudzba.cijena.ToString();
                btnDodaj.Text = "Ažuriraj narudžbu";
                this.Text = "Ažuriranje narudžbe";
                lblNaslovNarudzba.Text = "Ažuriraj narudžbu";
            }
            UcitajCombo();
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodavanjeNarudzbi_Load(object sender, EventArgs e)
        {
            UcitajGUI();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dobavljac dobavljac = cmbDobavljac.SelectedItem as dobavljac;
            double cijena = double.Parse(txtCijena.Text);
            if (odabranaNarudzba != null)
            {
                narudzbe.AzurirajNarudzbu(odabranaNarudzba, dobavljac, cijena);
            }
            else
            {
                narudzbe.DodajNarudzbu(dobavljac, cijena);
            }
            Close();
        }
    }
}
