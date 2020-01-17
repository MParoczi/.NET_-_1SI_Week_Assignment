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
        }
    }
}
