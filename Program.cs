using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Test Vehicle");
            Vehicle w = new Vehicle();
            w.StartEngine("RUM RUM");
            w.Drive();
            w.StopEngine("GIN GIN");
            Console.WriteLine("-------------");

            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff(); //calling the TakeOFF method in AIRPLANE class
            myPlane.Drive(); //Calling the override method within the AIRPLANE class
            myPlane.Land();
            myPlane.StopEngine("Whirr");
            Console.WriteLine("------------");

            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");
            Console.WriteLine("----------");

            Console.WriteLine("\nTesting polymorphism");
            Vehicle v = myCar;
            Vehicle annetta = new Vehicle();

            annetta.Drive();
            annetta = myPlane;
            annetta.Drive();
            v.Drive();
            v = myPlane;
            v.Drive();

            Console.WriteLine("------------");
            Console.WriteLine("Journey by motorcycle:");
            Motorcycle mc = new Motorcycle();
            mc.StartEngine("Hoooooonndaaa");
            mc.Accelerate();
            mc.Drive();
            mc.Brake();
            mc.StopEngine("Clunk");



        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
