namespace WebApp.Models;
public class CategoryRepository : BaseRepository{
    public CategoryRepository(IConfiguration configuration) : base(configuration){

    }
    public async Task<List<Category>?>  GetCategoriesAsync(){
        using HttpClient client = new HttpClient{BaseAddress = uri};
        return await client.GetFromJsonAsync<List<Category>>("/api/category");
    }
    public async Task<int> Add(Category obj){
        using HttpClient client = new HttpClient{BaseAddress = uri};
        var response = await client.PostAsJsonAsync("/api/category", obj);
        if(response.IsSuccessStatusCode){
            return await response.Content.ReadFromJsonAsync<int>();
        }
        return -1;
    }
}