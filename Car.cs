using System;

namespace Vehicles
{
    class Car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }
        public void Brake()
        {
            Console.WriteLine("Braking");
        }
        public override void Drive()
        {
            Console.WriteLine("Motoring");
        }
    }
}
