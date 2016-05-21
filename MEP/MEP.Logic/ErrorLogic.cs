using System;
using System.IO;
using MEP.Logic.Contracts;

namespace MEP.Logic
{
    public class ErrorLogic: BaseLogic, IErrorLogic
    {
        #region IErrorLogic Implementations

        public virtual void LogError(Exception e)
        {
            LogError(e.Message);
        }

        public virtual void LogError(string errorMsg)
        {
            LogErrorToFile(errorMsg);


        }

       

        #endregion

        protected virtual void LogErrorToFile(string errorMsg)
        {
            String target = @"C:\Temp\Logs";

            if (Directory.Exists(target))
            {
                string fileName = "Error.log";

                string fileTarget = string.Format(@"{0}\{1}", target, fileName);

                string msg = string.Format("DateTime: {0}, Message: {1}", DateTime.Now.ToString("yyyyMMdd HH:mm:ss"), errorMsg);

                using (var fs = new FileStream(fileTarget, FileMode.Append))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(msg);
                    }
                }
            }
        }


    }
}