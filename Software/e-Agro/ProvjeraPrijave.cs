using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class ProvjeraPrijave
    {
        public korisnik ProvjeraPodataka(string korisnickoIme, string lozinka)
        {
            korisnik prijavaKorisnika;
            using (var context = new PI20_024_DBEntities())
            {
                var query = from kor in context.korisniks
                            where kor.korisnicko_ime == korisnickoIme && kor.lozinka == lozinka
                            select kor;

                if (query.Any())
                    prijavaKorisnika = query.First();
                else
                    prijavaKorisnika = null;
            }
            if (prijavaKorisnika != null)
                return prijavaKorisnika;
            else
                return null;
        }
    }
}
