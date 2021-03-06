//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class WAGON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WAGON()
        {
            this.REPAIRS = new HashSet<REPAIR>();
            this.TRAINS_WAGONS = new HashSet<TRAINS_WAGONS>();
        }
    
        public int wagon_number { get; set; }
        public int weight { get; set; }
        public Nullable<int> volume { get; set; }
        public int max_load { get; set; }
        public bool is_locomotive { get; set; }
        public int station_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPAIR> REPAIRS { get; set; }
        public virtual STATION STATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAINS_WAGONS> TRAINS_WAGONS { get; set; }
    }
}
