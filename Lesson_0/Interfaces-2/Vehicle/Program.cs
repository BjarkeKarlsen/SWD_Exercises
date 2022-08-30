using System;
using Interfaces_2;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine gasEngine = new GasEngine(42);
            IEngine dieselEngine = new DieselEngine(323);


            MotorBike motorBike = new MotorBike(gasEngine);
            MotorBike motorBike1 = new MotorBike(dieselEngine);


            motorBike.RunAtHalfSpeed();
            Console.WriteLine("Get the motor type: " + motorBike.GetType());
            Console.WriteLine("Get the motor type: " + motorBike1.GetType());


            gasEngine.SetThrottle(1);
            dieselEngine.SetThrottle(2);

            Console.WriteLine("Gas type: " + gasEngine.GetThrottle());
            Console.WriteLine("Gas type: " + dieselEngine.GetThrottle());

        }

    }
}
