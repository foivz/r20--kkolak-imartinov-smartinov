using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class StrojeviNaSkladistu
    {
        public List<stroj_na_skladistu> DohvatiStrojeveNaSkladistu()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from s in context.stroj_na_skladistu.Include("katalog_strojeva").Include("skladiste")
                            select s;
                return query.ToList();
            }
        }

        public void DodajStrojNaSkladiste(katalog_strojeva stroj, skladiste skladiste, int kolicina)
        {
            using (var context=new PI20_024_DBEntities())
            {
                stroj_na_skladistu noviStrojNaSkladistu = new stroj_na_skladistu
                {
                    stroj_id = stroj.stroj_id,
                    skladiste_id = skladiste.skladiste_id,
                    kolicina=kolicina
                };
                context.stroj_na_skladistu.Add(noviStrojNaSkladistu);
                context.SaveChanges();
            }
        }

        public void ObrisiStrojNaSkladistu(stroj_na_skladistu strojNaSkladistu)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.stroj_na_skladistu.Attach(strojNaSkladistu);
                context.stroj_na_skladistu.Remove(strojNaSkladistu);
                context.SaveChanges();
            }
        }

        public void AzurirajStrojNaSKladistu(stroj_na_skladistu odabraniStrojNaSKladistu, katalog_strojeva stroj, skladiste skladiste, int kolicina)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabraniStrojNaSKladistu).State = EntityState.Modified;
                odabraniStrojNaSKladistu.stroj_id = stroj.stroj_id;
                odabraniStrojNaSKladistu.skladiste_id = skladiste.skladiste_id;
                odabraniStrojNaSKladistu.kolicina = kolicina;
                context.SaveChanges();
            }
        }
    }


}
