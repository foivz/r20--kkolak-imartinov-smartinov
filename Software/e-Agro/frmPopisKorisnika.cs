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
    /// <summary>
    /// Prikaz popisa korisnika te daljnji rad s korisnicima iz baze
    /// </summary>
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
            dgvKorisnici.Columns["korisnik_id"].Visible = false;
            dgvKorisnici.Columns["tip_id"].Visible = false;
            dgvKorisnici.Columns["radno_mjesto_id"].Visible = false;
        }

        private void frmPopisKorisnika_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
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

        private void frmPopisKorisnika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#313-upravljanje-korisnicima");
            }
        }
    }
}
