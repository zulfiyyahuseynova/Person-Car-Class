using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClass.Models
{
    class Person
    {
        public string name;
        public string surname;
        public int age;
        public bool isMarried;

        public Person()
        {

        }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Person(string name, string surname, int age, bool isMarried):this(name, surname)
        {
            this.age = age;
            this.isMarried = isMarried;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {name} \n" +
                $"Surname: {surname} \n" +
                $"Age: {age} \n" +
                $"Is married: {isMarried}");
        }
    }
}
