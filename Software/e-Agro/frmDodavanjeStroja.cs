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
    public partial class frmDodavanjeStroja : Form
    {
        Dobavljaci dobavljaci;
        Strojevi strojevi;

        private katalog_strojeva odabraniStroj;
        public frmDodavanjeStroja()
        {
            dobavljaci = new Dobavljaci();
            strojevi = new Strojevi();
            InitializeComponent();
        }

        public frmDodavanjeStroja(katalog_strojeva stroj)
        {
            dobavljaci = new Dobavljaci();
            strojevi = new Strojevi();
            odabraniStroj = stroj;
            InitializeComponent();
        }

        private void UcitajCombo()
        {
            cmbDobavljac.DataSource = dobavljaci.DohvatiDobavljace();
        }

        private void UcitajGUI()
        {
            if(odabraniStroj != null)
            {
                txtCijena.Text = odabraniStroj.cijena.ToString();
                txtModel.Text = odabraniStroj.model;
                txtNaziv.Text = odabraniStroj.naziv;
                txtVrsta.Text = odabraniStroj.vrsta;
                cmbDobavljac.SelectedItem = odabraniStroj.dobavljac;
                this.Text = "Ažuriranje kataloga strojeva";
                btnDodaj.Text = "Ažuriraj katalog strojeva";
                lblNaslovStroj.Text = "Ažuriraj stroj";
            }
            UcitajCombo();
        }

        private void frmDodavanjeStroja_Load(object sender, EventArgs e)
        {
            UcitajGUI();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            string vrsta = txtVrsta.Text;
            string model = txtModel.Text;
            string opis = rtxtOpis.Text;
            double cijena = double.Parse(txtCijena.Text);
            dobavljac dobavljac = cmbDobavljac.SelectedItem as dobavljac;

            if(odabraniStroj != null)
            {
                strojevi.AzurirajStroj(odabraniStroj, naziv, vrsta, model, opis, cijena, dobavljac);
            }
            else
            {
                strojevi.DodajStroj(naziv, vrsta, model, opis, cijena, dobavljac);
            }

            Close();
        }
    }
}
