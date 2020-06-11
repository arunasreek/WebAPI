using Serilog;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Logging.SerilogLogger.Contract;


namespace Esmart.Infrastructure.Logging.SerilogLogger.Logger
{
    public class CustomLogger : ICustomLogger
    {

        private readonly ILogger _log;

        public CustomLogger(ILogger log)
        {
            _log = log;
        }

       // Earlier one [without serilog logging]
        //public void Log(int Level, int OrgId, string Message, string CustomMessage, string StackTrace, DateTime CreatedDate)
        //{
        //    throw new NotImplementedException();
        //}

        public void Log(int Level, int UserId, int OrgId, string MessageTemplate, Exception ex)
        {
            switch (Level)
            {
                case 1:
                    _log.Information(ex, MessageTemplate, UserId, OrgId);
                    break;
                case 2:
                    _log.Warning(ex, MessageTemplate, UserId, OrgId);
                    break;
                case 3:
                    _log.Error(ex, MessageTemplate, UserId, OrgId);
                    break;
                case 4:
                    _log.Fatal(ex, MessageTemplate, UserId, OrgId);
                    break;
                default:
                    _log.Error(ex, MessageTemplate, UserId, OrgId);
                    break;
            }
               
        }
    }
}
