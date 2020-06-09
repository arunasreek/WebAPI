using System.Collections.Generic;
using System.Threading.Tasks;
using Esmart.Domain.Models.Models;

namespace Esmart.Domain.ServiceContract.Contracts
{
    public interface ISendNotificationDomainService
    {
        Task<DomainResultModel> ValidateSendNotificationAsync(SendNotificationDomainModel sendNotification, string UserId);

        Task<DomainResultModel> ValidateNotification(SendNotificationDomainModel sendNotification, string UserId, bool acceptOrReject);

        Task<DomainResultModel> ValidateDataPreparationNotification(List<SendNotificationDomainModel> sendNotificationList,string UserId);
    }
}
