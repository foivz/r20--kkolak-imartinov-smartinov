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
    public partial class frmAdmin : Form
    {
        private korisnik prijavljeniKorisnik;
        public frmAdmin(korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisKorisnika())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnUred_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisUreda())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void btnSkladiste_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new frmPopisSkladista())
            {
                forma.ShowDialog();
            }
            Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult odjavaDialog = MessageBox.Show("Jeste li sigurni da se želite odjaviti?", "eAgro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(odjavaDialog == DialogResult.Yes)
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

        private void frmAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#2-prijava-u-sustav");
            }
        }
    }
}
