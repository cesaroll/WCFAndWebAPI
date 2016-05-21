using System.ServiceModel;
using MEP.Service.Contract;

namespace MEP.Service
{
    [ServiceContract]
    public interface IMEP
    {
        [OperationContract(IsOneWay = true)]
        void SendEmail(Email email);

    }
}