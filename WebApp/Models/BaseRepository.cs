namespace WebApp.Models;
public class BaseRepository{
        protected Uri uri;
        public BaseRepository(IConfiguration configuration) {
            uri = new Uri(configuration["Api:Url"] ?? throw new Exception("Not found Api:Url"));
        }
} 