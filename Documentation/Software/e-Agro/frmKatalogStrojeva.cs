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
            this.KeyPreview = true;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                OsvjeziTablicu();
            else
            {
                using (var context = new PI20_024_DBEntities())
                {
                    var query = from k in context.katalog_strojeva.Include("dobavljac")
                                where k.naziv.Contains(txtSearch.Text) || k.vrsta.Contains(txtSearch.Text) || k.model.Contains(txtSearch.Text)
                                || k.opis.Contains(txtSearch.Text)
                                select k;

                    dgvStrojevi.DataSource = query.ToList();
                }
            }
        }

        private void frmKatalogStrojeva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#321-katalog-strojeva");
            }
        }
    }
}
