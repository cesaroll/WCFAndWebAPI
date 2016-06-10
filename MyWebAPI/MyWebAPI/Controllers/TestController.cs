using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MyWebAPI.Controllers
{
    /// <summary>
    /// ../api/Test
    /// </summary>
    //[EnableCors("*","*","*")] // Enabled at complete Service Level in WebApiConfig.cs
    public class TestController : ApiController
    {
        string[] s = new string[] {"Cesar Lopez testing Web API ...", "Asp.Net WebAPI"};

        // ../api/Test
        public string[] Get()
        {
            return s;
        }

        // ../api/Test/id
        public string Get(int id)
        {
            if (id >= 0 && s.Length > id)
                return s[id];

            return string.Empty;
        }
    }
}
