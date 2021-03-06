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
    
    public partial class RECS
    {
        public string RC_ID { get; set; }
        public string RC_PROT_ID { get; set; }
        public short RC_REPORTTYPE { get; set; }
        public string RC_AUTHOR { get; set; }
        public System.DateTime RC_DATE { get; set; }
        public string RC_PHRNUM { get; set; }
        public short RC_STATE { get; set; }
        public Nullable<short> RC_PRIORITY { get; set; }
        public string RC_PARENT_ID { get; set; }
        public string RC_MEMO { get; set; }
        public short RC_HOSPITAL { get; set; }
        public short RC_DEP { get; set; }
        public Nullable<int> RC_UNIXTIME { get; set; }
        public int RC_TALKFILE { get; set; }
        public string RC_CREATE_USER { get; set; }
        public Nullable<System.DateTime> RC_CREATE_DATE { get; set; }
        public string RC_UPDATE_USER { get; set; }
        public Nullable<System.DateTime> RC_UPDATE_DATE { get; set; }
        public Nullable<int> RC_ACC_ID { get; set; }
    
        public virtual DEPARTMENTS DEPARTMENTS { get; set; }
        public virtual HOSPITALS HOSPITALS { get; set; }
        public virtual PATIENTS PATIENTS { get; set; }
        public virtual REC_STATE REC_STATE { get; set; }
        public virtual USERS USERS { get; set; }
        public virtual REPORTDESC REPORTDESC { get; set; }
        public virtual TRANS TRANS { get; set; }
    }
}
