using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Owin.Security.OAuth;
using DataAccessLayer;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SMSWebAPI.App_Start
{
    
    public class AuthorizationServiceProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            DalLayer dal = new DalLayer();
            var result = dal.GetStudents().Where(o => o.Id.ToString() == context.UserName).SingleOrDefault();
            var result1 = dal.GetFaculty().Where(o => o.Id.ToString() == context.UserName).SingleOrDefault();
            if (result != null || result1 !=null)
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Provided username and password is incorrect");
                return;
            }
        }
    }
}