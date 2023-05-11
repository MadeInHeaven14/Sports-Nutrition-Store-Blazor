using BlazorInputFile;

namespace Sports_Nutrition_Store_Blazor.Data
{
    public interface IFileUpload
    {
        Task Upload(IFileListEntry file);
    }
}
