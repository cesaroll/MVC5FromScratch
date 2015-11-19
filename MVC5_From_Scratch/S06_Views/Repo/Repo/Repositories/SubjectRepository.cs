using System.Collections.Generic;
using System.Linq;
using Models.Interfaces;
using Models.Models;
using Repo.Config;
using Repo.Interfaces;

namespace Repo.Repositories
{
    public class SubjectRepository :IRepository<ISubject>
    {
        private static List<ISubject> _subjects;

        public SubjectRepository()
        {
            if (_subjects == null)
            {
                _subjects = new List<ISubject>();

                var ucc = UnityConfig.getInstance();

                AddNewSubject(ucc.Resolve<ISubject>(), 1, "Science", "Reactions", "Acids & Bases");
                AddNewSubject(ucc.Resolve<ISubject>(), 2, "Maths", "Geometry", "Algebra");
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