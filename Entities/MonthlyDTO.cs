
// -----------------------------------------------------------------------------
// <copyright>
//    Copyright (c) masglobalconsulting
// </copyright>
// <author>Ricardo Reyes Alzate - reyes160@gmail.com</author>
// <creationDate>23-01-2019</creationDate>
// <purpose>Define class MonthlyDTO</purpose>
// <filename>MonthlyDTO.cs</filename>
// -----------------------------------------------------------------------------

using System.Collections.Generic;


namespace Entities
{
    /// <summary>
    /// DTO to the list employees information
    /// </summary>  
    public abstract class MonthlyDTO
    {
        public abstract List<Employee> listEmployees { get; }
    }
}
