using BusinessContracts.Logger;
using System.IO;

namespace DataModel
{
    public class Logger : ILogger
    {
        public void Info(string s)
        {
            File.WriteAllText(@"C:\log.txt", s);
        }
    }
}
