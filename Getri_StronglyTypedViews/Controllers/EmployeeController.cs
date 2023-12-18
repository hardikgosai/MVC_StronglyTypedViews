using Getri_StronglyTypedViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace Getri_StronglyTypedViews.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee emp = new Employee()
            {
                EmpId = 1,
                EmpName = "John",
                EmpSal = 10000
            };

            return View(emp);            
        }
    }
}
