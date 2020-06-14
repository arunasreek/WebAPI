using Esmart.Application.Models.Models;
using Esmart.Application.ServiceContract.Contracts;
using Esmart.Application.WebApi.Attributes;
using Esmart.Infrastructure.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Esmart.Application.WebApi.Controllers
{
    public class EnterpriseController : ApiController
    {
        private readonly IEnterPriseApplicationService _enterPriseApplicationService;
        public EnterpriseController(IEnterPriseApplicationService enterPriseApplicationService)
        {
            _enterPriseApplicationService = enterPriseApplicationService;
        }

        [HttpGet]
        [Route("api/Enterprise/GetEnterpriseAllList")]
        //[ValidateToken]
        public async Task<HttpResponseMessage> GetEnterpriseAllList()
        {
            int ep_id = 0;
            try
            {
                var result = _enterPriseApplicationService.GetEnterPriseListForAll(0);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new ApplicationResultModel() { Success = true,Result= result });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ResourceStrings.ErrorMessage);
            }
        }
    }
}
