using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Application.Models;
using Esmart.Application.Models.Models;
using Esmart.Application.ServiceContract;
using Esmart.Application.ServiceContract.Contracts;
using Esmart.Infrastructure.RepositoryContract.Interfaces;
using Esmart.Infrastructure.Resources;


namespace Esmart.Application.Services.Services
{
    public class AspNetRolesApplicationService : ServiceBase, IAspNetRolesApplicationService
    {
        private readonly IAspNetRoleRepository _aspNetRoleRepository;

        public AspNetRolesApplicationService(IAspNetRoleRepository aspNetRoleRepository)
        {
            _aspNetRoleRepository = aspNetRoleRepository;
        }

        public async Task<ApplicationResultModel> GetAspNetRolesAsync()
        {           
            List<AspNetRole> aspNetRoleList = new List<AspNetRole>();
                        
                var mytask = Task.Run(async () =>
                {
                    var aspNetRoles = (await _aspNetRoleRepository.GetAspNetRolesAsync());

                    foreach (var role in aspNetRoles)
                    {
                        aspNetRoleList.Add(new AspNetRole()
                        {
                            Id = role.Id,
                            Name = role.Name
                        });
                    }                    
                 
                    AspNetRolesApplicationModel aspNetRoleDetails = new AspNetRolesApplicationModel
                    {
                        Roles = aspNetRoleList
                    };

                    return new ApplicationResultModel { Success = true, Result = aspNetRoleDetails };
                });
                
                return await mytask;       
        }

        public async Task<ApplicationResultModel> GetRolePrevilegesAsync(string roleId)
        {
            List<RolePrevilege> rolePrevilegeList = new List<RolePrevilege>();
            var myTask = Task.Run(async () =>
            {                
                var role = (await _aspNetRoleRepository.Find(x => x.Id == roleId)).ToList();

                if (role.Count() == 0)
                {
                    return new ApplicationResultModel { Success = false, Error = ResourceStrings.RoleNotFound };
                }



                return new ApplicationResultModel { Success = true, Result = null };
            });
            return await myTask;
        }
    }
}
