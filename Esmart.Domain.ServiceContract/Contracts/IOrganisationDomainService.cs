using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Application.Models.Models;
using Esmart.Domain.Models.Aggregates;
using Esmart.Domain.Models.Models;

namespace Esmart.Domain.ServiceContract.Contracts
{
   public interface IOrganisationDomainService
    {
        //Task<DomainResultModel> ValidateOrganisationBasicDetails(OrganisationDomainModel organisationDomainModel);
        Task<DomainResultModel> SaveOrganisationBasicDetailsAsync(OrganisationDomainBasicModel organisationDomainBasicModel, string UserId);
        Task<DomainResultModel> SaveOrganisationFileTypeDetailsAsync(OrganisationFileTypeDomainModel organisationFileTypeDomainModel, string UserId);
        Task<DomainResultModel> ValidateUpdateOrganisationBasicDetailsAsync(OrganisationDomainBasicModel organisationDomainBasicModel, string UserId);
        Task<DomainResultModel> SetOrganisationAdminAsync(OrganisationAdminDomainModel organisationAdminDomainModel);
    }
}
