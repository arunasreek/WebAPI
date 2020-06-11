using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Data;
using Esmart.Infrastructure.Models;
using Esmart.Infrastructure.RepositoryContract.Interfaces;

namespace Esmart.Infrastructure.Repository.Classes
{
    public class AspNetUsersRepository : Repository<AspNetUser>, IAspNetUsersRepository
    {
        public AspNetUsersRepository(esmartEntities context) : base(context)
        {
        }

        public esmartEntities IntellmixContext
        {
            get { return Context as esmartEntities; }
        }
    }
}
