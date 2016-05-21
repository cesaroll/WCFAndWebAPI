using System.Runtime.Serialization;

namespace MEP.Service.Contract
{
    [DataContract]
    public class Email 
    {
        [DataMember]
        public string From { get; set; }
        [DataMember]
        public string To { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Body { get; set; }
    }
}