using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Skladista
    {
        public List<skladiste> DohvatiSkladista()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from s in context.skladistes
                            select s;
                return query.ToList();
            }
        }
        public void ObrisiSkladiste(skladiste skladiste)
        {
            using (var context=new PI20_024_DBEntities())
            {
                context.skladistes.Attach(skladiste);
                context.skladistes.Remove(skladiste);
                context.SaveChanges();
            }
        }
    }
}
