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
    
    public partial class REPORTDESC
    {
        public REPORTDESC()
        {
            this.AH_USERGROUP_PERM = new HashSet<AH_USERGROUP_PERM>();
            this.RECS = new HashSet<RECS>();
            this.USERS = new HashSet<USERS>();
        }
    
        public short RD_REPORTTYPE { get; set; }
        public string RD_PHRNUM { get; set; }
        public string RD_REPEATABLE { get; set; }
        public string RD_REPORT_NAME { get; set; }
        public string RD_DESC { get; set; }
        public byte[] TEMPLATE { get; set; }
    
        public virtual ICollection<AH_USERGROUP_PERM> AH_USERGROUP_PERM { get; set; }
        public virtual ICollection<RECS> RECS { get; set; }
        public virtual ICollection<USERS> USERS { get; set; }
    }
}
