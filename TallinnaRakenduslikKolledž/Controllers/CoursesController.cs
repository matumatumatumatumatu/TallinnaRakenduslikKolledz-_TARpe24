﻿using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikKolledž.Data;

namespace TallinnaRakenduslikKolledž.Controllers
{
    public class CoursesController : Controller
    {

        private readonly SchoolContext _context;
        public CoursesController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var courses = _context.Courses.Include(c => c.Department)
                .AsNoTracking();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            PopulateDepartmentsDropDownList();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }
            var courses = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
            .FirstOrDefaultAsync(m => m.CourseID == id);
            if (courses == null)
            {
                return NotFound();
            }
            return View(courses);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (int id)
        {
            if(_context.Courses == null)
            {
                return NotFound();
            }
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private void PopulateDepartmentsDropDownList(object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Departments
                                   orderby d.Name
                                   select d;
            ViewBag.DepartmentID = new SelectList(departmentsQuery.AsNoTracking(), "DepartmentID","Name",selectedDepartment);
        }

    }
}
