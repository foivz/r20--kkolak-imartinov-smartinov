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
    public partial class frmDodavanjeStrojaNaPonuda : Form
    {
        private ponuda odabranaPonuda;
        Strojevi strojevi;
        StavkeNaPonudi stavkeNaPonudi;
        public frmDodavanjeStrojaNaPonuda(ponuda ponuda)
        {
            odabranaPonuda = ponuda;
            strojevi = new Strojevi();
            stavkeNaPonudi = new StavkeNaPonudi();
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
            stavkeNaPonudi.DodajStrojNaPonudu(odabraniStroj, kolicina, odabranaPonuda);
            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabranaPonuda).State = EntityState.Modified;
                odabranaPonuda.cijena += (odabraniStroj.cijena * kolicina);
                context.SaveChanges();
            }
            Close();
        }

        private void frmDodavanjeStrojaNaPonuda_Load(object sender, EventArgs e)
        {
            cmbStrojevi.DataSource = strojevi.DohvatiStrojeve();
        }
    }
}
