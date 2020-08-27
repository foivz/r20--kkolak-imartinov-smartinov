using System;
using System.Collections.Generic;
using System.Linq;
using e_Agro;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testovi
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void DohvatiDobavljaca()
        {
            Dobavljaci dobavljaci = new Dobavljaci();
            List<dobavljac> popisDobavljaca = new List<dobavljac>();

            using (var context = new PI20_024_DBEntities())
            {
                popisDobavljaca = dobavljaci.DohvatiDobavljace();
            }

            Assert.IsTrue(popisDobavljaca.Count > 0);
        }

        [TestMethod]
        public void DodajDobavljaca()
        {
            Dobavljaci dobavljaci = new Dobavljaci();
            List<dobavljac> popisDobavljaca = new List<dobavljac>();
            dobavljac zadnjiDobavljac = new dobavljac();

            using (var context = new PI20_024_DBEntities())
            {
                dobavljaci.DodajDobavljaca("TestDobavljac", "Koprivnica19", "HR123424234234214213");
                popisDobavljaca = dobavljaci.DohvatiDobavljace();
                zadnjiDobavljac = popisDobavljaca.Last();
            }
            Assert.IsTrue(zadnjiDobavljac.naziv == "TestDobavljac" && zadnjiDobavljac.adresa == "Koprivnica19" && zadnjiDobavljac.tekuci_racun == "HR123424234234214213");
            }

        [TestMethod]
        public void BrisanjeDobavljaca()
        {
            Dobavljaci dobavljaci = new Dobavljaci();
            List<dobavljac> popisDobavljaca = new List<dobavljac>(); 
            dobavljac zadnjiDobavljac = new dobavljac();
          

            using (var context = new PI20_024_DBEntities())
            {
                dobavljaci.DodajDobavljaca("TestBrisanje", "Koprivnica13", "HR1111111111111111111");
                popisDobavljaca = dobavljaci.DohvatiDobavljace();

                zadnjiDobavljac = popisDobavljaca.Last();
                dobavljaci.ObrisiDobavljaca(zadnjiDobavljac);

                popisDobavljaca = dobavljaci.DohvatiDobavljace();
                var rez = popisDobavljaca.Count(e => (e.naziv == "TestBrisanje" && e.adresa== "Koprivnica13" && e.tekuci_racun == "HR1111111111111111111"));
                Assert.IsTrue(rez == 0);
            }
            

        }
    }
    }


    
    

