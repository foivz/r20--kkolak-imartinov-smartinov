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
    public partial class frmPopisNarudzbi : Form
    {
        Narudzbe narudzbe;
        public frmPopisNarudzbi()
        {
            narudzbe = new Narudzbe();
            InitializeComponent();
        }
        private narudzba DohvatiOdabranu()
        {
            return dgvNarudzbe.CurrentRow.DataBoundItem as narudzba;
        }
        private void OsvjeziTablicu()
        {
            dgvNarudzbe.DataSource = narudzbe.DohvatiNarudzbe();
            dgvNarudzbe.Columns["stavke_na_narudzbi"].Visible = false;
        }

        private void frmPopisNarudzbi_Load_1(object sender, EventArgs e)
        {
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            narudzbe.ObrisiNarudzbu(DohvatiOdabranu());
            OsvjeziTablicu();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
