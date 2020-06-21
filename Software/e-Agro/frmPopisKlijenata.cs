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
    /// <summary>
    /// Prikaz popisa klijenata te daljnji rad s klijentima iz baze
    /// </summary>
    public partial class frmPopisKlijenata : Form
    {
        Klijenti klijenti; //
        public frmPopisKlijenata()
        {
            klijenti = new Klijenti();
            InitializeComponent();
        }
        private klijent DohvatiOdabranog()
        {
            return dgvKlijenti.CurrentRow.DataBoundItem as klijent;
        }

        private void OsvjeziTablicu()
        {
            dgvKlijenti.DataSource = klijenti.DohvatiKlijente();
            dgvKlijenti.Columns["ponudas"].Visible = false;
            dgvKlijenti.Columns["klijent_id"].Visible = false;
        }

        private void frmPopisKlijenata_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            OsvjeziTablicu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            klijenti.ObrisiKlijenta(DohvatiOdabranog());
            OsvjeziTablicu(); 
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeKlijenta())
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmDodavanjeKlijenta(DohvatiOdabranog()))
            {
                forma.ShowDialog();
            }
            Show();
            OsvjeziTablicu();
        }

        private void frmPopisKlijenata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#324-upravljanje-klijentima");
            }
        }
    }
}
