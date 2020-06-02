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
    public partial class frmAdmin : Form
    {
        private korisnik prijavljeniKorisnik;
        public frmAdmin(korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisKorisnika())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnZaposlenik_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisZaposlenika())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnUred_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisUreda())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnSkladiste_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisSkladista())
            {
                forma.ShowDialog();
            }
            Show();
        }
    }
}
