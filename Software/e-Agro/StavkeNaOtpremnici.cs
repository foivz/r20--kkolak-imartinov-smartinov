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
                            select s;

                foreach (var stavka in query)
                {
                    StavkeView stv = new StavkeView(stavka.kolicina, stavka.katalog_strojeva.naziv, stavka.katalog_strojeva.vrsta, stavka.katalog_strojeva.model, stavka.katalog_strojeva.cijena);
                    listaStavki.Add(stv);
                }
            }
            return listaStavki;
        }
    }
}
