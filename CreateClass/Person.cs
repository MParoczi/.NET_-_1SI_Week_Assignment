using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
 /// <summary>
 /// This is the Person class.
 /// With the help of Person class we can instantiante new people.
 /// We can get information about the person with the ToString() method.
 /// </summary>
    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; }
        public Gender Gender { get; set; }

        public Person(string name, DateTime birthDate, Gender gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"The name of this person is {this.Name}\n{this.Name} was born on {this.BirthDate.Date.ToString("d")} as a {this.Gender}\n";
        }

    }
}
