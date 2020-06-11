using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Data;

namespace Esmart.Infrastructure.RepositoryContract.Interfaces
{
	public interface IAspNetUserRolesRepository : IRepository<AspNetUserRole>
	{
		Task<List<string>> GetUsersRoles(string UserId, bool ActiveRoles = true);

	}
}
