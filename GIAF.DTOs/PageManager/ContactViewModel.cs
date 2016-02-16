using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GIAF.DTOs.PageManager
{
    [DataContract]
    public class ContactViewModel
    {
        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string MobilePhone { get; set; }

        [DataMember]
        public string Fax { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
