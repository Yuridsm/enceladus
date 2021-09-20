using BusinessContracts.WorkingStatistics;

namespace BusinessContracts.DbGateway
{
    public interface IDbGateway
    {
        IWorkingStatistics GetWorkingStatistics(int id);
        bool Connected { get; }
    }
}
