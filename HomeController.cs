using Microsoft.AspNetCore.Mvc;
using WebHelloPerson.Models;

namespace WebHelloPerson.Controllers
{
    public class HomeController : Controller
    {
            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Index(CPerson person)
            {
                ViewBag.Message = $"Hello, {person.Name}!";
                return View(person);
            }
    }
}
