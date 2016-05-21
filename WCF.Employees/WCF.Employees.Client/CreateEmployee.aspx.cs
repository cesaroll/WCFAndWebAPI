using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCF.Employees.Client.EmpServiceReference;

namespace WCF.Employees.Client
{
    public partial class CreateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var newEmp = new EmpServiceReference.Employee()
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Salary = decimal.Parse(tbSalary.Text)
            };

            using (var client = new EmpClient())
            {
                client.SaveEmployee(newEmp);

                Server.Transfer("Employee.aspx");

            }

            
        }
    }
}