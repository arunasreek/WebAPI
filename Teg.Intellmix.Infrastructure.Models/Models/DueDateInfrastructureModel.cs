using System.Collections.Generic;

namespace Esmart.Infrastructure.Models.Models
{
    public class DueDateInfrastructureModel
    {
        public List<CycleDetails> CycleDetails { get; set; }
        public Weeks Weeks { get; set; }
        public Days Days { get; set; }
        public Months Months { get; set; }
    }

    public class Selected
    {
        public bool IsSelected { get; set; }
    }

    public class CycleDetails : Selected
    {
        public int CycleId { get; set; }
        public string CycleType { get; set; }

    }

    public class StringEntities : Selected
    {
        public string Entity { get; set; }
    }

    public class Weeks
    {
        public List<StringEntities> WeeksList { get; set; }
    }

    public class Days
    {
        public List<StringEntities> DaysList { get; set; }
    }

    public class Months
    {
        public List<StringEntities> MonthsList { get; set; }
    }

    public class FileDueDateInfrastructureModel
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int BuId { get; set; }
        public int? OrgFileId { get; set; }
        public string WeekOfTheMonth { get; set; }
        public string DayOfTheWeek { get; set; }
        public string MonthOftheCycle { get; set; }
        public int ProcessState { get; set; }
        public bool IsActive { get; set; }
    }

}
