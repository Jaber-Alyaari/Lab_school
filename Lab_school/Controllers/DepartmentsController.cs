using Microsoft.AspNetCore.Mvc;

namespace Lab_school.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult departments()
        {
            return View();
        }
        public IActionResult add()
        {
            return View();
        }
        public IActionResult edit()
        {
            return View();
        }
    }
}
