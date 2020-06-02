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
        public frmPopisPrimki()
        {
            primke = new Primke();
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
    }
}
