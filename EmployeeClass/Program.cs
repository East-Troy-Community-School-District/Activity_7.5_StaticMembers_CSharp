/*
 * Employee Class
 * 2/28/2023
 * C#.NET I
 * 
 * Instructions
 * How are static fields used in the Employee class? How are static methods
 * called outside the class? Inside?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employees created: " + Employee.GetEmployeeCount());
            Employee e1 = new Employee("Jimbo", Role.CEO);
            Employee e2 = new Employee("Jenbo", Role.Programmer);
            Employee e3 = new Employee("Jambo", Role.Janitor);
            Employee e4 = new Employee("Junbo", Role.Secretary);
            Console.WriteLine("Employees created: " + Employee.GetEmployeeCount());

            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);
        }
    }
}
