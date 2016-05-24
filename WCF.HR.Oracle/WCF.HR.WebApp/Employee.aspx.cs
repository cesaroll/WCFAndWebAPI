using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCF.HR.WebApp.HRServiceReference;

namespace WCF.Employees.Client
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var client = new HRClient())
            {
                var employees = client.GetEmployees();

                gvEmployee.DataSource = employees;
                gvEmployee.DataBind();

            }

        }

        protected void gvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            var salaryHistory = new List<SalaryHistory>();


            int empId = int.Parse(gvEmployee.SelectedRow.Cells[1].Text);

            if (empId > 0)
            {
                using (var client = new EmpClient())
                {
                    salaryHistory = client.GetSalaryHistory(empId);
                }
            }

            gvSalaries.DataSource = salaryHistory;
            gvSalaries.DataBind();
          * */
        }

        protected void lbAddEmployee_Click(object sender, EventArgs e)
        {
            Server.Transfer("CreateEmployee.aspx");
        }

        
    }
}