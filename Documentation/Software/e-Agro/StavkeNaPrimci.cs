using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class StavkeNaPrimci
    {
        public List<StavkeView> DohvatiStavkeZaPrimku(primka odabranaPrimka)
        {
            List<StavkeView> listaStavki = new List<StavkeView>();
            using (var context = new PI20_024_DBEntities())
            {
                var query = from s in context.stavke_na_primci
                            where s.primka_id == odabranaPrimka.primka_id
                            select s;

                foreach (var stavka in query)
                {
                    StavkeView stv = new StavkeView(stavka.kolicina, stavka.katalog_strojeva.naziv, stavka.katalog_strojeva.vrsta, stavka.katalog_strojeva.model, stavka.katalog_strojeva.cijena);
                    listaStavki.Add(stv);
                }
            }
            return listaStavki;
        }

        public void DodajStrojNaPrimku(katalog_strojeva stroj, int kolicina, primka odabranaPrimka)
        {
            using (var context = new PI20_024_DBEntities())
            {
                stavke_na_primci novaStavka = new stavke_na_primci
                {
                    stroj_id = stroj.stroj_id,
                    kolicina = kolicina,
                    primka_id = odabranaPrimka.primka_id
                };
                context.stavke_na_primci.Add(novaStavka);
                context.SaveChanges();
            }
        }
    }
}
