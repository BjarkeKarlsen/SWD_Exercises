using CompressionStocking.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking.Devices.Compressing
{
    public class LaceTighteningDevice : ILaceTighteningDevice
    {
        public void Tighten()
        {
            System.Console.WriteLine("LACES tightened 1 click");
        }

        public void Lossen()
        {
            System.Console.WriteLine("LACES loosened 1 clicks");
        }
    }
}
