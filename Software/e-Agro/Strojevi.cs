using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Strojevi
    {
        public List<katalog_strojeva> DohvatiStrojeve()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from ks in context.katalog_strojeva.Include("dobavljac")
                            select ks;

                return query.ToList();
            }
        }
        public void ObrisiStroj(katalog_strojeva stroj)
        {
            using (var context=new PI20_024_DBEntities())
            {
                context.katalog_strojeva.Attach(stroj);
                context.katalog_strojeva.Remove(stroj);
                context.SaveChanges();
            }
        }
    }
}
