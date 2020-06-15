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
    public partial class frmProdajniReferent : Form
    {
        private korisnik prijavljeniKorisnik;
        public frmProdajniReferent(korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void btnStrojevi_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmKatalogStrojeva())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisNarudzbi())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnPonuda_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisPonuda())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnDobavljac_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisDobavljaca())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnKlijent_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisKlijenata())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnGraf_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmProdajniReferentGraf(prijavljeniKorisnik))
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name != "frmPrijava")
                {
                    fm.Close();
                }
            }
        }
    }
}
