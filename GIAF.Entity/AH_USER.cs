//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GIAF.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class AH_USER
    {
        public AH_USER()
        {
            this.TRANS = new HashSet<TRANS>();
        }
    
        public string USER_ID { get; set; }
        public string NAME_SURNAME { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<short> FULL_REPORT_PERM { get; set; }
        public short IS_ADMIN { get; set; }
        public short ACTIVE_PASSIVE { get; set; }
        public string GROUP_ID { get; set; }
        public short REPORT_CHK { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }
        public string PHONE { get; set; }
    
        public virtual AH_USER_GROUP AH_USER_GROUP { get; set; }
        public virtual ICollection<TRANS> TRANS { get; set; }
    }
}