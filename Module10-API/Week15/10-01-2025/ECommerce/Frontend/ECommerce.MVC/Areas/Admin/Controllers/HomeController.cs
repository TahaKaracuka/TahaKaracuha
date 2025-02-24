using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="AdminUser")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult GetProducts()
        {
            return View();
        }

        public IActionResult GetProducts1()
        {
            return View();
        }

        [Authorize(Roles ="NormalUser")]
        public IActionResult GetProduct21()
        {
            return View();
        }
    }
}