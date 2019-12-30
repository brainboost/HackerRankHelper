using System;

namespace HackerRankHelper
{
    public interface IReaderWriter : IDisposable
    {
        string ReadLine();
        int ReadLineToInt();
        long ReadLineToLong();
        int[] ReadLineToIntArray();
        long[] ReadLineToLongArray();
        int[] ReadLinesToIntArray();
        bool[] ReadLineToBoolArray(Func<char, bool> converter);
        void WriteLine();
        void Write(string format, params object[] args);
        void WriteLine(string format, params object[] args);
        void WriteLine(object o);
    }
}