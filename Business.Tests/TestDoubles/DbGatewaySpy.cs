using BusinessContracts.DbGateway;
using BusinessContracts.WorkingStatistics;

namespace Business.Tests.TestDoubles
{
    public class DbGatewaySpy : IDbGateway
    {
        public bool Connected { get; private set; }
        public int Id { get; private set; }
        private IWorkingStatistics _ws;

        public IWorkingStatistics GetWorkingStatistics(int id)
        {
            Id = id; // Save the information here
            
            if (id < 0)
            {
                Connected = false;
            } else
            {
                Connected = true;
            }

            return _ws;
        }

        public void SetWorkingStatistics(IWorkingStatistics ws)
        {
            _ws = ws;
        }
    }
}
