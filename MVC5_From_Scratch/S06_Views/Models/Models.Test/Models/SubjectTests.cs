using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Interfaces;
using Models.Models;

namespace Models.Test.Models
{
    [TestClass]
    public class SubjectTests
    {
        [TestMethod]
        public void TestUnity()
        {
            var subject = new Subject();

            Assert.IsInstanceOfType(subject, typeof(Model));
            Assert.IsInstanceOfType(subject, typeof(IModel));
            Assert.IsInstanceOfType(subject, typeof(ISubject));

        }

    }
}