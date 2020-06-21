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
    /// Prikaz svih mogućnosti kojima Prodajni referent može rukovati
    /// </summary>
    public partial class frmProdajniReferent : Form
    {
        private korisnik prijavljeniKorisnik; //Korisnik koji se prijavio u sustav

        /// <summary>
        /// Konstruktor forme koji služi za spremanje prijavljenog korisnika
        /// </summary>
        /// <param name="korisnik">Korisnik predan formi preko forme za prijavu</param>
        public frmProdajniReferent(korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Strojevi te služi za otvaranje forme za popis strojeva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStrojevi_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmKatalogStrojeva())
            {
                forma.ShowDialog();
            }
            Show();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Narudžba te služi za otvaranje forme za popis narudžbi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisNarudzbi())
            {
                forma.ShowDialog();
            }
            Show();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Ponuda te služi za otvaranje forme za popis ponuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPonuda_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisPonuda())
            {
                forma.ShowDialog();
            }
            Show();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Dobavljač te služi za otvaranje forme za popis dobavljača
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDobavljac_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisDobavljaca())
            {
                forma.ShowDialog();
            }
            Show();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Klijent te služi za otvaranje forme za popis klijenata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKlijent_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisKlijenata())
            {
                forma.ShowDialog();
            }
            Show();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Graf uspješnosti te služi za otvaranje forme za prikaz grafa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGraf_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmProdajniReferentGraf(prijavljeniKorisnik))
            {
                forma.ShowDialog();
            }
            Show();
        }

        /// <summary>
        /// Rukuje događajem klika na karticu Odjava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult odjavaDialog = MessageBox.Show("Jeste li sigurni da se želite odjaviti?", "eAgro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (odjavaDialog == DialogResult.Yes)
            {
                foreach (Form fm in Application.OpenForms)
                {
                    if (fm.Name != "frmPrijava")
                    {
                        fm.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Služi za prikaz pomoći pritiskom na tipku F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProdajniReferent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#32-prodajni-referent");
            }
        }

        /// <summary>
        /// Rukuje događajem učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProdajniReferent_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Mora se dodati kako bi radila F1 pomoć
        }
    }
}
