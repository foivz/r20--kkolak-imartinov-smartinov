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
    
    public partial class ured
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ured()
        {
            this.radno_mjesto = new HashSet<radno_mjesto>();
        }
    
        public int ured_id { get; set; }
        public string odjel { get; set; }
        public string zupanija { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<radno_mjesto> radno_mjesto { get; set; }
    }
}