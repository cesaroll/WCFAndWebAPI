using System;
using System.Dynamic;
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