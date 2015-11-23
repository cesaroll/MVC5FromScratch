using System.Collections.Generic;
using System.Linq;
using Ces.Sch.Data.Interfaces;
using Ces.Sch.Models.Interfaces;
using Ces.Sch.Models.DependencyInversion;

namespace Ces.Sch.Data
{
    public class SubjectRepository : ISubjectRepository
    {
        private static List<ISubject> _subjects;

        public SubjectRepository()
        {
            if (_subjects == null)
            {
                _subjects = new List<ISubject>();
                
                AddNewSubject(ModelsDIConfig.Resolve<ISubject>(), 1, "Science", "Reactions", "Acids & Bases");
                AddNewSubject(ModelsDIConfig.Resolve<ISubject>(), 2, "Maths", "Geometry", "Algebra");
            }
        }

        private void AddNewSubject(ISubject subject, int id, string name, params string[] topics)
        {
            subject.Id = id;
            subject.Name = name;
            subject.Topics = topics.ToList<string>();

            _subjects.Add(subject);

        }

        public ISubject Get(int id)
        {
            return _subjects.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<ISubject> GetAll()
        {
            return _subjects;
        }
    }
}