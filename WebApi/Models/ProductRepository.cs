namespace WebApi.Models;
public class ProductRepository : BaseRepository {
    public ProductRepository(StoreContext context) : base(context){}
    public List<Product> GetProducts(){
        return context.Products.ToList();
    }
    public int Add(Product obj){
        context.Products.Add(obj);
        return context.SaveChanges();
    }

    public int Edit(Product obj){
        context.Products.Update(obj);
        return context.SaveChanges();
    }
    public int Delete(int  id){
        context.Products.Remove(new Product{Id = id});
        //context.Products.Remove(context.Products.Find(id)!);
        return context.SaveChanges();
    }
    
    
}