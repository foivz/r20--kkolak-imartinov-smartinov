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
    public partial class frmPrikazIzvjestajaProdajniRefrent : Form
    {
        private dobavljac odabraniDobavljac;
        public frmPrikazIzvjestajaProdajniRefrent(dobavljac dobavljac)
        {
            odabraniDobavljac = dobavljac;
            InitializeComponent();
        }

        private void frmPrikazIzvjestajaProdajniRefrent_Load(object sender, EventArgs e)
        {
            List<katalog_strojeva> popisStrojeva = new List<katalog_strojeva>();
            using(var context = new PI20_024_DBEntities())
            {
                var query = from k in context.katalog_strojeva
                            where k.dobavljac_id == odabraniDobavljac.dobavljac_id
                            select k;

                popisStrojeva = query.ToList();
            }

            katalog_strojevaBindingSource.DataSource = popisStrojeva;
            dobavljacBindingSource.DataSource = odabraniDobavljac;

            this.rpvDobavljacStrojeva.RefreshReport();
        }
    }
}
