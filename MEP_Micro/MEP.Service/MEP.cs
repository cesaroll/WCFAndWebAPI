using System;
using System.ServiceModel;
using MEP.Service.Contract;
using MEP.Service.Logic;

namespace MEP.Service
{
    public class MEP : IMEP
    {
        public void SendEmail(Email email)
        {
            try
            {
                var emailLogic = new EmailLogic();
                emailLogic.Send(email);
            }
            catch (Exception e)
            {
                throw new FaultException(e.Message);
            }
        }
    }
}