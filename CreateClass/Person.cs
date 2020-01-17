using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
 /// <summary>
 /// This is the <c>Person</c> class.
 /// With the help of Person class we can instantiante new people.
 /// We can get information about the person with the ToString() method.
 /// </summary>
 /// <remarks>
 /// This is an "exercise" class which means that it has very few properties
 /// and methods
 /// </remarks>
    class Person
    {
        /// <value>
        /// Gets and sets the name of the person
        /// </value>
        public string Name { get; set; }
        /// <value>
        /// Gets the birthdate of the person
        /// </value>
        public DateTime BirthDate { get; }
        /// <value>
        /// Gets and sets the gender of the person
        /// </value>
        public Gender Gender { get; set; }

        /// <summary>
        /// This is the constructor method of the Person class.
        /// We hate provide the person's name, bithdate and his/her
        /// gender.
        /// </summary>
        /// <param name="name">The name of the person.</param>
        /// <param name="birthDate">The birthdate of the person.</param>
        /// <param name="gender">The gender of the person.</param>
        public Person(string name, DateTime birthDate, Gender gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
        }

        /// <summary>
        /// The ToString() method will provide information
        /// about the Person object that we previously
        /// instantianeted.
        /// </summary>
        /// <returns>
        /// The string that contains information about the person.
        /// </returns>
        /// <example>
        /// <code>
        /// Person janeDoe = new Person("Jane Doe", new DateTime(1994, 4, 8), Gender.Female);
        /// Console.WriteLine(janeDoe.ToString());
        ///
        /// Person johnDoe = new Person("John Doe", new DateTime(1984, 6, 18), Gender.Male);
        /// Console.WriteLine(johnDoe.ToString());
        /// </code>
        /// </example>
        /// See <see cref="Object.ToString"/> implementation to know more!
        public override string ToString()
        {
            return $"The name of this person is {this.Name}\n{this.Name} was born on {this.BirthDate.Date.ToString("d")} as a {this.Gender}\n";
        }

    }
}
