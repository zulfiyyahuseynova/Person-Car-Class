using PersonClass.Models;
using System;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Person-----------");
            Person person = new Person("Zulfiyye", "Huseynova", 19, false);
            person.ShowInfo();
            Console.WriteLine(" ");

            Console.WriteLine("---------Student-----------");
            Student student = new Student("Zulfiyye", "Huseynova", 19, false, "bakalavr", true);
            student.ShowInfo();
        }
    }
}
