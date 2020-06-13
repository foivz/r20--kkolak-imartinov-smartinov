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
    }
}
