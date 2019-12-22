using HackerRankHelper;
using Xunit.Abstractions;

namespace HackerRankSolutionTests
{
    public class XUnitFileReaderWriter : TestFileReaderWriter
    {
        private readonly ITestOutputHelper _output;
 
        public XUnitFileReaderWriter(ITestOutputHelper output, string inputFile = "input.txt", string outputFile = "expected.txt")
            :base(inputFile, outputFile)
        {
            _output = output;
        }

        public override void WriteLine()
        {
            _output.WriteLine(_currentLine.ToString());
            if (_myOutputReader != null)
            {
                CheckCurrentLine();
                _currentLine.Clear();
            }
            _currentLineNumber++;
        }
    }
}
