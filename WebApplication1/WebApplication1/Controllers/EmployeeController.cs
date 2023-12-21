using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employees = employeeService.GetEmployees();
            return View(employees);
        }

        [HttpPost]
        public IActionResult Work(int employeeIndex, int days)
        {
            employeeService.Work(employeeIndex, days);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult TakeVacation(int employeeIndex, float days)
        {
            employeeService.TakeVacation(employeeIndex, days);
            return RedirectToAction("Index");
        }
    }
}
