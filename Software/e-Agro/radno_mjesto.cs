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

    public partial class radno_mjesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public radno_mjesto()
        {
            this.korisniks = new HashSet<korisnik>();
        }
        [DisplayName("ID radnog mjesta")]
        public int radno_mjesto_id { get; set; }
        [DisplayName("Adresa")]
        public string adresa { get; set; }
        [DisplayName("ID ureda")]
        public Nullable<int> ured_id { get; set; }
        [DisplayName("ID skladišta")]
        public Nullable<int> skladiste_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<korisnik> korisniks { get; set; }

        [DisplayName("Skladište")]
        public virtual skladiste skladiste { get; set; }

        [DisplayName("Ured")]
        public virtual ured ured { get; set; }
    }
}
