using Delt.DataAccess.Interfaces;
using Delt.Models;
using Delt.Utility.Checkers;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Delt.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IUnitOfWork _context;

        public BookController(IUnitOfWork context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Book> books = await _context.Book.GetAllAsync();
            return View(books);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id.IsNullOrZero())
                return NotFound();

            Book book = await _context.Book.GetAsync(book => book.Id == id);

            if (book.IsNull())
                return NotFound();

            return View(book);
        }

        public async Task<IActionResult> Manage()
        {
            IEnumerable<Book> books = await _context.Book.GetAllAsync();
            return View(books);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id.IsNullOrZero())
                return NotFound();

            Book book = await _context.Book.GetAsync(book => book.Id == id);

            if (book.IsNull())
                return NotFound();

            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Book book)
        {
            if (ModelState.IsValid)
            {
                await _context.Book.Update(book);
                await _context.Commit();
                TempData["success"] = "کتاب با موفقیت ویرایش شد.";
                return RedirectToAction("Manage");
            }
            else
            {
                TempData["error"] = "در ویرایش کتاب مشکلی پیش آمد.";
            }
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Book book)
        {
            if (ModelState.IsValid)
            {
                await _context.Book.Add(book);
                await _context.Commit();
                TempData["success"] = "کتاب با موفقیت افزوده شد.";
                return RedirectToAction("Manage");
            }
            TempData["error"] = "در افزودن کتاب مشکلی پیش آمده.";
            return View();
        }

        public async Task<IActionResult> Remove(int? id)
        {
            if (id.IsNullOrZero())
                return NotFound();

            Book book = await _context.Book.GetAsync(book => book.Id == id);

            if (book.IsNull())
                return NotFound();

            if (ModelState.IsValid)
            {
                await _context.Book.Remove(book);
                await _context.Commit();
                TempData["success"] = "کتاب با موفقیت حذف شد.";
            }
            return Json(new { success = true });
        }
    }
}
