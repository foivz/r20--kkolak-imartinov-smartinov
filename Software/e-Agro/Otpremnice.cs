using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class Otpremnice
    {
        public List<otpremnica> DohvatiOtpremnice()
        {
            using(var context =new PI20_024_DBEntities())
            {
                var query = from o in context.otpremnicas.Include("korisnik")
                            select o;
                return query.ToList();
            }
        }
        public void ObrisiOtpremnicu(otpremnica otpremnica)
        {
            using(var context =new PI20_024_DBEntities())
            {
                context.otpremnicas.Attach(otpremnica);
                context.otpremnicas.Remove(otpremnica);
                context.SaveChanges();
            }
        }
    }
}
