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
    public partial class frmPopisUreda : Form
    {
        Uredi uredi;
        public frmPopisUreda()
        {
            uredi = new Uredi();
            InitializeComponent();
        }
        private ured DohvatiOdabranog()
        {
            return dgvUredi.CurrentRow.DataBoundItem as ured;
        }
        private void OsvjeziTablicu()
        {
            dgvUredi.DataSource = uredi.DohvatiUrede();
            dgvUredi.Columns["radno_mjesto"].Visible = false;
            dgvUredi.Columns["ured_id"].Visible = false;
        }

        private void frmPopisUreda_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            OsvjeziTablicu();

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            uredi.ObrisiUred(DohvatiOdabranog());
            OsvjeziTablicu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using(var forma = new frmDodavanjeUreda())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeUreda(DohvatiOdabranog()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void frmPopisUreda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#312-upravljanje-uredom");
            }
        }
    }
}
