using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Esmart.Application.Models.Models;
using Esmart.Application.WebApi.Attributes;
using Esmart.Infrastructure.RepositoryContract.Interfaces;
using Esmart.Infrastructure.Resources;

namespace Esmart.Application.WebApi.Controllers
{
    public class ValidateTokenController : ApiController
    {

      

        public ValidateTokenController()
        {
           
        }
       
        [HttpGet]
        [Route("api/Organisation/{OrganisationId}/BusinessUnit/{BusinessUnitId}/ValidateHarmonization")]
        [ClaimsAuthorization(ClaimType = "Privilege", ClaimValue = "File Upload")]
        public async Task<HttpResponseMessage> ValidateHarmonization(int OrganisationId , int BusinessUnitId)
        {
            try
            {
                var Identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
                string UserId = Identity.Claims.Where(c => c.Type == ClaimTypes.Sid).Select(c => c.Value).SingleOrDefault();
                if (String.IsNullOrEmpty(UserId))
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ResourceStrings.Unauthorized);
                }

                if (OrganisationId == 0)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, ResourceStrings.OrganisationNotFound);
                }

                if (BusinessUnitId == 0)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, ResourceStrings.InvalidBusinessUnitId);
                }


              


                return Request.CreateResponse(HttpStatusCode.OK);

            }
            catch (Exception ex)
            {
               
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ResourceStrings.ErrorMessage);
            }
        }

        [HttpGet]
        [Route("api/Organisation/{OrganisationId}/BusinessUnit/{BusinessUnitId}/ValidateDataPort")]
        [ClaimsAuthorization(ClaimType = "Privilege", ClaimValue = "File Approval")]
        public async Task<HttpResponseMessage> ValidateDataPort(int OrganisationId, int BusinessUnitId)
        {
            try
            {
                var Identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
                string UserId = Identity.Claims.Where(c => c.Type == ClaimTypes.Sid).Select(c => c.Value).SingleOrDefault();
                if (String.IsNullOrEmpty(UserId))
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ResourceStrings.Unauthorized);
                }

                if (OrganisationId == 0)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, ResourceStrings.OrganisationNotFound);
                }

                if (BusinessUnitId == 0)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, ResourceStrings.InvalidBusinessUnitId);
                }


              


                return Request.CreateResponse(HttpStatusCode.OK);

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ResourceStrings.ErrorMessage);
            }
        }


        [HttpGet]
        [Route("api/Organisation/{OrganisationId}/BusinessUnit/{BusinessUnitId}/ValidateETL")]
        [ClaimsAuthorization(ClaimType = "Privilege", ClaimValue = "File Approval")]
        public async Task<HttpResponseMessage> ValidateETL(int OrganisationId, int BusinessUnitId)
        {
            try
            {
                var Identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
                string UserId = Identity.Claims.Where(c => c.Type == ClaimTypes.Sid).Select(c => c.Value).SingleOrDefault();
                if (String.IsNullOrEmpty(UserId))
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ResourceStrings.Unauthorized);
                }

                if (OrganisationId == 0)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, ResourceStrings.OrganisationNotFound);
                }

                if (BusinessUnitId == 0)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, ResourceStrings.InvalidBusinessUnitId);
                }


             


                return Request.CreateResponse(HttpStatusCode.OK);

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ResourceStrings.ErrorMessage);
            }
        }


        [HttpGet]
        [Route("api/Organisation/{OrganisationId}/BusinessUnit/{BusinessUnitId}/ValidatePortETL")]
        [ClaimsAuthorization(ClaimType = "Privilege", ClaimValue = "Data Preperation")]
        public async Task<HttpResponseMessage> ValidatePortETL(int OrganisationId, int BusinessUnitId)
        {
            try
            {
                var Identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
                string UserId = Identity.Claims.Where(c => c.Type == ClaimTypes.Sid).Select(c => c.Value).SingleOrDefault();
                if (String.IsNullOrEmpty(UserId))
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ResourceStrings.Unauthorized);
                }

                if (OrganisationId == 0)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, ResourceStrings.OrganisationNotFound);
                }

                if (BusinessUnitId == 0)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, ResourceStrings.InvalidBusinessUnitId);
                }


                


                return Request.CreateResponse(HttpStatusCode.OK);

            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ResourceStrings.ErrorMessage);
            }
        }
    }
}
