using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Loops
{
    public class ParrallelForEach
    {
        class Container
        {
            public double a, b, c;
        }
        public void Run(Stopwatch stopwatch, long n)
        {
            Container[] containers = new Container[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                containers[i] = new Container()
                {
                    a = rand.Next(),
                    b = rand.Next(),
                    c = rand.Next(),
                };
            }

            Console.WriteLine("Starts Parrallel.ForEach for now.");

            stopwatch.Reset();
            stopwatch.Start();

            Parallel.ForEach(containers, container =>
            {
                container.c = container.a * container.b;
            });

            stopwatch.Stop();
            Console.WriteLine("Parrallel.ForEach loop time in milliseconds: {0}",
            stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }
    }
}
