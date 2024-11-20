using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models;
[Table("Product")]
public class Product{
    [Column("ProductId")]
    public int Id {get; set;}
    [Column("ProductName")]
    public string Name {get; set;} = null!;
    public short CategoryId {get; set;}
    public string Description {get; set;} = null!;

    public decimal Price {get; set;}

    public short Quantity {get; set;}
    public string ImageUrl{get; set;} = null!;

}