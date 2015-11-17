using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employee_Models.Tests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestEmployee()
        {
            var employee = new Employee();

            Assert.IsNotNull(employee);

        }
         
    }
}