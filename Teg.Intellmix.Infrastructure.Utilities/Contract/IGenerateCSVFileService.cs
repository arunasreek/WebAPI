using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Data;

namespace Esmart.Infrastructure.Utilities.Contract
{
    public interface IGenerateCSVFileService
    {
        Task<string> CreateCSVLogFileAsync(string organisationName, string fileTypeName, string organisationPeriod, string businessUnitName, dynamic source);
        Task<string> CreateETLCSVFileAsync(string organisationName, string businessUnitName, string organisationPeriod, string etlFileGroupId);
    }
}
