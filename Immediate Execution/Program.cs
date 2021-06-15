using System;
using System.Collections.Generic;
using System.Linq;

namespace Immediate_Execution
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

            // In the following statement, the LINQ Query is executed immediately as we are
            // Using the ToList() method which forces the query  to be executed immediately

            IEnumerable<Employee> result = (from emp in listEmployees
                                            where emp.Salary == 80000
                                            select emp).ToList();

            // Adding a new employee with Salary = 80000 to the collection listEmployees
            // will not have any effect on the result as the query is already executed

            listEmployees.Add(new Employee { ID = 1004, Name = "Sam", Salary = 80000 });

            // The above LINQ query is executed at the time of its creation.
            // This is proved because Santosh is not included in the result

            foreach (Employee emp in result)
            {
                Console.WriteLine($"{emp.ID} {emp.Name} {emp.Salary}");
            }
            Console.ReadKey();
        }
    }
}
