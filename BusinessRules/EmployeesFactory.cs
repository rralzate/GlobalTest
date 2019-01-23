// -----------------------------------------------------------------------------
// <copyright>
//    Copyright (c) masglobalconsulting
// </copyright>
// <author>Ricardo Reyes Alzate - reyes160@gmail.com</author>
// <creationDate>23-01-2019</creationDate>
// <purpose>Define class EmployeesFactory</purpose>
// <filename>EmployeesFactory.cs</filename>
// -----------------------------------------------------------------------------

namespace BusinessRules
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

        /// <summary>
    /// Class Employees Factory
    /// </summary>
    public class EmployeesFactory
    {
        /// <summary>
        /// Retrieve the information for a particular employee including the calculated Annual Monthly Salary
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public List<Employee> getEmployeeMonthlySalary(int _id)
        {
            return new MonthlySalaryEmployee(_id).listEmployees;            
        }
        /// <summary>
        /// Retrieve the information for a particular employee including the calculated Annual Hourly Salary
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public List<Employee> getEmployeeHourlySalary(int _id)
        {
            return new HourlySalaryEmployee(_id).listEmployees;
        }
    }
}
