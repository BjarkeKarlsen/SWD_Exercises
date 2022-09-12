using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CompressionStocking
{
    public class CompressionCtrl: ICompressionCtrl
    {
        Pump p1 = new Pump();
        private bool isCompressed;
       
        public void Compress()
        {
            if (isCompressed == false){ 
                p1.InitialPump();
                isCompressed = true;
            }
            else
            {
                Console.Write("Cannot compress");
            }
        }

        public void Decompress()
        {
            if (isCompressed == true)
            {
                p1.ReversePump();
                isCompressed = false;
            }
            else
            {
                Console.Write("Cannot decompress");
            }
        }

    }
}
