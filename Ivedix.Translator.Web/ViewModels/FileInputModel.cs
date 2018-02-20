using Microsoft.AspNetCore.Http;

namespace Ivedix.Translator.Web.ViewModels
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
