using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Otpremnice
    {
        public List<otpremnica> DohvatiOtpremnice()
        {
            using(var context =new PI20_024_DBEntities())
            {
                var query = from o in context.otpremnicas.Include("korisnik")
                            select o;
                return query.ToList();
            }
        }

        public void DodajOtpremnicu(korisnik korisnik, double cijena, DateTime datumIsporuke)
        {
            using (var context = new PI20_024_DBEntities())
            {
                otpremnica novaOtpremnica = new otpremnica
                {
                    korisnik_id = korisnik.korisnik_id,
                    cijena = cijena,
                    datum_isporuke = datumIsporuke
                };
                context.otpremnicas.Add(novaOtpremnica);
                context.SaveChanges();
            }
        }

        public void AzurirajNarudzbu(otpremnica odabranaOtpremnica, korisnik korisnik, double cijena, DateTime datumIsporuke)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabranaOtpremnica).State = EntityState.Modified;
                odabranaOtpremnica.korisnik_id = korisnik.korisnik_id;
                odabranaOtpremnica.cijena = cijena;
                odabranaOtpremnica.datum_isporuke = datumIsporuke;
                context.SaveChanges();
            }
        }
        public void ObrisiOtpremnicu(otpremnica otpremnica)
        {
            using(var context =new PI20_024_DBEntities())
            {
                context.otpremnicas.Attach(otpremnica);
                context.otpremnicas.Remove(otpremnica);
                context.SaveChanges();
            }
        }
    }
}
