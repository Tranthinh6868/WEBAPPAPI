using Microsoft.EntityFrameworkCore;

namespace WebApi.Models;

public class StoreContext : DbContext{
    public StoreContext(DbContextOptions options): base(options){

    } 
    public DbSet<Category> Categories {get; set;}
    public DbSet<Product> Products {get; set;}

}