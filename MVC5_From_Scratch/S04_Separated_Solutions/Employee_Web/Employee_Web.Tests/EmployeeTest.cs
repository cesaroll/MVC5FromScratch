using Employee_Repo;
using Employee_Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employee_Web.Tests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestGetWithID()
        {
            var repo = new EmployeeRepository();
            var empController = new EmployeeController(repo);
            var value = empController.Get(1);
            
            Assert.AreEqual("1 : Mike", value);
        }
    }
}