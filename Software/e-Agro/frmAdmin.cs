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
    /// Prikaz svih mogućnosti kojima može Admin rukovati
    /// </summary>
    public partial class frmAdmin : Form
    {
        private korisnik prijavljeniKorisnik; //Korisnik koji se prijavio u sustav

        /// <summary>
        /// Konstruktor forme koji služi za spremanje prijavljenog korisnika
        /// </summary>
        /// <param name="korisnik">Korisnik predan formi preko frmPrijava</param>
        public frmAdmin(korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Korisnik te služi za otvaranje forme za popis korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisKorisnika())
            {
                forma.ShowDialog();
            }
            Show();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Ured te služi za otvaranje forme za popis ureda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUred_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisUreda())
            {
                forma.ShowDialog();
            }
            Show();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Skladište te služi za otvaranje forme za popis skladišta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkladiste_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisSkladista())
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

            if(odjavaDialog == DialogResult.Yes)
            {
                foreach (Form fm in Application.OpenForms) //Zatvara sve otvorene forme osim forme za prijavu
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
        private void frmAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#31-admin");
            }
        }

        /// <summary>
        /// Rukuje događajem učitavanja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
