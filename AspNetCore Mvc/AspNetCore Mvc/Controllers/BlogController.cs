using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Mvc.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        // GET
        [Route("{year:int}/{month:int}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
//            if (id == null)
//            {
//                return new ContentResult {Content = null};
//            }

            return new ContentResult {Content = $"year :{year} month: {month} post: {key}"};
        }
    }
}