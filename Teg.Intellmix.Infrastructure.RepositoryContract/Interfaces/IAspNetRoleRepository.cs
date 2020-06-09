using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Data;
using Esmart.Infrastructure.Models;
using Esmart.Infrastructure.Models.Models;

namespace Esmart.Infrastructure.RepositoryContract.Interfaces
{
    public interface IAspNetRoleRepository : IRepository<AspNetRole>
    {
        Task<IEnumerable<AspNetRoleInfrastructureModel>> GetAspNetRolesAsync();
    }
}
