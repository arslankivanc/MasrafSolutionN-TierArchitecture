//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Masraf.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Masraflar
    {
        public int masrafid { get; set; }
        public string Baslik { get; set; }
        public decimal Tutar { get; set; }
        public string Acıklama { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string OnayDurumu { get; set; }
        public string MasrafSahibi { get; set; }
        public Nullable<int> YetkiRol { get; set; }
    }
}
