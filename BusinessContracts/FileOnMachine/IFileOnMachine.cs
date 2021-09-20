namespace BusinessContracts.FileOnMachine
{
    public interface IFileOnMachine
    {
        void Save(string text);
        void SetDirectory(string path);
        void SetFileName(string filename);
        bool IsValid(string path);
        byte[] ReadFile(string path);
    }
}
