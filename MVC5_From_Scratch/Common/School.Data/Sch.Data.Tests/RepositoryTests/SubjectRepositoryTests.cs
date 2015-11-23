using System.Linq;
using Ces.Sch.Data.Interfaces;
using Ces.Sch.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ces.Sch.Data.DependencyInversion;

namespace Ces.Sch.Data.Tests.RepositoryTests
{
    [TestClass]
    public class SubjectRepositoryTests
    {
        public ISubjectRepository repo { get; }
        public SubjectRepositoryTests()
        {
            repo = DataDIConfig.Resolve<ISubjectRepository>();
        }

        [TestMethod]
        public void SubjectRepositoryTestResolve()
        {
            Assert.IsInstanceOfType(repo, typeof(SubjectRepository));
            Assert.IsInstanceOfType(repo, typeof(ISubjectRepository));
            Assert.IsInstanceOfType(repo, typeof(IRepository<ISubject>));

        }

        public void SubjectRepositoryTestReturnType()
        {
            var subject = repo.GetAll().FirstOrDefault();

            Assert.IsInstanceOfType(subject, typeof(ISubject));
        }

        public void SubjectRepositoryTestGetById()
        {
            var subject = repo.Get(1);

            Assert.AreEqual("Science", subject.Name);

        }
    }
}