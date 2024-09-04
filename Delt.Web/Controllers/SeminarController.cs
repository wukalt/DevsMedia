using Microsoft.AspNetCore.Mvc;

namespace Delt.Web.Controllers
{
    public class SeminarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
