using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Domain.Models.Aggregates;
using Esmart.Domain.Models.Models;

namespace Esmart.Domain.ServiceContract.Contracts
{
   public interface IUserDomainService
    {
        Task<DomainResultModel> UpdateStatusAsync(UserStatusChangeDomainModel  userStatusChangeDomainModel, string UserId);
        //Task<DomainResultModel> SaveUserNotificationDetailsAsync(List<UserNotificationModel> UserNotificationModel, string userId);
        Task<DomainResultModel> SaveUserNotificationDetailsAsync(List<UserNotificationDomainModel> UserNotificationModel, string ProfileUserId,string UserId);
        Task<DomainResultModel> UpdateUserNotificationDetailsAsync(List<UserNotificationDomainModel> UserNotificationModel, string ProfileUserId, string UserId);
      
        Task<DomainResultModel> ValidateSaveUserDetails(UserDetailsDomainModel organisationUserDetailsDomainModel, string UserId);
        Task<DomainResultModel> ValidateUpdateUserDetails(UserDetailsDomainModel organisationUserDetailsDomainModel, string UserId);

        Task<DomainResultModel> ValidateSaveUserDashboardDetails(UserDashboardDetailDomainModel userDashboardDetailDomainModel, string UserId);
        Task<DomainResultModel> ValidateUpdateUserDashboardDetails(UserDashboardDetailDomainModel userDashboardDetailDomainModel, string UserId);

        Task<DomainResultModel> ValidateSaveUserRole(AspNetUserRoleDomainModel aspNetUserRoleDomainModel, string UserId);
        Task<DomainResultModel> ValidateUpdateUserRole(AspNetUserRoleDomainModel aspNetUserRoleDomainModel, string UserId);

        Task<DomainResultModel> ValidatePublishUserAsync(UserDetailsDomainModel userDetailsDomainModel, string UserId);
    }
}
