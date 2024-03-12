using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //Кнопка для Обработки нажатия
        [HttpPost]
        public ActionResult SubmitForm(string inputText)
        {

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SubmitText(string inputText)
        {
            ViewBag.OutputText = inputText;
            return View("Index");
        }
    }
}
