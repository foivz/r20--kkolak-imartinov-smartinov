using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Strojevi
    {
        public List<katalog_strojeva> DohvatiStrojeve()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from ks in context.katalog_strojeva.Include("dobavljac")
                            select ks;

                return query.ToList();
            }
        }

        public void DodajStroj(string naziv, string vrsta, string model, string opis, double cijena, dobavljac dobavljac)
        {
            using (var context = new PI20_024_DBEntities())
            {
                katalog_strojeva noviStroj = new katalog_strojeva
                {
                    naziv = naziv,
                    vrsta = vrsta,
                    model = model,
                    opis = opis,
                    cijena = cijena,
                    dobavljac_id = dobavljac.dobavljac_id
                };
                context.katalog_strojeva.Add(noviStroj);
                context.SaveChanges();
            }
        }

        public void AzurirajStroj(katalog_strojeva odabraniStroj, string naziv, string vrsta, string model, string opis, double cijena, dobavljac dobavljac)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabraniStroj).State = EntityState.Modified;

                odabraniStroj.naziv = naziv;
                odabraniStroj.vrsta = vrsta;
                odabraniStroj.model = model;
                odabraniStroj.opis = opis;
                odabraniStroj.cijena = cijena;
                odabraniStroj.dobavljac_id = dobavljac.dobavljac_id;

                context.SaveChanges();
            }
        }

        public void ObrisiStroj(katalog_strojeva stroj)
        {
            using (var context=new PI20_024_DBEntities())
            {
                context.katalog_strojeva.Attach(stroj);
                if(stroj.stavke_na_narudzbi.Count > 0 || stroj.stavke_na_otpremnici.Count > 0 || stroj.stavke_na_ponudi.Count > 0 || stroj.stavke_na_primci.Count > 0)
                    System.Windows.Forms.MessageBox.Show("Ne možete obrisati stroj koji se nalazi kao stavka!");
                else if(stroj.stroj_na_skladistu.Count > 0)
                    System.Windows.Forms.MessageBox.Show("Ne možete obrisati stroj koji se nalazi na skladištu!");
                else
                    context.katalog_strojeva.Remove(stroj);
                context.SaveChanges();
            }
        }
    }
}
