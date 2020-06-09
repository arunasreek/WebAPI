using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Esmart.Infrastructure.Resources;

namespace Esmart.Application.WebApi.Attributes
{
    public class ValidateTokenAttribute : AuthorizationFilterAttribute
    {
        public override Task OnAuthorizationAsync(HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken)
        {

            var principal = actionContext.RequestContext.Principal as ClaimsPrincipal;


            var Identity = (ClaimsPrincipal)Thread.CurrentPrincipal;

            if (Identity.Claims.Count() == 0)
            {
                actionContext.Response = actionContext.Request.CreateResponse((HttpStatusCode)467, ResourceStrings.TokenExpired);
                return Task.FromResult<object>(null);
            }

                      
            //User is Authorized, complete execution
            return Task.FromResult<object>(null);

        }
    }
}