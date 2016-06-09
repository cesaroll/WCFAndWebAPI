using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace WcfSecurityLib
{
    public class CustomUserNamePasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != "test" || password != "test")
            {
                throw new SecurityTokenException("Access Denied");
            }

        }
    }
}
