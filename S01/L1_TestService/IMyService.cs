using System.ServiceModel;

namespace L1_TestService
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string GetData();
    }
}