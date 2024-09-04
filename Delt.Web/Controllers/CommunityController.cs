using Microsoft.AspNetCore.Mvc;

namespace Delt.Web.Controllers
{
    public class CommunityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
