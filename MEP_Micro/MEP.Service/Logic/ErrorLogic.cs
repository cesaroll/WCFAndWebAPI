using System;
using System.IO;
using System.Linq;

namespace MEP.Service.Logic
{
    public class ErrorLogic
    {
        #region Public Methods
        public virtual void LogError(Exception e)
        {
            LogError(e.Message);
        }

        public virtual void LogError(string errorMsg)
        {
            LogErrorToFile(errorMsg);

            LogErrorToDb(errorMsg);
        }

        #endregion

        #region Protected Methods
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

        protected virtual void LogErrorToDb(string errorMsg)
        {

            var appName = "WEBSVC";

            using (var dc = new WcfDbDataContext())
            {
                var app = dc.Apps.FirstOrDefault(x => x.Name == appName);

                int appId = 0;
                if (app != null)
                    appId = app.Id;

                if (string.IsNullOrWhiteSpace(errorMsg))
                    errorMsg = "Empty Error Message";

                errorMsg = string.Format("{0}: {1}", appName, errorMsg);

                var error = new Error()
                {
                    App_Id = appId,
                    DateTime = DateTime.Now,
                    Message = errorMsg
                };

                dc.Errors.InsertOnSubmit(error);

                dc.SubmitChanges();

                dc.Dispose();
            }
            

        }

        #endregion
    }
}