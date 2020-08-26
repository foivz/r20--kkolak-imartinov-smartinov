using System;
using System.Collections.Generic;
using System.Linq;
using e_Agro;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testovi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrijavaKorisnika()
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
            Assert.IsTrue(zadnjiDobavljac.naziv == "TestDobavljac");
        }
    }
}
