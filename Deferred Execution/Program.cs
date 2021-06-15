using System;
using System.Collections.Generic;
using System.Linq;

namespace Deferred_Execution
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee { ID= 1001, Name = "Rohit", Salary = 80000 },
                new Employee { ID= 1002, Name = "Anurag", Salary = 90000 },
                new Employee { ID= 1003, Name = "Ajay", Salary = 80000 }
            };

            // In the below statement the LINQ Query is only defined and not executed
            // If the query is executed here, then the result should not display Santosh

            IEnumerable<Employee> result = from emp in listEmployees
                                           where emp.Salary == 80000
                                           select emp;
            // Adding a new employee with Salary = 80000 to the collection listEmployees

            listEmployees.Add(new Employee { ID = 1004, Name = "Sam", Salary = 80000 });

            // The LINQ query is actually executed when we iterate through using a for each loop
            // This is proved because Santosh is also included in the result

            foreach (Employee emp in result)
            {
                Console.WriteLine($"{emp.ID} {emp.Name} {emp.Salary}");
            }
            Console.ReadKey();
        }
    }
}
