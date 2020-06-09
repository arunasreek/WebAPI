using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Domain.Models.Models;

namespace Esmart.Domain.ServiceContract.Contracts
{
    public interface IFileUploadDomainService
    {
        Task<DomainResultModel> ValidateSaveUploadedFileDetailsAsync(UploadedFileDetailDomainModel uploadedFileDetails, string UserId);
        Task<DomainResultModel> ValidateUpdateErrorWarningsDetailsAsync(ErrorWarningsDetailsDomainModel errorWarningsDetailsDomain, string UserId);
        Task<DomainResultModel> ValidateUpdateUploadedFileDetailsAsync(UploadedFileDetailDomainModel uploadedFileDetails, string UserId);
        Task<DomainResultModel> ValidateDiscardFileAsync(UploadedFileDetailDomainModel uploadedFileDetail, string UserId);
    }
}
