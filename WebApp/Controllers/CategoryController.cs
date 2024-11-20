using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;
public class CategoryController : BaseController{
    public async Task<IActionResult> Index() 
    => View(await Provider.Category.GetCategoriesAsync() );

[HttpPost]
public async Task<IActionResult> Add (Category obj){
    int ret = await Provider.Category.Add(obj);
        if(ret > 0){
            return Redirect("/category");
            }
        return Redirect("/category/error");
    }
}