using BlazorInputFile;
using System.Runtime.CompilerServices;

namespace Sports_Nutrition_Store_Blazor.Data
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _oWebHostEnvironment;

        public FileUpload(IWebHostEnvironment oWebHostEnvironment)
        {
            _oWebHostEnvironment = oWebHostEnvironment;
        }

        public async Task Upload(IFileListEntry file)
        {
            var path = Path.Combine(_oWebHostEnvironment.ContentRootPath, "C:\\Users\\Артур\\source\\repos\\Sports Nutrition Store Blazor\\Sports Nutrition Store Blazor\\wwwroot\\ProductImages\\", file.Name);
            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(fs);
            }
        }
    }
}
