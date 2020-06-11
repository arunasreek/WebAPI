using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
  public  class FileProcessStateLogAggregate
   {
        public int OrgnisationId { get; set; }
        public string UserId { get; set; }
        public List<ApprovalModel> FileActions { get; set; }
    }

    public class ApprovalModel
    {
        public int BusinessUnitId { get; set; }
        public int PeriodId { get; set; }
        public int FileId { get; set; }
        public int FileState { get; set; }
        public string Remarks { get; set; }
        public int ProcessState { get; set; }

    }
}
