using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Ponude
    {
        public List<ponuda> DohvatiPonude()
        {
            using (var context =new PI20_024_DBEntities())
            {
                var query = from p in context.ponudas.Include("korisnik").Include("klijent")
                            select p;
                return query.ToList();
            }
        }
        public void ObrisiPonudu(ponuda ponuda)
        {
            using(var context = new PI20_024_DBEntities())
            {
                context.ponudas.Attach(ponuda);
                context.ponudas.Remove(ponuda);
                context.SaveChanges();
            }
        }
    }
}
