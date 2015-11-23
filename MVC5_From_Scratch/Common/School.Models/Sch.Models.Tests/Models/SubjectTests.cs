using Ces.Sch.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ces.Sch.Models.DependencyInversion;

namespace Ces.Sch.Models.Tests.Models
{
    [TestClass]
    public class SubjectTests
    {
        [TestMethod]
        public void SubjectTestResolve()
        {
            var subject = ModelsDIConfig.Resolve<ISubject>();

            Assert.IsInstanceOfType(subject, typeof(Model));
            Assert.IsInstanceOfType(subject, typeof(IModel));
            Assert.IsInstanceOfType(subject, typeof(ISubject));
        }
         
    }
}