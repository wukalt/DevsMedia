using Delt.DataAccess.Interfaces;
using Delt.Models;
using Microsoft.AspNetCore.Mvc;
using Delt.Utility.Checkers;

namespace Delt.Web.Controllers
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

        public async Task<IActionResult> Manage()
        {
            IEnumerable<Blog> blogs = await _context.Blog.GetAllAsync();
            return View(blogs);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id.IsNullOrZero())
                return NotFound();

            var blog = await _context.Blog.GetAsync(blog => blog.Id == id);

            if (blog.IsNull())
                return NotFound();

            return View(blog);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Blog blog)
        {
            if (ModelState.IsValid)
            {
                await _context.Blog.Update(blog);
                await _context.Commit();
                TempData["success"] = "بلاگ با موفقیت ویرایش شد.";
                return RedirectToAction("Manage");
            }
            else
            {
                TempData["error"] = "در ویرایش بلاگ مشکلی پیش آمده.";
            }
            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int? id)
        {
            if (id.IsNullOrZero())
                return NotFound();

            var blog = await _context.Blog.GetAsync(blog => blog.Id == id);

            if (blog.IsNull())
                return NotFound();

            if (ModelState.IsValid)
            {
                await _context.Blog.Remove(blog);
                await _context.Commit();
                TempData["success"] = "بلاگ با موفقیت حذف شد";
            }

            return Json(new {success = true });
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Blog blog)
        {
            if (ModelState.IsValid)
            {
                await _context.Blog.Add(blog);
                await _context.Commit();
                TempData["success"] = "بلاگ با موفقیت افزوده شد.";
                return RedirectToAction("Manage");
            }
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id.IsNullOrZero())
                return NotFound();

            Blog blog = await _context.Blog.GetAsync(blog => blog.Id == id);

            if (blog.IsNull())
                return NotFound();

            return View(blog);
        }
    }
}
