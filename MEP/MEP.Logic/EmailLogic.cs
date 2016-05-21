using System;
using System.Net.Mail;
using MEP.Logic.Contracts;
using MEP.Logic.Util;
using MEP.Models.Contracts;

namespace MEP.Logic
{
    public class EmailLogic : BaseLogic, IEmailLogic
    {
        #region IEmailLogic Implementations
        
        public virtual void Send(IEmail email)
        {
            try
            {

                var mailMsg = GetMailMessage(email);

                var smtpClient = GetSmtpClient();

                smtpClient.Send(mailMsg);
            }
            catch (Exception e)
            {
                var errorLogic = DependencyFactory.Resolve<IErrorLogic>();

                errorLogic.LogError(e);

                throw e;
            }
        }

        #endregion

        protected virtual SmtpClient GetSmtpClient()
        {
            //TODO: Use DB Metadata instead

            var client = new SmtpClient()
            {
                Port = 587,
                Host = "smtp.gmail.com",
                UseDefaultCredentials = false,
                EnableSsl = true,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential("cesaromar.lopez@gmail.com", "cpt@web@GOG_245")
            };

            return client;

        }


        protected virtual MailMessage GetMailMessage(IEmail email)
        {
            var mailMsg = new MailMessage()
            {
                From = new MailAddress(email.From),
                Subject = email.Subject,
                Body = email.Body
            };

            foreach (var item in email.To)
            {
                mailMsg.To.Add(item);
            }

            return mailMsg;
        }

    }
}