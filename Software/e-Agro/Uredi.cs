using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Uredi
    {
        public List<ured> DohvatiUrede()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from u in context.ureds
                            select u;
                return query.ToList();
            }
        }
        public void ObrisiUred(ured ured)
        {
            using(var context=new PI20_024_DBEntities())
            {
                context.ureds.Attach(ured);
                context.ureds.Remove(ured);
                context.SaveChanges();
            }
        }
    }
}
