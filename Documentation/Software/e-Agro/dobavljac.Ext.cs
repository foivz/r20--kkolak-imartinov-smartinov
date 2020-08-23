using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public partial class dobavljac
    {
        /// <summary>
        /// Promjena prikaza podataka za dobavljača kada je vanjski ključ
        /// </summary>
        /// <returns>Vraća naziv dobavljača</returns>
        public override string ToString()
        {
            return naziv;
        }
    }
}
