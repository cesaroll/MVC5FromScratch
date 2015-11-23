using System.Linq;
using System.Runtime.InteropServices;
using Ces.Sch.Data.DependencyInversion;
using Ces.Sch.Data.Interfaces;
using Ces.Sch.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ces.Sch.Data.Tests.RepositoryTests
{
    [TestClass]
    public class StudentRepositoryTests
    {
        public IStudentRepository repo { get; }
        public StudentRepositoryTests()
        {
            repo = DataDIConfig.Resolve<IStudentRepository>();
        }

        [TestMethod]
        public void StudentRepositoryTestResolve()
        {
            Assert.IsInstanceOfType(repo, typeof(StudentRepository));
            Assert.IsInstanceOfType(repo, typeof(IStudentRepository));
            Assert.IsInstanceOfType(repo, typeof(IRepository<IStudent>));

        }

        public void StudentRepositoryTestReturnType()
        {
            var student = repo.GetAll().FirstOrDefault();

            Assert.IsInstanceOfType(student, typeof(IStudent));
        }

        public void StudentRepositoryTestGetById()
        {
            var student = repo.Get(1);

            Assert.AreEqual("Mike", student.Name);

        }


    }
}