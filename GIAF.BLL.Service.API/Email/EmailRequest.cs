using System.Runtime.Serialization;
using GIAF.BLL.Service.API.BaseRequestResponse;

namespace GIAF.BLL.Service.API.Email
{
    public class EmailRequest : BaseRequest
    {
        [DataMember]
        public string EmailBody { get; set; }

        [DataMember]
        public string EmailSubject { get; set; }

        [DataMember]
        public string EmailFrom { get; set; }

        [DataMember]
        public string EmailTo { get; set; }

        [DataMember]
        public string EmailBcc { get; set; }

        [DataMember]
        public string EmailCc { get; set; }

        [DataMember]
        public string EmailFromName { get; set; }      
    }
}