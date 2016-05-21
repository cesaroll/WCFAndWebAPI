using System.Runtime.Serialization;

namespace MEP.Service.Contract
{
    [DataContract]
    public class ReturnMsg
    {
        public ReturnMsg()
        {
            Success = true;
            Message = string.Empty;
            ExceptionMsg = string.Empty;
        }

        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string ExceptionMsg { get; set; }
    }
}