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
    
    public partial class Pengguna
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pengguna()
        {
            this.Transaksi = new HashSet<Transaksi>();
        }
    
        public int ID { get; set; }
        public string NamaPengguna { get; set; }
        public string KataSandi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaksi> Transaksi { get; set; }
    }
}
