using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public Room Room { get; set; }
        private decimal _salary;

        public decimal Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The provided salary is below zero. Unacceptable.");
                }
                else
                {
                    this._salary = value;
                }
            }
        }

        public string Profession { get; set; }

        public Employee(string name, DateTime birthDate, Gender gender, decimal salary, string profession) : base(name, birthDate, gender)
        {
            this.Profession = profession;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}The profession of {this.Name} is {this.Profession}\nwhich for {this.Name} gets {this.Salary} dollar\nRoom where you can find this person: {this.Room.RoomNumber}";
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }
    }
}
