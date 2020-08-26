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
        public void DodajPrimku(korisnik korisnik, double cijena, DateTime datum, string mjesto, double tecaj)
        {
            using(var context=new PI20_024_DBEntities())
            {
                primka novaPrimka = new primka
                {
                    korisnik_id=korisnik.korisnik_id,
                    cijena=cijena,
                    datum=datum,
                    mjesto=mjesto,
                    tecaj=tecaj

                };
                context.primkas.Add(novaPrimka);
                context.SaveChanges();
            }
        }

        public void AzurirajPrimku(primka odabranaPrimka, korisnik korisnik, double cijena, DateTime datum, string mjesto, double tecaj)
        {
            using(var context=new PI20_024_DBEntities())
            {
                context.Entry(odabranaPrimka).State = EntityState.Modified;
                odabranaPrimka.korisnik_id = korisnik.korisnik_id;
                odabranaPrimka.cijena = cijena;
                odabranaPrimka.datum = datum;
                odabranaPrimka.mjesto = mjesto;
                odabranaPrimka.tecaj = tecaj;

                context.SaveChanges();
            }
        }
        public void ObrisiPrimku(primka primka)
        {
            using(var context=new PI20_024_DBEntities())
            {
                context.primkas.Attach(primka);
                var query = from s in primka.stavke_na_primci
                            where s.primka_id == primka.primka_id
                            select s;

                List<stavke_na_primci> popisStavki = query.ToList();
                foreach (var stavka in popisStavki)
                {
                    context.stavke_na_primci.Attach(stavka);
                    context.stavke_na_primci.Remove(stavka);
                }

                context.primkas.Remove(primka);
                
                context.SaveChanges();
            }
        }
    }
}
