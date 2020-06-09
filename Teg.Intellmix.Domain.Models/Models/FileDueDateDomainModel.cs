namespace Esmart.Domain.Models.Models
{
    public class FileDueDateDomainModel
    {
        public int OrganisationId { get; set; }
        public int BusinessUnitId { get; set; }
        public int ProcessState { get; set; }
        public int FileId { get; set; }
        public int PeriodId { get; set; }
        public string WeekOfTheMonth { get; set; }
        public string DayOfTheWeek { get; set; }
        public string MonthOfTheCycle { get; set; }
        public string CreatedBy { get; set; }
    }
}
