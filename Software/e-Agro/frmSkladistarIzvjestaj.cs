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
    public partial class frmSkladistarIzvjestaj : Form
    {
        Skladista skladista;
        public frmSkladistarIzvjestaj()
        {
            skladista = new Skladista();
            InitializeComponent();
        }

        private skladiste DohvatiOdabrano()
        {
            return cmbSkladiste.SelectedItem as skladiste;
        }
        private void frmSkladistarIzvjestaj_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            cmbSkladiste.DataSource = skladista.DohvatiSkladista();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma= new frmPrikazIzvjestajaSkladistar(DohvatiOdabrano()))
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void frmSkladistarIzvjestaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#334-izvje%C5%A1taj-stanja-na-skladi%C5%A1tu");
            }
        }
    }
}
