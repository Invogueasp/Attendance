//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendance
    {
        public int AttendanceID { get; set; }
        public string UniqueID { get; set; }
        public int EmpID { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<System.DateTime> LastInTime { get; set; }
        public string WorkingHour { get; set; }
        public System.DateTime WDate { get; set; }
        public string LateStatus { get; set; }
        public string Purpose { get; set; }
        public string OfficeStatus { get; set; }
        public string LateEmailSend { get; set; }
        public string LateNotify { get; set; }
        public string Comments { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
