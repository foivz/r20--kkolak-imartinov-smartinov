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
    public partial class frmPrijava : Form
    {
        private korisnik prijavljeniKorisnik;
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var provjera = new ProvjeraPrijave();
            prijavljeniKorisnik = provjera.ProvjeraPodataka(txtKorisnickoIme.Text, txtLozinka.Text);

            txtKorisnickoIme.Clear();
            txtLozinka.Clear();

            if(prijavljeniKorisnik != null)
            {
                if (prijavljeniKorisnik.tip_id == 3)
                {
                    Hide();
                    using (var forma = new frmAdmin(prijavljeniKorisnik))
                    {
                        forma.ShowDialog();
                    }
                    Show();
                }
                else if (prijavljeniKorisnik.tip_id == 2)
                {
                    Hide();
                    using (var forma = new frmSkladistar(prijavljeniKorisnik))
                    {
                        forma.ShowDialog();
                    }
                    Show();
                }
                else if (prijavljeniKorisnik.tip_id == 1)
                {
                    Hide();
                    using (var forma = new frmProdajniReferent(prijavljeniKorisnik))
                    {
                        forma.ShowDialog();
                    }
                    Show();
                }
            }
            else
                MessageBox.Show("Ne postoji korisnik za unesene podatke!");
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrijava.PerformClick();
            }
        }

        private void txtKorisnickoIme_Click(object sender, EventArgs e)
        {
            txtKorisnickoIme.Clear();
        }

        private void txtLozinka_Click(object sender, EventArgs e)
        {
            txtLozinka.Clear();
        }
        private void lblRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            using (var forma = new frmSlanjeEmaila("Prijava"))
            {
                forma.ShowDialog();
            }
            Show();
        }
    }
}
