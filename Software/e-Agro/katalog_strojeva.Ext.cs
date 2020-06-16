using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public partial class katalog_strojeva
    {
        public override string ToString()
        {
            return vrsta + " " + naziv + " " + model + " " +  cijena + "kn";
        }
    }
}
