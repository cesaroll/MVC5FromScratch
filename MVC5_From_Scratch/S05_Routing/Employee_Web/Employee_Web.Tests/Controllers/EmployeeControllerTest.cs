using Employee_Repo;
using Employee_Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employee_Web.Tests
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void GetEmployeeWithIdTest()
        {
            var repo = new EmployeeRepository();
            var empController = new EmployeeController(repo);
            var value = empController.Employee(1);

            Assert.AreEqual("1 : Mike", value);
        }
    }
}