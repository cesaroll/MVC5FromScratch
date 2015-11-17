using Employee_Models;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employee_Repo.Tests
{
    [TestClass]
    public class EmployeeRepositoryTest
    {
        public IUnityContainer UnityContainer { get; set; }

        public EmployeeRepositoryTest()
        {
            UnityContainer = new UnityContainer();
            UnityContainer.RegisterType<IRepository<Employee>, EmployeeRepository>();
        }

        [TestMethod]
        public void TestUnity()
        {
            var employeeRepo = UnityContainer.Resolve<IRepository<Employee>>();

            Assert.IsTrue(employeeRepo is EmployeeRepository);
        }

        [TestMethod]
        public void TestWithId()
        {
            var empRepo = UnityContainer.Resolve<IRepository<Employee>>();
            var emp = empRepo.Get(1);

            Assert.AreEqual("MikeGregory", emp.Name + emp.Surname);
        }
    }
}