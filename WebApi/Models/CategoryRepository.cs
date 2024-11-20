namespace WebApi.Models;

public class CategoryRepository: BaseRepository{
    public CategoryRepository(StoreContext context): base(context){

    }
    public List<Category> GetCategories(){
        return context.Categories.ToList();
    }
    public int Add ( Category obj){
        context.Categories.Add(obj);
        return context.SaveChanges();
    }
    public int Delete(short id){
        var obj = context.Categories.Find(id);
        if(obj is null)
        return 0;
        context.Categories.Remove(obj);
        return context.SaveChanges();
    }
    public int Edit(Category obj){
        context.Categories.Update(obj);
        return context.SaveChanges();
    }
    public Category? GetCategory(short id){
        return context.Categories.Find(id);
    }

}