using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Dobavljaci
    {
        public List<dobavljac> DohvatiDobavljace()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from d in context.dobavljacs
                            select d;
                return query.ToList();
            }
        }

        public void ObrisiDobavljaca(dobavljac dobavljac)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.dobavljacs.Attach(dobavljac);
                context.dobavljacs.Remove(dobavljac);
                context.SaveChanges();
            }

        }
    }
}
