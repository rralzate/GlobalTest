// -----------------------------------------------------------------------------
// <copyright>
//    Copyright (c) masglobalconsulting
// </copyright>
// <author>Ricardo Reyes Alzate - reyes160@gmail.com</author>
// <creationDate>23-01-2019</creationDate>
// <purpose>Define class EmployeesController</purpose>
// <filename>EmployeesController.cs</filename>
// -----------------------------------------------------------------------------

namespace WebApi.Controllers
{
    using BusinessRules;
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class EmployeesController : ApiController
    {
        private EmployeesFactory _factory;

        public EmployeesController()
        {
            _factory = new EmployeesFactory();
        }

        /// <summary>
        /// Retrieve all the information for a particular employee including the calculated Annual Salary
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/Employees/GetEmployeeMonthlySalary 
        [Route("api/v1/Employees/GetEmployee")]
        [HttpGet]
        public List<Employee> GetEmployee(int id)
        {
            List<Employee> list = new List<Employee>();

            list = _factory.getEmployeeHourlySalary(id).Concat(_factory.getEmployeeMonthlySalary(id)).ToList();
            
            return list;
        }

        /// <summary>
        /// Retrieve the information for a particular employee including the calculated Annual Monthly Salary
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/Employees/GetEmployeeMonthlySalary 
        [Route("api/v1/Employees/GetEmployeeMonthlySalary")]
        [HttpGet]
        public List<Employee> GetEmployeeMonthlySalary(int id)
        {
            return _factory.getEmployeeMonthlySalary(id);
        }

        /// <summary>
        /// Retrieve the information for a particular employee including the calculated Annual Hourly Salary
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/Employees/GetEmployeeHourlytSalary 
        [Route("api/v1/Employees/GetEmployeeHourlytSalary")]
        [HttpGet]
        public List<Employee> GetEmployeeHourlytSalary(int id)
        {
            return _factory.getEmployeeHourlySalary(id);
        }
    }
}
