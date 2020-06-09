using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Domain.Models.Models;

namespace Esmart.Domain.ServiceContract.Contracts
{
    public interface IProcessTypeStateDomainService
    {
        Task<DomainResultModel> ValidateProcessTypeState(ProcessTypeStateDomainModel processTypeState, string UserId);
    }
}
