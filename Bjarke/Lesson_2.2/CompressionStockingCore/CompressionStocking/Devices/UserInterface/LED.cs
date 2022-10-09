﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking.Devices.UserInterface
{
    public class LED : ITwoStateUnit
    {
        public void TurnOn()
        {
            Console.WriteLine("LED turned ON");

        }

        public void TurnOff()
        {
            Console.WriteLine("LED turned OFF");
        }

    }
}
