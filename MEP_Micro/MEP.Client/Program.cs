using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MEP.Client.MEPServiceReference;

namespace MEP.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var item = new Program();

            item.SendEmail();

            while (!item.Finished())
            {
                Thread.Sleep(300);
            }
        }

        private MEPCallback Callback { get; set; }

        public bool Finished()
        {
            return Callback.Received;
        }

        protected virtual void SendEmail()
        {
            Console.WriteLine("Calling Service...");

            Callback = new MEPCallback();
             
            var context = new InstanceContext(Callback);

            var clientSvc = new MEPClient(context);

            var email = new Email()
            {
                From = "cesar@gmail.com",
                To = "cesar@gmail.com",
                Subject = "Hola",
                Body = "Test"
            };

            clientSvc.SendEmail(email);
            
        }
    }

    public class MEPCallback : IMEPCallback
    {
        public bool Received { get; set; }

        public MEPCallback()
        {
            Received = false;
        }

        public void SendEmailCallBack(ReturnMsg msg, Email email)
        {
            Console.WriteLine(msg.Message);
            Received = true;
        }
    }
}
