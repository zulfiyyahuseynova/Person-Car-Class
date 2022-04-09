using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClass.Models
{
    class Student:Person
    {
        public string degree;
        public bool isHigh;

        public Student(string name, string surname, int age, bool isMarried, string degree, bool isHigh):base(name,surname,age,isMarried)
        {
            this.degree = degree;
            this.isHigh = isHigh;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Degree: {degree}\n" +
                $"Is high: {isHigh}");
        }
    }
}
