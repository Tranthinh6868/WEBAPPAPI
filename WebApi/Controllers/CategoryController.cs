using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : BaseController{
    [HttpGet]
    public List<Category> Categories(){
        return Provider.Category.GetCategories();
    }
    [HttpPost]
    public int Add(Category obj){
        return Provider.Category.Add(obj);
    }

    [HttpGet("{id}")]
    public Category? GetCategory(short id){
        return Provider.Category.GetCategory(id);
    }
    [HttpDelete("{id}")]
    public int Delete(short id){
        return Provider.Category.Delete(id);
    }
    [HttpPut("{id}")]
    public int Edit(Category obj){
        return Provider.Category.Edit(obj);
    }
}
