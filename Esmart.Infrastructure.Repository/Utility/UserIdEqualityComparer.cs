using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Models.Models;

namespace Esmart.Infrastructure.Repository.Utility
{
    public class UserIdEqualityComparer: IEqualityComparer<UserInfrastructureModel>
    {
        public bool Equals(UserInfrastructureModel x, UserInfrastructureModel y)
        {
            bool result = x.Id == y.Id;
            return result;
        }

        public int GetHashCode(UserInfrastructureModel obj)
        {
            return obj.Id.GetHashCode();
        }
    }

	public class RoleIdEqualityComparer : IEqualityComparer<RolesInfrastructureModel>
	{
		public bool Equals(RolesInfrastructureModel x, RolesInfrastructureModel y)
		{
			bool result = x.Id == y.Id;
			return result;
		}

		public int GetHashCode(RolesInfrastructureModel obj)
		{
			return obj.Id.GetHashCode();
		}
	}
}
