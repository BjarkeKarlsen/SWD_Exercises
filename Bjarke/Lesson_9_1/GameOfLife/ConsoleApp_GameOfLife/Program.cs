using System;
using System.Diagnostics;
using GameOfLifeNamespace;

namespace ConsoleApp_GameOfLife
{
    class Program
    {

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            GameOfLife gameOfLife;
            const int gridSize = 1000;


            gameOfLife = new SequentialGameOfLife(gridSize);
            stopwatch.Start();
            gameOfLife.Run(100);
            stopwatch.Stop();
            Console.WriteLine("Sequnential: " + stopwatch.ElapsedMilliseconds);

            gameOfLife = new ParallelGameOfLife(gridSize);
            stopwatch.Restart();
            gameOfLife.Run(100);
            stopwatch.Stop();
            Console.WriteLine("Parrallel: " + stopwatch.ElapsedMilliseconds);


            gameOfLife = new ParallelGameOfLifeWithBarrier(gridSize);
            stopwatch.Restart();
            gameOfLife.Run(100);
            stopwatch.Stop();
            Console.WriteLine("Parallel with barrier: " + stopwatch.ElapsedMilliseconds);

        }
    }
}
