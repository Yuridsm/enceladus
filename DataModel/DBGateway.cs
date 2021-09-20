using BusinessContracts.DbGateway;
using BusinessContracts.WorkingStatistics;

namespace DataModel
{
    public class DBGateway : IDbGateway
    {
        public bool Connected { get; }

        public IWorkingStatistics GetWorkingStatistics(int id)
        {
            //A real gateway can experience any possible problems
            //like "no connection" throwing an exception
            throw new NoConnection();
        }
    }
}
