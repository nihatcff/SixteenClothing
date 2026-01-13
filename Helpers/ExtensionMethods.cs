using System.Threading.Tasks;

namespace SixteenClothing.Helpers
{
    public static class ExtensionMethods
    {
        public static bool CheckSize(this IFormFile file, int mb)
        {
            return file.Length < mb * 1024 * 1024;
        } 

        public static bool CheckType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }

        public static async Task<string> FileUploadAsync(this IFormFile file, string folderpath)
        {
            string uniqueFileName = Guid.NewGuid().ToString() + file.FileName;
            string path = Path.Combine(folderpath, uniqueFileName);

            using FileStream stream = new(path, FileMode.Create);
            await file.CopyToAsync(stream);

            return uniqueFileName;
        }

        public static void FileDelete(String path)
        {
            if(File.Exists(path))
                { File.Delete(path); }
        } 
    }
}
