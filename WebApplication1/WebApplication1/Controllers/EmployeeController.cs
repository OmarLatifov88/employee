using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contexts;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly TaskDbContext _context;

        public EmployeeController(TaskDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();

            return View(employees);
        }

        public IActionResult Detail(int id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}
