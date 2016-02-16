using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GIAF.DTOs.PageManager
{
    [DataContract]
    public class PageViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime? PublishDate { get; set; }

        [DataMember]
        public DateTime? PublishStartDate { get; set; }

        [DataMember]
        public DateTime? PublishEndDate { get; set; }

        [DataMember]
        public string Module { get; set; }

        [DataMember]
        public string PageType { get; set; }

        [DataMember]
        public string Image { get; set; }

        [DataMember]
        public string Icon { get; set; }

        [DataMember]
        public string Link { get; set; }

        [DataMember]
        public string Detail { get; set; }

        [DataMember]
        public string VideoUrl { get; set; }

        [DataMember]
        public bool? IsShowOnHomePage { get; set; }

        [DataMember]
        public bool? IsShowOnMenuSummary { get; set; }

        [DataMember]
        public bool? IsShowOnSubMenu { get; set; }

        [DataMember]
        public bool? IsShowOnMenu { get; set; }

        [DataMember]
        public bool? IsShowOnFooter { get; set; }

        [DataMember]
        public bool? IsShowOnSidePage { get; set; }

        [DataMember]
        public int Visiting { get; set; }

        [DataMember]
        public string Map { get; set; }

        [DataMember]
        public string GaleryId { get; set; }

        [DataMember]
        public string VideoGaleryId { get; set; }
    }
}
