using System.Collections.Generic;
using System.Linq;
using Models.Interfaces;
using Models.Models;
using Repo.Config;
using Repo.Interfaces;

namespace Repo.Repositories
{
    public class StudentRepository: IRepository<IStudent>
    {

        private static List<IStudent> _students;

        public StudentRepository()
        {
            if (_students == null)
            {
                _students = new List<IStudent>();

                var ucc = UnityConfig.getInstance(); //Get Unity Config Container access

                AddNewStudent(ucc.Resolve<IStudent>(), 1, "Mike", "Gregory", true, Course.MVC5);
                AddNewStudent(ucc.Resolve<IStudent>(), 2, "David", "Graham", true, Course.jQuery);
                AddNewStudent(ucc.Resolve<IStudent>(), 3, "Nancy", "Drew", true, Course.MVC5);
                AddNewStudent(ucc.Resolve<IStudent>(), 4, "Elizabeth", "Hughes", false, Course.HTML5);

            }
            
        }

        private void AddNewStudent(IStudent student, int id, string name, string surname, bool isactive, Course course)
        {
            student.Id = id;
            student.Name = name;
            student.Surname = surname;
            student.IsActive = isactive;
            student.Course = course;

            _students.Add(student);
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