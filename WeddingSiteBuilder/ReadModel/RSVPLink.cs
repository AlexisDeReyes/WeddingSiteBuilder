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
    
    public partial class RSVPLink
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RSVPLink()
        {
            CreateDate = DateTime.Now;
            LastUpdated = DateTime.Now;
        }

        public long RSVPLinkID { get; set; }
        public long AttendeeID { get; set; }
        public string RSVPNameBlub { get; set; }
        public System.Guid GuidToken { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool IsAnswered { get; set; }
    }
}
