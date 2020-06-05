using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class StavkeNaOtpremnici
    {
        public List<StavkeView> DohvatiStavkeZaOtpremnicu(otpremnica odabranaOtpremnica)
        {
            List<StavkeView> listaStavki = new List<StavkeView>();
            using (var context = new PI20_024_DBEntities())
            {
                var query = from s in context.stavke_na_otpremnici
                            where s.otpremnica_id==odabranaOtpremnica.otpremnica_id
                            select s;

                foreach (var stavka in query)
                {
                    StavkeView stv = new StavkeView(stavka.kolicina, stavka.katalog_strojeva.naziv, stavka.katalog_strojeva.vrsta, stavka.katalog_strojeva.model, stavka.katalog_strojeva.cijena);
                    listaStavki.Add(stv);
                }
            }
            return listaStavki;
        }

        public void DodajStrojNaOtpremnicu(katalog_strojeva stroj, int kolicina, otpremnica odabranaOtpremnica)
        {
            using (var context = new PI20_024_DBEntities())
            {
                stavke_na_otpremnici novaStavka = new stavke_na_otpremnici
                {
                    stroj_id = stroj.stroj_id,
                    kolicina = kolicina,
                    otpremnica_id = odabranaOtpremnica.otpremnica_id
                };
                context.stavke_na_otpremnici.Add(novaStavka);
                context.SaveChanges();
            }
        }
    }
}
