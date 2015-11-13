using System.Collections.Generic;
using System.Linq;
using Employee_Models;

namespace Employee_Repo
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private static List<Employee> _employees;
        private static object _employeesLock = new object();
        
        private List<Employee> Employees
        {
            get
            {
                if (_employees == null)
                {
                    lock (_employeesLock)
                    {
                        if (_employees == null)
                        {
                            _employees = new List<Employee>();
                            _employees.Add(new Employee() {Id = 1, Name = "Mike", MiddleName = "", Surname = "Gregory"});
                            _employees.Add(new Employee() {Id = 2, Name = "David", Surname = "Graham"});
                        }
                    }
                }

                return _employees;
            }
            
        }

        public Employee Get(int id)
        {
            return Employees.FirstOrDefault(e => e.Id == id);
        }
    }
}