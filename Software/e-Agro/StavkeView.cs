using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class StavkeView
    {
        [DisplayName("Količina")]
        public int Kolicina { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public string Model { get; set; }
        public double Cijena { get; set; }

        public StavkeView(int kolicina, string naziv, string vrsta, string model, double cijena)
        {
            Kolicina = kolicina;
            Naziv = naziv;
            Vrsta = vrsta;
            Model = model;
            Cijena = cijena;
        }
    }
}
