using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEP.Client.MEPServiceReference;

namespace MEP.Client
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Email Sent!");
        }
    }
}
