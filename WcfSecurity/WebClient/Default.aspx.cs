using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfSecurityServiceReference;
using System.ServiceModel.Security;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            var cc = new CalculatorClient("BasicHttpBinding_ICalculator");

            cc.ClientCredentials.UserName.UserName = "test";
            cc.ClientCredentials.UserName.Password = "t78est";

            Response.Write(cc.Add(4, 96));
        }
        catch(MessageSecurityException ex)
        {
            Response.Write("Access Denied");
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}