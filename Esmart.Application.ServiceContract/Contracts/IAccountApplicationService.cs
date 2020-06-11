using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Application.Models.Models;
using Esmart.Infrastructure.Membership.Models;

namespace Esmart.Application.ServiceContract.Contracts
{
   public  interface IAccountApplicationService
   {
        Task<ApplicationResultModel> Register(RegisterBindingApplicationModel model);
        Task<ApplicationUser> FindUserByEmailAsync(string email);
        Task<IdentityResult> ChangePasswordAsync(string UserId, string OldPassword, string NewPassword);
        Task<IdentityResult> AddPasswordAsync(string UserId, string NewPassword);
        Task<IdentityResult> RemovePasswordAsync(string UserId);
        Task<IdentityResult> SetPhoneNumberAsync(string UserId, string PhoneNumber);
        Task<ApplicationUser> FindByIdAsync(string UserId);
        Task<string> GeneratePasswordResetTokenAsync(string UserId);
        Task<IdentityResult> RemoveLoginAsync(string UserId, UserLoginInfo userLoginInfo);
        Task<IdentityResult> CreateAsync(ApplicationUser applicationUser,string Password);
        Task<bool> IsEmailConfirmedAsync(string UserId);
        Task<bool> ValidateTokenAsync(string Token, ApplicationUser user);
        bool ResetPassword(string UserId, string Token, string Password);
    }
}
