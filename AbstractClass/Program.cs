using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Worker {Name = "David", Salary = 50000};

            var emp2 = new Manager {Name = "Mike", Salary = 100000};

            var emp3 = new Manager {Name = "Zach", Salary = 120000};

            var employees = new List<Employee> {emp1, emp2, emp3};

            emp2.Hire();

            foreach (var emp in employees)
            {
                Console.Write($"{emp.Name}'s salary was {emp.Salary} and is {emp.GetType().Name}");
                emp.GiveRaise();
                Console.WriteLine(" but is now {0}", emp.Salary);
            }

            Console.Read();
        }
    }
}
