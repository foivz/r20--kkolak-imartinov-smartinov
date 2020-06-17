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
                rtxtOpis.Text = odabraniStroj.opis;
                txtVrsta.Text = odabraniStroj.vrsta;
                cmbDobavljac.SelectedItem = odabraniStroj.dobavljac;
                this.Text = "Ažuriranje kataloga strojeva";
                btnDodaj.Text = "Ažuriraj katalog strojeva";
                lblNaslov.Text = "Ažuriranje kataloga strojeva";
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
            bool vecPostoji = false;
            string naziv = txtNaziv.Text;
            string vrsta = txtVrsta.Text;
            string model = txtModel.Text;
            string opis = rtxtOpis.Text;
            double cijena = double.Parse(txtCijena.Text);
            dobavljac dobavljac = cmbDobavljac.SelectedItem as dobavljac;

            if(naziv == "" || vrsta == "" || model == "" || opis == "" || string.IsNullOrEmpty(cmbDobavljac.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }

            if(odabraniStroj != null)
            {
                strojevi.AzurirajStroj(odabraniStroj, naziv, vrsta, model, opis, cijena, dobavljac);
            }
            else
            {
                List<katalog_strojeva> postojeciStrojevi = strojevi.DohvatiStrojeve();
                foreach (var stroj in postojeciStrojevi)
                {
                    if(stroj.naziv == naziv && stroj.vrsta == vrsta && stroj.model == model)
                    {
                        vecPostoji = true;
                        break;
                    }
                }
                if(vecPostoji)
                    MessageBox.Show("Stroj " + naziv + " " + vrsta + " " + model + " već postoji!");
                else
                    strojevi.DodajStroj(naziv, vrsta, model, opis, cijena, dobavljac);
            }

            Close();
        }
    }
}
