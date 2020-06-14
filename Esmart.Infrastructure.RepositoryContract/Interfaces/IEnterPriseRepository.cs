using Esmart.Application.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Infrastructure.RepositoryContract.Interfaces
{
   public interface IEnterPriseRepository
    {
        dynamic GetEnterPriseListForAll(long ep_id);
    }
}
