using System.Runtime.Serialization;
using MEP.Models.Contracts;

namespace MEP.ServiceLib.Contracts
{
    [DataContract]
    public class Email : IEmail
    {
        [DataMember]
        public string From { get; set; }
        [DataMember]
        public string[] To { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Body { get; set; }
    }
}