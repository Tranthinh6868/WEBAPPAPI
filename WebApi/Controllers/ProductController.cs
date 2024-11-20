using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;
namespace WebApi.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ProductController : BaseController{
    [HttpGet]
    public List<Product> GetProducts(){
        return Provider.Product.GetProducts();
    }
    [HttpPost]
    public int  Post(Product obj){
        
        if( ModelState.IsValid){

            return Provider.Product.Add(obj);
        }
        return -1;

    }
}

