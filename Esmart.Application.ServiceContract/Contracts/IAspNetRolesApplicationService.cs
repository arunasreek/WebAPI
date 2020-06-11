using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Application.Models.Models;

namespace Esmart.Application.ServiceContract
{
    public interface IAspNetRolesApplicationService
    {
        Task<ApplicationResultModel> GetAspNetRolesAsync();
        Task<ApplicationResultModel> GetRolePrevilegesAsync(string roleId);
    }
}
