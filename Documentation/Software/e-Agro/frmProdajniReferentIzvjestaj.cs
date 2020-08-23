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
    public partial class frmProdajniReferentIzvjestaj : Form
    {
        Dobavljaci dobavljaci;
        public frmProdajniReferentIzvjestaj()
        {
            dobavljaci = new Dobavljaci();
            InitializeComponent();
        }

        private void frmProdajniReferentIzvjestaj_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            cmbDobavljac.DataSource = dobavljaci.DohvatiDobavljace();
        }

        private dobavljac DohvatiOdabranog()
        {
            dobavljac odabraniDobavljac = cmbDobavljac.SelectedItem as dobavljac;
            return odabraniDobavljac;
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            Hide();
            using(var forma = new frmPrikazIzvjestajaProdajniRefrent(DohvatiOdabranog()))
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void frmProdajniReferentIzvjestaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#325-upravljanje-dobavlja%C4%8Dima");
            }
        }
    }
}
