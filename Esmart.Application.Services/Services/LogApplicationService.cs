using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teg.Intellmix.Application.ServiceContract;
using Teg.Intellmix.Infrastructure.Logging.SerilogLogger.Contract;
using Teg.Intellmix.Infrastructure.UOWContract;

namespace Teg.Intellmix.Application.Services
{
    public class LogService : ServiceBase, ILogService
    {
        public readonly ICustomLogger _customLogger;
        public LogService(ICustomLogger customLogger)
        {
            _customLogger = customLogger;
        }
      
        public void AddLog(int Level, int UserId, int OrgId, string MessageTemplate, Exception ex)
        {
            _customLogger.Log( Level,  UserId,  OrgId,  MessageTemplate, ex);
                        
        }
    }
}
