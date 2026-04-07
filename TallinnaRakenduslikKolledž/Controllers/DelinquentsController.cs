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
    }
}
