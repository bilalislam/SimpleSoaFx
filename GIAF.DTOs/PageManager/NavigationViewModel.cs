using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GIAF.DTOs.PageManager
{
    [DataContract]
    public class NavigationViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int? MainId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Link { get; set; }

        [DataMember]
        public bool Selected { get; set; }

        [DataMember]
        public List<NavigationViewModel> NavigationList { get; set; }
    }
}
