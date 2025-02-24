using Microsoft.AspNetCore.Mvc;

namespace MVC03_SampleProjectWithDotnetCLI.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

    }
}
