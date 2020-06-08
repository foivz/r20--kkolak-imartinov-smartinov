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
        public frmDodavanjeStroja()
        {
            dobavljaci = new Dobavljaci();
            strojevi = new Strojevi();
            InitializeComponent();
        }

        private void frmDodavanjeStroja_Load(object sender, EventArgs e)
        {
            cmbDobavljac.DataSource = dobavljaci.DohvatiDobavljace();
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

            strojevi.DodajStroj(naziv, vrsta, model, opis, cijena, dobavljac);
        }
    }
}
