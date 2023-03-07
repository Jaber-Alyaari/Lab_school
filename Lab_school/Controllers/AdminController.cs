using Microsoft.AspNetCore.Mvc;

namespace Lab_school.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult dashboard()
        {
            return View();
        }
    }
}
