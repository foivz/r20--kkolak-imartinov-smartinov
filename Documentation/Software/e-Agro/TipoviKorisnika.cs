using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class TipoviKorisnika
    {
        public List<tip_korisnika> DohvatiTipoveKorisnika()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from tip in context.tip_korisnika.Include("korisniks")
                            select tip;

                return query.ToList();
            }
        }
    }
}
