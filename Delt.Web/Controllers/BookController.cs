using Delt.DataAccess.Interfaces;
using Delt.Models;
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
    }
}
