using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikKolledž.Data;
using TallinnaRakenduslikKolledž.Models;

namespace TallinnaRakenduslikKolledž.Controllers
{
    public class DelinquentsController : Controller
    {
        private readonly SchoolContext _context;
        public DelinquentsController(SchoolContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Delinquents.ToListAsync());
        }
        [HttpGet]
        public IActionResult Create()
        {
            var delinquent = new Delinquents();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Delinquents delinquent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(delinquent);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(delinquent);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var delinquent = await _context.Delinquents.FindAsync(id);
            return View(delinquent);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var delinquent = await _context.Delinquents.FindAsync(id);
            return View(delinquent);
        }
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit([Bind("DelinquentsID,FirstName,LastName,Violation,Instructor,Details")] Delinquents delinquent)
        {
            if (ModelState.IsValid)
            {
                _context.Delinquents.Update(delinquent);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(delinquent);

        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }
            var deleteableDelinquent = await _context.Delinquents
                .FirstOrDefaultAsync(s => s.DelinquentsID == id);
            if (deleteableDelinquent == null)
            {
                return NotFound();
            }
            return View(deleteableDelinquent);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Delinquents deleteableDelinquent = await _context.Delinquents
                .SingleAsync(i => i.DelinquentsID == id);
            _context.Delinquents.Remove(deleteableDelinquent);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
