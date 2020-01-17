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

            Employee johnWick = new Employee("John Wick", new DateTime(1964, 9, 2), Gender.Male, 1000, "Assassin");
            Console.WriteLine($"Please provide a salary for {johnWick.Name}:");

            ValidateUserProvidedSalary(johnWick);

            johnWick.Room = new Room(420);

            Console.WriteLine(johnWick.ToString());

            Employee Kovacs = new Employee("Géza", DateTime.Now, Gender.Male, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());

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
