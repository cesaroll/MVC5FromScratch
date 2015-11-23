using System.Collections.Generic;
using System.Linq;
using Ces.Sch.Data.Interfaces;
using Ces.Sch.Models.Enums;
using Ces.Sch.Models.Interfaces;
using Ces.Sch.Models.DependencyInversion;

namespace Ces.Sch.Data
{
    public class StudentRepository : IStudentRepository
    {
        private static List<IStudent> _students;

        public StudentRepository()
        {
            if (_students == null)
            {
                _students = new List<IStudent>();
                
                AddNewStudent(ModelsDIConfig.Resolve<IStudent>(), 1, "Mike", "Gregory", true, Course.MVC5);
                AddNewStudent(ModelsDIConfig.Resolve<IStudent>(), 2, "David", "Graham", true, Course.jQuery);
                AddNewStudent(ModelsDIConfig.Resolve<IStudent>(), 3, "Nancy", "Drew", true, Course.MVC5);
                AddNewStudent(ModelsDIConfig.Resolve<IStudent>(), 4, "Elizabeth", "Hughes", false, Course.HTML5);

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

        public IStudent Get(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<IStudent> GetAll()
        {
            return _students;
        }
    }
}