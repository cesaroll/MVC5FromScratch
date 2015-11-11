using System.Collections.Generic;
using System.Linq;
using S04_L08_Models;

namespace S04_L08_Repository
{
    public class PersonRepository : IRepository
    {
        private static List<Employee> _employees;

        public PersonRepository()
        {
            _employees = new List<Employee>();
            _employees.Add(new Employee() { Id = 1, Name = "Michael", Surname = "Gregory" });
            _employees.Add(new Employee() { Id = 2, Name = "Jim", Surname = "Graham" });
        }

        public Employee Get(int id)
        {
            //return _employees.Where(e => e.Id == id).FirstOrDefault();
            return _employees.FirstOrDefault(e => e.Id == id);
        }
    }
}