using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.Web.Controllers;

namespace School.Web.Tests.Controllers
{
    [TestClass]
    public class StudentControllerTests
    {
        [TestMethod]
        public void StudentControllerGetAllTest()
        {
            var controller = new StudentController();

            var result = controller.GetAll() as ViewResult;

            Assert.IsNotNull(result);
        }

    }
}