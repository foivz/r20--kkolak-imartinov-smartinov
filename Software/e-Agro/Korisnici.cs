using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Korisnici
    {
        public List<korisnik> DohvatiKorisnike()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from kor in context.korisniks.Include("tip_korisnika").Include("radno_mjesto")
                            select kor;
                return query.ToList();
            }
        }

        public void DodajKorisnika(string email, string korisnickoIme, string lozinka, tip_korisnika tipKorisnika, string ime, string prezime, string tekuciRacun, string adresa, radno_mjesto radnoMjesto)
        {
            using(var context = new PI20_024_DBEntities())
            {
                korisnik noviKorisnik = new korisnik
                {
                    email = email,
                    korisnicko_ime = korisnickoIme,
                    lozinka = lozinka,
                    tip_id = tipKorisnika.tip_id,
                    ime = ime,
                    prezime = prezime,
                    tekuci_racun = tekuciRacun,
                    adresa = adresa,
                    radno_mjesto_id = radnoMjesto.radno_mjesto_id
                };
                context.korisniks.Add(noviKorisnik);
                context.SaveChanges();
            }
        }

        public void AzurirajKorisnika(korisnik odabraniKorisnik, string email, string korisnickoIme, string lozinka, tip_korisnika tipKorisnika, string ime, string prezime, string tekuciRacun, string adresa, radno_mjesto radnoMjesto)
        {
            using(var context = new PI20_024_DBEntities())
            {
                context.Entry(odabraniKorisnik).State = EntityState.Modified;

                odabraniKorisnik.email = email;
                odabraniKorisnik.korisnicko_ime = korisnickoIme;
                odabraniKorisnik.lozinka = lozinka;
                odabraniKorisnik.tip_id = tipKorisnika.tip_id;
                odabraniKorisnik.ime = ime;
                odabraniKorisnik.prezime = prezime;
                odabraniKorisnik.adresa = adresa;
                odabraniKorisnik.tekuci_racun = tekuciRacun;
                odabraniKorisnik.radno_mjesto_id = radnoMjesto.radno_mjesto_id;

                context.SaveChanges();
            }
        }

        public void ObrisiKorisnika(korisnik korisnik)
        {
            using(var context = new PI20_024_DBEntities())
            {
                context.korisniks.Attach(korisnik);
                if(korisnik.otpremnicas.Count > 0 || korisnik.ponudas.Count > 0 || korisnik.primkas.Count > 0 || korisnik.ponudas.Count > 0)
                    System.Windows.Forms.MessageBox.Show("Ne možete obrisati korisnika koji ima kreirane dokumente!");
                else
                    context.korisniks.Remove(korisnik);
                context.SaveChanges();
            }
        }
    }
}
