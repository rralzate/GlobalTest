// -----------------------------------------------------------------------------
// <copyright>
//    Copyright (c) masglobalconsulting
// </copyright>
// <author>Ricardo Reyes Alzate - reyes160@gmail.com</author>
// <creationDate>23-01-2019</creationDate>
// <purpose>Define interface IEmployees</purpose>
// <filename>Employees.cs</filename>
// -----------------------------------------------------------------------------

namespace DataAccess
{
    using Entities;
    using System.Collections.Generic;

    public interface IEmployees
    {
        /// <summary>
        /// Retrieve the information for all the employees including the calculated Annual Salaries
        /// </summary>
        /// <returns></returns>
        List<Employee> getEmployees();
        
    }
}
