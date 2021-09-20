namespace BusinessContracts.Socket
{
    public interface ISocketOverNetwork
    {
        void SetHost(string host);
        void SetDNS(string dns);
        void sendMessage(byte[] message);
    }
}
