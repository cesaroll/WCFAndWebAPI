using System.ServiceModel;
using MEP.Service.Contract;

namespace MEP.Service
{
    [ServiceContract(CallbackContract = typeof(IMEPCallBack))]
    public interface IMEP
    {
        [OperationContract(IsOneWay = true)]
        void SendEmail(Email email);

    }

    [ServiceContract]
    public interface IMEPCallBack
    {
        // Implementation of this contract must be in the client
        // Call of this method must be in the service

        [OperationContract(IsOneWay = true)]
        void SendEmailCallBack(ReturnMsg returnMsg, Email email); 
    }
}