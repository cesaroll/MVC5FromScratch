using System.Collections.Generic;
using System.Linq;
using Models.Interfaces;
using Models.Models;
using Repo.Interfaces;

namespace Repo.Repositories
{
    public class StudentRepository: IRepository<IStudent>
    {

        private static List<IStudent> _students;

        public StudentRepository()
        {
            _students = new List<IStudent>();
            _students.Add(new Student() { Id = 1, Name = "Mike", Surname = "Gregory", IsActive = true });
            _students.Add(new Student() { Id = 2, Name = "David", Surname = "Graham", IsActive = true});
            _students.Add(new Student() { Id = 3, Name = "Nancy", Surname = "Drew", IsActive = true});
            _students.Add(new Student() { Id = 4, Name = "Elizabeth", Surname = "Hughes", IsActive = false});

        }

        public IEnumerable<IStudent> GetAll()
        {
            return _students;
        }
        public IStudent Get(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }
    }
}