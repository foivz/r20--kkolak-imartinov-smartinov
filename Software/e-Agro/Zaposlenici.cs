using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Zaposlenici
    {
        public List<korisnik> DohvatiZaposlenike()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from k in context.korisniks.Include("tip_korisnika").Include("radno_mjesto")
                            select k;
                return query.ToList();
            }
        }
        public void ObrisiZaposlenika(korisnik zaposlenik)
        {
            using (var context=new PI20_024_DBEntities())
            {
                context.korisniks.Attach(zaposlenik);
                context.korisniks.Remove(zaposlenik);
                context.SaveChanges();
            }
        }
    }
}
