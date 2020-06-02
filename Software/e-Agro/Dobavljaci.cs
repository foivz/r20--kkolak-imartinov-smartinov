using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void DodajDobavljaca(string naziv, string adresa, string tekuciRacun)
        {
            using (var context =new PI20_024_DBEntities())
            {
                dobavljac noviDobavljac = new dobavljac
                {
                    naziv = naziv,
                    adresa = adresa,
                    tekuci_racun = tekuciRacun
                };
                context.dobavljacs.Add(noviDobavljac);
                context.SaveChanges();
            }
        }

        public void AzurirajDobavljaca(dobavljac odabraniDobavljac,string naziv, string adresa, string tekuciRacun)
        {
            using (var context=new PI20_024_DBEntities())
            {
                context.Entry(odabraniDobavljac).State = EntityState.Modified;

                odabraniDobavljac.naziv = naziv;
                odabraniDobavljac.adresa = adresa;
                odabraniDobavljac.tekuci_racun = tekuciRacun;

                context.SaveChanges();
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
