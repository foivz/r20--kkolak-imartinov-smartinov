﻿using System;
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
    public partial class frmSkladistar : Form
    {
        private korisnik prijavljeniKorisnik;
        public frmSkladistar(korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void btnOtpremnica_Click(object sender, EventArgs e)
        {
            var popisOtpremnica = new frmPopisOtpremnica();
            popisOtpremnica.ShowDialog();
        }

        private void btnPrimka_Click(object sender, EventArgs e)
        {
            var popisPrimki = new frmPopisPrimki();
            popisPrimki.ShowDialog();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma =new frmSkladistarIzvjestaj())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnStojeviNaSkladistu_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma= new frmPopisStrojevaNaSkladistu())
            {
                forma.ShowDialog();
            }
            Show();
        }

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
    }
}
