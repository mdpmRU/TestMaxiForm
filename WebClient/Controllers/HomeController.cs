using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DataService;
using Entities;
using WebClient.Models;
using RepositoriesSQL;
using Microsoft.AspNetCore.Components.Forms;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        private DepartmentRepository _departmentRepository = new();
        private EmployeeRepository _employeeRepository = new();
        private PositionRepository _positionRepository = new();
        private Service service;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            this.service = new(_employeeRepository, _positionRepository, _departmentRepository);
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


        
        [HttpPost]
        public ActionResult SubmitForm(string inputText)
        {

            return RedirectToAction("Index");
        }

        //Кнопка для Обработки нажатия
        [HttpPost]
        public IActionResult SubmitText(string inputText)
        {
            int employeeId;
            if (!Int32.TryParse(inputText, out employeeId))
            {
                ViewBag.OutputText = "Что-то пошло не так. Значение не распознается";
            }
            else
            {
                var lastName = service.GetEmployeeById(employeeId).LastName;
                ViewData.Model = service.GetbyLastNameEmployees(lastName);
            }
            return View("Index");
        }
    }
}
