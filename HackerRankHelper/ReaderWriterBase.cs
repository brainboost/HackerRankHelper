using System;
using System.Collections.Generic;

namespace HackerRankHelper
{
    public abstract class ReaderWriterBase : IReaderWriter
    {
        public abstract string ReadLine();
        public abstract void Write(string format, params object[] args);
        public abstract void WriteLine(string format, params object[] args);
        public void WriteLine(object o)
        {
            WriteLine(o.ToString());
        }

        public abstract void WriteLine();

        public virtual void Dispose()
        {
        }

        public int ReadLineToInt()
        {
            var line = ReadLine();
            return int.Parse(line.Trim());
        }

        public long ReadLineToLong()
        {
            var line = ReadLine();
            return long.Parse(line.Trim());
        }

        public int[] ReadLineToIntArray()
        {
            return Array.ConvertAll(ReadLine().Trim().Split(' '), int.Parse);
        }

        public long[] ReadLineToLongArray()
        {
            return Array.ConvertAll(ReadLine().Trim().Split(' '), long.Parse);
        }

        public int[] ReadLinesToIntArray()
        {
            var result = new List<int>();
            var line = ReadLine();
            while (line != null)
            {
                result.Add(int.Parse(line.Trim()));
                line = ReadLine();
            }

            return result.ToArray();
        }

        public bool[] ReadLineToBoolArray(Func<char, bool> converter)
        {
            return Array.ConvertAll(ReadLine().ToCharArray(), converter.Invoke);
        }

    }
}