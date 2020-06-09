using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Esmart.Application.Models.Models;
using Esmart.Application.ServiceContract.Contracts;
using Esmart.Infrastructure.Membership.App_Start;
using Esmart.Infrastructure.Membership.Models;

namespace Esmart.Application.Services.Services
{
   public class AccountApplicationService : IAccountApplicationService
   {
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                //return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
                return _userManager ?? HttpContext.Current.Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public async Task<ApplicationResultModel> Register(RegisterBindingApplicationModel model)
        {
            var user = new ApplicationUser() { UserName = model.Email, Email = model.Email, EmailConfirmed = true };
            if (!string.IsNullOrEmpty(model.PhoneNumber))
            {
                user.PhoneNumber = model.PhoneNumber;
            }

            IdentityResult result = await UserManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return new ApplicationResultModel() { Success = false, Error = result.Errors.FirstOrDefault() };
            }
            return new ApplicationResultModel() { Success = true };
        }

        public async Task<ApplicationUser> FindUserByEmailAsync(string email)
        {
            return await UserManager.FindByEmailAsync(email);
        }

        public async Task<IdentityResult> ChangePasswordAsync(string UserId, string OldPassword, string NewPassword)
        {
            return await UserManager.ChangePasswordAsync(UserId, OldPassword, NewPassword);
        }

        public async Task<IdentityResult> AddPasswordAsync(string UserId, string NewPassword)
        {
            return await UserManager.AddPasswordAsync(UserId, NewPassword);
        }

        public async Task<IdentityResult> RemovePasswordAsync(string UserId)
        {
            return await UserManager.RemovePasswordAsync(UserId);
        }

        public async Task<IdentityResult> RemoveLoginAsync(string UserId, UserLoginInfo userLoginInfo)
        {
            return await UserManager.RemoveLoginAsync(UserId, userLoginInfo);
        }

        public async Task<IdentityResult> SetPhoneNumberAsync(string UserId, string PhoneNumber)
        {
            return await UserManager.SetPhoneNumberAsync(UserId,PhoneNumber);
        }

        public async Task<ApplicationUser> FindByIdAsync(string UserId)
        {
            return await UserManager.FindByIdAsync(UserId);
        }

        public async Task<string> GeneratePasswordResetTokenAsync(string UserId)
        {
            return await UserManager.GeneratePasswordResetTokenAsync(UserId);
        }

        public async Task<IdentityResult> CreateAsync(ApplicationUser applicationUser, string Password)
        {
            return await UserManager.CreateAsync(applicationUser, Password);
        }

        public async Task<bool> IsEmailConfirmedAsync(string UserId)
        {
            return await UserManager.IsEmailConfirmedAsync(UserId);
        }

        public async Task<bool> ValidateTokenAsync(string Token, ApplicationUser user)
        {
            return await UserManager.UserTokenProvider.ValidateAsync("ResetPassword", Token,UserManager, user);
        }
        
        public bool ResetPassword(string UserId, string Token,string Password)
        {
            return UserManager.ResetPassword(UserId, Token, Password).Succeeded;
        }



    }
}
