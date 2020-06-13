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
    public partial class frmKatalogStrojeva : Form
    {
        Strojevi strojevi;
        public frmKatalogStrojeva()
        {
            strojevi = new Strojevi();
            InitializeComponent();
        }
        private katalog_strojeva DohvatiOdabrani()
        {
            return dgvStrojevi.CurrentRow.DataBoundItem as katalog_strojeva;
        }
        private void OsvjeziTablicu()
        {
            dgvStrojevi.DataSource = strojevi.DohvatiStrojeve();
            dgvStrojevi.Columns["stroj_id"].Visible = false;
            dgvStrojevi.Columns["dobavljac_id"].Visible = false;
            dgvStrojevi.Columns["stavke_na_narudzbi"].Visible = false;
            dgvStrojevi.Columns["stavke_na_otpremnici"].Visible = false;
            dgvStrojevi.Columns["stavke_na_ponudi"].Visible = false;
            dgvStrojevi.Columns["stavke_na_primci"].Visible = false;
            dgvStrojevi.Columns["stroj_na_skladistu"].Visible = false;
        }

        private void frmKatalogStrojeva_Load(object sender, EventArgs e)
        {
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            strojevi.ObrisiStroj(DohvatiOdabrani());
            OsvjeziTablicu();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeStroja())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeStroja(DohvatiOdabrani()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }
    }
}
