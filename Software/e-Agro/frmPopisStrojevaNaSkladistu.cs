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
    public partial class frmPopisStrojevaNaSkladistu : Form
    {
        StrojeviNaSkladistu strojeviNaSkladistu;
        public frmPopisStrojevaNaSkladistu()
        {
            strojeviNaSkladistu = new StrojeviNaSkladistu();
            InitializeComponent();
        }

        private stroj_na_skladistu DohvatiOdabrani()
        {
            return dgvStrojeviNaSkladistu.CurrentRow.DataBoundItem as stroj_na_skladistu;
        }
        private void OsvjeziTablicu()
        {
            dgvStrojeviNaSkladistu.DataSource = strojeviNaSkladistu.DohvatiStrojeveNaSkladistu();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma=new frmDodavanjeStrojaNaSkladiste())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void frmPopisStrojevaNaSkladistu_Load(object sender, EventArgs e)
        {
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            strojeviNaSkladistu.ObrisiStrojNaSkladistu(DohvatiOdabrani());
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeStrojaNaSkladiste(DohvatiOdabrani()))
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
                    var query = from s in context.stroj_na_skladistu
                                where s.katalog_strojeva.naziv.Contains(txtSearch.Text) || s.katalog_strojeva.vrsta.Contains(txtSearch.Text)
                                || s.katalog_strojeva.model.Contains(txtSearch.Text) || s.katalog_strojeva.opis.Contains(txtSearch.Text)
                                || s.skladiste.naziv.Contains(txtSearch.Text)
                                select s;

                    dgvStrojeviNaSkladistu.DataSource = query.ToList();
                }
            }
        }
    }
}
