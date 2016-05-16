using System;
using System.Runtime.Serialization;

namespace ModelLib.Util
{
    [DataContract]
    public class ReturnMsg : IReturnMsg
    {
        public ReturnMsg()
        {
            Success = true;
            Message = string.Empty;
            ex = null;
        }

        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public Exception ex { get; set; }
    }
}