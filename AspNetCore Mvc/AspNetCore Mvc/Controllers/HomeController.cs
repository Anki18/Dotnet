using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return new ContentResult {Content = "Hello from home controller"};
        }
    }
}