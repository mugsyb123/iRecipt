using System.IO;
using System.Threading.Tasks;

namespace iRecipt
{
    public interface ImageUpload
    {
        Task<Stream> GetImageStreamAsync();
    }
}
