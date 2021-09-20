using BusinessContracts.FileOnMachine;
using System.Text;

namespace DataModel
{
    public class FileOnMachine : IFileOnMachine
    {
        public void Save(string text)
        {
            // Do nothing
        }

        public bool IsValid(string path)
        {
            if (!string.IsNullOrWhiteSpace(path))
                return true;
            return false;
        }

        public void SetDirectory(string path)
        {
            // Do nothing
        }

        public void SetFileName(string filename)
        {
            // Do nothing
        }

        public byte[] ReadFile(string path)
        {
            if (!IsValid(path)) return null;

            const string content = "You Are A Software Developer";
            byte[] data = Encoding.UTF8.GetBytes(content);

            return data;
        }
    }
}
