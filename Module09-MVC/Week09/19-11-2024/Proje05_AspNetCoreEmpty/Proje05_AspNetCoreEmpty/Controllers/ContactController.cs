using Microsoft.AspNetCore.Mvc;
using Proje05_AspNetCoreEmpty.Models;

namespace Proje05_AspNetCoreEmpty.Controllers
{
    public class ContactController : Controller
    {
        private readonly Contact _contact;
        public ContactController()
        {
            _contact = new()
            {
                Email="info@kitapapp.com",
                PhoneNumber="+90 555 889 66 99",
                Address="Elalmış Caddesi No:34 Ataşehir İstanbul",
                GoogleMap= "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3008.095105412389!2d28.99570407551702!3d41.06691371581312!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab7913b7b9b3f%3A0x154c9d69c759851e!2zSW5mb3RlY2ggQWNhZGVteSBZYXrEsWzEsW0gS3Vyc3UgKMWeacWfbGkvTWVjaWRpeWVrw7Z5IMWedWJlKQ!5e0!3m2!1str!2str!4v1732015740069!5m2!1str!2str\" width=\"600\" height=\"400\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>"
            };
        }
        public IActionResult Index()
        {
            //_contact değişkeninin içindeki bilgileri, ViewBag içindeki ContactInfo adlı bölümün içine koyarak View'e yolluyoruz.
            ViewBag.ContactInfo=_contact;
            return View();
        }
    }
}
