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
            dgvStrojeviNaSkladistu.Columns["stroj_id"].Visible = false;
            dgvStrojeviNaSkladistu.Columns["skladiste_id"].Visible = false;
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
            this.KeyPreview = true;
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

        private void frmPopisStrojevaNaSkladistu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#333-dodavanje-strojeva-na-skladi%C5%A1te");
            }
        }
    }
}
