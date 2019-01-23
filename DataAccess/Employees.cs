// -----------------------------------------------------------------------------
// <copyright>
//    Copyright (c) masglobalconsulting
// </copyright>
// <author>Ricardo Reyes Alzate - reyes160@gmail.com</author>
// <creationDate>23-01-2019</creationDate>
// <purpose>Define class Employees</purpose>
// <filename>Employees.cs</filename>
// -----------------------------------------------------------------------------


namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    using Common;
    using Entities;

    public class Employees : IEmployees
    {
        /// <summary>
        /// Retrieve the information for all the employees including the calculated Annual Salaries
        /// </summary>
        /// <returns></returns>
        public List<Employee> getEmployees()
        {
            string URL = "http://masglobaltestapi.azurewebsites.net/api/Employees";
            var retorno = new HelperConsumoRest().PeticionRespuestaObj<List<Employee>>(URL, null);
            return retorno;
        }
    }
}
