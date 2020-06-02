using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Narudzbe
    {
        public List<narudzba> DohvatiNarudzbe()  
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from n in context.narudzbas.Include("dobavljac")
                            select n;
                return query.ToList();
            }
        }
        public void ObrisiNarudzbu(narudzba narudzba)
        {
            using(var context=new PI20_024_DBEntities())
            {
                context.narudzbas.Attach(narudzba);
                context.narudzbas.Remove(narudzba);
                context.SaveChanges();
            }
        }
    }
}
