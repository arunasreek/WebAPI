using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Domain.Models.Models;

namespace Esmart.Domain.ServiceContract.Contracts
{
    public interface IFileApprovalDomainService
    {
        Task<DomainResultModel> ValidateFileApprovalAsync(FileApprovalDomainModel fileApprovalDomainModel);
        Task<DomainResultModel> ValidateAllFilesUploadedAndSelfApprovedAsync(FileApprovalDomainModel fileApprovalDomainModel);
    }
}
