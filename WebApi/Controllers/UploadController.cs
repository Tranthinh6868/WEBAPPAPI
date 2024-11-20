using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers;
[ApiController, Route("api/[controller]")]
public class UploadController : ControllerBase{
    [HttpPost]
    public string Post(IFormFile f){
        return Helper.Upload(f);
    }
}