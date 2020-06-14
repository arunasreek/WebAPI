using Esmart.Application.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.ServiceContract.Contracts
{
    public interface IEnterPriseApplicationService
    {
        Task<ApplicationResultModel> GetEnterPriseListForAll(long ep_id);
    }
}
