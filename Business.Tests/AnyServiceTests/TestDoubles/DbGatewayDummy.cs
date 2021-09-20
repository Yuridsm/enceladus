using BusinessContracts.DbGateway;
using BusinessContracts.WorkingStatistics;

namespace Business.Tests.AnyServiceTests.TestDoubles
{
    public class DbGatewayDummy : IDbGateway
    {
        public bool Connected { get; set; }
        public IWorkingStatistics GetWorkingStatistics(int id)
        {
            return null;
        }
    }
}
