using Microsoft.AspNetCore.Mvc;

namespace Proje04_MVCBasics.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        //Çok satan ürünler için bir Action ve View hazırlayıp test edin. (BestSellers)
        public IActionResult BestSellers()
        {
            return View();
        }
    }
}
