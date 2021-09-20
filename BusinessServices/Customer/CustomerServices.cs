using BusinessContracts.DbGateway;
using BusinessContracts.Logger;
using BusinessContracts.WorkingStatistics;

namespace BusinessServices.Customer.CustomerServices
{
    public class CustomerServices
    {
        private readonly IDbGateway _gateway;
        private readonly ILogger _logger;

        public CustomerServices(IDbGateway gateway, ILogger logger)
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
            catch
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
