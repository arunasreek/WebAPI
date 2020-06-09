using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Web;

namespace Esmart.Application.WebApi.Attributes
{
    public class AuthorizationAttribute : System.Web.Http.AuthorizeAttribute
    {
        public string Roles { get; set; }

        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            ClaimsPrincipal currentPrincipal = HttpContext.Current.User as ClaimsPrincipal;
            var result = CheckRoles(currentPrincipal);
            if (currentPrincipal != null && CheckRoles(currentPrincipal))
            {
                return true;
            }
            else
            {
                actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized)
                {
                    ReasonPhrase = "Claims not found!"
                };
                return false;
            }
        }

        private bool CheckRoles(ClaimsPrincipal principal)
        {
            try
            {
                string[] roles = RolesSplit;
                if (roles.Length == 0)
                {
                    return false;
                }
                else
                {
                    return roles.Any(principal.IsInRole);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            

        }

        protected string[] RolesSplit
        {
            get { return SplitStrings(Roles); }
        }

        protected static string[] SplitStrings(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return new string[0];
            }
            var result = input.Split(',').Where(s => !String.IsNullOrWhiteSpace(s.Trim()));
            return result.Select(s => s.Trim()).ToArray();
        }

    }
}