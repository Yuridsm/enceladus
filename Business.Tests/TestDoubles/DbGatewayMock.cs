using BusinessContracts.DbGateway;
using BusinessContracts.WorkingStatistics;

namespace Business.Tests.TestDoubles
{
    public class DbGatewayMock : IDbGateway
    {
        public bool Connected => false;
        public int Id { get; set; }
        private IWorkingStatistics _ws;

        public IWorkingStatistics GetWorkingStatistics(int id)
        {
            Id = id;
            return _ws;
        }

        public void SetWorkingStatistics(IWorkingStatistics ws)
        {
            _ws = ws;
        }

        public bool VerifyCalledWithProperId(int id)
        {
            return Id == id;
        }

    }
}
