using System;
using System.IO;
using System.Text;

namespace HackerRankHelper
{
    public class TestFileReaderWriter : ReaderWriterBase
    {
        private readonly TextReader _myReader;
        private readonly TextReader _myOutputReader;
        private readonly StringBuilder _currentLine = new StringBuilder();
        private int _currentLineNumber = 1;
        public TestFileReaderWriter(string inputFile = "input.txt", string outputFile = "expected.txt")
        {
            _myReader = File.OpenText(inputFile);
            _myOutputReader = !string.IsNullOrEmpty(outputFile) && File.Exists(outputFile)
                ? File.OpenText(outputFile)
                : null;
        }
        public override string ReadLine()
        {
            return _myReader.ReadLine();
        }

        public override void WriteLine()
        {
            Console.WriteLine(_currentLine);
            if (_myOutputReader != null)
            {
                CheckCurrentLine();
            }
            _currentLine.Clear();
            _currentLineNumber++;
        }

        public override void Write(string format, params object[] args)
        {
            _currentLine.AppendFormat(format, args);
        }

        public override void WriteLine(string format, params object[] args)
        {
            Write(format, args);
            WriteLine();
        }

        private void CheckCurrentLine()
        {
            var nextLine = _myOutputReader.ReadLine()?.Trim();
            var currentLine = _currentLine.ToString().Trim();

            if (nextLine != currentLine) { throw new Exception($"Error: line {_currentLineNumber}. Expected {nextLine}, actual {currentLine}"); }
        }

        public override void Dispose()
        {
            foreach (var tr in new[] { _myReader, _myOutputReader })
            {
                if (tr != null)
                {
                    tr.Close();
                    tr.Dispose();
                }
            }
        }
    }
}