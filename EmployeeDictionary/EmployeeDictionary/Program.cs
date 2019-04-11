using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //create directory
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(101, new Employee { FirstName = "James", LastName = "Ostler", Id = 101 });
            employees.Add(102, new Employee { FirstName = "Gary", LastName = "Smiley", Id = 102 });
            employees.Add(103, new Employee { FirstName = "Robert", LastName = "Wolf", Id = 103 });

            //get employees
            Console.WriteLine(employees[101].ToString());
            Console.WriteLine(employees[102].ToString());
            Console.WriteLine(employees[103].ToString());
            Console.ReadLine();
        }
    }
}
