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
    public partial class frmPopisPrimki : Form
    {
        Primke primke;
        StavkeNaPrimci stavkeNaPrimci;
        public frmPopisPrimki()
        {
            primke = new Primke();
            stavkeNaPrimci = new StavkeNaPrimci();
            InitializeComponent();
        }
        private primka DohvatiOdabranu()
        {
            return dgvPrimke.CurrentRow.DataBoundItem as primka;
        }
        private void OsvjeziTablicu()
        {
            dgvPrimke.DataSource = primke.DohvatiPrimke();
            dgvPrimke.Columns["stavke_na_primci"].Visible = false;
            dgvPrimke.Columns["primka_id"].Visible = false;
            dgvPrimke.Columns["korisnik_id"].Visible = false;
        }
        private void frmPopisPrimki_Load(object sender, EventArgs e)
        {
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            primke.ObrisiPrimku(DohvatiOdabranu());
            OsvjeziTablicu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjePrimke())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjePrimke(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnDodajStroj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeStrojaNaPrimku(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void dgvPrimke_SelectionChanged(object sender, EventArgs e)
        {
            dgvStavkeNaPrimci.DataSource = stavkeNaPrimci.DohvatiStavkeZaPrimku(DohvatiOdabranu());
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma= new frmPrimkaIzvjestaj(DohvatiOdabranu()))
            {
                forma.ShowDialog();
            }
            Show();
        }
    }
}
