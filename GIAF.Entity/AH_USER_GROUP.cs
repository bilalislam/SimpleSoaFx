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
    
    public partial class AH_USER_GROUP
    {
        public AH_USER_GROUP()
        {
            this.AH_USER = new HashSet<AH_USER>();
            this.AH_USERGROUP_PERM = new HashSet<AH_USERGROUP_PERM>();
        }
    
        public string GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string CREATE_USER { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
    
        public virtual ICollection<AH_USER> AH_USER { get; set; }
        public virtual ICollection<AH_USERGROUP_PERM> AH_USERGROUP_PERM { get; set; }
    }
}
