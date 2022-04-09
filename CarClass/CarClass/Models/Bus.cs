using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass.Models
{
    class Bus : Car
    {
        public int passengerCount;

        public Bus(string brand, string model, string color, int maxSpeed, int passengerCount) : base(brand, model, color, maxSpeed)
        {
            this.passengerCount = passengerCount;
        }

        public override string Info()
        {
            return base.Info() + $"\nPassenger count: {passengerCount}";
        }
    }
}
