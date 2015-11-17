using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_Models;
using Employee_Repo;

namespace Employee_Web.Controllers
{
    public class EmployeeController : Controller
    {
        private IRepository<Employee> _employeeRepo;

        public EmployeeController(IRepository<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        // GET: Employee
        public string Employee(int id)
        {
            var employee = _employeeRepo.Get(id);
            string name = employee.Name;

            return string.Format("{0} : {1}", id, name);
        }
    }
}