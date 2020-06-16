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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using(var forma = new frmDodavanjeUreda())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeUreda(DohvatiOdabranog()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                OsvjeziTablicu();
            else
            {
                using(var context = new PI20_024_DBEntities())
                {
                    var query = from u in context.ureds
                                where u.odjel.Contains(txtSearch.Text) || u.zupanija.Contains(txtSearch.Text)
                                select u;

                    dgvUredi.DataSource = query.ToList();
                }
            }
        }
    }
}
