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
        EmployeeContract SaveEmployee(EmployeeContract employee);

        [OperationContract]
        void SaveSalaryHistory(EmployeeContract employee);

        [OperationContract]
        string Hola();

    }
}