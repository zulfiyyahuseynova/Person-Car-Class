using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass.Models
{
    class Car
    {
        public string brand;
        public string model;
        public string color;
        public int maxSpeed;

        public Car()
        {
            Console.WriteLine("Car created");
        }
        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public Car(string brand, string model, string color, int maxSpeed) : this(brand, model)
        {
            this.color = color;
            this.maxSpeed = maxSpeed;
        }

        public virtual string Info()
        {
            return $"Brand: {brand}\n" +
                $"Model: {model}\n" +
                $"Color: {color}\n" +
                $"Max speed: {maxSpeed}";
        }
    }
}
