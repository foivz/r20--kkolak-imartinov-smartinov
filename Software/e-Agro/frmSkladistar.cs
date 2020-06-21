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
    /// Prikaz svih mogućnosti kojima Skladištar može rukovati
    /// </summary>
    public partial class frmSkladistar : Form
    {
        private korisnik prijavljeniKorisnik; //Korisnik koji se prijavio u sustav

        /// <summary>
        /// Konstruktor forme koji služi za spremanje prijavljenog korisnika
        /// </summary>
        /// <param name="korisnik">Korisnik predan formi preko forme za prijavu</param>
        public frmSkladistar(korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Otoremnica te služi za otvaranje forme za popis otpremnica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOtpremnica_Click(object sender, EventArgs e)
        {
            var popisOtpremnica = new frmPopisOtpremnica();
            popisOtpremnica.ShowDialog();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Primka te služi za otvaranje forme za popis primki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrimka_Click(object sender, EventArgs e)
        {
            var popisPrimki = new frmPopisPrimki();
            popisPrimki.ShowDialog();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Izvještaj stanja na skladištu te prikazuje formu za odabir prikaza izvještaja za skladište
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmSkladistarIzvjestaj())
            {
                forma.ShowDialog();
            }
            Show();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Strojevi na skladištu te služi za otvaranje forme za popis strojeva na skladištu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStrojeviNaSkladistu_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisStrojevaNaSkladistu())
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
        private void frmSkladistar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#33-skladi%C5%A1tar");
            }
        }

        /// <summary>
        /// Rukuje događajem učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSkladistar_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Mora se dodati kako bi radila F1 pomoć
        }
    }
}
