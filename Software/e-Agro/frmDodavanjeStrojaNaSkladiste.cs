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
    public partial class frmDodavanjeStrojaNaSkladiste : Form
    {
        private stroj_na_skladistu odabraniStrojNaSkladistu;
        StrojeviNaSkladistu strojeviNaSkladistu;
        Strojevi strojevi;
        Skladista skladista;
        public frmDodavanjeStrojaNaSkladiste()
        {
            strojeviNaSkladistu = new StrojeviNaSkladistu();
            strojevi = new Strojevi();
            skladista = new Skladista();
            InitializeComponent();
        }

        public frmDodavanjeStrojaNaSkladiste(stroj_na_skladistu strojNaSkladistu)
        {
            strojeviNaSkladistu = new StrojeviNaSkladistu();
            strojevi = new Strojevi();
            skladista = new Skladista();
            odabraniStrojNaSkladistu = strojNaSkladistu;
            InitializeComponent();
        }

        private void UcitajCombo()
        {
            cmbSkladiste.DataSource = skladista.DohvatiSkladista();
            cmbStrojevi.DataSource = strojevi.DohvatiStrojeve();
        }

        private void UcitajGUI()
        {
            if (odabraniStrojNaSkladistu != null)
            {
                cmbStrojevi.SelectedItem = odabraniStrojNaSkladistu.katalog_strojeva;
                cmbSkladiste.SelectedItem = odabraniStrojNaSkladistu.skladiste;
                cmbStrojevi.Enabled = false;
                cmbSkladiste.Enabled = false;
                txtKolicina.Text = odabraniStrojNaSkladistu.kolicina.ToString();
                btnDodaj.Text = "Ažuriraj stroj na skladištu";
                this.Text = "Ažuriranje stroja na skladištu";
                lblNaslov.Text = "Ažuriraj stroj na skladištu";
            }
            UcitajCombo();
        }
        private void frmDodavanjeStrojaNaSkladiste_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            UcitajGUI();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            katalog_strojeva odabraniStroj = cmbStrojevi.SelectedItem as katalog_strojeva;
            skladiste odabranoSkladiste = cmbSkladiste.SelectedItem as skladiste;
            int kolicina = int.Parse(txtKolicina.Text);

            if(txtKolicina.Text == "" || string.IsNullOrEmpty(cmbSkladiste.Text) || string.IsNullOrEmpty(cmbStrojevi.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }
                if (odabraniStrojNaSkladistu!= null)
            {
                strojeviNaSkladistu.AzurirajStrojNaSKladistu(odabraniStrojNaSkladistu, kolicina);
            }
            else
            {
                strojeviNaSkladistu.DodajStrojNaSkladiste(odabraniStroj, odabranoSkladiste, kolicina);
            }
            Close();
        }

        private void frmDodavanjeStrojaNaSkladiste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#333-dodavanje-strojeva-na-skladi%C5%A1te");
            }
        }
    }
}
