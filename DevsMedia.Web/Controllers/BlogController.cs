using DevsMedia.DataAccess.Interfaces;
using DevsMedia.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevsMedia.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IUnitOfWork _context;

        public BlogController(IUnitOfWork context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Blog> blogs = await _context.Blog.GetAllAsync();
            return View(blogs);
        }
    }
}
