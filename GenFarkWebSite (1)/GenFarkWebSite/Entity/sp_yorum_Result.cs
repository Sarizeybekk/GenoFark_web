//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenFarkWebSite.Entity
{
    using System;
    
    public partial class sp_yorum_Result
    {
        public int Yorum_id { get; set; }
        public string Yorum_ad { get; set; }
        public string Yorum_soyad { get; set; }
        public string Yorum_mail { get; set; }
        public System.DateTime Yorum_tarih { get; set; }
        public bool Yorum_onay { get; set; }
        public string Yorum_icerik { get; set; }
        public int KHastalik_id { get; set; }
    }
}
