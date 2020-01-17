using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person janeDoe = new Person("Jane Doe", new DateTime(1994, 4, 8), Gender.Female);
            Console.WriteLine(janeDoe.ToString());

            Person johnDoe = new Person("John Doe", new DateTime(1984, 6, 18), Gender.Male);
            Console.WriteLine(johnDoe.ToString());

            Employee johnWick = new Employee("John Wick", new DateTime(1964, 9, 2), Gender.Male, "Assassin");
            Console.WriteLine($"Please provide a salary for {johnWick.Name}:");

            ValidateUserProvidedSalary(johnWick);

            Console.WriteLine(johnWick.ToString());

        }

        private static void ValidateUserProvidedSalary(Employee employee)
        {
            while (true)
            {
                try
                {
                    employee.Salary = Convert.ToDecimal(Console.ReadLine());
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The provided salary is below zero. Please try again:");
                    continue;
                }

            }
        }
    }
}
