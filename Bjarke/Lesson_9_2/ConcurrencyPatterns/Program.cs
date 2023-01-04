using PipelineLib;
using System.Diagnostics;

internal class Program
{
    const int NUMBER_OF_STRINGS = 100000;
    const int STRING_LENGHT = 500;
    private static void Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        Console.WriteLine("Generating and compressing strings");

        var sequentialStringCompression = new SequentialStringCompression("ABC", NUMBER_OF_STRINGS, STRING_LENGHT);
        stopwatch.Start();
        var avgCompressionRation = sequentialStringCompression.Run();
        stopwatch.Stop();
        Console.WriteLine($"Average compression ration: {avgCompressionRation}");
        Console.WriteLine($"Serial time in milliseconds: {stopwatch.ElapsedMilliseconds}");

        stopwatch.Reset();

        var pipelineSequentialStringCompress = new PipelineSequentialStringCompression("ABC", NUMBER_OF_STRINGS, STRING_LENGHT);
        stopwatch.Start();
        avgCompressionRation = pipelineSequentialStringCompress.Run();
        stopwatch.Stop();
        Console.WriteLine($"Average compression ration: {avgCompressionRation}");
        Console.WriteLine($"Pipelined time in milliseconds: {stopwatch.ElapsedMilliseconds}");

        stopwatch.Reset();
        var pipelinedStringCompressionWithMulitpleCompressors = new PipelinedStringCompressionWithMulitpleCompressors("ABC", NUMBER_OF_STRINGS, STRING_LENGHT);
        stopwatch.Start();
        avgCompressionRation = pipelinedStringCompressionWithMulitpleCompressors.Run();
        stopwatch.Stop();
        Console.WriteLine($"Average compression ration: {avgCompressionRation}");
        Console.WriteLine($"Pipelined with multiple compressors time in milliseconds: {stopwatch.ElapsedMilliseconds}");


    }
}