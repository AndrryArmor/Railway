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
    
    public partial class STATIONS_CONNECTIONS
    {
        public int stations_connection_id { get; set; }
        public int distance { get; set; }
        public int first_station_id { get; set; }
        public int second_station_id { get; set; }
    
        public virtual STATION STATION { get; set; }
        public virtual STATION STATION1 { get; set; }
    }
}
