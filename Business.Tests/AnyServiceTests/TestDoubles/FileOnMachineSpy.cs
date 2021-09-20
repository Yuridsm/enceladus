using BusinessContracts.FileOnMachine;
using System.Text;

namespace Business.Tests.AnyServiceTests.TestDoubles
{
    public class FileOnMachineSpy : IFileOnMachine
    {
        public string Content { get; private set; }

        public void SetContent(string content)
        {
            Content = content;
        }

        public bool IsValid(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return false;
            return true;
        }

        public byte[] ReadFile(string path)
        {
            return Encoding.UTF8.GetBytes(Content);
        }

        public void Save(string text)
        {
            // Do nothing
        }

        public void SetDirectory(string path)
        {
            // Do nothing
        }

        public void SetFileName(string filename)
        {
            // Do nothing
        }
    }
}
