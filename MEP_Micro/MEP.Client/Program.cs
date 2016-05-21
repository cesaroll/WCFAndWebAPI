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

        }

        protected virtual void SendEmail()
        {
            Console.WriteLine("Calling Service...");

            var clientSvc = new MEPClient();

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

  
}
