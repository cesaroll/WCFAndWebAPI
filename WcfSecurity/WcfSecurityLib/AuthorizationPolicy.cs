using System;
using System.Collections.Generic;
using System.IdentityModel.Policy;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace WcfSecurityLib
{
    public class AuthorizationPolicy : IAuthorizationPolicy
    {

        public bool Evaluate(EvaluationContext evaluationContext, ref object state)
        {
            object obj;

            if (!evaluationContext.Properties.TryGetValue("Identities", out obj))
                return false;

            var identities = obj as IList<IIdentity>;

            if (obj == null || identities.Count <= 0)
                return false;

            evaluationContext.Properties["Principal"] = new CustomPrincipal(identities[0]);

            return true;
        }

        public System.IdentityModel.Claims.ClaimSet Issuer
        {
            get { return System.IdentityModel.Claims.ClaimSet.System; }
        }

        public string Id
        {
            get { return Guid.NewGuid().ToString(); }
        }
    }

    public class CustomPrincipal : IPrincipal
    {
        private IIdentity _identity;
        public IIdentity Identity
        {
            get { return _identity; }
        }

        public bool IsInRole(string role)
        {
            string userName = Identity.Name.ToString();

            if (userName == "test" && role == "Admin")
                return true;

            return false;
        }

        public CustomPrincipal(IIdentity identity)
        {
            _identity = identity;
        }
    }
}
