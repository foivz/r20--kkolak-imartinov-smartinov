using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Primke
    {
        public List<primka> DohvatiPrimke()
        {
            using(var context=new PI20_024_DBEntities())
            {
                var query = from pr in context.primkas.Include("korisnik")
                            select pr;
                return query.ToList();
            }
        }
        public void DodajPrimku(korisnik korisnik, double cijena)
        {
            using(var context=new PI20_024_DBEntities())
            {
                primka novaPrimka = new primka
                {
                    korisnik_id=korisnik.korisnik_id,
                    cijena=cijena
                };
                context.primkas.Add(novaPrimka);
                context.SaveChanges();
            }
        }

        public void AzurirajPrimku(primka odabranaPrimka, korisnik korisnik, int cijena)
        {
            using(var context=new PI20_024_DBEntities())
            {
                context.Entry(odabranaPrimka).State = EntityState.Modified;
                odabranaPrimka.korisnik_id = korisnik.korisnik_id;
                odabranaPrimka.cijena = cijena;
                context.SaveChanges();
            }
        }
        public void ObrisiPrimku(primka primka)
        {
            using(var context=new PI20_024_DBEntities())
            {
                context.primkas.Attach(primka);
                context.primkas.Remove(primka);
                context.SaveChanges();
            }
        }
    }
}
