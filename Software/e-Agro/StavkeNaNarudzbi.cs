using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class StavkeNaNarudzbi
    {
        public List<StavkeView> DohvatiStavkeZaNarudzbu(narudzba odabranaNarudzba)
        {
            List<StavkeView> listaStavki = new List<StavkeView>();
            using (var context = new PI20_024_DBEntities())
            {
                var query = from s in context.stavke_na_narudzbi
                            where s.narudzba_id == odabranaNarudzba.narudzba_id
                            select s;

                foreach (var stavka in query)
                {
                    StavkeView stv = new StavkeView(stavka.kolicina, stavka.katalog_strojeva.naziv, stavka.katalog_strojeva.vrsta, stavka.katalog_strojeva.model, stavka.katalog_strojeva.cijena);
                    listaStavki.Add(stv);
                }
            }
            return listaStavki;
        }

        public void DodajStrojNaNarudzbu(katalog_strojeva stroj, int kolicina, narudzba odabranaNarudzba)
        {
            using (var context = new PI20_024_DBEntities())
            {
                stavke_na_narudzbi novaStavka = new stavke_na_narudzbi
                {
                    stroj_id = stroj.stroj_id,
                    kolicina = kolicina,
                    narudzba_id = odabranaNarudzba.narudzba_id
                };
                context.stavke_na_narudzbi.Add(novaStavka);
                context.SaveChanges();
            }
        }
    }
}
