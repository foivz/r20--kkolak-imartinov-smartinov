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
        Klijenti klijenti; // Referenca na klasu Klijenti koja upravlja klijentima iz baze podataka

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public frmPopisKlijenata()
        {
            klijenti = new Klijenti();
            InitializeComponent();
        }

        /// <summary>
        /// Dohvaćanje odabranog klijenta iz tablice
        /// </summary>
        /// <returns>Vraća objekta klijent koji je instanca iz baze podataka</returns>
        private klijent DohvatiOdabranog()
        {
            return dgvKlijenti.CurrentRow.DataBoundItem as klijent;
        }

        /// <summary>
        /// Prikaz popisa klijenata u DataGridView
        /// </summary>
        private void OsvjeziTablicu()
        {
            dgvKlijenti.DataSource = klijenti.DohvatiKlijente();
            dgvKlijenti.Columns["ponudas"].Visible = false;
            dgvKlijenti.Columns["klijent_id"].Visible = false;
        }

        /// <summary>
        /// Rukuje događajem učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopisKlijenata_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Mora se dodati kako bi radila F1 pomoć
            OsvjeziTablicu();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Obriši
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            klijenti.ObrisiKlijenta(DohvatiOdabranog());
            OsvjeziTablicu(); 
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Dodaj te otvara formu za dodavanje klijenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Rukuje događajem klika na gumb Ažuriraj te otvara formu za dodavanje klijenta gdje predaje kao parametar formi odabranog klijenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Služi za prikaz pomoći pritiskom na tipku F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopisKlijenata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#324-upravljanje-klijentima");
            }
        }
    }
}
