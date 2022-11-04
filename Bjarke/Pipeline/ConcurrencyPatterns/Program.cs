using PipelineLib;

internal class Program
{
    private static void Main(string[] args)
    {
        var sequentialString = new SequentialStringCompression("ABC", 10000, 2500);
        var output = sequentialString.Run();
        Console.WriteLine(output);
    }
}