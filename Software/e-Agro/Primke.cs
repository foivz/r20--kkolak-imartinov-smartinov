using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Primke
    {
        public List<primka> DohvatiPrimke()
        {
            using(var context=new PI20_024_DBEntities())
            {
                var query = from pr in context.primkas.Include("korisnik")
                            select pr;
                return query.ToList();
            }
        }
        public void ObrisiPrimku(primka primka)
        {
            using(var context=new PI20_024_DBEntities())
            {
                context.primkas.Attach(primka);
                context.primkas.Remove(primka);
                context.SaveChanges();
            }
        }
    }
}
