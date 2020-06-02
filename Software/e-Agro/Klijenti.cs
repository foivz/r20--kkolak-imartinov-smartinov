using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Klijenti
    {
        public Klijenti()
        {

        }

        public List<klijent> DohvatiKlijente()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from k in context.klijents
                            select k;
                return query.ToList();
            }
        }

        public void DodajKlijenta(string ime, string prezime, string email, string adresa, string tekuciRacun)
        {
            using(var context = new PI20_024_DBEntities())
            {
                klijent noviKlijent = new klijent
                {
                    ime = ime,
                    prezime = prezime,
                    email = email,
                    adresa = adresa,
                    tekuci_racun = tekuciRacun
                };
                context.klijents.Add(noviKlijent);
                context.SaveChanges();
            }
        }

        public void ObrisiKlijenta(klijent klijent)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.klijents.Attach(klijent);
                context.klijents.Remove(klijent);
                context.SaveChanges();
            }
        }
    }
}
