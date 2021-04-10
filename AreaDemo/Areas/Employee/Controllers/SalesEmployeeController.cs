using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaDemo.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class SalesEmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        
        public IActionResult GetEmployeeListByLocation(int locationID)
        {
           Models.Employee[] employees = new Models.Employee[] {
                new Models.Employee
                {
                    ID = 1,
                    Name = "Robert",
                    Designation="Manager",
                    LocationID=1
                },
                new Models.Employee
                {
                    ID = 2,
                    Name = "Steve",
                    Designation="Developer",
                    LocationID=1
                },
                new Models.Employee
                {
                    ID = 3,
                    Name = "Rajan",
                    Designation="CEO",
                    LocationID=2
                },
            };
            Models.Employee[] empList = 
                employees.Where(item => item.LocationID == locationID).ToArray();
            return View(empList);
        }
    }
}
