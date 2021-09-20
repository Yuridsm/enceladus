using BusinessContracts.Socket;

namespace Business.Tests.AnyServiceTests.TestDoubles
{
    public class SocketOverNetworkDummy : ISocketOverNetwork
    {
        public void sendMessage(byte[] message)
        {
            // do nothing
        }

        public void SetDNS(string dns)
        {
            // do nothing
        }

        public void SetHost(string host)
        {
            // do nothing
        }
    }
}
