using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Interfaces;
using Models.Models;

namespace Models.Test.Models
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestUnity()
        {
            var student = new Student();
        
            Assert.IsInstanceOfType(student, typeof(Model));
            Assert.IsInstanceOfType(student, typeof(IModel));
            Assert.IsInstanceOfType(student, typeof(IStudent));

        }
    }
}