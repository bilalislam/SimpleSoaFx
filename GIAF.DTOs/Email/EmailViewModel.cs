using System.Runtime.Serialization;

namespace GIAF.DTOs.Email
{
    [DataContract]
    public class EmailViewModel
    {
        [DataMember]
        public string USER_ID { get; set; }

        [DataMember]
        public string NAME_SURNAME { get; set; }
    }
}
