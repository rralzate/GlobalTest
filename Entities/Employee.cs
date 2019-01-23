// -----------------------------------------------------------------------------
// <copyright>
//    Copyright (c) masglobalconsulting
// </copyright>
// <author>Ricardo Reyes Alzate - reyes160@gmail.com</author>
// <creationDate>23-01-2019</creationDate>
// <purpose>Define class Employee</purpose>
// <filename>Employee.cs</filename>
// -----------------------------------------------------------------------------


namespace Entities
{
    /// <summary>
    /// Entitie information for employees including the calculated Annual Salaries
    /// </summary>    
    public class Employee
    {        
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public long hourlySalary { get; set; }
        public long monthlySalary { get; set; }
        public long calculateSalary { get; set; }

    }
}
