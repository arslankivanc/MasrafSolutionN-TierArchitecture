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
    
    public partial class Kullanıcı
    {
        public int personid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<int> YöneticiRol { get; set; }
    
        public virtual Kisi Kisi { get; set; }
    }
}
