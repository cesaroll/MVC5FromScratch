using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using S04_L08_Model.App_Start;
using S04_L08_Model.Controllers;
using S04_L08_Repository;


namespace S04_L08_Model.Tests
{
	[TestClass]
	public class EmployeeTest
	{
		[TestMethod]
		public void TestGetWithId()
		{
            var repo = new EmployeeRepository();
            var empController = new EmployeeController(repo);
		    var employee = empController.Get(1);
            Assert.AreEqual("1 : Mike", employee);
		}
	}
}
