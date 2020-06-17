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
    public partial class frmDodavanjeUreda : Form
    {
        Uredi uredi;

        private ured odabraniUred;
        public frmDodavanjeUreda()
        {
            uredi = new Uredi();
            InitializeComponent();
        }

        public frmDodavanjeUreda(ured ured)
        {
            uredi = new Uredi();
            odabraniUred = ured;
            InitializeComponent();
        }

        private void UcitajGUI()
        {
            radno_mjesto odabranoRadnoMjesto = new radno_mjesto();
            if (odabraniUred != null)
            {
                using (var context = new PI20_024_DBEntities())
                {
                    var query = from r in context.radno_mjesto
                                where r.ured_id == odabraniUred.ured_id
                                select r;

                    odabranoRadnoMjesto = query.First();
                }

                txtAdresa.Text = odabranoRadnoMjesto.adresa;
                txtOdjel.Text = odabraniUred.odjel;
                txtZupanija.Text = odabraniUred.zupanija;
                this.Text = "Ažuriranje ureda";
                btnDodaj.Text = "Ažuriraj ured";
                lblNaslov.Text = "Ažuriraj ured";
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodavanjeUreda_Load(object sender, EventArgs e)
        {
            UcitajGUI();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            bool vecPostoji = false;
            string adresa = txtAdresa.Text;
            string zupanija = txtZupanija.Text;
            string odjel = txtOdjel.Text;

            if(adresa == "" || zupanija == "" || odjel == "")
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }
            if(odabraniUred != null)
            {
                uredi.AzurirajUred(odabraniUred, odjel, adresa, zupanija);
            }
            else
            {
                uredi.DodajUred(odjel, adresa, zupanija);
            }
            Close();
        }
    }
}
