using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Narudzbe
    {
        public List<narudzba> DohvatiNarudzbe()  
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from n in context.narudzbas.Include("dobavljac")
                            select n;
                return query.ToList();
            }
        }

        public void DodajNarudzbu(dobavljac dobavljac, double cijena)
        {
            using (var context = new PI20_024_DBEntities())
            {
                narudzba novaNarudzba = new narudzba
                {
                    dobavljac_id = dobavljac.dobavljac_id,
                    cijena = cijena
                };
                context.narudzbas.Add(novaNarudzba);
                context.SaveChanges();
            }
        }

        public void AzurirajNarudzbu(narudzba odabranaNarudzba, dobavljac dobavljac, double cijena)
        {
            using (var context = new PI20_024_DBEntities())
            {
                context.Entry(odabranaNarudzba).State = EntityState.Modified;
                odabranaNarudzba.dobavljac_id = dobavljac.dobavljac_id;
                odabranaNarudzba.cijena = cijena;
                context.SaveChanges();
            }
        }
        public void ObrisiNarudzbu(narudzba narudzba)
        {
            using(var context=new PI20_024_DBEntities())
            {
                context.narudzbas.Attach(narudzba);
                context.narudzbas.Remove(narudzba);
                context.SaveChanges();
            }
        }
    }
}
