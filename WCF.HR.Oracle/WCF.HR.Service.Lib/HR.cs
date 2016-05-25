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
            List<EmployeeContract> employees;

            using (var empLogic = new EmployeeLogic())
            {
                employees = empLogic.GetEmployees();
            }

            return employees;

        }
        
        public EmployeeContract SaveEmployee(EmployeeContract employee)
        {
            using (var empLogic = new EmployeeLogic())
            {
                employee = empLogic.SaveEmployee(employee);
            }

            return employee;
        }
       
        public void SaveSalaryHistory(EmployeeContract employee)
        {
            using (var empLogic = new EmployeeLogic())
            {
                empLogic.SaveSalaryHistory(employee);
            }

        }

        public string Hola()
        {
            return "hola";
        }
    }
}