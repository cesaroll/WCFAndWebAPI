using System.Collections.Generic;
using System.Linq;
using WCF.HR.DAL;
using WCF.HR.Service.Lib.Contracts;

namespace WCF.HR.Service.Lib.Logic
{
    public class EmployeeLogic
    {

        public static EmployeeContract ToEmployeeContract(EMPLOYEE emp)
        {
            var ec = new EmployeeContract()
            {
                EmployeeId = emp.EMPLOYEE_ID,
                FirstName = emp.FIRST_NAME,
                LastName = emp.LAST_NAME,
                Email = emp.EMAIL,
                PhoneNumber = emp.PHONE_NUMBER,
                HireDate = emp.HIRE_DATE,
                JobId = emp.JOB_ID,
                Salary = emp.SALARY,
                CommissionPct = emp.COMMISSION_PCT,
                ManagerId = emp.MANAGER_ID,
                DepartmentId = emp.DEPARTMENT_ID
            };

            return ec;
        }

        
        public List<EmployeeContract> GetEmployees()
        {
            var employees = new List<EmployeeContract>();

            using (var ctx = new HrEntities())
            {
                employees = ctx.EMPLOYEES.AsParallel().Select(ToEmployeeContract).ToList();
            }

            return employees;
        }
    }
}