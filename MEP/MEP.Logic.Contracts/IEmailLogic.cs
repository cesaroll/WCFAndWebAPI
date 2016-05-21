using System.Net.Mail;
using MEP.Models.Contracts;

namespace MEP.Logic.Contracts
{
    public interface IEmailLogic: ILogic
    {
        void Send(IEmail email);
    }
}