//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace e_Agro
{
    using System;
    using System.Collections.Generic;
    
    public partial class otpremnica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public otpremnica()
        {
            this.stavke_na_otpremnici = new HashSet<stavke_na_otpremnici>();
        }
    
        public int otpremnica_id { get; set; }
        public int korisnik_id { get; set; }
        public double cijena { get; set; }
        public System.DateTime datum_isporuke { get; set; }
    
        public virtual korisnik korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavke_na_otpremnici> stavke_na_otpremnici { get; set; }
    }
}
