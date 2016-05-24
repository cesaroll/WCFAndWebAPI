using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public static EMPLOYEE ToEmployee(EmployeeContract emp)
        {
            var ec = new EMPLOYEE()
            {
                EMPLOYEE_ID = emp.EmployeeId,
                FIRST_NAME = emp.FirstName,
                LAST_NAME = emp.LastName,
                EMAIL = emp.Email,
                PHONE_NUMBER = emp.PhoneNumber,
                HIRE_DATE = emp.HireDate,
                JOB_ID = emp.JobId,
                SALARY = emp.Salary,
                COMMISSION_PCT = emp.CommissionPct,
                MANAGER_ID = emp.ManagerId,
                DEPARTMENT_ID = emp.DepartmentId 
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

        public EmployeeContract SaveEmployee(EmployeeContract employee)
        {
            var emp = ToEmployee(employee);
            
            emp.HIRE_DATE = DateTime.Now;
            emp.JOB_ID = "IT_PROG";
            emp.MANAGER_ID = 103;
            emp.DEPARTMENT_ID = 60;


            using (var ctx = new HrEntities())
            {
                emp.EMPLOYEE_ID = ctx.EMPLOYEES.Max(x => x.EMPLOYEE_ID) + 1;

                ctx.EMPLOYEES.Add(emp);

                ctx.SaveChanges();
            }

            return ToEmployeeContract(emp);

        }

        public void SaveSalaryHistory(EmployeeContract employee)
        {
            var emp = ToEmployee(employee);

            var newSalHist = new SALARY_HISTORY()
            {
                EMPLOYEE_ID = emp.EMPLOYEE_ID,
                START_DATE = DateTime.Now,
                SALARY = (decimal)emp.SALARY
            };

            using (var ctx = new HrEntities())
            {
                newSalHist.SEQ = (short)(ctx.SALARY_HISTORY.Where(x => x.EMPLOYEE_ID == emp.EMPLOYEE_ID).Max(x => x.SEQ) + 1);

                ctx.SALARY_HISTORY.Add(newSalHist);

                ctx.SaveChanges();
            }
        }

    }
}