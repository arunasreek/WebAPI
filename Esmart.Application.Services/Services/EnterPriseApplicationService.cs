using Esmart.Application.Models.Models;
using Esmart.Application.ServiceContract.Contracts;
using Esmart.Infrastructure.RepositoryContract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Services.Services
{
    public class EnterPriseApplicationService : IEnterPriseApplicationService
    {
        private readonly IEnterPriseRepository _enterPriseRepository;
        public EnterPriseApplicationService(IEnterPriseRepository enterPriseRepository)
        {
            _enterPriseRepository = enterPriseRepository;
        }
        public async Task<ApplicationResultModel> GetEnterPriseListForAll(long ep_id)
        {
            var result = _enterPriseRepository.GetEnterPriseListForAll(ep_id);

            return new ApplicationResultModel() { Success = true, Result = result };
        }
    }
}
