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
    
    public partial class Komputer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Komputer()
        {
            this.Transaksi = new HashSet<Transaksi>();
        }
    
        public int ID { get; set; }
        public int Nomor { get; set; }
        public string Merek { get; set; }
        public int IDJenis { get; set; }
    
        public virtual Jenis Jenis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaksi> Transaksi { get; set; }
    }
}
