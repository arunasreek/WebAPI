using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Esmart.Application.WebApi.Attributes;
using Esmart.Infrastructure.Resources;

namespace Esmart.Application.WebApi.Controllers
{
    public class CustomErrorController : ApiController
    {
        public CustomErrorController()
        {

        }

        [HttpGet]
        [ValidateToken]
        public HttpResponseMessage Handle404()
        {
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, ResourceStrings.NotFound);
        }        
    }
}
