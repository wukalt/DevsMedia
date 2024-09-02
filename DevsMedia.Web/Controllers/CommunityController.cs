using Microsoft.AspNetCore.Mvc;

namespace DevsMedia.Web.Controllers
{
    public class CommunityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
