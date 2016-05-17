using System;

namespace ModelLib.Util
{
    public interface IReturnMsg
    {
        bool Success { get; set; }
        
        string Message { get; set; }

        string ExceptionMsg { get; set; } 
    }
}