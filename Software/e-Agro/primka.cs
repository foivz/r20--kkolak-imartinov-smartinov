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
    using System.ComponentModel;

    public partial class primka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public primka()
        {
            this.stavke_na_primci = new HashSet<stavke_na_primci>();
        }
        [DisplayName("ID primke")]
        public int primka_id { get; set; }
        [DisplayName("ID korisnika")]
        public int korisnik_id { get; set; }
        [DisplayName("Cijena")]
        public int cijena { get; set; }
    
        public virtual korisnik korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavke_na_primci> stavke_na_primci { get; set; }
    }
}
