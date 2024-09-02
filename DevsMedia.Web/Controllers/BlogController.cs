using Microsoft.AspNetCore.Mvc;

namespace DevsMedia.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
