using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Esmart.Infrastructure.Resources;

namespace Esmart.Application.WebApi.Attributes
{
    public class ClaimsAuthorizationAttribute : AuthorizationFilterAttribute
    {
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public override Task OnAuthorizationAsync(HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken)
        {

            var principal = actionContext.RequestContext.Principal as ClaimsPrincipal;
            var authToken = actionContext.Request.Headers.Authorization.Parameter;

            var Identity = (ClaimsPrincipal)Thread.CurrentPrincipal;

            if (Identity.Claims.Count() == 0)
            {
                actionContext.Response = actionContext.Request.CreateResponse((HttpStatusCode)467, ResourceStrings.TokenExpired);
                return Task.FromResult<object>(null);
            }
                       

            if (!principal.Identity.IsAuthenticated)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, ResourceStrings.Unauthorized);
                return Task.FromResult<object>(null);
            }


            // check if claim type and claim value matches. One claim can have multiple values. 

            if (!(principal.HasClaim(x => x.Type == ClaimType && x.Value == ClaimValue)))
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, ResourceStrings.Unauthorized);
                return Task.FromResult<object>(null);
            }

            //User is Authorized, complete execution
            return Task.FromResult<object>(null);

        }
    }
}