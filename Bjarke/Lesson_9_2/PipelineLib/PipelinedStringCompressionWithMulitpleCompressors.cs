using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineLib
{
    public class PipelinedStringCompressionWithMulitpleCompressors
    {
        private readonly int _nStrings;
        private readonly int _stringLength;
        private readonly string _charsInString;

        double _avgCompressionRatio = 0;

        public PipelinedStringCompressionWithMulitpleCompressors(string charsInString, int nStrings, int stringLength)
        {
            _charsInString = charsInString;
            _nStrings = nStrings;
            _stringLength = stringLength;
        }
        struct CompressedStringInfo
        {
            public string original;
            public string compressed;
        };

        BlockingCollection<string> generatedStringQueue = new BlockingCollection<string>();
        BlockingCollection<CompressedStringInfo> compressedStringQueue1 = new BlockingCollection<CompressedStringInfo>();
        BlockingCollection<CompressedStringInfo> compressedStringQueue2 = new BlockingCollection<CompressedStringInfo>();
        BlockingCollection<CompressedStringInfo> compressedStringQueue3 = new BlockingCollection<CompressedStringInfo>();
        BlockingCollection<CompressedStringInfo> compressedStringQueue4 = new BlockingCollection<CompressedStringInfo>();
        public double Run()
        {
            // Create and start tasks
            Task generateStringTask = Task.Run(() => GenerateStringsStage(_nStrings, _stringLength, generatedStringQueue));
            Task compressionTask1 = Task.Run(() => CompessStringsStage(generatedStringQueue, compressedStringQueue1));
            Task compressionTask2 = Task.Run(() => CompessStringsStage(generatedStringQueue, compressedStringQueue2));
            Task compressionTask3 = Task.Run(() => CompessStringsStage(generatedStringQueue, compressedStringQueue3));
            Task compressionTask4 = Task.Run(() => CompessStringsStage(generatedStringQueue, compressedStringQueue4));
            Task updateCompressStatsTask = Task.Run(() => UpdateCompressionStatsStage(new[] { compressedStringQueue1, compressedStringQueue2, compressedStringQueue3, compressedStringQueue4 }, ref _avgCompressionRatio));

            Task.WaitAll(generateStringTask, compressionTask1, compressionTask2, compressionTask3, compressionTask4, updateCompressStatsTask);

            return _avgCompressionRatio;
        }


        private void GenerateStringsStage(int numberOfStrings, int stringLength, BlockingCollection<string> output)
        {
            try
            {
                for (int i = 0; i < numberOfStrings; i++)
                {
                    var str = Generate(stringLength);
                    output.Add(str);
                }
            }
            finally
            {
                output.CompleteAdding();
            }
        }

        private void CompessStringsStage(BlockingCollection<string> input, BlockingCollection<CompressedStringInfo> output)
        {
            try
            {
                foreach (var str in input.GetConsumingEnumerable())
                {
                    var compressedString = Compress(str);
                    CompressedStringInfo strInfo = new CompressedStringInfo();
                    strInfo.original = str;
                    strInfo.compressed = compressedString;
                    output.Add(strInfo);
                }
            }
            finally
            {
                output.CompleteAdding();
            }
        }

        private void UpdateCompressionStatsStage(BlockingCollection<CompressedStringInfo>[] inputs, ref double compressionRatio)
        {
            int i = 0;
            var info = new CompressedStringInfo();

            while (!inputs.All(input => input.IsCompleted))
            {
                if (BlockingCollection<CompressedStringInfo>.TryTakeFromAny(inputs, out info) != -1)
                {
                    compressionRatio = UpdateCompressionStats(i, info.original, info.compressed);
                }
            }
        }



        private double UpdateCompressionStats(int i, string str, string compressedStr)
        {
            _avgCompressionRatio = ((i * _avgCompressionRatio) + ((double)(compressedStr.Length) / str.Length)) / (i + 1);
            return _avgCompressionRatio;
        }


        private string Compress(string str)
        {
            var result = "";
            for (var i = 0; i < str.Length; i++)
            {
                var j = i;
                result += str[i];
                while ((j < str.Length) && (str[i] == str[j]))
                    j++;

                if (j > i + 1)
                {
                    result += (j - i);
                    i = j - 1;
                }
            }
            return result;
        }

        private string Generate(int stringLength)
        {
            var random = new Random();
            var result = new string(Enumerable.Repeat(_charsInString, stringLength).Select(s => s[random.Next(s.Length)]).ToArray());
            return result;
        }
    }
}
