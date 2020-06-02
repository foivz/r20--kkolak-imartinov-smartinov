using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Klijenti
    {
        public Klijenti()
        {

        }

        public List<klijent> DohvatiKlijente()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from k in context.klijents
                            select k;
                return query.ToList();
            }
        }

        public void ObrisiKlijenta(klijent klijent)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.klijents.Attach(klijent);
                context.klijents.Remove(klijent);
                context.SaveChanges();
            }
        }
    }
}
