﻿using BusinessContracts.DbGateway;
using BusinessContracts.WorkingStatistics;
using System;

namespace Business.Tests.TestDoubles
{
    public class DbGatewayStub : IDBGateway
    {
        private IWorkingStatistics _ws;
        public bool Connected => false;

        public IWorkingStatistics GetWorkingStatistics(int id)
        {
            return _ws;
        }

        public void SetWorkingStatistics(IWorkingStatistics ws)
        {
            _ws = ws;
        }
    }
}
