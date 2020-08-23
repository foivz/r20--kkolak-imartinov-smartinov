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
        /// <summary>
        /// Dohvaćanje svih dobavljača iz baze
        /// </summary>
        /// <returns>Vraća listu u kojoj se nalaze svi dobavljači iz baze podataka</returns>
        public List<dobavljac> DohvatiDobavljace()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from d in context.dobavljacs
                            select d;
                return query.ToList();
            }
        }

        /// <summary>
        /// Kreira novog dobavljača gdje se kao parametar predaju podaci o dobavljaču
        /// </summary>
        /// <param name="naziv">String koji predstavlja naziv dobavljača</param>
        /// <param name="adresa">String koji predstavlja adresu dobavljača</param>
        /// <param name="tekuciRacun">String koji predstavlja tekući račun dobavljača</param>
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

        /// <summary>
        /// Ažuriranje podataka za predanog dobavljača
        /// </summary>
        /// <param name="odabraniDobavljac">Dobavljač za kojeg se ažuriraju podaci</param>
        /// <param name="naziv">String koji predstavlja naziv dobavljača</param>
        /// <param name="adresa">String koji predstavlja adresu dobavljača</param>
        /// <param name="tekuciRacun">String koji predstavlja tekući račun dobavljača</param>
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

        /// <summary>
        /// Brisanje dobavljača predanog u parametru
        /// </summary>
        /// <param name="dobavljac">Odabrani dobavljač koji se briše iz baze podataka</param>
        public void ObrisiDobavljaca(dobavljac dobavljac)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.dobavljacs.Attach(dobavljac);
                if(dobavljac.katalog_strojeva.Count > 0)
                    System.Windows.Forms.MessageBox.Show("Ne možete obrisati dobavljača koji dobavlja strojeve!");
                else if(dobavljac.narudzbas.Count > 0)
                    System.Windows.Forms.MessageBox.Show("Ne možete obrisati dobavljača koji ima narudžbe!");
                else
                    context.dobavljacs.Remove(dobavljac);
                context.SaveChanges();
            }

        }
    }
}
