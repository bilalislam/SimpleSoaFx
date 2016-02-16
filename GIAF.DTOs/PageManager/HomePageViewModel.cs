using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GIAF.DTOs.PageManager
{
    [DataContract]
    public class HomePageViewModel
    {
        [DataMember]
        public PageViewModel SummaryInHomePage { get; set; }
    }
}
