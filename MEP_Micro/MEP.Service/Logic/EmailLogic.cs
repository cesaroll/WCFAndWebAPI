using System;
using System.Net.Mail;
using MEP.Service.Contract;

namespace MEP.Service.Logic
{
    public class EmailLogic
    {
        #region IEmailLogic Implementations

        public virtual ReturnMsg Send(Email email)
        {
            var rm = new ReturnMsg();

            try
            {
                var mailMsg = GetMailMessage(email);

                var smtpClient = GetSmtpClient();

                smtpClient.Send(mailMsg);

                rm.Message = "Email Sent";

            }
            catch (Exception e)
            {
                var errorLogic = new ErrorLogic();

                errorLogic.LogError(e);

                //throw e;

                rm.Success = false;
                rm.Message = "Email not sent!";
                rm.ExceptionMsg = e.Message;
            }

            return rm;

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