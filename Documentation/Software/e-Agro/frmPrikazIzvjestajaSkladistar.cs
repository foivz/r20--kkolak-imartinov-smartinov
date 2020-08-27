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
    public partial class frmPrikazIzvjestajaSkladistar : Form
    {
        private skladiste odabranoSkladiste;
        public frmPrikazIzvjestajaSkladistar(skladiste skladiste)
        {
            odabranoSkladiste = skladiste;
            InitializeComponent();
        }

        private void frmSkladistarIzvjestaj_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            List<katalog_strojeva> popisStrojeva = new List<katalog_strojeva>();
            using (var context = new PI20_024_DBEntities())
            {
                var query = from s in context.stroj_na_skladistu
                            where s.skladiste_id == odabranoSkladiste.skladiste_id
                            select s.katalog_strojeva;

                popisStrojeva = query.ToList();
            }
            skladisteBindingSource.DataSource = odabranoSkladiste;
            katalog_strojevaBindingSource.DataSource = popisStrojeva;
           this.rpvSkladisteStrojevi.RefreshReport();
        }

        private void frmPrikazIzvjestajaSkladistar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r20--kkolak-imartinov-smartinov/wiki/Korisni%C4%8Dka-dokumentacija#334-izvje%C5%A1taj-stanja-na-skladi%C5%A1tu");
            }
        }
    }
}