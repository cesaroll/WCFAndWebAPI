using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClient.MyServiceReference;

namespace MyClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new MyServiceClient();

            var countries = client.CountriesGetAll();

            lbCountries.DataSource = countries;
            lbCountries.DataValueField = "Id";
            lbCountries.DataTextField = "Name";
            lbCountries.DataBind();
        }
    }
}