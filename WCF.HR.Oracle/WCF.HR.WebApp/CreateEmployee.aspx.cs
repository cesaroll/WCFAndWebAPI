using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCF.HR.WebApp.HRServiceReference;

namespace WCF.Employees.Client
{
    public partial class CreateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var emp = new EmployeeContract()
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Salary = decimal.Parse(tbSalary.Text),
                Email = tbEmail.Text,
                PhoneNumber = tbPhone.Text
            };

            using (var client = new HRClient())
            {
                emp = client.SaveEmployee(emp);
            }

            Server.Transfer("Employee.aspx");
        }
    }
}