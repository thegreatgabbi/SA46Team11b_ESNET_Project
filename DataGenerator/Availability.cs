//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataGenerator
{
    using System;
    using System.Collections.Generic;
    
    public partial class Availability
    {
        public int FacilityID { get; set; }
        public System.DateTime BookingDateFrom { get; set; }
        public System.DateTime BookingDateTo { get; set; }
    
        public virtual Facility Facility { get; set; }
    }
}
