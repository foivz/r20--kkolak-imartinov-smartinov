using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Klijenti
    {
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
            using (var context = new PI20_024_DBEntities())
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

        public void AzurirajKlijenta(klijent odabraniKlijent, string ime, string prezime, string email, string adresa, string tekuciRacun)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabraniKlijent).State = EntityState.Modified;

                odabraniKlijent.ime = ime;
                odabraniKlijent.prezime = prezime;
                odabraniKlijent.email = email;
                odabraniKlijent.adresa = adresa;
                odabraniKlijent.tekuci_racun = tekuciRacun;

                context.SaveChanges();
            }
        }

        public void ObrisiKlijenta(klijent klijent)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.klijents.Attach(klijent);
                if(klijent.ponudas.Count > 0)
                    System.Windows.Forms.MessageBox.Show("Ne možete izbrisati klijenta koji ima ponude!");
                else
                    context.klijents.Remove(klijent);
                context.SaveChanges();
            }
        }
    }
}
