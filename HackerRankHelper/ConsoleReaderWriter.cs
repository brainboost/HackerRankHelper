using System;

namespace HackerRankHelper
{
    public class ConsoleReaderWriter : ReaderWriterBase
    {

        /// <summary>
        /// Reads a line of characters from the text reader and returns the data as a string.
        /// </summary>
        /// <returns>
        /// The next line from the reader, or null if all characters have been read.
        /// </returns>
        /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader"/> is closed. </exception><exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line is larger than <see cref="F:System.Int32.MaxValue"/></exception>
        public override string ReadLine()
        {
            return Console.ReadLine();
        }

        public override void WriteLine()
        {
            Console.WriteLine();
        }

        public override void Write(string format, params object[] args)
        {
            Console.Write(format, args);
        }

        public override void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

    }
}