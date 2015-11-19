using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Repo.Repositories;

namespace Repo.Tests.RepositoriesTests
{
    [TestClass]
    public class StudentRepositoryTests
    {
        [TestMethod]
        public void StudentRepositoryTest1()
        {
            var repo = new StudentRepository();

            var student = repo.GetAll().FirstOrDefault();

            Assert.IsInstanceOfType(student, typeof(Student));

        }
         
    }
}