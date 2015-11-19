using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Repo.Repositories;

namespace Repo.Tests.RepositoriesTests
{
    [TestClass]
    public class SubjectRepositoryTests
    {
        [TestMethod]
        public void SubjectRepositoryTest1()
        {
            var repo = new SubjectRepository();
            var subject = repo.GetAll().FirstOrDefault();

            Assert.IsInstanceOfType(subject, typeof(Subject));
        }
         
    }
}