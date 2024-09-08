using Delt.DataAccess.Interfaces;
using Delt.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Delt.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _context;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<object> data = new List<object>();
            var headBooks = await _context.Book.GetAllAsync(3);
            var headBlogs = await _context.Blog.GetAllAsync(3);
            var headSeminars = await _context.Seminar.GetAllAsync(3);

            headBooks.ToList().ForEach(x => data.Add(x));
            headBlogs.ToList().ForEach(x => data.Add(x));
            headSeminars.ToList().ForEach(x => data.Add(x));

            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
