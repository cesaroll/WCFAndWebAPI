using System.Collections.Generic;
using System.Linq;
using WCF.HR.Service.Lib.Contracts;
using WCF.HR.Service.Lib.Logic;


namespace WCF.HR.Service.Lib
{
    public class HR : IHR
    {
        public List<EmployeeContract> GetEmployees()
        {
            var empLogic = new EmployeeLogic();

            var employees = empLogic.GetEmployees();

            return employees;

        }
        
        public EmployeeContract SaveEmployee(EmployeeContract employee)
        {
            var empLogic = new EmployeeLogic();

            var emp = empLogic.SaveEmployee(employee);

            return emp;
        }
       
        public void SaveSalaryHistory(EmployeeContract employee)
        {
            var empLogic = new EmployeeLogic();

            empLogic.SaveSalaryHistory(employee);

        }

        public string Hola()
        {
            return "hola";
        }
    }
}