using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Membership.App_Start;
using Esmart.Infrastructure.Membership.Models;
using Esmart.Infrastructure.Repository.Classes;
using Esmart.Infrastructure.Resources;

namespace Esmart.Application.WebApi.Providers
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        private readonly string _publicClientId;
		
      


        public ApplicationOAuthProvider(string publicClientId)
        {
            if (publicClientId == null)
            {
                throw new ArgumentNullException("publicClientId");
            }

            _publicClientId = publicClientId;
			
			
           

        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var allowedOrigin = context.OwinContext.Get<string>("as:clientAllowedOrigin");
            if (allowedOrigin == null) allowedOrigin = "*";
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();

            if (context.Password == ResourceStrings.DefaultPassword)
            {
                context.SetError("invalid_grant", ResourceStrings.ChangeDefaultPassword);
                return;
            }

            ApplicationUser user = await userManager.FindAsync(context.UserName, context.Password);


            if (user == null)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }

            var claims = new List<Claim>()
            {
               new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Sid, user.Id)
            };


			StringBuilder roles = new StringBuilder();

			// add all roles to the claim

			//foreach (string role in await _aspNetUserRolesRepository.GetUsersRoles(user.Id, true))
			//{
			//	claims.Add(new Claim(ClaimTypes.Role, role));
			//	roles.Append("," + role);

			//}

			//add new properties here. 
			var properties = new AuthenticationProperties(new Dictionary<string, string>
		    {
			    { "email", user.UserName},
				{ "userId",user.Id}
		    });


			//add all priviliges to the claim

			foreach (var item in  await userManager.GetClaimsAsync(user.Id))
            {
                claims.Add(new Claim("Privilege", item.Value));
            }

			// add OrganisationId to the claim


			ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(userManager,
               OAuthDefaults.AuthenticationType);
            oAuthIdentity.AddClaims(claims);
           
           

            AuthenticationTicket ticket = new AuthenticationTicket(oAuthIdentity, properties);
            context.Validated(ticket);
           // context.Request.Context.Authentication.SignIn(cookiesIdentity);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.
            if (context.ClientId == null)
            {
                context.Validated();
            }

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            if (context.ClientId == _publicClientId)
            {
                Uri expectedRootUri = new Uri(context.Request.Uri, "/");

                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    context.Validated();
                }
            }

            return Task.FromResult<object>(null);
        }

        public static AuthenticationProperties CreateProperties(string userName)
        {
            IDictionary<string, string> data = new Dictionary<string, string>
            {
                { "userName", userName }
            };
            return new AuthenticationProperties(data);
        }
    }
}