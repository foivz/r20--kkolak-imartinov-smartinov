using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class StavkeNaPonudi
    {
        public List<StavkeView> DohvatiStavkeZaPonudu(ponuda odabranaPonuda)
        {
            List<StavkeView> listaStavki = new List<StavkeView>();
            using (var context = new PI20_024_DBEntities())
            {
                var query = from s in context.stavke_na_ponudi
                            where s.ponuda_id == odabranaPonuda.ponuda_id
                            select s;

                foreach (var stavka in query)
                {
                    StavkeView stv = new StavkeView(stavka.kolicina, stavka.katalog_strojeva.naziv, stavka.katalog_strojeva.vrsta, stavka.katalog_strojeva.model, stavka.katalog_strojeva.cijena);
                    listaStavki.Add(stv);
                }
            }
            return listaStavki;
        }

        public void DodajStrojNaPonudu(katalog_strojeva stroj, int kolicina, ponuda odabranaPonuda)
        {
            using (var context = new PI20_024_DBEntities())
            {
                stavke_na_ponudi novaStavka = new stavke_na_ponudi
                {
                    stroj_id = stroj.stroj_id,
                    kolicina = kolicina,
                    ponuda_id = odabranaPonuda.ponuda_id
                };
                context.stavke_na_ponudi.Add(novaStavka);
                context.SaveChanges();
            }
        }
    }
}
