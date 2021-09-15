using Microsoft.AspNetCore.Mvc;

namespace OrderBin.Modules.Products.Api.Controllers
{
    [Route("products")]
    internal class HomeController : ControllerBase
    {
       [HttpGet]
        public ActionResult<string> Get() => "Product API";
    }
}