using Delt.DataAccess.Interfaces;
using Delt.Models;
using Delt.Utility.Checkers;
using Microsoft.AspNetCore.Mvc;

namespace Delt.Web.Controllers
{
    public class SeminarController : Controller
    {
        private readonly IUnitOfWork _context;

        public SeminarController(IUnitOfWork context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Seminar> seminars = await _context.Seminar.GetAllAsync();
            return View(seminars);
        }

        public async Task<IActionResult> Manage()
        {
            IEnumerable<Seminar> seminars = await _context.Seminar.GetAllAsync();
            return View(seminars);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id.IsNullOrZero())
                return NotFound();

            var seminar = await _context.Seminar.GetAsync(seminar => seminar.Id == id);

            if (seminar.IsNull())
                return NotFound();

            return View(seminar);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Seminar seminar)
        {
            if (ModelState.IsValid)
            {
                await _context.Seminar.Update(seminar);
                await _context.Commit();
                TempData["success"] = "سمینار با موفقیت ویرایش شد.";
                return RedirectToAction("Manage");
            }
            TempData["error"] = "در ویرایش سمینار مشکلی پیش آمده.";
            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int? id)
        {
            if (id.IsNullOrZero())
                return NotFound();

            var seminar = await _context.Seminar.GetAsync(seminar => seminar.Id == id);

            if (seminar.IsNull())
                return NotFound();

            if (ModelState.IsValid)
            {
                await _context.Seminar.Remove(seminar);
                await _context.Commit();
                TempData["success"] = "سمینار با موفقیت حذف شد";
            }

            return Json(new { success = true });
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Seminar seminar)
        {
            if (ModelState.IsValid)
            {
                await _context.Seminar.Add(seminar);
                await _context.Commit();
                TempData["success"] = "سمینار با موفقیت افزوده شد.";
                return RedirectToAction("Manage");
            }
            TempData["error"] = "در افزودن سمینار مشکلی پیش آمد.";
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id.IsNullOrZero())
                return NotFound();

            Seminar seminar = await _context.Seminar.GetAsync(seminar => seminar.Id == id);

            if (seminar.IsNull())
                return NotFound();

            return View(seminar);
        }
    }
}
