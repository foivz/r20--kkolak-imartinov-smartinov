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

    public partial class stavke_na_otpremnici
    {
        [DisplayName("ID otpremnice")]
        public int otpremnica_id { get; set; }
        [DisplayName("ID stroja")]
        public int stroj_id { get; set; }
        [DisplayName("Količina")]
        public int kolicina { get; set; }
    
        public virtual katalog_strojeva katalog_strojeva { get; set; }
        public virtual otpremnica otpremnica { get; set; }
    }
}
