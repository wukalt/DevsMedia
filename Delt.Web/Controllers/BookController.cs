using Delt.DataAccess.Interfaces;
using Delt.Models;
using Delt.Utility.Checkers;
using Microsoft.AspNetCore.Mvc;

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
    }
}
