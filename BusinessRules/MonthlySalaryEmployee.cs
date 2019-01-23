// -----------------------------------------------------------------------------
// <copyright>
//    Copyright (c) masglobalconsulting
// </copyright>
// <author>Ricardo Reyes Alzate - reyes160@gmail.com</author>
// <creationDate>23-01-2019</creationDate>
// <purpose>Define class MonthlySalaryEmployee</purpose>
// <filename>MonthlySalaryEmployee.cs</filename>
// -----------------------------------------------------------------------------


namespace BusinessRules
{
    using Entities;
    using DataAccess;
    using System.Collections.Generic;

    /// <summary>
    /// Class to MonthlySalaryEmployee
    /// </summary>
    public class MonthlySalaryEmployee : MonthlyDTO
    {
        List<Employee> _list = new List<Employee>();
        Employees dataEmployees = new Employees();      
        int _id = 0;

        public MonthlySalaryEmployee(int id)
        {
            _id = id;
        }


        /// <summary>
        /// Retrieve the information for a particular employee including the calculated Annual Monthly Salary
        /// </summary>
        public override List<Employee> listEmployees
        {
            get
            {
                if (_id > 0)
                {
                    var employees = dataEmployees.getEmployees();                    
                   var employee = employees.Find(x => x.id == _id);

                    if (employee != null)
                    {
                        employee.calculateSalary = employee.monthlySalary * 12;

                        _list.Add(employee);
                    }

                    return _list;
                }
                else
                {
                    var employees = dataEmployees.getEmployees();
                    if (employees != null)
                    {
                        foreach (var item in employees)
                        {
                            item.calculateSalary = item.monthlySalary * 12;
                            //Add item to the list
                            _list.Add(item);
                        }
                    }
                    return _list;
                }                
               
            }
        }
        
    }
}
