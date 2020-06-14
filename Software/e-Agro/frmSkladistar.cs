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
    public partial class frmSkladistar : Form
    {
        private korisnik prijavljeniKorisnik;
        public frmSkladistar(korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void btnOtpremnica_Click(object sender, EventArgs e)
        {
            var popisOtpremnica = new frmPopisOtpremnica();
            popisOtpremnica.ShowDialog();
        }

        private void btnPrimka_Click(object sender, EventArgs e)
        {
            var popisPrimki = new frmPopisPrimki();
            popisPrimki.ShowDialog();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma =new frmSkladistarIzvjestaj())
            {
                forma.ShowDialog();
            }
            Show();
        }
    }
}
