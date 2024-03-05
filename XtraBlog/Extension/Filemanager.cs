using XtraBlog.Model;

namespace XtraBlog.Extension
{
    public static class Filemanager
    {
        public static bool ContentType(this IFormFile file,string type)
        {
            return file.ContentType.Contains(type);
        }
        public static bool CheckLength(this IFormFile file,int size)
        {
            return  file.Length/1024 > size;
        }
        public async static Task<string>Fileupload(this IFormFile file,IWebHostEnvironment _environment,string folder)
        {

            string wwwRootPath = _environment.WebRootPath;
            string filePath = Path.Combine(wwwRootPath,folder);
            string filename = Guid.NewGuid() + "_" + file.FileName;
            string fullPath = Path.Combine(filePath, filename);


            using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return filename;
        }
    }
}
