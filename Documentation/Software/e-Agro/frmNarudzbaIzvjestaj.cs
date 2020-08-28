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
    public partial class frmNarudzbaIzvjestaj : Form
    {
        public frmNarudzbaIzvjestaj()
        {
            InitializeComponent();
        }

        private void frmNarudzbaIzvjestaj_Load(object sender, EventArgs e)
        {
            List<stavke_na_primci> popisStavki = new List<stavke_na_primci>();
            this.reportViewer1.RefreshReport();
           
        }
    }
}
