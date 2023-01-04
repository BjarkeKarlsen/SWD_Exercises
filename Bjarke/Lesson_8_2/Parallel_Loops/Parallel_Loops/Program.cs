using Parallel_Loops;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        const long N = 40000000;

        var sequentail = new Sequential();
        sequentail.Run(stopwatch, N);

        var parrallelFor = new ParrallelFor();
        parrallelFor.Run(stopwatch, N);

        var parrallelForEach = new ParrallelForEach();
        parrallelForEach.Run(stopwatch, N);
    }
}