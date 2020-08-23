using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Ponude
    {
        public List<ponuda> DohvatiPonude()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from p in context.ponudas.Include("korisnik").Include("klijent")
                            select p;
                return query.ToList();
            }
        }

        public void DodajPonudu(korisnik korisnik, string naziv, double cijena, DateTime datumKreiranja, klijent klijent)
        {
            using (var context = new PI20_024_DBEntities())
            {
                ponuda novaPonuda = new ponuda
                {
                    korisnik_id = korisnik.korisnik_id,
                    naziv = naziv,
                    cijena = cijena,
                    datum_kreiranja = datumKreiranja,
                    klijent_id = klijent.klijent_id
                };
                context.ponudas.Add(novaPonuda);
                context.SaveChanges();
            }
        }

        public void AzurirajPonudu(ponuda odabranaPonuda, korisnik korisnik, string naziv, double cijena, DateTime datumKreiranja, klijent klijent)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabranaPonuda).State = EntityState.Modified;
                odabranaPonuda.korisnik_id = korisnik.korisnik_id;
                odabranaPonuda.naziv = naziv;
                odabranaPonuda.cijena = cijena;
                odabranaPonuda.datum_kreiranja = datumKreiranja;
                odabranaPonuda.klijent_id = klijent.klijent_id;
                context.SaveChanges();
            }
        }
        public void ObrisiPonudu(ponuda ponuda)
        {
            using(var context = new PI20_024_DBEntities())
            {
                context.ponudas.Attach(ponuda);
                var query = from s in ponuda.stavke_na_ponudi
                            where s.ponuda_id == ponuda.ponuda_id
                            select s;

                List<stavke_na_ponudi> popisStavki = query.ToList();
                foreach (var stavka in popisStavki)
                {
                    context.stavke_na_ponudi.Attach(stavka);
                    context.stavke_na_ponudi.Remove(stavka);
                }
                context.ponudas.Remove(ponuda);
                context.SaveChanges();
            }
        }
    }
}
