using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GIAF.DTOs.PageManager
{
    [DataContract]
    public class LayoutViewModel
    {
        [DataMember]
        public string MetaTitle { get; set; }

        [DataMember]
        public string MetaKeywords { get; set; }

        [DataMember]
        public string MetaDescription { get; set; }

        [DataMember]
        public string Logo { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public ContactViewModel ContactInfo { get; set; }

        [DataMember]
        public NavigationViewModel Navigations { get; set; }

        [DataMember]
        public List<PageViewModel> FooterPageList { get; set; }
    }
}
