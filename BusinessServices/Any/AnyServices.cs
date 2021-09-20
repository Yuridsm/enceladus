using BusinessContracts.DbGateway;
using BusinessContracts.FileOnMachine;
using BusinessContracts.Logger;
using BusinessContracts.Socket;

namespace BusinessServices.Any
{
    public class AnyServices
    {
        private readonly IDbGateway _gateway;
        private readonly ILogger _logger;
        private readonly IFileOnMachine _fileOnMachine;
        private readonly ISocketOverNetwork _socketOverNetwork;

        public AnyServices(IDbGateway gateway, ILogger logger, IFileOnMachine fileOnMachine, ISocketOverNetwork socketOverNetwork)
        {
            _gateway = gateway;
            _logger = logger;
            _fileOnMachine = fileOnMachine;
            _socketOverNetwork = socketOverNetwork;
        }

        public bool WriteOnFile(string filepath, string content)
        {
            if (!_fileOnMachine.IsValid(filepath)) return false;

            if (!string.IsNullOrWhiteSpace(content))
            {
                _fileOnMachine.Save(content);

                return true;
            }

            return false;
        }
    }
}
