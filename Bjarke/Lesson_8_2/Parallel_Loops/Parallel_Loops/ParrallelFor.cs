using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Loops
{
    public class ParrallelFor
    {
        public void Run(Stopwatch stopwatch, long n)
        {
            double[] A, B, C;
            A = new double[n];
            B = new double[n];
            C = new double[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                A[i] = rand.Next();
                B[i] = rand.Next();
                C[i] = rand.Next();
            }
            Console.WriteLine("Starts Parrallel.For for now.");

            stopwatch.Reset();
            stopwatch.Start();

            Parallel.For(0, n, i =>
                {
                    C[i] = A[i] * B[i];
                }
            );

            stopwatch.Stop();
            Console.WriteLine("Parrallel.For loop time in milliseconds: {0}",
            stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }


    }
}
