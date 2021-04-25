using System;

namespace Vehicles
{
    class Motorcycle : Vehicle
    {
        internal void Accelerate()
        {
            Console.WriteLine("Motorcycle going fast");
        }

        internal void Brake()
        {
            Console.WriteLine("Motorcycle skidding tires on pavement");
        }
        public override void Drive()
        {
            Console.WriteLine("Motorcycling");
        }
    }
}
