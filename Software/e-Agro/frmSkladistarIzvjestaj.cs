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
    }
}
