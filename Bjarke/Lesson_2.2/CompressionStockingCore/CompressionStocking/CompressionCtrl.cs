using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CompressionStocking
{
    public class CompressionCtrl : ICompressionCtrl
    {
        public void Compress()
        {
            System.Console.WriteLine("Starting to compression");
            Thread.Sleep(5000);
                //Pump for 5 second
        }

        public void Decompress()
        {
            //
            System.Console.WriteLine("Start to decompress");
        }
    }
}

