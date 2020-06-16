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
    public partial class frmPopisKorisnika : Form
    {
        Korisnici korisnici;
        public frmPopisKorisnika()
        {
            korisnici = new Korisnici();
            InitializeComponent();  
        }
        private korisnik DohvatiOdabranog()
        {
            return dgvKorisnici.CurrentRow.DataBoundItem as korisnik;
        }
        private void OsvjeziTablicu()
        {
            dgvKorisnici.DataSource = korisnici.DohvatiKorisnike();
            dgvKorisnici.Columns["otpremnicas"].Visible = false;
            dgvKorisnici.Columns["ponudas"].Visible = false;
            dgvKorisnici.Columns["primkas"].Visible = false;
        }

        private void frmPopisKorisnika_Load(object sender, EventArgs e)
        {
            OsvjeziTablicu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeKorisnika())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            korisnici.ObrisiKorisnika(DohvatiOdabranog());
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeKorisnika(DohvatiOdabranog()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }
    }
}
