using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Serilog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using Esmart.Application.Models.Models;
using Esmart.Application.ServiceContract.Contracts;
using Esmart.Application.WebApi.Models;
using Esmart.Infrastructure.Membership.App_Start;
using Esmart.Infrastructure.Membership.Models;
using Esmart.Infrastructure.Resources;

namespace Esmart.Application.WebApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private readonly ILogger _logger;



        //private readonly IForgotPasswordApplicationService _forgotPasswordApplicationService;
        //private readonly IUserApplicationService _userApplicationService;
        private readonly IAccountApplicationService _accountApplicationService;


        public AccountController(IAccountApplicationService accountApplicationService)
        {
           
            _accountApplicationService = accountApplicationService;
        }

        public AccountController(ApplicationUserManager userManager,
            ISecureDataFormat<AuthenticationTicket> accessTokenFormat)
        {
             AccessTokenFormat = accessTokenFormat; ;
        }


        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; private set; }

        // GET api/Account/UserInfo
        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        [Route("UserInfo")]
        public UserInfoViewModel GetUserInfo()
        {
            ExternalLoginData externalLogin = ExternalLoginData.FromIdentity(User.Identity as ClaimsIdentity);

            return new UserInfoViewModel
            {
                Email = User.Identity.GetUserName(),
                HasRegistered = externalLogin == null,
                LoginProvider = externalLogin != null ? externalLogin.LoginProvider : null
            };
        }

        // POST api/Account/Logout
        [Route("Logout")]
        public IHttpActionResult Logout()
        {
            Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
            return Ok();
        }


        // POST api/Account/ChangePassword
        [Route("ChangePassword")]
        public async Task<ApplicationResultModel> ChangePassword(ChangePasswordBindingModel model)
        {
           
            if (model.NewPassword.Length < 8)
            {
                return new ApplicationResultModel() { Success = false, Error = ResourceStrings.InvalidPasswordLength };
            }

            if (model.NewPassword != model.ConfirmPassword)
            {
                return new ApplicationResultModel() { Success = false, Error = ResourceStrings.PasswordsDoNotMatch };
            }

            if (model.NewPassword == ResourceStrings.DefaultPassword)
            {
                return new ApplicationResultModel() { Success = false, Error = ResourceStrings.InvalidPassword };
            }

            if (model.NewPassword == model.OldPassword)
            {
                return new ApplicationResultModel() { Success = false, Error = ResourceStrings.InvalidPassword };
            }

            IdentityResult result = await _accountApplicationService.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword,
                model.NewPassword);

            if (!result.Succeeded)
            {
                string errorDesc = "";
                foreach (var error in result.Errors)
                {
                    errorDesc = error;
                }
                return new ApplicationResultModel() { Success = false, Error = errorDesc };
            }

            return new ApplicationResultModel() { Success = true };
        }

        // POST api/Account/SetPassword
        [Route("SetPassword")]
        public async Task<IHttpActionResult> SetPassword(SetPasswordBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await _accountApplicationService.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword);

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

      
        // POST api/Account/RemoveLogin
        [Route("RemoveLogin")]
        public async Task<IHttpActionResult> RemoveLogin(RemoveLoginBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result;

            if (model.LoginProvider == LocalLoginProvider)
            {
                result = await _accountApplicationService.RemovePasswordAsync(User.Identity.GetUserId());
            }
            else
            {
                result = await _accountApplicationService.RemoveLoginAsync(User.Identity.GetUserId(),
                    new UserLoginInfo(model.LoginProvider, model.ProviderKey));
            }

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

        // POST api/Account/Register
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(RegisterBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser() { UserName = model.Email, Email = model.Email, EmailConfirmed = true };
            if (!string.IsNullOrEmpty(model.PhoneNumber))
            {
                user.PhoneNumber = model.PhoneNumber;
            }

            IdentityResult result = await _accountApplicationService.CreateAsync(user, model.Password);


            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

        
        [HttpPost]
        [AllowAnonymous]
        [Route("ForgotPassword")]
        public async Task<HttpResponseMessage> ForgotPassword(ForgotPasswordBindingModel model)
        {
            string UserId = string.Empty;

            //For checking Static Email For Sending Mail 
            bool isStaticEmailStatus = Convert.ToBoolean(WebConfigurationManager.AppSettings["UseStaticEmailForSendingMail"]);

            if (ModelState.IsValid)
            {
                var user = await _accountApplicationService.FindUserByEmailAsync(model.Email);

                if (user == null || !(await _accountApplicationService.IsEmailConfirmedAsync(user.Id)))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new ApplicationResultModel() { Success = false, Error = ResourceStrings.EmailValidCheck });
                }

                try
                {
                    UserId = user.Id;

                    var token = await _accountApplicationService.GeneratePasswordResetTokenAsync(user.Id);

                    var activationLink = string.Format(WebConfigurationManager.AppSettings["WebURL"] + "forgotPassword?emailId=" + HttpUtility.UrlEncode(user.UserName) + "&token=" + HttpUtility.UrlEncode(token));

                    List<string> attachments = new List<string>();
                    string subject = "Reset Password";

                    //  return Request.CreateResponse(HttpStatusCode.OK, await _forgotPasswordApplicationService.SendForgetPasswordLinkAsync(user.Email, user.UserName, subject, activationLink.ToString(), isStaticEmailStatus));
                    return Request.CreateResponse(HttpStatusCode.OK, new ApplicationResultModel() { Success = true, Result = null });
                }
                catch (Exception ex)
                {

                   // _logger.Error("Error For {UserId} and {OrgId}", UserId, (int)(await _userApplicationService.GetUserDetailsByUserIdAsync(UserId)).Result);
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new ApplicationResultModel() { Success = false });
                }


            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new ApplicationResultModel() { Success = false, Error = ResourceStrings.EmailValidCheck });
            }
        }

        [HttpPatch]
        [AllowAnonymous]
        [Route("ResetPasswordToken")]
        public async Task<HttpResponseMessage> ResetPassword(ResetPasswordViewModel model)
        {
            var user = await _accountApplicationService.FindUserByEmailAsync(model.Email);
            if (user == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new ApplicationResultModel() { Success = false, Error = ResourceStrings.EmailValidCheck });
            }
            //HttpUtility.UrlEncode(code);
            
            var result = await _accountApplicationService.ValidateTokenAsync(model.Token, user);
            if (result)
            {
                var resetPasswordModel = new ResetPasswordViewModel()
                {
                    Email = model.Email,
                    Token = model.Token,
                };
                return Request.CreateResponse(HttpStatusCode.OK, new ApplicationResultModel() { Success = true, Result = resetPasswordModel });
            }
            return Request.CreateResponse(HttpStatusCode.OK, new ApplicationResultModel() { Success = false, Error = ResourceStrings.TokenValidaCheck });
        }

        /// <summary>
        /// Resets the user's password based on the posted data.
        /// Accepts the user ID, password reset token and the new password via the ResetPasswordViewModel.
        /// </summary>
        [HttpPatch]
        [AllowAnonymous]
        [Route("ResetPassword")]
        public async Task<HttpResponseMessage> ResetPasswordMethod(ResetPasswordViewModel model)
        {
            var user = await _accountApplicationService.FindUserByEmailAsync(model.Email);
            // Validates the received password data based on the view model
            try
            {
                if (model.Password.Length < 8)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new ApplicationResultModel() { Success = false, Error = ResourceStrings.InvalidPasswordLength });
                }

                //if (model.NewPassword != model.ConfirmPassword)
                //{
                //    return new ApplicationResultModel() { Success = false, Error = ResourceStrings.PasswordsDoNotMatch };
                //}

                if (model.Password == ResourceStrings.DefaultPassword)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new ApplicationResultModel() { Success = false, Error = ResourceStrings.InvalidPassword });
                }

                // Changes the user's password if the provided reset token is valid
                if (_accountApplicationService.ResetPassword(user.Id, model.Token, model.Password))
                {
                    // If the password change was successful, displays a view informing the user
                    return Request.CreateResponse(HttpStatusCode.OK, new ApplicationResultModel() { Success = true });
                }

                // Occurs if the reset token is invalid
                // Returns a view informing the user that the password reset failed
                return Request.CreateResponse(HttpStatusCode.OK, new ApplicationResultModel() { Success = false, Error = ResourceStrings.InvalidPasswordFormat });
            }
            catch (InvalidOperationException)
            {
                // An InvalidOperationException occurs if a user with the given ID is not found
                // Returns a view informing the user that the password reset failed
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new ApplicationResultModel() { Success = false });
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #region Helpers

        private IAuthenticationManager Authentication
        {
            get { return Request.GetOwinContext().Authentication; }
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }

        private class ExternalLoginData
        {
            public string LoginProvider { get; set; }
            public string ProviderKey { get; set; }
            public string UserName { get; set; }

            public IList<Claim> GetClaims()
            {
                IList<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, ProviderKey, null, LoginProvider));

                if (UserName != null)
                {
                    claims.Add(new Claim(ClaimTypes.Name, UserName, null, LoginProvider));
                }

                return claims;
            }

            public static ExternalLoginData FromIdentity(ClaimsIdentity identity)
            {
                if (identity == null)
                {
                    return null;
                }

                Claim providerKeyClaim = identity.FindFirst(ClaimTypes.NameIdentifier);

                if (providerKeyClaim == null || String.IsNullOrEmpty(providerKeyClaim.Issuer)
                    || String.IsNullOrEmpty(providerKeyClaim.Value))
                {
                    return null;
                }

                if (providerKeyClaim.Issuer == ClaimsIdentity.DefaultIssuer)
                {
                    return null;
                }

                return new ExternalLoginData
                {
                    LoginProvider = providerKeyClaim.Issuer,
                    ProviderKey = providerKeyClaim.Value,
                    UserName = identity.FindFirstValue(ClaimTypes.Name)
                };
            }
        }

        private static class RandomOAuthStateGenerator
        {
            private static RandomNumberGenerator _random = new RNGCryptoServiceProvider();

            public static string Generate(int strengthInBits)
            {
                const int bitsPerByte = 8;

                if (strengthInBits % bitsPerByte != 0)
                {
                    throw new ArgumentException("strengthInBits must be evenly divisible by 8.", "strengthInBits");
                }

                int strengthInBytes = strengthInBits / bitsPerByte;

                byte[] data = new byte[strengthInBytes];
                _random.GetBytes(data);
                return HttpServerUtility.UrlTokenEncode(data);
            }
        }

        #endregion
    }
}
