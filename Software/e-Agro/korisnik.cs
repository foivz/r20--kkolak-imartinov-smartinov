﻿//------------------------------------------------------------------------------
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

    public partial class korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public korisnik()
        {
            this.otpremnicas = new HashSet<otpremnica>();
            this.ponudas = new HashSet<ponuda>();
            this.primkas = new HashSet<primka>();
        }
        [DisplayName("ID korisnika")]
        public int korisnik_id { get; set; }
        [DisplayName("E-mail")]
        public string email { get; set; }
        [DisplayName("Korisničko ime")]
        public string korisnicko_ime { get; set; }
        [DisplayName("Lozinka")]
        public string lozinka { get; set; }
        [DisplayName("ID tipa korisnika")]
        public int tip_id { get; set; }
        [DisplayName("Ime")]
        public string ime { get; set; }
        [DisplayName("Prezime")]
        public string prezime { get; set; }
        [DisplayName("Tekući račun")]
        public string tekuci_racun { get; set; }
        [DisplayName("Adresa")]
        public string adresa { get; set; }
        [DisplayName("ID radnog mjesta")]
        public int radno_mjesto_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<otpremnica> otpremnicas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ponuda> ponudas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<primka> primkas { get; set; }
        [DisplayName("Radno mjesto")]
        public virtual radno_mjesto radno_mjesto { get; set; }
        [DisplayName("Tip korisnika")]
        public virtual tip_korisnika tip_korisnika { get; set; }

    }
}
