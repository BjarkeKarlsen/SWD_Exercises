using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Loops
{
    public class Sequential
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
            Console.WriteLine("Starts sequential for now.");
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {
                C[i] = A[i] * B[i];
            }
            stopwatch.Stop();
            Console.WriteLine("Sequential loop time in milliseconds: {0}",
            stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
            Console.WriteLine("Finished");
        }
    }
}
