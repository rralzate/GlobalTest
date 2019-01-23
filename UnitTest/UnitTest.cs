// -----------------------------------------------------------------------------
// <copyright>
//    Copyright (c) masglobalconsulting
// </copyright>
// <author>Ricardo Reyes Alzate - reyes160@gmail.com</author>
// <creationDate>23-01-2019</creationDate>
// <purpose>Define class UnitTest</purpose>
// <filename>UnitTest.cs</filename>
//
using BusinessRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{   

    [TestClass]
    public class UnitTest
    {
        private EmployeesFactory _factory;

        public UnitTest()
        {
            _factory = new EmployeesFactory();
        }

        [TestMethod]
        public void getMonthlyEmployee()
        {
            var id = 1;

            var employee = _factory.getEmployeeMonthlySalary(id);

            Assert.AreEqual(employee.Count, 1);
        }

        [TestMethod]
        public void getAllMonthlyEmployees()
        {
            var id = 0;

            var employee = _factory.getEmployeeMonthlySalary(id);

            Assert.AreNotEqual(employee.Count, 1);
        }

        [TestMethod]
        public void getHourlyEmployee()
        {
            var id = 1;

            var employee = _factory.getEmployeeHourlySalary(id);

            Assert.AreEqual(employee.Count, 1);
        }

        [TestMethod]
        public void getAllHourlyEmployees()
        {
            var id = 0;

            var employee = _factory.getEmployeeHourlySalary(id);

            Assert.AreNotEqual(employee.Count, 1);
        }
    }
}
