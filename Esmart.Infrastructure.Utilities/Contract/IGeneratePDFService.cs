using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Esmart.Infrastructure.Utilities.Contract
{
    public interface IGeneratePDFService
    {
        Task<string> CreatePDFAsync(int organisationId, int uploadedFileDetailsId, int uploadedFileRevisionNo, string filePath);
    }
}
