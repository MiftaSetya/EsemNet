//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace D1_MIFTA_SETYA_PRATAMA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaksi
    {
        public int ID { get; set; }
        public int IDKomputer { get; set; }
        public Nullable<int> IDMember { get; set; }
        public int IDPaket { get; set; }
        public Nullable<int> IDPotonganHarga { get; set; }
        public System.DateTime Tanggal { get; set; }
        public System.TimeSpan Waktu { get; set; }
        public int DibuatOleh { get; set; }
        public int Durasi { get; set; }
    
        public virtual KodePotonganHarga KodePotonganHarga { get; set; }
        public virtual Komputer Komputer { get; set; }
        public virtual Member Member { get; set; }
        public virtual Paket Paket { get; set; }
        public virtual Pengguna Pengguna { get; set; }
    }
}
