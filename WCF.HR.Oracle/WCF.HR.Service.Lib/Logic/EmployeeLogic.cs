using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using WCF.HR.DAL;
using WCF.HR.Service.Lib.Contracts;

namespace WCF.HR.Service.Lib.Logic
{
    public class EmployeeLogic : IDisposable
    {
        #region Properties
        protected HrEntities Ctx { get; set; }
        protected bool _disposed = false;

        #endregion

        #region Constructor
        public EmployeeLogic()
        {
            Ctx = new HrEntities();
        }
        #endregion

        #region Dispose
        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(_disposed)
                return;

            if (disposing)
            {
                if(Ctx != null)
                    Ctx.Dispose();
            }

            _disposed = true;
        }
        #endregion

        #region Static Methods
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

        #endregion

        #region Employee Methods
        public virtual List<EmployeeContract> GetEmployees()
        {
            var employees = Ctx.EMPLOYEES.AsParallel().Select(ToEmployeeContract).OrderByDescending(x => x.EmployeeId).ToList();
            
            return employees;
        }

        public virtual EmployeeContract SaveEmployee(EmployeeContract employee)
        {
            var emp = ToEmployee(employee);
            
            emp.HIRE_DATE = DateTime.Now;
            emp.JOB_ID = "IT_PROG";
            emp.MANAGER_ID = 103;
            emp.DEPARTMENT_ID = 60;
            try
            {
                emp.EMPLOYEE_ID = Ctx.EMPLOYEES.Max(x => x.EMPLOYEE_ID) + 1;

                Ctx.EMPLOYEES.Add(emp); //Same transaction
                SaveSalaryHistory(emp); //Same Transaction

                Ctx.SaveChanges();
            }
            catch (Exception)
            {
                
            }
            

            return ToEmployeeContract(emp);

        }

        public virtual void SaveSalaryHistory(EmployeeContract employee)
        {
            var emp = ToEmployee(employee);

            SaveSalaryHistory(emp);
            
            Ctx.SaveChanges();
        }

        public virtual void SaveSalaryHistory(EMPLOYEE emp)
        {
            var newSalHist = new SALARY_HISTORY()
            {
                EMPLOYEE = emp,
                START_DATE = DateTime.Now,
                SALARY = emp.SALARY?? 0
            };

            newSalHist.SEQ = Ctx.SALARY_HISTORY.Where(x => x.EMPLOYEE_ID == emp.EMPLOYEE_ID).Select(x => x.SEQ).DefaultIfEmpty((short)0).Max();

            //newSalHist.SEQ = (short)( Ctx.SALARY_HISTORY.Where(x => x.EMPLOYEE_ID == emp.EMPLOYEE_ID).Max(x => x.SEQ) + 1);

            Ctx.SALARY_HISTORY.Add(newSalHist);
        }
       

        #endregion

    }
}