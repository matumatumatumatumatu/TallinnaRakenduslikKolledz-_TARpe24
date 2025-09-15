using Microsoft.AspNetCore.Mvc;

namespace TallinnaRakenduslikKolledž.Controllers
{
    public class InstructorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
