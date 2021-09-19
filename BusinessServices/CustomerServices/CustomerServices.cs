using BusinessContracts.DbGateway;
using BusinessContracts.Logger;
using BusinessContracts.WorkingStatistics;
using System;

namespace BusinessServices.CustomerServices
{
    public class CustomerServices
    {
        private readonly IDBGateway _gateway;
        private readonly ILogger _logger;

        public CustomerServices(IDBGateway gateway, ILogger logger)
        {
            _gateway = gateway;
            _logger = logger;
        }

        public decimal CalculateWage(int id)
        {
            //if (!_gateway.Connected)
            //{
            //    return 0;
            //}
            IWorkingStatistics ws = null;
            try
            {
                ws = _gateway.GetWorkingStatistics(id);
            }
            catch (Exception ex)
            {
                return 0;
            }
            decimal wage;
            if (ws.PayHourly)
            {
                wage = ws.WorkingHours * ws.HourSalary;
            }
            else
            {
                wage = ws.MonthSalary;
            }
            _logger.Info($"Customer ID={id}, Wage:{wage}");

            return wage;
        }

    }
}
