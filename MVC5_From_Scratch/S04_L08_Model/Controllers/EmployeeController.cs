using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using S04_L08_Repository;

namespace S04_L08_Model.Controllers
{
    public class EmployeeController : Controller
    {
        private IRepository _repo;
        public EmployeeController(IRepository repo)
        {
            _repo = repo;
        }

        // GET: Employee
        public string Get(int id)
        {
            //var employeeRepo = new PersonRepository(); //new EmployeeRepository();
            var employee = _repo.Get(id);
            string name = employee.Name;

            return string.Format("{0} : {1}", id, name);
        }
    }
}