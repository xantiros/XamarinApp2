using System.Threading.Tasks;

namespace XamarinApp2.Interfaces
{
    public interface IFileSystem
    {
        Task WriteTextAsync(string fileName, string text);
    }
}
