using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    /// <summary>
    /// Represents an employee within an organization.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Get or set the name of the employee.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set the role of the employee.
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Get the id of the employee.
        /// </summary>
        public int Id { get; }

        private static int nextID = 10000;
        private static int employeeCount = 0;

        /// <summary>
        /// Constructors a new Employee object.
        /// </summary>
        /// <param name="name">The name of the employee.</param>
        /// <param name="role">The role of the employee.</param>
        public Employee(string name, Role role)
        {
            Name = name;
            Role = role;
            Id = nextID;
            nextID++;
            employeeCount++;
        }

        /// <summary>
        /// Converts the Employee object into a string in the format
        /// "{Name}:{Id} is a(n) {Role}".
        /// </summary>
        /// <returns>TA string representation of the object.</returns>
        public override string ToString()
        {
            return Name + ":" + Id + " is a(n) " + Role;
        }

        /// <summary>
        /// Returns the number of Employee objects created.
        /// </summary>
        /// <returns>Number of Employee objects.</returns>
        public static int GetEmployeeCount()
        {
            return employeeCount;
        }
    }
}
