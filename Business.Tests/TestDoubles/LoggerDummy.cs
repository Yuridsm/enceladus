using BusinessContracts.Logger;

namespace Business.Tests.TestDoubles
{
    public class LoggerDummy : ILogger
    {
        public void Info(string s)
        {
            // Do nothing
        }
    }
}
