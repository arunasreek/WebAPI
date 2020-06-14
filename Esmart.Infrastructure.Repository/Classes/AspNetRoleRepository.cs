using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Data;
using Esmart.Infrastructure.Models;
using Esmart.Infrastructure.Models.Models;
using Esmart.Infrastructure.Repository.Utility;
using Esmart.Infrastructure.RepositoryContract.Interfaces;

namespace Esmart.Infrastructure.Repository.Classes
{
    public class AspNetRoleRepository : Repository<AspNetRole>, IAspNetRoleRepository
    {
        public AspNetRoleRepository(EsmartEntitiess context) : base(context)
        {
        }

        public async Task<IEnumerable<AspNetRoleInfrastructureModel>> GetAspNetRolesAsync()
        { 
            var myTask = Task.Run(async () =>
            {
                List<AspNetRoleInfrastructureModel> aspNetRoleList = new List<AspNetRoleInfrastructureModel>();
                
                
                foreach (AspNetRole aspNetRole in IntellmixContext.AspNetRoles.ToList())
                {                                      
                    aspNetRoleList.Add(new AspNetRoleInfrastructureModel()
                    {
                        Id = aspNetRole.Id,
                        Name = aspNetRole.Name
                    });
                }
                return aspNetRoleList;
            });
            return await myTask;
        }

        public EsmartEntitiess IntellmixContext
        {
            get { return Context as EsmartEntitiess; }
        }
    }
}