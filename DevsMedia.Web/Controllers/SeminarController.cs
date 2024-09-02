using Microsoft.AspNetCore.Mvc;

namespace DevsMedia.Web.Controllers
{
    public class SeminarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
