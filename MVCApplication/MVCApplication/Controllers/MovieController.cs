using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class MovieController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return
            View();
        }
    }
}