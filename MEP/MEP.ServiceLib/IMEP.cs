using System.ServiceModel;
using MEP.ServiceLib.Contracts;

namespace MEP.ServiceLib
{
    [ServiceContract]
    public interface IMEP
    {
        [OperationContract(IsOneWay = true)]
        void SendEmail(Email email);

    }
}