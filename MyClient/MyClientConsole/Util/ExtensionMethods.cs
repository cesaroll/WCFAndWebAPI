using MyClientConsole.MySrvRefOnIIS;
using System;

namespace MyClientConsole.Util
{
    public static class ExtensionMethods
    {
        public static void PrintReturnMsg(this ReturnMsg retMsg)
        {  

            if (retMsg.Success)
            {
                Console.WriteLine("Success!");
                Console.WriteLine(retMsg.Message);
            }
            else
            {
                Console.WriteLine("Error:");
                Console.WriteLine(retMsg.Message + "\n" + retMsg.ExceptionMsg);
            }
            
        }
    }
}