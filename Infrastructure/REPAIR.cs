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
    
    public partial class REPAIR
    {
        public int repair_id { get; set; }
        public int wagon_number { get; set; }
        public System.DateTime repair_date { get; set; }
        public int station_id { get; set; }
    
        public virtual WAGON WAGON { get; set; }
        public virtual STATION STATION { get; set; }
    }
}
