using System;
using System.Diagnostics;

namespace HackerRankHelper
{
    public static class Program
    {
        public static void SolvePuzzle(IReaderWriter readerWriter)
        {
            int n = readerWriter.ReadLineToInt();

            for (int i = 1; i < n + 1; i++)
            {
                var line = Solution.FizzBuzz(i);
                readerWriter.WriteLine(line);
            }
        }


        static void Main(string[] args)
        {
            IReaderWriter readerWriter = null;
            try
            {
                if (Debugger.IsAttached)
                {
                    readerWriter = new TestFileReaderWriter();
                }
                else
                {
                    // console output
                    readerWriter = new ConsoleReaderWriter();
                }

                SolvePuzzle(readerWriter);

                if (Debugger.IsAttached)
                {
                    Console.WriteLine("Finished!");
                    //Console.ReadKey();
                }
            }
            finally
            {
                readerWriter?.Dispose();
            }
        }
    }
}