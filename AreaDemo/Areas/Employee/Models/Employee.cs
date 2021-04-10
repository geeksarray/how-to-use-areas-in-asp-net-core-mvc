using AreaDemo.Areas.Departments.Models;
using System.Data;

namespace AreaDemo.Areas.Employee.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int LocationID { get; set; }
    }
}
