using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF.Employees.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Emp" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Emp.svc or Emp.svc.cs at the Solution Explorer and start debugging.
    public class Emp : IEmp
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();

            using (var dc = new MvcDbDataContext())
            {
                employees = dc.Employees.ToList();
            }

            return employees;
        }

        public void SaveEmployee(Employee employee)
        {
            using (var dc = new MvcDbDataContext())
            {
                dc.Employees.InsertOnSubmit(employee);
                //dc.SubmitChanges();


                var lastSeq = dc.SalaryHistories
                    .Where(x => x.EmpId == employee.EmpId)
                    .OrderByDescending(x => x.Seq)
                    .Select(x => x.Seq)
                    .FirstOrDefault();

                lastSeq += 1;

                var salHist = new SalaryHistory()
                {
                    Employee = employee,
                    Seq = lastSeq,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Parse("01/01/2050"),
                    Salary = employee.Salary
                };

                dc.SalaryHistories.InsertOnSubmit(salHist);
                dc.SubmitChanges();
            }
        }

        public List<SalaryHistory> GetSalaryHistory(int employeeId)
        {
            var salaryHistory = new List<SalaryHistory>();

            using (var dc = new MvcDbDataContext())
            {
                salaryHistory = dc.SalaryHistories
                                    .Where(x => x.EmpId == employeeId)
                                    .OrderBy(x => x.Seq)
                                    .ToList();

            }

            return salaryHistory;
        }
    }
}
