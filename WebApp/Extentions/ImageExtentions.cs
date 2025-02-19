public class ImageExtention
{
    public static void SaveToServer(IFormFile form , string path)
    {
        path = path +'\\'+form.FileName;
        byte[] file;
        using(var stream = form.OpenReadStream())
        {
            using(MemoryStream ms = new MemoryStream())
            {
                ms.CopyTo(ms);
                file = ms.ToArray();
            }
        }
        File.WriteAllBytes(path,file);
    }
}