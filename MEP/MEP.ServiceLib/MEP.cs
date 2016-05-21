using System;
using System.ServiceModel;
using MEP.Logic.Contracts;
using MEP.Models.Contracts;
using MEP.ServiceLib.Contracts;
using MEP.ServiceLib.Util;

namespace MEP.ServiceLib
{
    public class MEP : IMEP
    {
        #region IMEP Implementations

        void IMEP.SendEmail(Email email)
        {
            this.SendEmail(email);
        }

        #endregion

        public void SendEmail(IEmail email)
        {
            try
            {
                var emailFact = DependencyFactory.Resolve<IEmailLogic>();

                emailFact.Send(email);
            }
            catch (Exception e)
            {
                throw new FaultException(e.Message);
            }
        }

    }
}