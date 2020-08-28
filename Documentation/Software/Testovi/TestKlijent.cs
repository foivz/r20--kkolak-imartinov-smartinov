using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using e_Agro;

namespace Testovi
{
    [TestClass]
    public class TestKlijent
    {
        [TestMethod]
        public void DohvatiKlijenta_PostojeKlijenti()
            {
                Klijenti klijenti = new Klijenti();
                List<klijent> popisKlijenta = new List<klijent>();

                using (var context = new PI20_024_DBEntities())
                {
                popisKlijenta = klijenti.DohvatiKlijente();
                }
                Assert.IsTrue(popisKlijenta.Count > 0);
            }

        [TestMethod]
        public void DodajKlijenta_DodanKlijentTestniKlijent_PostojiKlijent()
        {
            Klijenti klijenti = new Klijenti();
            List<klijent> popisKlijenta = new List<klijent>();
            klijent posljednjiklijent = new klijent();

            using (var context = new PI20_024_DBEntities())
            {
                klijenti.DodajKlijenta("Testni", "Klijent", "TestniKlijent@gmail.com", "Test19", "HR3726183728392837121");
                popisKlijenta = klijenti.DohvatiKlijente();

                posljednjiklijent = popisKlijenta.Last();
            }
            Assert.IsTrue(posljednjiklijent.ime == "Testni" && posljednjiklijent.prezime == "Klijent" && posljednjiklijent.email == "TestniKlijent@gmail.com" && posljednjiklijent.adresa == "Test19" && posljednjiklijent.tekuci_racun == "HR3726183728392837121"); 
        }


        [TestMethod]
        public void BrisanjeKlijenta_BrisanjeKlijentaTestni_ObrisaniKlijent()
        {
            Klijenti klijenti = new Klijenti();
            List<klijent> popisKlijenta = new List<klijent>();
            klijent posljednjiklijent = new klijent();


            using (var context = new PI20_024_DBEntities())
            {
                klijenti.DodajKlijenta("TestniK", "Klijent", "TestniKlijent@gmail.com", "Test19", "HR3726183728392837121");
                popisKlijenta = klijenti.DohvatiKlijente();

                posljednjiklijent = popisKlijenta.Last();
                klijenti.ObrisiKlijenta(posljednjiklijent);

                popisKlijenta = klijenti.DohvatiKlijente();
                var rezultat = popisKlijenta.Count(e => (e.ime == "TestniK" && e.tekuci_racun == "HR3726183728392837121"));
              
                Assert.IsTrue(rezultat == 0);
            }
        }
    }
}
