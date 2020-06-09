using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Data;
using Esmart.Infrastructure.RepositoryContract.Interfaces;

namespace Esmart.Infrastructure.Repository.Classes
{
	public class AspNetUserRolesRepository : Repository<AspNetUserRole>, IAspNetUserRolesRepository
	{
		public AspNetUserRolesRepository(esmartEntities context) : base(context)
		{
		}

		public esmartEntities EsmartEntities
		{
			get { return Context as esmartEntities; }
		}

		public async Task<List<string>> GetUsersRoles(string UserId, bool ActiveRoles = true)
		{
			var myTask = Task.Run(async () =>
			{
				using (var context = new esmartEntities())
				{

					return context.AspNetUserRoles
								  .Join(context.AspNetRoles,
									ur => ur.RoleId,
									r => r.Id,
									(ur, r) => new { UR = ur, R = r })
								  .Where(x => x.UR.IsActive == ActiveRoles && x.UR.UserId== UserId)
								  .Select(x => new { Role = x.R.Name }).ToList();
				}

			});

			var result = await myTask;
			List<string> lst = new List<string>();
			foreach (var obj in result)
			{
				lst.Add(obj.Role.ToString());
			}
			return lst;
		}
	}
}
