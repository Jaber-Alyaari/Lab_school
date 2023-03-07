using Lab_school.Models;
using Lab_school.repositories;
using Microsoft.AspNetCore.Mvc;

namespace Lab_school.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly IRepository<Subject> repository;  

        public SubjectsController(IRepository<Subject> repository)
        {
            this.repository = repository;
        }
        public IActionResult getall()
        {
           var f= repository.getall();
            return View(f);   
        }
        [HttpGet]
        public IActionResult add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add(Subject s)
        {
           var v= repository.add(s);
            return RedirectToAction("getall");
        }
        public IActionResult edit()
        {
            return View();
        }
    }
}
