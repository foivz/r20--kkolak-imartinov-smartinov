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

    public partial class dobavljac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dobavljac()
        {
            this.katalog_strojeva = new HashSet<katalog_strojeva>();
            this.narudzbas = new HashSet<narudzba>();
        }
    
        public int dobavljac_id { get; set; }

        [DisplayName("Naziv dobavljaca")]
        public string naziv { get; set; }

        [DisplayName("Adresa")]
        public string adresa { get; set; }

        [DisplayName("Tekuci racun")]
        public string tekuci_racun { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<katalog_strojeva> katalog_strojeva { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<narudzba> narudzbas { get; set; }
    }
}
