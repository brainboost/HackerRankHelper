using HackerRankHelper;
using Xunit;
using Xunit.Abstractions;

namespace HackerRankSolutionTests.fizzbuzz
{
    public class FizzBuzzTest
    {
        private readonly ITestOutputHelper _output;
        public FizzBuzzTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Test1()
        {
            using var readerWriter = new XUnitFileReaderWriter(_output, "fizzbuzz\\input.txt", "fizzbuzz\\expected.txt");
            Program.SolvePuzzle(readerWriter);
        }
    }
}
