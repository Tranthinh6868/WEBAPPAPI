namespace WebApi.Services;
public static class Helper{

    public static string RandomString(int len){
        string pattern = "12345789qryiupadhglzcmnb";
        char [] arr = new char[len];
        Random random= new Random();
        for (int i = 0; i < len ; i++){
            arr[i] = pattern[random.Next(0, pattern.Length)];
        }
        return string.Join(string.Empty, arr);
    }
    public static string Upload(IFormFile f,string root, string folder= "images", int len = 32){
        string ext = Path.GetExtension(f.FileName);
        string FileName = RandomString(len - ext.Length) + ext;
        using (Stream stream = new FileStream(Path.Combine(root, folder, FileName), FileMode.Create)){
            f.CopyTo(stream);
        }
        return FileName;
    }


    public static string Upload(IFormFile f, string folder= "images", int len = 32){
        string root = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        return Upload(f, root, folder, len);
    }


}