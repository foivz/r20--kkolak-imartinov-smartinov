using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void DodajSkladiste(string naziv, string adresa)
        {
            using (var context = new PI20_024_DBEntities())
            {
                skladiste novoSkladiste = new skladiste
                {
                    naziv = naziv
                };

                context.skladistes.Add(novoSkladiste);

                radno_mjesto novoRadnoMjesto = new radno_mjesto
                {
                    adresa = adresa,
                    skladiste_id = novoSkladiste.skladiste_id
                };

                context.radno_mjesto.Add(novoRadnoMjesto);
                context.SaveChanges();
            }
        }

        public void AzurirajSkladiste(skladiste odabranoSkladiste, string naziv, string adresa)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabranoSkladiste).State = EntityState.Modified;
                odabranoSkladiste.naziv = naziv;
                var query = from r in context.radno_mjesto
                            where r.skladiste_id == odabranoSkladiste.skladiste_id
                            select r;
                radno_mjesto odabranoRadnoMjesto = query.First();
                context.Entry(odabranoRadnoMjesto).State = EntityState.Modified;
                odabranoRadnoMjesto.adresa = adresa;
                context.SaveChanges();
            }
        }
        public void ObrisiSkladiste(skladiste skladiste)
        {
            using (var context=new PI20_024_DBEntities())
            {
                context.skladistes.Attach(skladiste);
                if(skladiste.radno_mjesto.Count > 0)
                    System.Windows.Forms.MessageBox.Show("Ne možete obrisati skladište koje ima radna mjesta!");
                else
                    context.skladistes.Remove(skladiste);
                context.SaveChanges();
            }
        }
    }
}
