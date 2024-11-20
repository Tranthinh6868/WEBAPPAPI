using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class UploadController : BaseController{
    public IActionResult Index(){
        return View();
    }
    public IActionResult Add(){
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Add(IFormFile f){
        if( f != null){
          return   Json(await Provider.Upload.Post(f));
        }
        return Json(null);
    }
}