using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Infrastructure.Logging.SerilogLogger.Contract
{
    public interface ICustomLogger
    {
        void Log(int Level,int UserId, int OrgId, string MessageTemplate, Exception ex); 
    }
}
