using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Loops
{
    public class MyParallelFor_cs
    {
        public static void MyParallelFor(int inclusiveLowerBound, int exclusiveUpperBound, Action<int> body)
        {
            // Determine size of each partition of work (size/nCores) – static partitioning
            int size = exclusiveUpperBound - inclusiveLowerBound;
            int numProcs = Environment.ProcessorCount;
            int range = size / numProcs;

            // Initialize threads to do work
            var threads = new List<Thread>(numProcs);
            for (int p = 0; p < numProcs; p++)
            {
                int start = p * range + inclusiveLowerBound;
                int end = (p == numProcs - 1) ? exclusiveUpperBound : start + range;
                threads.Add(new Thread(() =>
                {
                    for (int i = start; i < end; i++) body(i);
                }));
            }

            // Start and await threads
            foreach (var thread in threads) thread.Start();  // Start them all
            foreach (var thread in threads) thread.Join();   // wait on all
        }

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

            //MyParallelFor(0, n, )
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
