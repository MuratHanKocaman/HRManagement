//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PerformanceReview
    {
        public int ReviewID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> ReviewDate { get; set; }
        public Nullable<int> PerformanceRating { get; set; }
        public string Comments { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
