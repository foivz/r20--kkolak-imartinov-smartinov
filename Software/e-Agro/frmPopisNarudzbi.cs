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
        StavkeNaNarudzbi stavkeNaNarudzbi;
        public frmPopisNarudzbi()
        {
            narudzbe = new Narudzbe();
            stavkeNaNarudzbi = new StavkeNaNarudzbi();
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
            dgvNarudzbe.Columns["narudzba_id"].Visible = false;
            dgvNarudzbe.Columns["dobavljac_id"].Visible = false;
        }

        private void frmPopisNarudzbi_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            narudzbe.ObrisiNarudzbu(DohvatiOdabranu());
            OsvjeziTablicu();
        }

        private void dgvNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            dgvStavkeNaNarudzbi.DataSource = stavkeNaNarudzbi.DohvatiStavkeZaNarudzbu(DohvatiOdabranu());
        }

        private void btnDodajStroj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeStrojaNaNarudzbu(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            Hide();
            using (var forma = new frmDodavanjeNarudzbi())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeNarudzbi(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void frmPopisNarudzbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#323-upravljanje-narud%C5%BEbama");
            }
        }
    }
}
