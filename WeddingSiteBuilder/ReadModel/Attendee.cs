//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeddingSiteBuilder.ReadModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendee
    {
        public long AttendeeID { get; set; }
        public long PersonID { get; set; }
        public long WeddingID { get; set; }
        public string WeddingRole { get; set; }
        public string Relationship { get; set; }
        public string Side { get; set; }
        public string Attending { get; set; }
        public int numberofRSVPs { get; set; }
        public string PartyMemberBlub { get; set; }
        public Nullable<bool> RSVPStatus { get; set; }
        public Nullable<System.Guid> GuidToken { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    }
}
