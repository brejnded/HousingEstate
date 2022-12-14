using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class Person
    {
        private string name;
        private string surname;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public override string ToString()
        {
            return String.Format($"\nName: {name}\nSurname: {surname}\nAge: {age}");
        }


    }
}
