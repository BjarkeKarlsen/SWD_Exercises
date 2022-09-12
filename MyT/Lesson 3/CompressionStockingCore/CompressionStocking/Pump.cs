using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CompressionStocking
{
    public class Pump
    {
        public void InitialPump()
        {
            System.Console.WriteLine("Pumps for 5 seconds");
            Thread.Sleep(5000);
        }
        public void ReversePump()
        {
            System.Console.WriteLine("Pumps Backwards for 2 seconds");
            Thread.Sleep(2000);
            // pump run backwards 2 seconds
            // stop
            System.Console.WriteLine("Stops");
        }
    }
}
