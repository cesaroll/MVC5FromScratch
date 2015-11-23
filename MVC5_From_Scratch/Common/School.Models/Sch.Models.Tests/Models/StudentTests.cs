using Ces.Sch.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ces.Sch.Models.DependencyInversion;


namespace Ces.Sch.Models.Tests.Models
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentTestResolve()
        {
            var student = ModelsDIConfig.Resolve<IStudent>();

            Assert.IsInstanceOfType(student, typeof(Model));
            Assert.IsInstanceOfType(student, typeof(IModel));
            Assert.IsInstanceOfType(student, typeof(IStudent));

        }
         
    }
}