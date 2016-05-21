using System;
using System.Net.Mail;
using MEP.Service.Contract;

namespace MEP.Service.Logic
{
    public class EmailLogic
    {
        #region IEmailLogic Implementations

        public virtual void Send(Email email)
        {
            try
            {
                var mailMsg = GetMailMessage(email);

                var smtpClient = GetSmtpClient();

                smtpClient.Send(mailMsg);
            }
            catch (Exception e)
            {
                var errorLogic = new ErrorLogic();

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
                Credentials = new System.Net.NetworkCredential("something@gmail.com", "xxxxx")
            };

            return client;

        }


        protected virtual MailMessage GetMailMessage(Email email)
        {
            var mailMsg = new MailMessage()
            {
                From = new MailAddress(email.From),                
                Subject = email.Subject,
                Body = email.Body
            };

            mailMsg.To.Add(email.To);

            return mailMsg;
        }
    }
}