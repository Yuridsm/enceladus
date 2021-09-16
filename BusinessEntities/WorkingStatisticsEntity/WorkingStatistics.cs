using BusinessContracts.WorkingStatistics;

namespace BusinessEntities.WorkStatisticEntity
{
    public class WorkingStatistics : IWorkingStatistics
    {
        public decimal HourSalary { get; set; }
        public int WorkingHours { get; set; }
        public decimal MonthSalary { get; set; }
        public bool PayHourly { get; set; }
    }
}
