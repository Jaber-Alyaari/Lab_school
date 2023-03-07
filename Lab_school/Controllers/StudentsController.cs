
using Lab_school.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lab_school.Controllers
{
    public class StudentsController : Controller
    {
        private SchoolDBContext _context;
        public StudentsController(SchoolDBContext context)
        {
            _context = context;
        }
        public IActionResult dashboard()
        {
            return View();
        }
        public IActionResult students()
        {
            List<Student> students = new List<Student>();
            students = _context.Students.ToList();

            return View(students);
        }
      
        public IActionResult details(int id)
        {
            // Student  students = _context.Students.Find(id);
            List<Student> students = _context.Students.Where(s => s.Id == id).ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add( Student s)
        {
            if(!ModelState.IsValid)
            {
                return View(s);
            }

            else
            {
                _context.Students.Add(s);
                _context.SaveChanges();
                return RedirectToAction(nameof(students));
               // return RedirectToAction("students");


            }
        }

        [HttpGet]
        public IActionResult edit(int id)
        {
            Student students = _context.Students.Find(id);
            return View(students);
        }
        [HttpPost]
        public IActionResult edit(Student s)
        {
             _context.Students.Update(s);
            return RedirectToAction("students");
        }
        public IActionResult delate(int id)
        {

            Student students = _context.Students.Find(id);
            _context.Students.Remove(students);
            _context.SaveChanges();
                return RedirectToAction("students");
        }

        public IActionResult search (string? search_name,int? search_id,int search_phone) {
            List<Student> students = null;
            if (search_name != null)
            {
                 students = _context.Students.Where(s => s.Fname == search_name).ToList();
            }
            else if  (search_id != null)
            {
                students = _context.Students.Where(s => s.Id == search_id).ToList();
            }
            else if (search_phone != null)
            {
                students = _context.Students.Where(s => s.Phone == search_phone).ToList();
            }
            return View("students", students);
        }
    }
}
