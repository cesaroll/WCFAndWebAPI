using System.Runtime.Serialization;

namespace ModelLib.Util
{
    [DataContract]
    public class DivFault
    {
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string OperationMessage { get; set; }
         
    }
}