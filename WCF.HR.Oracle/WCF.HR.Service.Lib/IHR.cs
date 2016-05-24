using System.Collections.Generic;
using System.ServiceModel;
using WCF.HR.Service.Lib.Contracts;

namespace WCF.HR.Service.Lib
{
    [ServiceContract]
    public interface IHR
    {
        [OperationContract]
        List<EmployeeContract> GetEmployees();

        [OperationContract]
        string Hola();

    }
}