using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using e_Agro;
using System.Collections.Generic;

namespace Testovi
{
    [TestClass]
    public class TestNarudzbe
    {
        [TestMethod]
        public void DohvacanjeNarudzbe_PostojeNarudzbe()
        {
            Narudzbe narudzbe = new Narudzbe();
            List<narudzba> popisNarudzba = new List<narudzba>();

            using (var context = new PI20_024_DBEntities())
            {
                popisNarudzba = narudzbe.DohvatiNarudzbe();
            }
            Assert.IsTrue(popisNarudzba.Count > 0);
        }
        /*
        [TestMethod]
        public void DodajNarudzbu_DodanaNarudzbaTestnaNarudzba_PostojiNarudzba()
        {
            Narudzbe narudzbe = new Narudzbe();
            List<narudzba> popisNarudzba = new List<narudzba>();
            narudzba zadnjaNarudzba = new narudzba();

            Dobavljaci dobavljaci = new Dobavljaci();
            List<dobavljac> popisDobavljaca = new List<dobavljac>();
            dobavljac zadnjiDobavljac = new dobavljac();

            using (var context = new PI20_024_DBEntities())
            {
                popisDobavljaca = dobavljaci.DohvatiDobavljace();
                zadnjiDobavljac = popisDobavljaca.Last();

                narudzbe.DodajNarudzbu(zadnjiDobavljac, 100);
                popisNarudzba = narudzbe.DohvatiNarudzbe();
                zadnjaNarudzba = popisNarudzba.Last();

            }
            Assert.IsTrue(zadnjaNarudzba.cijena == 100);
        }*/
    }
}
