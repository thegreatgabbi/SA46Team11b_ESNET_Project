//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int BookingID { get; set; }
        public System.DateTime IssueDate { get; set; }
        public int MemberID { get; set; }
        public int FacilitiesID { get; set; }
        public System.DateTime BookingDateFrom { get; set; }
        public System.DateTime BookingDateTo { get; set; }
        public int NumberofPax { get; set; }
    
        public virtual Facility Facility { get; set; }
    }
}
