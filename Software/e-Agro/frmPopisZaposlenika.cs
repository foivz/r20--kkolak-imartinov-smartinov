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
    public partial class frmPopisZaposlenika : Form
    {
        Zaposlenici zaposlenici;
        public frmPopisZaposlenika()
        {
            zaposlenici = new Zaposlenici();
            InitializeComponent();
        }
        private korisnik DohvatiOdabranog()
        {
            return dgvZaposlenici.CurrentRow.DataBoundItem as korisnik;
        }
        private void OsvjeziTablicu()
        {
            dgvZaposlenici.DataSource = zaposlenici.DohvatiZaposlenike();
            dgvZaposlenici.Columns["otpremnicas"].Visible = false;
            dgvZaposlenici.Columns["ponudas"].Visible = false;
            dgvZaposlenici.Columns["primkas"].Visible = false;
        }

        private void frmPopisZaposlenika_Load(object sender, EventArgs e)
        {
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            zaposlenici.ObrisiZaposlenika(DohvatiOdabranog());
            OsvjeziTablicu();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
