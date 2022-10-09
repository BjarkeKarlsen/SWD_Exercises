using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking.Devices.UserInterface
{
    public class Vibrator : ITwoStateUnit
    {
        public void TurnOff()
        {
            Console.WriteLine("Vibrator turned ON");
        }

        public void TurnOn()
        {
            Console.WriteLine("Vibrator turned OFF");
        }
    }
}
