using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF.Employees.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmp" in both code and config file together.
    [ServiceContract]
    public interface IEmp
    {
        [OperationContract]
        List<Employee> GetEmployees();

        [OperationContract]
        List<SalaryHistory> GetSalaryHistory(int employeeId);

        [OperationContract]
        void SaveEmployee(Employee employee);

    }

}
