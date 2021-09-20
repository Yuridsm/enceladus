using BusinessContracts.DbGateway;
using BusinessContracts.WorkingStatistics;
using BusinessEntities.WorkStatisticEntity;
using System;
using System.Collections.Generic;

namespace Business.Tests.TestDoubles
{
    public class DbGatewayFake : IDbGateway
    {
        private Dictionary<int, IWorkingStatistics> _storage = new Dictionary<int, IWorkingStatistics>() 
        {
            { 1, new WorkingStatistics() { PayHourly = true, WorkingHours = 5, HourSalary = 10 } },
            { 2, new WorkingStatistics() { PayHourly = false, WorkingHours = 500 } },
            { 3, new WorkingStatistics() { PayHourly = true, WorkingHours = 5, HourSalary = 100 } },
            { 4, new WorkingStatistics() { PayHourly = false, WorkingHours = 20, HourSalary = 90 } }
        };
        public bool Connected => throw new NotImplementedException();

        public IWorkingStatistics GetWorkingStatistics(int id)
        {
            return _storage[id];
        }
    }
}
