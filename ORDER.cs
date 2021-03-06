//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoodsOrdering
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER()
        {
            this.TRAINS = new HashSet<TRAIN>();
        }
    
        public int order_id { get; set; }
        public string description { get; set; }
        public int weight { get; set; }
        public int volume { get; set; }
        public bool is_fulfilled { get; set; }
        public int client_id { get; set; }
        public int departure_station_id { get; set; }
        public int arrival_station_id { get; set; }
        public System.DateTime creation_date { get; set; }
        public Nullable<System.DateTime> execution_date { get; set; }
    
        public virtual CLIENT CLIENT { get; set; }
        public virtual STATION STATION { get; set; }
        public virtual STATION STATION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAIN> TRAINS { get; set; }
    }
}
