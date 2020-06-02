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
        }

        private void frmPopisUreda_Load(object sender, EventArgs e)
        {
            OsvjeziTablicu();

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            uredi.ObrisiUred(DohvatiOdabranog());
            OsvjeziTablicu();
        }
    }
}
