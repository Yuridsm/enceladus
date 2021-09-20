using BusinessContracts.Logger;

namespace Business.Tests.AnyServiceTests.TestDoubles
{
    public class LoggerDummy : ILogger
    {
        public void Info(string s)
        {
            // Do nothing
        }
    }
}
