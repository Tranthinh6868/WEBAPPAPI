using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models;
//default Categories
[Table("Category")]
public class Category{
    [Column("CategoryId")] // Viet vay la alias no tu map vao database
    public short Id {get; set;}
    [Column("CategoryName")]
    public string Name {get; set;} = null!;
}