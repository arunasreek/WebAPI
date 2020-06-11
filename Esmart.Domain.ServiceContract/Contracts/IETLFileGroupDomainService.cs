using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Domain.Models.Models;

namespace Esmart.Domain.ServiceContract.Contracts
{
    public interface IETLFileGroupDomainService
    {
        Task<DomainResultModel> ValidateETLFileGroupAsync(ETLFileGroupDomainModel etlFileGroupDomainModel);    
    }
}
