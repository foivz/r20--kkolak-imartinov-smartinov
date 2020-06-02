using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public partial class korisnik
    {
        public override string ToString()
        {
            return tip_korisnika.naziv + " -> " + ime + " " + prezime;
        }
    }
}
