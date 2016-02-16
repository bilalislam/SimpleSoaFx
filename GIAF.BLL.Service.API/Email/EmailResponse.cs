using System.Runtime.Serialization;
using GIAF.BLL.Service.API.BaseRequestResponse;

namespace GIAF.BLL.Service.API.Email
{
    public class EmailResponse : BaseResponse
    {
        [DataMember]
        public string MessageId { get; set; }

        [DataMember]
        public int EmailId { get; set; }
    }
}