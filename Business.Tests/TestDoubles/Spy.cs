using BusinessContracts.DbGateway;
using BusinessContracts.WorkingStatistics;
using System;

namespace Business.Tests.TestDoubles
{
    public class Spy : IDBGateway
    {
        public bool Connected { get; set; }
        public int Id { get; set; }
        private IWorkingStatistics _ws;

        public IWorkingStatistics GetWorkingStatistics(int id)
        {
            Id = id;
            if (id >= 5)
                Connected = true;
            return _ws;
        }

        public void SetWorkingStatistics(IWorkingStatistics ws)
        {
            _ws = ws;
        }
    }
}
