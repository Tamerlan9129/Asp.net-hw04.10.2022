using Microsoft.AspNetCore.Mvc;

namespace Asp.net_hw04._10._2022.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Tamerlan";
            ViewBag.Surname = "Alimardanli";
            ViewBag.Age = 31;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "+994557623800";
            return View();
        }
    }
}
