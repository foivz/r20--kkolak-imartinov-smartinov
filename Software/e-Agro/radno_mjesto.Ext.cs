using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public partial class radno_mjesto
    {
        public override string ToString()
        {
            using(var context = new PI20_024_DBEntities())
            {
                context.radno_mjesto.Attach(this);
                if (this.ured != null)
                    return this.ured.odjel;
                else
                    return this.skladiste.naziv;
            }
            
        }
    }
}
