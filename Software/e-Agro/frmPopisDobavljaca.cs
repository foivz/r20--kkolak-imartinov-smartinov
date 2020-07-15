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
    public partial class frmPopisDobavljaca : Form
    {
        Dobavljaci dobavljaci;
        public frmPopisDobavljaca()
        {
            dobavljaci = new Dobavljaci();
            InitializeComponent();
        }

        private void OsvjeziTablicu()
        {
            dgvDobavljaci.DataSource = dobavljaci.DohvatiDobavljace();
            dgvDobavljaci.Columns["narudzbas"].Visible = false;
            dgvDobavljaci.Columns["katalog_strojeva"].Visible = false;
            dgvDobavljaci.Columns["dobavljac_id"].Visible = false;
        }

        private dobavljac DohvatiOdabranog()
        {
            return dgvDobavljaci.CurrentRow.DataBoundItem as dobavljac;
        }

        private void frmPopisDobavljaca_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            dobavljaci.ObrisiDobavljaca(DohvatiOdabranog());
            OsvjeziTablicu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeDobavljaca())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeDobavljaca(DohvatiOdabranog()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmProdajniReferentIzvjestaj())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void frmPopisDobavljaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#325-upravljanje-dobavlja%C4%8Dima");
            }
        }
    }
}
