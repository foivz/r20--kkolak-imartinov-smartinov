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
    public partial class frmSkladistarIzvjestaj : Form
    {
        public frmSkladistarIzvjestaj()
        {
            InitializeComponent();
        }

        private void frmSkladistarIzvjestaj_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
