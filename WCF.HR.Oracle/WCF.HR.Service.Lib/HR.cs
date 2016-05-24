using System.Collections.Generic;
using System.Linq;
using WCF.HR.DAL;
using WCF.HR.Service.Lib.Contracts;
using WCF.HR.Service.Lib.Logic;


namespace WCF.HR.Service.Lib
{
    public class HR : IHR
    {
        public List<EmployeeContract> GetEmployees()
        {
            var empLog = new EmployeeLogic();

            var employees = empLog.GetEmployees();

            return employees;

        }

        public string Hola()
        {
            return "hola";
        }
    }
}