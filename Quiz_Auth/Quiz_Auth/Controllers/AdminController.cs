using Microsoft.AspNetCore.Mvc;

namespace Quiz_Auth.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
