using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void DodajUred(string odjel, string adresa, string zupanija)
        {
            using(var context = new PI20_024_DBEntities())
            {
                ured noviUred = new ured
                {
                    odjel = odjel,
                    zupanija = zupanija
                };

                context.ureds.Add(noviUred);

                radno_mjesto novoRadnoMjesto = new radno_mjesto
                {
                    adresa = adresa,
                    ured_id = noviUred.ured_id
                };

                context.radno_mjesto.Add(novoRadnoMjesto);
                context.SaveChanges();
            }
        }

        public void AzurirajUred(ured odabraniUred, string odjel, string adresa, string zupanija)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabraniUred).State = EntityState.Modified;
                odabraniUred.odjel = odjel;
                odabraniUred.zupanija = zupanija;
                var query = from r in context.radno_mjesto
                            where r.ured_id == odabraniUred.ured_id
                            select r;
                radno_mjesto odabranoRadnoMjesto = query.First();
                context.Entry(odabranoRadnoMjesto).State = EntityState.Modified;
                odabranoRadnoMjesto.adresa = adresa;
                context.SaveChanges();
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
