using BusinessContracts.WorkingStatistics;

namespace BusinessContracts.DbGateway
{
    public interface IDBGateway
    {
        IWorkingStatistics GetWorkingStatistics(int id);
        bool Connected { get; }
    }
}
