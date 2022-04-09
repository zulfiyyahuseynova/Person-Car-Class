using CarClass.Models;
using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------CAR---------");
            Car car = new Car("Toyota", "Prius", "White", 200);
            Console.WriteLine(car.Info());
            Console.WriteLine(" ");

            Console.WriteLine("--------BUS---------");
            Bus bus = new Bus("Mercedes", "Benz", "Grey", 100, 30);
            Console.WriteLine(bus.Info());
        }
    }
}
